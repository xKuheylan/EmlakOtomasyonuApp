using System;
using System.IO;
using System.Numerics;

namespace EmlakOtomasyonu.Data.Items
{
    public enum EvTuru
    {
        Daire,
        Bahçeli,
        Dubleks,
        Müstakil
    }

    public class EvItem
    {
        // Alanlar
        private int _odaSayisi;
        private int _katNumarasi;
        private string _semt;
        private decimal _alani;
        private DateTime _yapimTarihi;
        private EvTuru _turu;
        private bool _aktif;
        private int _emlakNumarasi;
        public decimal Kira { get; set; }
        public decimal Depozito { get; set; }
        public decimal Fiyat { get; set; }

        // dogrulama ve log özellikleri
        public int OdaSayisi
        {
            get { return _odaSayisi; }
            set
            {
                if (value < 0)
                {
                    _odaSayisi = 0;
                    LogToFile($"Negatif oda sayısı girildi: {value}");
                }
                else
                {
                    _odaSayisi = value;
                    LogToFile($"Pozitif oda sayısı girildi: {value}");
                }
            }
        }

        public int KatNumarasi
        {
            get { return _katNumarasi; }
            set
            {
                if (value < 0)
                {
                    _katNumarasi = 0;
                    LogToFile($"Negatif kat numarası girildi: {value}");
                }
                else
                {
                    _katNumarasi = value;
                    LogToFile($"Pozitif kat numarası girildi: {value}");
                }
            }
        }

        public string Semti
        {
            get { return _semt; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _semt = "Bilinmeyen";
                    LogToFile("Semt bilgisi boş veya geçersiz.");
                }
                else
                {
                    _semt = value;
                    LogToFile($"Semt bilgisi girildi: {value}");
                }
            }
        }

        public decimal Alani
        {
            get { return _alani; }
            set
            {
                if (value < 0)
                {
                    _alani = 0;
                    LogToFile($"Negatif alan değeri girildi: {value}");
                }
                else
                {
                    _alani = value;
                    LogToFile($"Pozitif alan değeri girildi: {value}");
                }
            }
        }

        public DateTime YapimTarihi
        {
            get { return _yapimTarihi; }
            set { _yapimTarihi = value; }
        }

        public EvTuru Turu
        {
            get { return _turu; }
            set { _turu = value; }
        }

        public bool Aktif
        {
            get { return _aktif; }
            set { _aktif = value; }
        }

        public int EmlakNumarasi
        {
            get { return _emlakNumarasi; }
            set { _emlakNumarasi = value; }
        }

        // yaş hesaplamak için türetilmiş özellik
        public int Yas
        {
            get
            {
                int yas = DateTime.Now.Year - _yapimTarihi.Year;
                if (DateTime.Now < _yapimTarihi.AddYears(yas)) yas--;
                return yas;
            }
        }

        // gerekli alanlarla kurucu metodu
        public EvItem(int odaSayisi, int katNumarasi, string semti, decimal alani, DateTime yapimTarihi, EvTuru turu, bool aktif)
        {
            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semti = semti;
            Alani = alani;
            YapimTarihi = yapimTarihi;
            Turu = turu;
            Aktif = aktif;
            EmlakNumarasi = new Random().Next(1000, 9999); // Benzersiz numara için
        }

        // Aşırı yüklenmiş kurucu metotttttttt
        public EvItem(int odaSayisi, int katNumarasi, string semt, decimal alan, DateTime yapimTarihi, EvTuru turu, bool aktif, decimal fiyat)
            : this(odaSayisi, katNumarasi, semt, alan, yapimTarihi, turu, aktif)  // Diğer temel alanları bu kurucuya ilet
        {
            Fiyat = fiyat;  // Fiyat değerini alıp, Fiyat özelliğine atıyoruz
        }


        // Emlak bilgilerini döndüren metod
        public virtual string EvBilgileri()
        {
            return string.Format("Ev Numarası: {0}\nOda Sayısı: {1}\nKat Numarası: {2}\nSemt: {3}\nAlan: {4} m²\nYapım Tarihi: {5}\nEvin Türü: {6}\nAktif: {7}",
                                 EmlakNumarasi, OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi.Year, Turu, Aktif);
        }


        // Fiyat Hesaplama metodu
        public decimal FiyatHesapla()
        {
            decimal katsayi = 200; // Varsayılan katsayı

            // room_cost.txt dosyasını kontrol et ve okuma işlemi yap
            string path = @"C:\Users\Public\Documents\room_cost.txt";
            if (System.IO.File.Exists(path))
            {
                string text = System.IO.File.ReadAllText(path);
                if (decimal.TryParse(text, out decimal readKatsayi))
                {
                    katsayi = readKatsayi;
                }
            }

            return OdaSayisi * katsayi;
        }

        // Log tutma metodu 
        private void LogToFile(string logMessage)
        {
            string logFilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\EmlakOtomasyonu\log.txt";

            // Eğer klasör yoksa oluştur
            string directoryPath = System.IO.Path.GetDirectoryName(logFilePath);
            if (!System.IO.Directory.Exists(directoryPath))
            {
                System.IO.Directory.CreateDirectory(directoryPath);
            }

            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {logMessage}");
            }
        }

    }
}

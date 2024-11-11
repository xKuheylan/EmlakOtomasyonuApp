using System;

namespace EmlakOtomasyonu.Data.Items
{
    public class SatilikEvItem : EvItem
    {
        // Satılık evlere özgü alanlar
        public decimal Fiyat { get; set; }

        // Satılık ev için uygun kurucu metot
        public SatilikEvItem(int odaSayisi, int katNumarasi, string semt, decimal alan, DateTime yapimTarihi, EvTuru turu, bool aktif, decimal fiyat)
            : base(odaSayisi, katNumarasi, semt, alan, yapimTarihi, turu, aktif)
        {
            Fiyat = fiyat;
        }

        // EvBilgileri metodunu override ediyoruz
        public override string EvBilgileri()
        {
            // Satılık evin bilgilerini döndüren metodu biçimlendiriyoruz
            return string.Format("Satılık Ev Bilgileri:\nOda Sayısı: {0}\nKat Numarası: {1}\nSemt: {2}\nAlan: {3} m²\nYapım Yılı: {4}\nEmlak Tipi: {5}\nAktif Durum: {6}\nFiyat: {7} TL",
                                 OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi.Year, Turu, Aktif ? "Aktif" : "Pasif", Fiyat);
        }
    }
}

using System;

namespace EmlakOtomasyonu.Data.Items
{
    public class KiralikEvItem : EvItem
    {
        // Kiralık evlere özgü alanlar
        public decimal Depozito { get; set; }
        public decimal Kira { get; set; }

        // Kiralık ev için uygun kurucu metot
        public KiralikEvItem(int odaSayisi, int katNumarasi, string semt, decimal alan, DateTime yapimTarihi, EvTuru turu, bool aktif, decimal kira, decimal depozito)
            : base(odaSayisi, katNumarasi, semt, alan, yapimTarihi, turu, aktif)
        {
            Kira = kira;
            Depozito = depozito;
        }

        // EvBilgileri metodunu override ediyoruz
        public override string EvBilgileri()
        {
            // Kiralık evin bilgilerini döndüren metodu biçimlendiriyoruz
            return string.Format("Kiralık Ev Bilgileri:\nOda Sayısı: {0}\nKat Numarası: {1}\nSemt: {2}\nAlan: {3} m²\nYapım Yılı: {4}\nEmlak Tipi: {5}\nAktif Durum: {6}\nKira: {7} TL\nDepozito: {8} TL",
                                 OdaSayisi, KatNumarasi, Semti, Alani, YapimTarihi.Year, Turu, Aktif ? "Aktif" : "Pasif", Kira, Depozito);
        }
    }
}

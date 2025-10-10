namespace PTS
{
    public static class GirisYapanKullanici
    {
        public static int KullaniciId { get; set; }
        public static int PersonelId { get; set; }
        public static string AdSoyad { get; set; }

        public static void OturumuKapat()
        {
            KullaniciId = 0;
            PersonelId = 0;
            AdSoyad = null;
        }
    }
}
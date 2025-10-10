using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    // Sorgu güncellendi: Personelin adını ve soyadını da çekiyoruz.
                    string sorgu = @"SELECT 
                                        k.kullanici_id, 
                                        k.personel_id, 
                                        p.ad + ' ' + p.soyad AS ad_soyad
                                     FROM kullanicilar k
                                     INNER JOIN personel p ON k.personel_id = p.personel_id
                                     WHERE k.kullanici_adi = @k_adi AND k.sifre_hash = @sifre";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    string girilenSifreHash = SifrelemeYardimcisi.ComputeSha256Hash(txtSifre.Text);

                    komut.Parameters.AddWithValue("@k_adi", txtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@sifre", girilenSifreHash);

                    baglanti.Open();
                    SqlDataReader okuyucu = komut.ExecuteReader();

                    if (okuyucu.Read())
                    {
                        // Giriş başarılı! Bilgileri statik sınıfa kaydet.
                        GirisYapanKullanici.KullaniciId = Convert.ToInt32(okuyucu["kullanici_id"]);
                        GirisYapanKullanici.PersonelId = Convert.ToInt32(okuyucu["personel_id"]);
                        GirisYapanKullanici.AdSoyad = okuyucu["ad_soyad"].ToString();

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormIzinTalebi : Form
    {
        public FormIzinTalebi()
        {
            InitializeComponent();
        }

        private void FormIzinTalebi_Load(object sender, EventArgs e)
        {
            PersonelleriYukle();
            IzinTurleriniYukle();
        }

        private void PersonelleriYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT personel_id, (ad + ' ' + soyad) AS adsoyad FROM personel WHERE aktif_mi = 1 ORDER BY adsoyad";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbPersonel.DataSource = dt;
                    cmbPersonel.DisplayMember = "adsoyad";
                    cmbPersonel.ValueMember = "personel_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personeller yüklenemedi: " + ex.Message);
            }
        }

        private void IzinTurleriniYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT izin_turu_id, izin_turu_adi FROM izin_turleri ORDER BY izin_turu_adi";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbIzinTuru.DataSource = dt;
                    cmbIzinTuru.DisplayMember = "izin_turu_adi";
                    cmbIzinTuru.ValueMember = "izin_turu_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İzin türleri yüklenemedi: " + ex.Message);
            }
        }

        private void btnTalepGonder_Click(object sender, EventArgs e)
        {
            if (cmbPersonel.SelectedIndex == -1 || cmbIzinTuru.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen personel ve izin türü seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpBitisTarihi.Value < dtpBaslangicTarihi.Value)
            {
                MessageBox.Show("Bitiş tarihi, başlangıç tarihinden önce olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = @"INSERT INTO izinler 
                                       (personel_id, izin_turu_id, baslangic_tarihi, bitis_tarihi, izin_gun_sayisi, aciklama, talep_tarihi, onay_durumu) 
                                     VALUES 
                                       (@personel_id, @izin_turu_id, @baslangic_tarihi, @bitis_tarihi, @izin_gun_sayisi, @aciklama, GETDATE(), 'beklemede')";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    TimeSpan gunFarki = dtpBitisTarihi.Value.Date - dtpBaslangicTarihi.Value.Date;
                    decimal gunSayisi = Convert.ToDecimal(gunFarki.TotalDays + 1);

                    komut.Parameters.AddWithValue("@personel_id", cmbPersonel.SelectedValue);
                    komut.Parameters.AddWithValue("@izin_turu_id", cmbIzinTuru.SelectedValue);
                    komut.Parameters.AddWithValue("@baslangic_tarihi", dtpBaslangicTarihi.Value);
                    komut.Parameters.AddWithValue("@bitis_tarihi", dtpBitisTarihi.Value);
                    komut.Parameters.AddWithValue("@izin_gun_sayisi", gunSayisi);
                    komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text.Trim());

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("İzin talebiniz başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("İzin talebi oluşturulurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
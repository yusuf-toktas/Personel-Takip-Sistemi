using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormPersonelDetay : Form
    {
        private readonly int? _personelId;

        public FormPersonelDetay(int? personelId = null)
        {
            InitializeComponent();
            _personelId = personelId;
        }

        private void FormPersonelDetay_Load(object sender, EventArgs e)
        {
            DepartmanlariYukle();
            UnvanlariYukle();
            YoneticileriYukle();

            if (_personelId.HasValue)
            {
                this.Text = "Personel Bilgilerini Düzenle";
                btnKaydet.Text = "Güncelle";
                btnMaasGecmisi.Visible = true;
                PersonelBilgileriniGetir(_personelId.Value);
            }
            else
            {
                this.Text = "Yeni Personel Ekle";
                btnKaydet.Text = "Kaydet";
                btnMaasGecmisi.Visible = false;
            }
        }

        private void DepartmanlariYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT departman_id, departman_adi FROM departmanlar ORDER BY departman_adi", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbDepartman.DataSource = dt;
                    cmbDepartman.DisplayMember = "departman_adi";
                    cmbDepartman.ValueMember = "departman_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departmanlar yüklenemedi: " + ex.Message);
            }
        }

        private void UnvanlariYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT unvan_id, unvan_adi FROM unvanlar ORDER BY unvan_adi", baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbUnvan.DataSource = dt;
                    cmbUnvan.DisplayMember = "unvan_adi";
                    cmbUnvan.ValueMember = "unvan_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unvanlar yüklenemedi: " + ex.Message);
            }
        }

        private void YoneticileriYukle()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT personel_id, (ad + ' ' + soyad) AS adsoyad FROM personel WHERE aktif_mi = 1";
                    if (_personelId.HasValue)
                    {
                        sorgu += " AND personel_id != " + _personelId.Value;
                    }
                    sorgu += " ORDER BY adsoyad";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow dr = dt.NewRow();
                    dr["personel_id"] = DBNull.Value;
                    dr["adsoyad"] = "Yönetici Seçilmedi";
                    dt.Rows.InsertAt(dr, 0);

                    cmbYonetici.DataSource = dt;
                    cmbYonetici.DisplayMember = "adsoyad";
                    cmbYonetici.ValueMember = "personel_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yöneticiler yüklenemedi: " + ex.Message);
            }
        }

        private void PersonelBilgileriniGetir(int personelId)
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = "SELECT * FROM personel WHERE personel_id = @personel_id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@personel_id", personelId);
                    baglanti.Open();
                    SqlDataReader okuyucu = komut.ExecuteReader();
                    if (okuyucu.Read())
                    {
                        txtAd.Text = okuyucu["ad"].ToString();
                        txtSoyad.Text = okuyucu["soyad"].ToString();
                        txtTcKimlikNo.Text = okuyucu["tc_kimlik_no"].ToString();
                        dtpDogumTarihi.Value = Convert.ToDateTime(okuyucu["dogum_tarihi"]);
                        dtpIseGirisTarihi.Value = Convert.ToDateTime(okuyucu["ise_giris_tarihi"]);
                        txtTelefon.Text = okuyucu["telefon_kisisel"].ToString();
                        txtEposta.Text = okuyucu["eposta_is"].ToString();
                        txtAdres.Text = okuyucu["adres"].ToString();

                        if (okuyucu["departman_id"] != DBNull.Value)
                            cmbDepartman.SelectedValue = okuyucu["departman_id"];
                        if (okuyucu["unvan_id"] != DBNull.Value)
                            cmbUnvan.SelectedValue = okuyucu["unvan_id"];
                        if (okuyucu["yonetici_id"] != DBNull.Value)
                            cmbYonetici.SelectedValue = okuyucu["yonetici_id"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel bilgileri getirilemedi: " + ex.Message);
                this.Close();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(txtTcKimlikNo.Text))
            {
                MessageBox.Show("Ad, Soyad ve TC Kimlik No alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu;
                    if (_personelId.HasValue)
                    {
                        sorgu = @"UPDATE personel SET 
                                    ad = @ad, soyad = @soyad, tc_kimlik_no = @tc_kimlik_no, dogum_tarihi = @dogum_tarihi,
                                    ise_giris_tarihi = @ise_giris_tarihi, telefon_kisisel = @telefon, eposta_is = @eposta,
                                    adres = @adres, departman_id = @departman_id, unvan_id = @unvan_id, yonetici_id = @yonetici_id
                                  WHERE personel_id = @personel_id";
                    }
                    else
                    {
                        sorgu = @"INSERT INTO personel 
                                    (ad, soyad, tc_kimlik_no, dogum_tarihi, ise_giris_tarihi, telefon_kisisel, eposta_is, adres, departman_id, unvan_id, yonetici_id, aktif_mi)
                                  VALUES 
                                    (@ad, @soyad, @tc_kimlik_no, @dogum_tarihi, @ise_giris_tarihi, @telefon, @eposta, @adres, @departman_id, @unvan_id, @yonetici_id, 1)";
                    }

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                    komut.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                    komut.Parameters.AddWithValue("@tc_kimlik_no", txtTcKimlikNo.Text.Trim());
                    komut.Parameters.AddWithValue("@dogum_tarihi", dtpDogumTarihi.Value);
                    komut.Parameters.AddWithValue("@ise_giris_tarihi", dtpIseGirisTarihi.Value);
                    komut.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                    komut.Parameters.AddWithValue("@eposta", txtEposta.Text.Trim());
                    komut.Parameters.AddWithValue("@adres", txtAdres.Text.Trim());

                    komut.Parameters.AddWithValue("@departman_id", (object)cmbDepartman.SelectedValue ?? DBNull.Value);
                    komut.Parameters.AddWithValue("@unvan_id", (object)cmbUnvan.SelectedValue ?? DBNull.Value);
                    komut.Parameters.AddWithValue("@yonetici_id", (object)cmbYonetici.SelectedValue ?? DBNull.Value);

                    if (_personelId.HasValue)
                    {
                        komut.Parameters.AddWithValue("@personel_id", _personelId.Value);
                    }

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("İşlem başarıyla tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaasGecmisi_Click(object sender, EventArgs e)
        {
            if (_personelId.HasValue)
            {
                string adSoyad = txtAd.Text + " " + txtSoyad.Text;
                FormMaasGecmisi formGecmis = new FormMaasGecmisi(_personelId.Value, adSoyad);
                formGecmis.ShowDialog();
            }
        }
    }
}
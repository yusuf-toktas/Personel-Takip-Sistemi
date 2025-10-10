using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTS
{
    public partial class FormMaasGecmisi : Form
    {
        private readonly int _personelId;
        private readonly string _personelAdSoyad;

        public FormMaasGecmisi(int personelId, string personelAdSoyad)
        {
            InitializeComponent();
            _personelId = personelId;
            _personelAdSoyad = personelAdSoyad;
        }

        private void FormMaasGecmisi_Load(object sender, EventArgs e)
        {
            this.Text = _personelAdSoyad + " - Maaş Geçmişi";
            GecmisiListele();
        }

        private void GecmisiListele()
        {
            try
            {
                using (var baglanti = VeritabaniBaglantisi.BaglantiGetir())
                {
                    string sorgu = @"SELECT brut_maas, baslangic_tarihi, degisiklik_nedeni 
                                     FROM maas_gecmisi 
                                     WHERE personel_id = @personel_id 
                                     ORDER BY baslangic_tarihi DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    da.SelectCommand.Parameters.AddWithValue("@personel_id", _personelId);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewMaasGecmisi.DataSource = dt;
                    BasliklariAyarla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaş geçmişi listelenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BasliklariAyarla()
        {
            if (dataGridViewMaasGecmisi.Columns.Count > 0)
            {
                dataGridViewMaasGecmisi.Columns["brut_maas"].HeaderText = "Brüt Maaş";
                dataGridViewMaasGecmisi.Columns["baslangic_tarihi"].HeaderText = "Başlangıç Tarihi";
                dataGridViewMaasGecmisi.Columns["degisiklik_nedeni"].HeaderText = "Değişiklik Nedeni";

                dataGridViewMaasGecmisi.Columns["brut_maas"].DefaultCellStyle.Format = "c2";
            }
        }
    }
}
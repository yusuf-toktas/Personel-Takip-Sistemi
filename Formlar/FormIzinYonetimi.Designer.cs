namespace PTS
{
    partial class FormIzinYonetimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewIzinler = new System.Windows.Forms.DataGridView();
            this.btnYeniIzinTalebi = new System.Windows.Forms.Button();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.groupBoxFiltre = new System.Windows.Forms.GroupBox();
            this.btnFiltreyiTemizle = new System.Windows.Forms.Button();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTarihArasi = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.cmbDurumFiltre = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cmbPersonelFiltre = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIzinler)).BeginInit();
            this.groupBoxFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewIzinler
            // 
            this.dataGridViewIzinler.AllowUserToAddRows = false;
            this.dataGridViewIzinler.AllowUserToDeleteRows = false;
            this.dataGridViewIzinler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIzinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIzinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIzinler.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewIzinler.MultiSelect = false;
            this.dataGridViewIzinler.Name = "dataGridViewIzinler";
            this.dataGridViewIzinler.ReadOnly = true;
            this.dataGridViewIzinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIzinler.Size = new System.Drawing.Size(910, 303);
            this.dataGridViewIzinler.TabIndex = 0;
            // 
            // btnYeniIzinTalebi
            // 
            this.btnYeniIzinTalebi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniIzinTalebi.Location = new System.Drawing.Point(12, 451);
            this.btnYeniIzinTalebi.Name = "btnYeniIzinTalebi";
            this.btnYeniIzinTalebi.Size = new System.Drawing.Size(121, 35);
            this.btnYeniIzinTalebi.TabIndex = 1;
            this.btnYeniIzinTalebi.Text = "Yeni İzin Talebi Oluştur";
            this.btnYeniIzinTalebi.UseVisualStyleBackColor = true;
            this.btnYeniIzinTalebi.Click += new System.EventHandler(this.btnYeniIzinTalebi_Click);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnayla.Location = new System.Drawing.Point(745, 451);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(85, 35);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Seçili Olanı Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReddet.Location = new System.Drawing.Point(836, 451);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(86, 35);
            this.btnReddet.TabIndex = 3;
            this.btnReddet.Text = "Seçili Olanı Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // groupBoxFiltre
            // 
            this.groupBoxFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltre.Controls.Add(this.btnFiltreyiTemizle);
            this.groupBoxFiltre.Controls.Add(this.btnFiltrele);
            this.groupBoxFiltre.Controls.Add(this.dtpBitisTarihi);
            this.groupBoxFiltre.Controls.Add(this.lblTarihArasi);
            this.groupBoxFiltre.Controls.Add(this.dtpBaslangicTarihi);
            this.groupBoxFiltre.Controls.Add(this.lblTarihAraligi);
            this.groupBoxFiltre.Controls.Add(this.cmbDurumFiltre);
            this.groupBoxFiltre.Controls.Add(this.lblDurum);
            this.groupBoxFiltre.Controls.Add(this.cmbPersonelFiltre);
            this.groupBoxFiltre.Controls.Add(this.lblPersonel);
            this.groupBoxFiltre.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltre.Name = "groupBoxFiltre";
            this.groupBoxFiltre.Size = new System.Drawing.Size(910, 124);
            this.groupBoxFiltre.TabIndex = 4;
            this.groupBoxFiltre.TabStop = false;
            this.groupBoxFiltre.Text = "Filtreleme Seçenekleri";
            // 
            // btnFiltreyiTemizle
            // 
            this.btnFiltreyiTemizle.Location = new System.Drawing.Point(784, 53);
            this.btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            this.btnFiltreyiTemizle.Size = new System.Drawing.Size(107, 23);
            this.btnFiltreyiTemizle.TabIndex = 9;
            this.btnFiltreyiTemizle.Text = "Filtreyi Temizle";
            this.btnFiltreyiTemizle.UseVisualStyleBackColor = true;
            this.btnFiltreyiTemizle.Click += new System.EventHandler(this.btnFiltreyiTemizle_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(784, 24);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(107, 23);
            this.btnFiltrele.TabIndex = 8;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(401, 57);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(170, 20);
            this.dtpBitisTarihi.TabIndex = 7;
            // 
            // lblTarihArasi
            // 
            this.lblTarihArasi.AutoSize = true;
            this.lblTarihArasi.Location = new System.Drawing.Point(384, 60);
            this.lblTarihArasi.Name = "lblTarihArasi";
            this.lblTarihArasi.Size = new System.Drawing.Size(10, 13);
            this.lblTarihArasi.TabIndex = 6;
            this.lblTarihArasi.Text = "-";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(208, 57);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(170, 20);
            this.dtpBaslangicTarihi.TabIndex = 5;
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.Location = new System.Drawing.Point(205, 41);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(95, 13);
            this.lblTarihAraligi.TabIndex = 4;
            this.lblTarihAraligi.Text = "İzin Başlangıç Tarih Aralığı:";
            // 
            // cmbDurumFiltre
            // 
            this.cmbDurumFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurumFiltre.FormattingEnabled = true;
            this.cmbDurumFiltre.Location = new System.Drawing.Point(9, 83);
            this.cmbDurumFiltre.Name = "cmbDurumFiltre";
            this.cmbDurumFiltre.Size = new System.Drawing.Size(170, 21);
            this.cmbDurumFiltre.TabIndex = 3;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(6, 67);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(69, 13);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "İzin Durumu:";
            // 
            // cmbPersonelFiltre
            // 
            this.cmbPersonelFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelFiltre.FormattingEnabled = true;
            this.cmbPersonelFiltre.Location = new System.Drawing.Point(9, 41);
            this.cmbPersonelFiltre.Name = "cmbPersonelFiltre";
            this.cmbPersonelFiltre.Size = new System.Drawing.Size(170, 21);
            this.cmbPersonelFiltre.TabIndex = 1;
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(6, 25);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(51, 13);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "Personel:";
            // 
            // FormIzinYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 492);
            this.Controls.Add(this.groupBoxFiltre);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.btnYeniIzinTalebi);
            this.Controls.Add(this.dataGridViewIzinler);
            this.Name = "FormIzinYonetimi";
            this.Text = "İzin Yönetimi";
            this.Load += new System.EventHandler(this.FormIzinYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIzinler)).EndInit();
            this.groupBoxFiltre.ResumeLayout(false);
            this.groupBoxFiltre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIzinler;
        private System.Windows.Forms.Button btnYeniIzinTalebi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.GroupBox groupBoxFiltre;
        private System.Windows.Forms.ComboBox cmbPersonelFiltre;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.ComboBox cmbDurumFiltre;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblTarihArasi;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.Button btnFiltreyiTemizle;
        private System.Windows.Forms.Button btnFiltrele;
    }
}
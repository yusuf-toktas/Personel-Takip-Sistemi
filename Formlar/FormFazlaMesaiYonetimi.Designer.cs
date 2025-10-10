namespace PTS
{
    partial class FormFazlaMesaiYonetimi
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
            this.dataGridViewMesailer = new System.Windows.Forms.DataGridView();
            this.btnYeniMesaiEkle = new System.Windows.Forms.Button();
            this.btnOdendiIsaretle = new System.Windows.Forms.Button();
            this.groupBoxFiltre = new System.Windows.Forms.GroupBox();
            this.btnFiltreyiTemizle = new System.Windows.Forms.Button();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.cmbOdendiFiltre = new System.Windows.Forms.ComboBox();
            this.lblOdendiDurumu = new System.Windows.Forms.Label();
            this.cmbPersonelFiltre = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).BeginInit();
            this.groupBoxFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMesailer
            // 
            this.dataGridViewMesailer.AllowUserToAddRows = false;
            this.dataGridViewMesailer.AllowUserToDeleteRows = false;
            this.dataGridViewMesailer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMesailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMesailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesailer.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewMesailer.MultiSelect = false;
            this.dataGridViewMesailer.Name = "dataGridViewMesailer";
            this.dataGridViewMesailer.ReadOnly = true;
            this.dataGridViewMesailer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMesailer.Size = new System.Drawing.Size(910, 303);
            this.dataGridViewMesailer.TabIndex = 1;
            // 
            // btnYeniMesaiEkle
            // 
            this.btnYeniMesaiEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniMesaiEkle.Location = new System.Drawing.Point(12, 451);
            this.btnYeniMesaiEkle.Name = "btnYeniMesaiEkle";
            this.btnYeniMesaiEkle.Size = new System.Drawing.Size(121, 35);
            this.btnYeniMesaiEkle.TabIndex = 2;
            this.btnYeniMesaiEkle.Text = "Yeni Mesai Ekle";
            this.btnYeniMesaiEkle.UseVisualStyleBackColor = true;
            this.btnYeniMesaiEkle.Click += new System.EventHandler(this.btnYeniMesaiEkle_Click);
            // 
            // btnOdendiIsaretle
            // 
            this.btnOdendiIsaretle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdendiIsaretle.Location = new System.Drawing.Point(784, 451);
            this.btnOdendiIsaretle.Name = "btnOdendiIsaretle";
            this.btnOdendiIsaretle.Size = new System.Drawing.Size(138, 35);
            this.btnOdendiIsaretle.TabIndex = 3;
            this.btnOdendiIsaretle.Text = "Seçili Olanı Ödendi İşaretle";
            this.btnOdendiIsaretle.UseVisualStyleBackColor = true;
            this.btnOdendiIsaretle.Click += new System.EventHandler(this.btnOdendiIsaretle_Click);
            // 
            // groupBoxFiltre
            // 
            this.groupBoxFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltre.Controls.Add(this.btnFiltreyiTemizle);
            this.groupBoxFiltre.Controls.Add(this.btnFiltrele);
            this.groupBoxFiltre.Controls.Add(this.dtpBitisTarihi);
            this.groupBoxFiltre.Controls.Add(this.label1);
            this.groupBoxFiltre.Controls.Add(this.dtpBaslangicTarihi);
            this.groupBoxFiltre.Controls.Add(this.lblTarihAraligi);
            this.groupBoxFiltre.Controls.Add(this.cmbOdendiFiltre);
            this.groupBoxFiltre.Controls.Add(this.lblOdendiDurumu);
            this.groupBoxFiltre.Controls.Add(this.cmbPersonelFiltre);
            this.groupBoxFiltre.Controls.Add(this.lblPersonel);
            this.groupBoxFiltre.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltre.Name = "groupBoxFiltre";
            this.groupBoxFiltre.Size = new System.Drawing.Size(910, 124);
            this.groupBoxFiltre.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
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
            this.lblTarihAraligi.Text = "Mesai Tarih Aralığı:";
            // 
            // cmbOdendiFiltre
            // 
            this.cmbOdendiFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdendiFiltre.FormattingEnabled = true;
            this.cmbOdendiFiltre.Location = new System.Drawing.Point(9, 83);
            this.cmbOdendiFiltre.Name = "cmbOdendiFiltre";
            this.cmbOdendiFiltre.Size = new System.Drawing.Size(170, 21);
            this.cmbOdendiFiltre.TabIndex = 3;
            // 
            // lblOdendiDurumu
            // 
            this.lblOdendiDurumu.AutoSize = true;
            this.lblOdendiDurumu.Location = new System.Drawing.Point(6, 67);
            this.lblOdendiDurumu.Name = "lblOdendiDurumu";
            this.lblOdendiDurumu.Size = new System.Drawing.Size(84, 13);
            this.lblOdendiDurumu.TabIndex = 2;
            this.lblOdendiDurumu.Text = "Ödenme Durumu:";
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
            // btnExcelAktar
            // 
            this.btnExcelAktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcelAktar.Location = new System.Drawing.Point(139, 451);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(121, 35);
            this.btnExcelAktar.TabIndex = 6;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // FormFazlaMesaiYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 492);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.groupBoxFiltre);
            this.Controls.Add(this.btnOdendiIsaretle);
            this.Controls.Add(this.btnYeniMesaiEkle);
            this.Controls.Add(this.dataGridViewMesailer);
            this.Name = "FormFazlaMesaiYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fazla Mesai Yönetimi";
            this.Load += new System.EventHandler(this.FormFazlaMesaiYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesailer)).EndInit();
            this.groupBoxFiltre.ResumeLayout(false);
            this.groupBoxFiltre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMesailer;
        private System.Windows.Forms.Button btnYeniMesaiEkle;
        private System.Windows.Forms.Button btnOdendiIsaretle;
        private System.Windows.Forms.GroupBox groupBoxFiltre;
        private System.Windows.Forms.Button btnFiltreyiTemizle;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.ComboBox cmbOdendiFiltre;
        private System.Windows.Forms.Label lblOdendiDurumu;
        private System.Windows.Forms.ComboBox cmbPersonelFiltre;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Button btnExcelAktar;
    }
}
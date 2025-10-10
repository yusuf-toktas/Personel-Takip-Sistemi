namespace PTS
{
    partial class FormIzinTalebi
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
            this.lblPersonel = new System.Windows.Forms.Label();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.cmbIzinTuru = new System.Windows.Forms.ComboBox();
            this.lblIzinTuru = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBitis = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnTalepGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(28, 30);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(91, 13);
            this.lblPersonel.TabIndex = 0;
            this.lblPersonel.Text = "İzin Talep Eden : ";
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(125, 27);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(247, 21);
            this.cmbPersonel.TabIndex = 1;
            // 
            // cmbIzinTuru
            // 
            this.cmbIzinTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIzinTuru.FormattingEnabled = true;
            this.cmbIzinTuru.Location = new System.Drawing.Point(125, 54);
            this.cmbIzinTuru.Name = "cmbIzinTuru";
            this.cmbIzinTuru.Size = new System.Drawing.Size(247, 21);
            this.cmbIzinTuru.TabIndex = 3;
            // 
            // lblIzinTuru
            // 
            this.lblIzinTuru.AutoSize = true;
            this.lblIzinTuru.Location = new System.Drawing.Point(28, 57);
            this.lblIzinTuru.Name = "lblIzinTuru";
            this.lblIzinTuru.Size = new System.Drawing.Size(53, 13);
            this.lblIzinTuru.TabIndex = 2;
            this.lblIzinTuru.Text = "İzin Türü :";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(28, 88);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(88, 13);
            this.lblBaslangic.TabIndex = 4;
            this.lblBaslangic.Text = "Başlangıç Tarihi :";
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(125, 82);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(247, 20);
            this.dtpBaslangicTarihi.TabIndex = 5;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(125, 108);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(247, 20);
            this.dtpBitisTarihi.TabIndex = 7;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(28, 114);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(61, 13);
            this.lblBitis.TabIndex = 6;
            this.lblBitis.Text = "Bitiş Tarihi :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(125, 134);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(247, 85);
            this.txtAciklama.TabIndex = 8;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(28, 137);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 13);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // btnTalepGonder
            // 
            this.btnTalepGonder.Location = new System.Drawing.Point(257, 225);
            this.btnTalepGonder.Name = "btnTalepGonder";
            this.btnTalepGonder.Size = new System.Drawing.Size(115, 33);
            this.btnTalepGonder.TabIndex = 10;
            this.btnTalepGonder.Text = "Talebi Gönder";
            this.btnTalepGonder.UseVisualStyleBackColor = true;
            this.btnTalepGonder.Click += new System.EventHandler(this.btnTalepGonder_Click);
            // 
            // FormIzinTalebi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 276);
            this.Controls.Add(this.btnTalepGonder);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.cmbIzinTuru);
            this.Controls.Add(this.lblIzinTuru);
            this.Controls.Add(this.cmbPersonel);
            this.Controls.Add(this.lblPersonel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIzinTalebi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni İzin Talebi Oluştur";
            this.Load += new System.EventHandler(this.FormIzinTalebi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.ComboBox cmbIzinTuru;
        private System.Windows.Forms.Label lblIzinTuru;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnTalepGonder;
    }
}
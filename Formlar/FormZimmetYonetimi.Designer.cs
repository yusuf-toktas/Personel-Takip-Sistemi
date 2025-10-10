namespace PTS
{
    partial class FormZimmetYonetimi
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
            this.dataGridViewZimmetler = new System.Windows.Forms.DataGridView();
            this.btnYeniZimmetAta = new System.Windows.Forms.Button();
            this.btnIadeAl = new System.Windows.Forms.Button();
            this.groupBoxFiltre = new System.Windows.Forms.GroupBox();
            this.btnFiltreyiTemizle = new System.Windows.Forms.Button();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.cmbPersonelFiltre = new System.Windows.Forms.ComboBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmetler)).BeginInit();
            this.groupBoxFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewZimmetler
            // 
            this.dataGridViewZimmetler.AllowUserToAddRows = false;
            this.dataGridViewZimmetler.AllowUserToDeleteRows = false;
            this.dataGridViewZimmetler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewZimmetler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewZimmetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZimmetler.Location = new System.Drawing.Point(12, 107);
            this.dataGridViewZimmetler.MultiSelect = false;
            this.dataGridViewZimmetler.Name = "dataGridViewZimmetler";
            this.dataGridViewZimmetler.ReadOnly = true;
            this.dataGridViewZimmetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZimmetler.Size = new System.Drawing.Size(890, 338);
            this.dataGridViewZimmetler.TabIndex = 0;
            // 
            // btnYeniZimmetAta
            // 
            this.btnYeniZimmetAta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYeniZimmetAta.Location = new System.Drawing.Point(12, 451);
            this.btnYeniZimmetAta.Name = "btnYeniZimmetAta";
            this.btnYeniZimmetAta.Size = new System.Drawing.Size(121, 35);
            this.btnYeniZimmetAta.TabIndex = 2;
            this.btnYeniZimmetAta.Text = "Yeni Zimmet Ata";
            this.btnYeniZimmetAta.UseVisualStyleBackColor = true;
            this.btnYeniZimmetAta.Click += new System.EventHandler(this.btnYeniZimmetAta_Click);
            // 
            // btnIadeAl
            // 
            this.btnIadeAl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIadeAl.Location = new System.Drawing.Point(783, 451);
            this.btnIadeAl.Name = "btnIadeAl";
            this.btnIadeAl.Size = new System.Drawing.Size(119, 35);
            this.btnIadeAl.TabIndex = 3;
            this.btnIadeAl.Text = "Seçili Olanı İade Al";
            this.btnIadeAl.UseVisualStyleBackColor = true;
            this.btnIadeAl.Click += new System.EventHandler(this.btnIadeAl_Click);
            // 
            // groupBoxFiltre
            // 
            this.groupBoxFiltre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltre.Controls.Add(this.btnFiltreyiTemizle);
            this.groupBoxFiltre.Controls.Add(this.btnFiltrele);
            this.groupBoxFiltre.Controls.Add(this.txtArama);
            this.groupBoxFiltre.Controls.Add(this.lblArama);
            this.groupBoxFiltre.Controls.Add(this.cmbPersonelFiltre);
            this.groupBoxFiltre.Controls.Add(this.lblPersonel);
            this.groupBoxFiltre.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFiltre.Name = "groupBoxFiltre";
            this.groupBoxFiltre.Size = new System.Drawing.Size(890, 89);
            this.groupBoxFiltre.TabIndex = 4;
            this.groupBoxFiltre.TabStop = false;
            this.groupBoxFiltre.Text = "Filtreleme";
            // 
            // btnFiltreyiTemizle
            // 
            this.btnFiltreyiTemizle.Location = new System.Drawing.Point(501, 43);
            this.btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            this.btnFiltreyiTemizle.Size = new System.Drawing.Size(95, 23);
            this.btnFiltreyiTemizle.TabIndex = 5;
            this.btnFiltreyiTemizle.Text = "Filtreyi Temizle";
            this.btnFiltreyiTemizle.UseVisualStyleBackColor = true;
            this.btnFiltreyiTemizle.Click += new System.EventHandler(this.btnFiltreyiTemizle_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(420, 43);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrele.TabIndex = 4;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(216, 45);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(180, 20);
            this.txtArama.TabIndex = 3;
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(213, 29);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(127, 13);
            this.lblArama.TabIndex = 2;
            this.lblArama.Text = "Ürün Adı / Seri No ile Ara:";
            // 
            // cmbPersonelFiltre
            // 
            this.cmbPersonelFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelFiltre.FormattingEnabled = true;
            this.cmbPersonelFiltre.Location = new System.Drawing.Point(18, 45);
            this.cmbPersonelFiltre.Name = "cmbPersonelFiltre";
            this.cmbPersonelFiltre.Size = new System.Drawing.Size(180, 21);
            this.cmbPersonelFiltre.TabIndex = 1;
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Location = new System.Drawing.Point(15, 29);
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
            this.btnExcelAktar.Size = new System.Drawing.Size(119, 35);
            this.btnExcelAktar.TabIndex = 5;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // FormZimmetYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 492);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.groupBoxFiltre);
            this.Controls.Add(this.btnIadeAl);
            this.Controls.Add(this.btnYeniZimmetAta);
            this.Controls.Add(this.dataGridViewZimmetler);
            this.Name = "FormZimmetYonetimi";
            this.Text = "Zimmet Yönetimi";
            this.Load += new System.EventHandler(this.FormZimmetYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmetler)).EndInit();
            this.groupBoxFiltre.ResumeLayout(false);
            this.groupBoxFiltre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZimmetler;
        private System.Windows.Forms.Button btnYeniZimmetAta;
        private System.Windows.Forms.Button btnIadeAl;
        private System.Windows.Forms.GroupBox groupBoxFiltre;
        private System.Windows.Forms.Button btnFiltreyiTemizle;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.ComboBox cmbPersonelFiltre;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Button btnExcelAktar;
    }
}
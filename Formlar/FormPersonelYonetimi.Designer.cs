namespace PTS
{
    partial class FormPersonelYonetimi
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmanYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unvanYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izinYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zimmetYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazlaMesaiYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBuAyGiren = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdenmemisMesai = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBekleyenIzin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamPersonel = new System.Windows.Forms.Label();
            this.btnDashboardYenile = new System.Windows.Forms.Button();
            this.tabPagePersonelListesi = new System.Windows.Forms.TabPage();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.cmbDepartmanFiltre = new System.Windows.Forms.ComboBox();
            this.lblDepartmanFiltre = new System.Windows.Forms.Label();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnYeniEkle = new System.Windows.Forms.Button();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPagePersonelListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.işlemlerToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmanYönetimiToolStripMenuItem,
            this.unvanYönetimiToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // departmanYönetimiToolStripMenuItem
            // 
            this.departmanYönetimiToolStripMenuItem.Name = "departmanYönetimiToolStripMenuItem";
            this.departmanYönetimiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.departmanYönetimiToolStripMenuItem.Text = "Departman Yönetimi";
            this.departmanYönetimiToolStripMenuItem.Click += new System.EventHandler(this.departmanYönetimiToolStripMenuItem_Click);
            // 
            // unvanYönetimiToolStripMenuItem
            // 
            this.unvanYönetimiToolStripMenuItem.Name = "unvanYönetimiToolStripMenuItem";
            this.unvanYönetimiToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.unvanYönetimiToolStripMenuItem.Text = "Unvan Yönetimi";
            this.unvanYönetimiToolStripMenuItem.Click += new System.EventHandler(this.unvanYönetimiToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izinYönetimiToolStripMenuItem,
            this.zimmetYönetimiToolStripMenuItem,
            this.fazlaMesaiYönetimiToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // izinYönetimiToolStripMenuItem
            // 
            this.izinYönetimiToolStripMenuItem.Name = "izinYönetimiToolStripMenuItem";
            this.izinYönetimiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.izinYönetimiToolStripMenuItem.Text = "İzin Yönetimi";
            this.izinYönetimiToolStripMenuItem.Click += new System.EventHandler(this.izinYönetimiToolStripMenuItem_Click);
            // 
            // zimmetYönetimiToolStripMenuItem
            // 
            this.zimmetYönetimiToolStripMenuItem.Name = "zimmetYönetimiToolStripMenuItem";
            this.zimmetYönetimiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.zimmetYönetimiToolStripMenuItem.Text = "Zimmet Yönetimi";
            this.zimmetYönetimiToolStripMenuItem.Click += new System.EventHandler(this.zimmetYönetimiToolStripMenuItem_Click);
            // 
            // fazlaMesaiYönetimiToolStripMenuItem
            // 
            this.fazlaMesaiYönetimiToolStripMenuItem.Name = "fazlaMesaiYönetimiToolStripMenuItem";
            this.fazlaMesaiYönetimiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.fazlaMesaiYönetimiToolStripMenuItem.Text = "Fazla Mesai Yönetimi";
            this.fazlaMesaiYönetimiToolStripMenuItem.Click += new System.EventHandler(this.fazlaMesaiYönetimiToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında...";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageDashboard);
            this.tabControl1.Controls.Add(this.tabPagePersonelListesi);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 495);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Controls.Add(this.panel4);
            this.tabPageDashboard.Controls.Add(this.panel3);
            this.tabPageDashboard.Controls.Add(this.panel2);
            this.tabPageDashboard.Controls.Add(this.panel1);
            this.tabPageDashboard.Controls.Add(this.btnDashboardYenile);
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 22);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(975, 469);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Gösterge Paneli";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblBuAyGiren);
            this.panel4.Location = new System.Drawing.Point(627, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 100);
            this.panel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bu Ay İşe Girenler";
            // 
            // lblBuAyGiren
            // 
            this.lblBuAyGiren.AutoSize = true;
            this.lblBuAyGiren.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBuAyGiren.ForeColor = System.Drawing.Color.White;
            this.lblBuAyGiren.Location = new System.Drawing.Point(10, 17);
            this.lblBuAyGiren.Name = "lblBuAyGiren";
            this.lblBuAyGiren.Size = new System.Drawing.Size(36, 37);
            this.lblBuAyGiren.TabIndex = 0;
            this.lblBuAyGiren.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblOdenmemisMesai);
            this.panel3.Location = new System.Drawing.Point(427, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 100);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ödenmemiş Mesai";
            // 
            // lblOdenmemisMesai
            // 
            this.lblOdenmemisMesai.AutoSize = true;
            this.lblOdenmemisMesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenmemisMesai.ForeColor = System.Drawing.Color.White;
            this.lblOdenmemisMesai.Location = new System.Drawing.Point(10, 17);
            this.lblOdenmemisMesai.Name = "lblOdenmemisMesai";
            this.lblOdenmemisMesai.Size = new System.Drawing.Size(36, 37);
            this.lblOdenmemisMesai.TabIndex = 0;
            this.lblOdenmemisMesai.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblBekleyenIzin);
            this.panel2.Location = new System.Drawing.Point(227, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 100);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bekleyen İzin Talebi";
            // 
            // lblBekleyenIzin
            // 
            this.lblBekleyenIzin.AutoSize = true;
            this.lblBekleyenIzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBekleyenIzin.ForeColor = System.Drawing.Color.White;
            this.lblBekleyenIzin.Location = new System.Drawing.Point(10, 17);
            this.lblBekleyenIzin.Name = "lblBekleyenIzin";
            this.lblBekleyenIzin.Size = new System.Drawing.Size(36, 37);
            this.lblBekleyenIzin.TabIndex = 0;
            this.lblBekleyenIzin.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblToplamPersonel);
            this.panel1.Location = new System.Drawing.Point(27, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Personel";
            // 
            // lblToplamPersonel
            // 
            this.lblToplamPersonel.AutoSize = true;
            this.lblToplamPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamPersonel.ForeColor = System.Drawing.Color.White;
            this.lblToplamPersonel.Location = new System.Drawing.Point(10, 17);
            this.lblToplamPersonel.Name = "lblToplamPersonel";
            this.lblToplamPersonel.Size = new System.Drawing.Size(36, 37);
            this.lblToplamPersonel.TabIndex = 0;
            this.lblToplamPersonel.Text = "0";
            // 
            // btnDashboardYenile
            // 
            this.btnDashboardYenile.Location = new System.Drawing.Point(27, 19);
            this.btnDashboardYenile.Name = "btnDashboardYenile";
            this.btnDashboardYenile.Size = new System.Drawing.Size(111, 23);
            this.btnDashboardYenile.TabIndex = 0;
            this.btnDashboardYenile.Text = "Verileri Yenile";
            this.btnDashboardYenile.UseVisualStyleBackColor = true;
            this.btnDashboardYenile.Click += new System.EventHandler(this.btnDashboardYenile_Click);
            // 
            // tabPagePersonelListesi
            // 
            this.tabPagePersonelListesi.Controls.Add(this.btnExcelAktar);
            this.tabPagePersonelListesi.Controls.Add(this.btnYenile);
            this.tabPagePersonelListesi.Controls.Add(this.cmbDepartmanFiltre);
            this.tabPagePersonelListesi.Controls.Add(this.lblDepartmanFiltre);
            this.tabPagePersonelListesi.Controls.Add(this.lblArama);
            this.tabPagePersonelListesi.Controls.Add(this.txtArama);
            this.tabPagePersonelListesi.Controls.Add(this.btnSil);
            this.tabPagePersonelListesi.Controls.Add(this.btnDuzenle);
            this.tabPagePersonelListesi.Controls.Add(this.btnYeniEkle);
            this.tabPagePersonelListesi.Controls.Add(this.dataGridViewPersonel);
            this.tabPagePersonelListesi.Location = new System.Drawing.Point(4, 22);
            this.tabPagePersonelListesi.Name = "tabPagePersonelListesi";
            this.tabPagePersonelListesi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonelListesi.Size = new System.Drawing.Size(975, 469);
            this.tabPagePersonelListesi.TabIndex = 1;
            this.tabPagePersonelListesi.Text = "Personel Listesi";
            this.tabPagePersonelListesi.UseVisualStyleBackColor = true;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcelAktar.Location = new System.Drawing.Point(105, 431);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(91, 32);
            this.btnExcelAktar.TabIndex = 18;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnYenile.Location = new System.Drawing.Point(8, 431);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(91, 32);
            this.btnYenile.TabIndex = 17;
            this.btnYenile.Text = "Listeyi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // cmbDepartmanFiltre
            // 
            this.cmbDepartmanFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartmanFiltre.FormattingEnabled = true;
            this.cmbDepartmanFiltre.Location = new System.Drawing.Point(415, 14);
            this.cmbDepartmanFiltre.Name = "cmbDepartmanFiltre";
            this.cmbDepartmanFiltre.Size = new System.Drawing.Size(199, 21);
            this.cmbDepartmanFiltre.TabIndex = 16;
            this.cmbDepartmanFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmanFiltre_SelectedIndexChanged);
            // 
            // lblDepartmanFiltre
            // 
            this.lblDepartmanFiltre.AutoSize = true;
            this.lblDepartmanFiltre.Location = new System.Drawing.Point(317, 17);
            this.lblDepartmanFiltre.Name = "lblDepartmanFiltre";
            this.lblDepartmanFiltre.Size = new System.Drawing.Size(92, 13);
            this.lblDepartmanFiltre.TabIndex = 15;
            this.lblDepartmanFiltre.Text = "Departmana Göre:";
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(8, 17);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(82, 13);
            this.lblArama.TabIndex = 14;
            this.lblArama.Text = "Ad / Soyad Ara:";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(96, 14);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(199, 20);
            this.txtArama.TabIndex = 13;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(875, 431);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 32);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(777, 431);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(92, 32);
            this.btnDuzenle.TabIndex = 11;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeniEkle.Location = new System.Drawing.Point(680, 431);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(91, 32);
            this.btnYeniEkle.TabIndex = 10;
            this.btnYeniEkle.Text = "Yeni Ekle";
            this.btnYeniEkle.UseVisualStyleBackColor = true;
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AllowUserToAddRows = false;
            this.dataGridViewPersonel.AllowUserToDeleteRows = false;
            this.dataGridViewPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(8, 49);
            this.dataGridViewPersonel.MultiSelect = false;
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.ReadOnly = true;
            this.dataGridViewPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(959, 376);
            this.dataGridViewPersonel.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssKullanici,
            this.tssTarih});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(983, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssKullanici
            // 
            this.tssKullanici.Name = "tssKullanici";
            this.tssKullanici.Size = new System.Drawing.Size(59, 17);
            this.tssKullanici.Text = "Kullanıcı: -";
            // 
            // tssTarih
            // 
            this.tssTarih.Name = "tssTarih";
            this.tssTarih.Size = new System.Drawing.Size(909, 17);
            this.tssTarih.Spring = true;
            this.tssTarih.Text = "Tarih";
            this.tssTarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 1000;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // FormPersonelYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 545);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPersonelYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Yönetim Sistemi";
            this.Load += new System.EventHandler(this.FormPersonelYonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPagePersonelListesi.ResumeLayout(false);
            this.tabPagePersonelListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmanYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unvanYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izinYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zimmetYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazlaMesaiYönetimiToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.TabPage tabPagePersonelListesi;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ComboBox cmbDepartmanFiltre;
        private System.Windows.Forms.Label lblDepartmanFiltre;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYeniEkle;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.Button btnDashboardYenile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamPersonel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBekleyenIzin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBuAyGiren;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdenmemisMesai;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssKullanici;
        private System.Windows.Forms.ToolStripStatusLabel tssTarih;
        private System.Windows.Forms.Timer timerSaat;
    }
}
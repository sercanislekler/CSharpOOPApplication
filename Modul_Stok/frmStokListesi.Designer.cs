namespace Otomasyon.Modul_Stok
{
    partial class frmStokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.RadKdvHaric = new System.Windows.Forms.RadioButton();
            this.RadIskonto = new System.Windows.Forms.RadioButton();
            this.RadTumunuListele = new System.Windows.Forms.RadioButton();
            this.RadKdvDahil = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtStkKrtkSv = new DevExpress.XtraEditors.TextEdit();
            this.txtUreticiFir = new DevExpress.XtraEditors.TextEdit();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIptal = new System.Windows.Forms.RadioButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.BtnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dtbitis = new System.Windows.Forms.DateTimePicker();
            this.dtbaslangic = new System.Windows.Forms.DateTimePicker();
            this.StokListe = new DevExpress.XtraGrid.GridControl();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stokBilgileriniGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StokListeGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Barkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UreticiFirma = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokKrtkSev = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokSatisFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokSatisKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KdvDahil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokSaveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IskontoDahil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IskontoOran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IndirimliFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IndirimMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokPaket = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStkKrtkSv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUreticiFir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StokListe)).BeginInit();
            this.SagTik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StokListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.StokListe);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1184, 422);
            this.splitContainerControl1.SplitterPosition = 221;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(221, 422);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.RadKdvHaric);
            this.xtraTabPage1.Controls.Add(this.RadIskonto);
            this.xtraTabPage1.Controls.Add(this.RadTumunuListele);
            this.xtraTabPage1.Controls.Add(this.RadKdvDahil);
            this.xtraTabPage1.Controls.Add(this.simpleButton1);
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.txtBarkod);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.txtStkKrtkSv);
            this.xtraTabPage1.Controls.Add(this.txtUreticiFir);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.groupBox1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(215, 394);
            this.xtraTabPage1.Text = "Arama";
            // 
            // RadKdvHaric
            // 
            this.RadKdvHaric.AutoSize = true;
            this.RadKdvHaric.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadKdvHaric.ForeColor = System.Drawing.Color.Red;
            this.RadKdvHaric.Location = new System.Drawing.Point(98, 320);
            this.RadKdvHaric.Name = "RadKdvHaric";
            this.RadKdvHaric.Size = new System.Drawing.Size(78, 17);
            this.RadKdvHaric.TabIndex = 10;
            this.RadKdvHaric.Text = "Kdv Hariç";
            this.RadKdvHaric.UseVisualStyleBackColor = true;
            // 
            // RadIskonto
            // 
            this.RadIskonto.AutoSize = true;
            this.RadIskonto.Checked = true;
            this.RadIskonto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadIskonto.ForeColor = System.Drawing.Color.Red;
            this.RadIskonto.Location = new System.Drawing.Point(14, 345);
            this.RadIskonto.Name = "RadIskonto";
            this.RadIskonto.Size = new System.Drawing.Size(100, 17);
            this.RadIskonto.TabIndex = 11;
            this.RadIskonto.TabStop = true;
            this.RadIskonto.Text = "İskonto Dahil";
            this.RadIskonto.UseVisualStyleBackColor = true;
            // 
            // RadTumunuListele
            // 
            this.RadTumunuListele.AutoSize = true;
            this.RadTumunuListele.Checked = true;
            this.RadTumunuListele.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadTumunuListele.ForeColor = System.Drawing.Color.Red;
            this.RadTumunuListele.Location = new System.Drawing.Point(14, 370);
            this.RadTumunuListele.Name = "RadTumunuListele";
            this.RadTumunuListele.Size = new System.Drawing.Size(111, 17);
            this.RadTumunuListele.TabIndex = 11;
            this.RadTumunuListele.TabStop = true;
            this.RadTumunuListele.Text = "Tümünü Listele";
            this.RadTumunuListele.UseVisualStyleBackColor = true;
            // 
            // RadKdvDahil
            // 
            this.RadKdvDahil.AutoSize = true;
            this.RadKdvDahil.Checked = true;
            this.RadKdvDahil.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.RadKdvDahil.ForeColor = System.Drawing.Color.Red;
            this.RadKdvDahil.Location = new System.Drawing.Point(15, 320);
            this.RadKdvDahil.Name = "RadKdvDahil";
            this.RadKdvDahil.Size = new System.Drawing.Size(77, 17);
            this.RadKdvDahil.TabIndex = 11;
            this.RadKdvDahil.TabStop = true;
            this.RadKdvDahil.Text = "Kdv Dahil";
            this.RadKdvDahil.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.simpleButton1.Location = new System.Drawing.Point(123, 263);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 38);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Önizleme";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Otomasyon.Properties.Resources.Excel32x32;
            this.simpleButton2.Location = new System.Drawing.Point(10, 263);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(107, 38);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Excel\'e Aktar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnAra
            // 
            this.btnAra.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(10, 223);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(107, 35);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Otomasyon.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(123, 223);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Temizle";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(13, 119);
            this.txtBarkod.Margin = new System.Windows.Forms.Padding(2);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(184, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(13, 78);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(184, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // txtStkKrtkSv
            // 
            this.txtStkKrtkSv.Location = new System.Drawing.Point(13, 201);
            this.txtStkKrtkSv.Margin = new System.Windows.Forms.Padding(2);
            this.txtStkKrtkSv.Name = "txtStkKrtkSv";
            this.txtStkKrtkSv.Size = new System.Drawing.Size(67, 20);
            this.txtStkKrtkSv.TabIndex = 1;
            // 
            // txtUreticiFir
            // 
            this.txtUreticiFir.Location = new System.Drawing.Point(13, 160);
            this.txtUreticiFir.Margin = new System.Windows.Forms.Padding(2);
            this.txtUreticiFir.Name = "txtUreticiFir";
            this.txtUreticiFir.Size = new System.Drawing.Size(184, 20);
            this.txtUreticiFir.TabIndex = 1;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(13, 37);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(2);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(184, 20);
            this.txtStokKodu.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 101);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Barkod :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Stok Adı :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 184);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(67, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Stk. Krtk. Sv. ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 143);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Üretici Firma :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radIptal);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(2, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtreleme Seçenekleri";
            // 
            // radIptal
            // 
            this.radIptal.AutoSize = true;
            this.radIptal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radIptal.ForeColor = System.Drawing.Color.Red;
            this.radIptal.Location = new System.Drawing.Point(130, 68);
            this.radIptal.Name = "radIptal";
            this.radIptal.Size = new System.Drawing.Size(52, 17);
            this.radIptal.TabIndex = 0;
            this.radIptal.TabStop = true;
            this.radIptal.Text = "İptal";
            this.radIptal.UseVisualStyleBackColor = true;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.BtnFiltrele);
            this.xtraTabPage2.Controls.Add(this.labelControl7);
            this.xtraTabPage2.Controls.Add(this.labelControl6);
            this.xtraTabPage2.Controls.Add(this.dtbitis);
            this.xtraTabPage2.Controls.Add(this.dtbaslangic);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(215, 394);
            this.xtraTabPage2.Text = "Tarih Sorgulama";
            // 
            // BtnFiltrele
            // 
            this.BtnFiltrele.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.BtnFiltrele.Location = new System.Drawing.Point(22, 130);
            this.BtnFiltrele.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFiltrele.Name = "BtnFiltrele";
            this.BtnFiltrele.Size = new System.Drawing.Size(171, 35);
            this.BtnFiltrele.TabIndex = 3;
            this.BtnFiltrele.Text = "Tarihe Göre Ara";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(21, 72);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Bitiş Tarihi :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(22, 22);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 13);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Başlangıç Tarihi :";
            // 
            // dtbitis
            // 
            this.dtbitis.Location = new System.Drawing.Point(21, 94);
            this.dtbitis.Name = "dtbitis";
            this.dtbitis.Size = new System.Drawing.Size(172, 21);
            this.dtbitis.TabIndex = 1;
            // 
            // dtbaslangic
            // 
            this.dtbaslangic.Location = new System.Drawing.Point(21, 40);
            this.dtbaslangic.Name = "dtbaslangic";
            this.dtbaslangic.Size = new System.Drawing.Size(172, 21);
            this.dtbaslangic.TabIndex = 1;
            // 
            // StokListe
            // 
            this.StokListe.ContextMenuStrip = this.SagTik;
            this.StokListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StokListe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.StokListe.Location = new System.Drawing.Point(0, 0);
            this.StokListe.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.StokListe.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Silver;
            this.StokListe.LookAndFeel.SkinName = "Office 2010 Silver";
            this.StokListe.LookAndFeel.UseDefaultLookAndFeel = false;
            this.StokListe.MainView = this.StokListeGrid;
            this.StokListe.Margin = new System.Windows.Forms.Padding(2);
            this.StokListe.Name = "StokListe";
            this.StokListe.Size = new System.Drawing.Size(958, 422);
            this.StokListe.TabIndex = 0;
            this.StokListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StokListeGrid});
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokBilgileriniGösterToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(177, 48);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // stokBilgileriniGösterToolStripMenuItem
            // 
            this.stokBilgileriniGösterToolStripMenuItem.Name = "stokBilgileriniGösterToolStripMenuItem";
            this.stokBilgileriniGösterToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.stokBilgileriniGösterToolStripMenuItem.Text = "Malzeme Kartını Aç";
            this.stokBilgileriniGösterToolStripMenuItem.Click += new System.EventHandler(this.stokBilgileriniGösterToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.yenileToolStripMenuItem.Text = "Yeni Malzeme Kartı";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // StokListeGrid
            // 
            this.StokListeGrid.Appearance.Preview.ForeColor = System.Drawing.Color.White;
            this.StokListeGrid.Appearance.Preview.Options.UseForeColor = true;
            this.StokListeGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.StokListeGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.StokKodu,
            this.StokAdi,
            this.Barkod,
            this.UreticiFirma,
            this.StokKategori,
            this.StokKrtkSev,
            this.StokBirim,
            this.StokSatisFiyat,
            this.StokSatisKDV,
            this.KdvDahil,
            this.StokSaveDate,
            this.IskontoDahil,
            this.IskontoOran,
            this.IndirimliFiyat,
            this.IndirimMiktari,
            this.StokMiktar,
            this.StokPaket});
            this.StokListeGrid.GridControl = this.StokListe;
            this.StokListeGrid.Name = "StokListeGrid";
            this.StokListeGrid.OptionsView.AllowHtmlDrawHeaders = true;
            this.StokListeGrid.OptionsView.EnableAppearanceEvenRow = true;
            this.StokListeGrid.OptionsView.ShowAutoFilterRow = true;
            this.StokListeGrid.OptionsView.ShowGroupPanel = false;
            this.StokListeGrid.PaintStyleName = "Style3D";
            this.StokListeGrid.DoubleClick += new System.EventHandler(this.StokListeGrid_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // StokKodu
            // 
            this.StokKodu.Caption = "Stok Kodu";
            this.StokKodu.FieldName = "StokKodu";
            this.StokKodu.Name = "StokKodu";
            this.StokKodu.OptionsColumn.AllowEdit = false;
            this.StokKodu.OptionsColumn.AllowFocus = false;
            this.StokKodu.OptionsColumn.FixedWidth = true;
            this.StokKodu.Visible = true;
            this.StokKodu.VisibleIndex = 0;
            this.StokKodu.Width = 50;
            // 
            // StokAdi
            // 
            this.StokAdi.Caption = "Stok Adı";
            this.StokAdi.FieldName = "StokAdi";
            this.StokAdi.Name = "StokAdi";
            this.StokAdi.OptionsColumn.AllowEdit = false;
            this.StokAdi.OptionsColumn.AllowFocus = false;
            this.StokAdi.OptionsColumn.FixedWidth = true;
            this.StokAdi.Visible = true;
            this.StokAdi.VisibleIndex = 1;
            this.StokAdi.Width = 100;
            // 
            // Barkod
            // 
            this.Barkod.Caption = "Barkod";
            this.Barkod.FieldName = "Barkod";
            this.Barkod.Name = "Barkod";
            this.Barkod.OptionsColumn.AllowEdit = false;
            this.Barkod.OptionsColumn.AllowFocus = false;
            this.Barkod.OptionsColumn.FixedWidth = true;
            this.Barkod.Visible = true;
            this.Barkod.VisibleIndex = 2;
            this.Barkod.Width = 60;
            // 
            // UreticiFirma
            // 
            this.UreticiFirma.Caption = "Üretici Firma";
            this.UreticiFirma.FieldName = "UreticiFirma";
            this.UreticiFirma.Name = "UreticiFirma";
            this.UreticiFirma.OptionsColumn.FixedWidth = true;
            this.UreticiFirma.Visible = true;
            this.UreticiFirma.VisibleIndex = 3;
            this.UreticiFirma.Width = 55;
            // 
            // StokKategori
            // 
            this.StokKategori.Caption = "Kategori";
            this.StokKategori.FieldName = "StokKategori";
            this.StokKategori.Name = "StokKategori";
            this.StokKategori.OptionsColumn.FixedWidth = true;
            this.StokKategori.Visible = true;
            this.StokKategori.VisibleIndex = 4;
            this.StokKategori.Width = 50;
            // 
            // StokKrtkSev
            // 
            this.StokKrtkSev.Caption = "Stk. Krtk. Sv.";
            this.StokKrtkSev.FieldName = "StokKrtkSev";
            this.StokKrtkSev.Name = "StokKrtkSev";
            this.StokKrtkSev.Visible = true;
            this.StokKrtkSev.VisibleIndex = 5;
            this.StokKrtkSev.Width = 36;
            // 
            // StokBirim
            // 
            this.StokBirim.Caption = "Birim";
            this.StokBirim.FieldName = "StokBirim";
            this.StokBirim.Name = "StokBirim";
            this.StokBirim.Visible = true;
            this.StokBirim.VisibleIndex = 6;
            this.StokBirim.Width = 36;
            // 
            // StokSatisFiyat
            // 
            this.StokSatisFiyat.Caption = "Fiyat";
            this.StokSatisFiyat.DisplayFormat.FormatString = "C";
            this.StokSatisFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.StokSatisFiyat.FieldName = "StokSatisFiyat";
            this.StokSatisFiyat.Name = "StokSatisFiyat";
            this.StokSatisFiyat.Visible = true;
            this.StokSatisFiyat.VisibleIndex = 7;
            this.StokSatisFiyat.Width = 36;
            // 
            // StokSatisKDV
            // 
            this.StokSatisKDV.Caption = "KDV Oranı (%)";
            this.StokSatisKDV.FieldName = "StokSatisKDV";
            this.StokSatisKDV.Name = "StokSatisKDV";
            this.StokSatisKDV.Visible = true;
            this.StokSatisKDV.VisibleIndex = 8;
            this.StokSatisKDV.Width = 36;
            // 
            // KdvDahil
            // 
            this.KdvDahil.Caption = "Kdv Dahil";
            this.KdvDahil.FieldName = "KdvDahil";
            this.KdvDahil.Name = "KdvDahil";
            this.KdvDahil.Visible = true;
            this.KdvDahil.VisibleIndex = 10;
            this.KdvDahil.Width = 29;
            // 
            // StokSaveDate
            // 
            this.StokSaveDate.Caption = "Giris Tarihi";
            this.StokSaveDate.DisplayFormat.FormatString = "d";
            this.StokSaveDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.StokSaveDate.FieldName = "StokSaveDate";
            this.StokSaveDate.Name = "StokSaveDate";
            this.StokSaveDate.OptionsColumn.FixedWidth = true;
            this.StokSaveDate.Visible = true;
            this.StokSaveDate.VisibleIndex = 9;
            this.StokSaveDate.Width = 36;
            // 
            // IskontoDahil
            // 
            this.IskontoDahil.Caption = "İskonto Dahil";
            this.IskontoDahil.FieldName = "IskontoDahil";
            this.IskontoDahil.Name = "IskontoDahil";
            this.IskontoDahil.Visible = true;
            this.IskontoDahil.VisibleIndex = 14;
            this.IskontoDahil.Width = 36;
            // 
            // IskontoOran
            // 
            this.IskontoOran.Caption = "İskonto Oranı(%)";
            this.IskontoOran.FieldName = "IskontoOran";
            this.IskontoOran.Name = "IskontoOran";
            this.IskontoOran.Visible = true;
            this.IskontoOran.VisibleIndex = 11;
            this.IskontoOran.Width = 30;
            // 
            // IndirimliFiyat
            // 
            this.IndirimliFiyat.Caption = "İndirimli Fiyat";
            this.IndirimliFiyat.FieldName = "IndirimliFiyat";
            this.IndirimliFiyat.Name = "IndirimliFiyat";
            this.IndirimliFiyat.Visible = true;
            this.IndirimliFiyat.VisibleIndex = 12;
            this.IndirimliFiyat.Width = 30;
            // 
            // IndirimMiktari
            // 
            this.IndirimMiktari.Caption = "İndirim Miktarı";
            this.IndirimMiktari.FieldName = "IndirimMiktari";
            this.IndirimMiktari.Name = "IndirimMiktari";
            this.IndirimMiktari.Visible = true;
            this.IndirimMiktari.VisibleIndex = 13;
            this.IndirimMiktari.Width = 30;
            // 
            // StokMiktar
            // 
            this.StokMiktar.Caption = "Adet";
            this.StokMiktar.FieldName = "StokMiktar";
            this.StokMiktar.Name = "StokMiktar";
            this.StokMiktar.OptionsColumn.FixedWidth = true;
            this.StokMiktar.Visible = true;
            this.StokMiktar.VisibleIndex = 15;
            this.StokMiktar.Width = 55;
            // 
            // StokPaket
            // 
            this.StokPaket.Caption = "Paket Miktarı";
            this.StokPaket.FieldName = "StokPaket";
            this.StokPaket.Name = "StokPaket";
            this.StokPaket.OptionsColumn.FixedWidth = true;
            this.StokPaket.Visible = true;
            this.StokPaket.VisibleIndex = 16;
            this.StokPaket.Width = 88;
            // 
            // frmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1184, 422);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmStokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.frmStokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStkKrtkSv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUreticiFir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StokListe)).EndInit();
            this.SagTik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StokListeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl StokListe;
        private DevExpress.XtraGrid.Views.Grid.GridView StokListeGrid;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn StokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn StokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Barkod;
        private DevExpress.XtraGrid.Columns.GridColumn UreticiFirma;
        private DevExpress.XtraGrid.Columns.GridColumn StokKategori;
        private DevExpress.XtraGrid.Columns.GridColumn StokKrtkSev;
        private DevExpress.XtraGrid.Columns.GridColumn StokBirim;
        private DevExpress.XtraGrid.Columns.GridColumn StokSatisFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn StokSatisKDV;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.SimpleButton BtnFiltrele;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.DateTimePicker dtbitis;
        private System.Windows.Forms.DateTimePicker dtbaslangic;
        private DevExpress.XtraEditors.TextEdit txtStkKrtkSv;
        private DevExpress.XtraEditors.TextEdit txtUreticiFir;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn StokSaveDate;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem stokBilgileriniGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn KdvDahil;
        private DevExpress.XtraGrid.Columns.GridColumn IskontoOran;
        private DevExpress.XtraGrid.Columns.GridColumn IndirimliFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn IndirimMiktari;
        private System.Windows.Forms.RadioButton RadKdvHaric;
        private System.Windows.Forms.RadioButton RadKdvDahil;
        private System.Windows.Forms.RadioButton RadTumunuListele;
        private System.Windows.Forms.RadioButton RadIskonto;
        private DevExpress.XtraGrid.Columns.GridColumn IskontoDahil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIptal;
        private DevExpress.XtraGrid.Columns.GridColumn StokMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn StokPaket;
    }
}
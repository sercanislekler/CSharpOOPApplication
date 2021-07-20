namespace Otomasyon.Modul_Kasa
{
    partial class frmKasaHareketleri
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaHareketleri));
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtCikis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiris = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvrakID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvrakTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKasaAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.GridControl();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DevirKartiDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TahsilatOdemeDuzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SagTik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Açıklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.OptionsColumn.AllowFocus = false;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 6;
            this.Aciklama.Width = 501;
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(612, 23);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.Mask.EditMask = "n";
            this.txtBakiye.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(105, 20);
            this.txtBakiye.TabIndex = 1;
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(431, 52);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Properties.Mask.EditMask = "n";
            this.txtCikis.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCikis.Properties.ReadOnly = true;
            this.txtCikis.Size = new System.Drawing.Size(107, 20);
            this.txtCikis.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(544, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(57, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Kalan Borç :\r\n";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(431, 26);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Properties.Mask.EditMask = "n";
            this.txtGiris.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGiris.Properties.ReadOnly = true;
            this.txtGiris.Size = new System.Drawing.Size(108, 20);
            this.txtGiris.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(361, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Alınan :";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(94, 53);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(261, 20);
            this.txtKasaKodu.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(361, 29);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Yapılan Öd. :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Kodu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Adı :";
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "Alınan Ödeme";
            this.GIRIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            // 
            // EvrakID
            // 
            this.EvrakID.Caption = "Evrak ID";
            this.EvrakID.FieldName = "EvrakID";
            this.EvrakID.Name = "EvrakID";
            // 
            // EvrakTuru
            // 
            this.EvrakTuru.Caption = "Evrak Türü";
            this.EvrakTuru.FieldName = "EvrakTuru";
            this.EvrakTuru.Name = "EvrakTuru";
            this.EvrakTuru.OptionsColumn.AllowEdit = false;
            this.EvrakTuru.OptionsColumn.AllowFocus = false;
            this.EvrakTuru.OptionsColumn.FixedWidth = true;
            this.EvrakTuru.Visible = true;
            this.EvrakTuru.VisibleIndex = 2;
            this.EvrakTuru.Width = 100;
            // 
            // BelgeNo
            // 
            this.BelgeNo.Caption = "Belge No";
            this.BelgeNo.FieldName = "BelgeNo";
            this.BelgeNo.Name = "BelgeNo";
            this.BelgeNo.OptionsColumn.AllowEdit = false;
            this.BelgeNo.OptionsColumn.AllowFocus = false;
            this.BelgeNo.OptionsColumn.FixedWidth = true;
            this.BelgeNo.Visible = true;
            this.BelgeNo.VisibleIndex = 1;
            this.BelgeNo.Width = 100;
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(94, 27);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(261, 20);
            this.txtKasaAdi.TabIndex = 1;
            this.txtKasaAdi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaAdi_ButtonClick);
            // 
            // gridView2
            // 
            this.gridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.BelgeNo,
            this.EvrakTuru,
            this.EvrakID,
            this.GIRIS,
            this.CIKIS,
            this.Tarih,
            this.Aciklama});
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.gridView2.FormatRules.Add(gridFormatRule1);
            this.gridView2.GridControl = this.gridView1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsFind.FindNullPrompt = "Arama Yapın...";
            this.gridView2.OptionsFind.SearchInPreview = true;
            this.gridView2.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridView2.OptionsPrint.ExpandAllDetails = true;
            this.gridView2.OptionsPrint.PrintDetails = true;
            this.gridView2.OptionsPrint.PrintFilterInfo = true;
            this.gridView2.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView2.OptionsPrint.SplitCellPreviewAcrossPages = true;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Standard;
            this.gridView2.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.PaintStyleName = "Style3D";
            this.gridView2.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "Yapılan Harcama";
            this.CIKIS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.DisplayFormat.FormatString = "d";
            this.Tarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.OptionsFilter.AllowAutoFilter = false;
            this.Tarih.OptionsFilter.AllowFilter = false;
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.ContextMenuStrip = this.SagTik;
            this.gridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView1.EmbeddedNavigator.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton()});
            gridLevelNode1.RelationName = "Level1";
            this.gridView1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridView1.Location = new System.Drawing.Point(2, 20);
            this.gridView1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White;
            this.gridView1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White;
            this.gridView1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.gridView1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.gridView1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridView1.MainView = this.gridView2;
            this.gridView1.Name = "gridView1";
            this.gridView1.Size = new System.Drawing.Size(1026, 388);
            this.gridView1.TabIndex = 0;
            this.gridView1.UseEmbeddedNavigator = true;
            this.gridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DevirKartiDuzenle,
            this.TahsilatOdemeDuzenle});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(247, 48);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // DevirKartiDuzenle
            // 
            this.DevirKartiDuzenle.Name = "DevirKartiDuzenle";
            this.DevirKartiDuzenle.Size = new System.Drawing.Size(246, 22);
            this.DevirKartiDuzenle.Text = "Devir Kartı İşlemini Düzenle";
            this.DevirKartiDuzenle.Click += new System.EventHandler(this.DevirKartiDuzenle_Click);
            // 
            // TahsilatOdemeDuzenle
            // 
            this.TahsilatOdemeDuzenle.Name = "TahsilatOdemeDuzenle";
            this.TahsilatOdemeDuzenle.Size = new System.Drawing.Size(246, 22);
            this.TahsilatOdemeDuzenle.Text = "Tahsilat/Ödeme İşlemini Düzenle";
            this.TahsilatOdemeDuzenle.Click += new System.EventHandler(this.TahsilatOdemeDuzenle_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridView1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 83);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1030, 410);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txtCikis);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtGiris);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1030, 83);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa Bilgileri";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Location = new System.Drawing.Point(816, 40);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(90, 38);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Yazdır";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Image = global::Otomasyon.Properties.Resources.Excel32x32;
            this.simpleButton2.Location = new System.Drawing.Point(912, 40);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(113, 38);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Excel\'e Aktar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.simpleButton1.Location = new System.Drawing.Point(723, 40);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 38);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Önizleme";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel Çalışma Kitabı | *.xlsx";
            // 
            // frmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1030, 493);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmKasaHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCikis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiris.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.SagTik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtCikis;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtGiris;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn EvrakID;
        private DevExpress.XtraGrid.Columns.GridColumn BelgeNo;
        private DevExpress.XtraEditors.ButtonEdit txtKasaAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem DevirKartiDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TahsilatOdemeDuzenle;
        public DevExpress.XtraGrid.Columns.GridColumn EvrakTuru;
        public DevExpress.XtraGrid.GridControl gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
namespace Otomasyon.Modul_Kasa
{
    partial class frmKasaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaListesi));
            this.KasaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.StokListeGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KasaListe = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokListeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KasaKodu
            // 
            this.KasaKodu.Caption = "Kasa Kodu";
            this.KasaKodu.FieldName = "KasaKodu";
            this.KasaKodu.Name = "KasaKodu";
            this.KasaKodu.OptionsColumn.AllowEdit = false;
            this.KasaKodu.OptionsColumn.AllowFocus = false;
            this.KasaKodu.OptionsColumn.FixedWidth = true;
            this.KasaKodu.Visible = true;
            this.KasaKodu.VisibleIndex = 0;
            this.KasaKodu.Width = 85;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(13, 102);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(58, 35);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(120, 102);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(58, 35);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Temizle";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(13, 78);
            this.txtKasaAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(165, 20);
            this.txtKasaAdi.TabIndex = 1;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(13, 37);
            this.txtKasaKodu.Margin = new System.Windows.Forms.Padding(2);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Size = new System.Drawing.Size(165, 20);
            this.txtKasaKodu.TabIndex = 1;
            // 
            // StokListeGrid
            // 
            this.StokListeGrid.Appearance.GroupPanel.Font = new System.Drawing.Font("Lucida Sans Unicode", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokListeGrid.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.StokListeGrid.Appearance.GroupPanel.Options.UseFont = true;
            this.StokListeGrid.Appearance.GroupPanel.Options.UseForeColor = true;
            this.StokListeGrid.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.StokListeGrid.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.StokListeGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.StokListeGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.KasaKodu,
            this.KasaAdi,
            this.GIRIS,
            this.CIKIS,
            this.BAKIYE,
            this.Aciklama,
            this.gridColumn1});
            this.StokListeGrid.GridControl = this.KasaListe;
            this.StokListeGrid.GroupPanelText = "Kasa Listesi";
            this.StokListeGrid.Name = "StokListeGrid";
            this.StokListeGrid.OptionsPrint.EnableAppearanceEvenRow = true;
            this.StokListeGrid.OptionsPrint.EnableAppearanceOddRow = true;
            this.StokListeGrid.OptionsPrint.ExpandAllDetails = true;
            this.StokListeGrid.OptionsPrint.PrintDetails = true;
            this.StokListeGrid.OptionsPrint.PrintFilterInfo = true;
            this.StokListeGrid.OptionsPrint.PrintSelectedRowsOnly = true;
            this.StokListeGrid.OptionsView.EnableAppearanceEvenRow = true;
            this.StokListeGrid.OptionsView.ShowAutoFilterRow = true;
            this.StokListeGrid.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.StokListeGrid.PaintStyleName = "Style3D";
            this.StokListeGrid.DoubleClick += new System.EventHandler(this.StokListeGrid_DoubleClick);
            // 
            // KasaAdi
            // 
            this.KasaAdi.Caption = "Kasa Adı";
            this.KasaAdi.FieldName = "KasaAdi";
            this.KasaAdi.Name = "KasaAdi";
            this.KasaAdi.OptionsColumn.AllowEdit = false;
            this.KasaAdi.OptionsColumn.AllowFocus = false;
            this.KasaAdi.OptionsColumn.FixedWidth = true;
            this.KasaAdi.Visible = true;
            this.KasaAdi.VisibleIndex = 1;
            this.KasaAdi.Width = 150;
            // 
            // GIRIS
            // 
            this.GIRIS.Caption = "Giriş";
            this.GIRIS.FieldName = "GIRIS";
            this.GIRIS.Name = "GIRIS";
            this.GIRIS.OptionsColumn.AllowEdit = false;
            this.GIRIS.OptionsColumn.AllowFocus = false;
            this.GIRIS.OptionsColumn.FixedWidth = true;
            this.GIRIS.Visible = true;
            this.GIRIS.VisibleIndex = 3;
            this.GIRIS.Width = 110;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "Çıkış";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            this.CIKIS.Width = 110;
            // 
            // BAKIYE
            // 
            this.BAKIYE.Caption = "Bakiye";
            this.BAKIYE.FieldName = "BAKIYE";
            this.BAKIYE.Name = "BAKIYE";
            this.BAKIYE.OptionsColumn.AllowEdit = false;
            this.BAKIYE.OptionsColumn.AllowFocus = false;
            this.BAKIYE.OptionsColumn.FixedWidth = true;
            this.BAKIYE.Visible = true;
            this.BAKIYE.VisibleIndex = 5;
            this.BAKIYE.Width = 113;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Açıklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.OptionsColumn.AllowEdit = false;
            this.Aciklama.OptionsColumn.AllowFocus = false;
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 2;
            this.Aciklama.Width = 110;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "İşlem ";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // KasaListe
            // 
            this.KasaListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KasaListe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.KasaListe.Location = new System.Drawing.Point(0, 0);
            this.KasaListe.LookAndFeel.SkinName = "Office 2010 Silver";
            this.KasaListe.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.KasaListe.MainView = this.StokListeGrid;
            this.KasaListe.Margin = new System.Windows.Forms.Padding(2);
            this.KasaListe.Name = "KasaListe";
            this.KasaListe.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.KasaListe.Size = new System.Drawing.Size(696, 421);
            this.KasaListe.TabIndex = 0;
            this.KasaListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StokListeGrid});
            this.KasaListe.DoubleClick += new System.EventHandler(this.KasaListe_DoubleClick);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kasa Adı :";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.simpleButton2);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.txtKasaAdi);
            this.xtraTabPage1.Controls.Add(this.txtKasaKodu);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(215, 393);
            this.xtraTabPage1.Text = "Arama";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Otomasyon.Properties.Resources.Excel32x32;
            this.simpleButton2.Location = new System.Drawing.Point(13, 155);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(165, 38);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Excel\'e Aktar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(221, 421);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.KasaListe);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(922, 421);
            this.splitContainerControl1.SplitterPosition = 221;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // frmKasaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 421);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Listesi";
            this.Load += new System.EventHandler(this.frmKasaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokListeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn KasaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraGrid.Views.Grid.GridView StokListeGrid;
        private DevExpress.XtraGrid.Columns.GridColumn KasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn BAKIYE;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        public DevExpress.XtraGrid.GridControl KasaListe;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
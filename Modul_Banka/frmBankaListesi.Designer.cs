namespace Otomasyon.Modul_Banka
{
    partial class frmBankaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBankaListesi));
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtIBAN = new DevExpress.XtraEditors.TextEdit();
            this.txtHesapAdi = new DevExpress.XtraEditors.TextEdit();
            this.SagTik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bankaBilgileriniDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HesapNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HesapAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvrakID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Giris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).BeginInit();
            this.SagTik.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(13, 142);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(81, 45);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Otomasyon.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(111, 142);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 45);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Temizle";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Location = new System.Drawing.Point(13, 119);
            this.txtIBAN.Margin = new System.Windows.Forms.Padding(2);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(186, 20);
            this.txtIBAN.TabIndex = 1;
            // 
            // txtHesapAdi
            // 
            this.txtHesapAdi.Location = new System.Drawing.Point(13, 37);
            this.txtHesapAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtHesapAdi.Name = "txtHesapAdi";
            this.txtHesapAdi.Size = new System.Drawing.Size(186, 20);
            this.txtHesapAdi.TabIndex = 1;
            // 
            // SagTik
            // 
            this.SagTik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankaBilgileriniDüzenleToolStripMenuItem});
            this.SagTik.Name = "SagTik";
            this.SagTik.Size = new System.Drawing.Size(204, 26);
            this.SagTik.Opening += new System.ComponentModel.CancelEventHandler(this.SagTik_Opening);
            // 
            // bankaBilgileriniDüzenleToolStripMenuItem
            // 
            this.bankaBilgileriniDüzenleToolStripMenuItem.Name = "bankaBilgileriniDüzenleToolStripMenuItem";
            this.bankaBilgileriniDüzenleToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.bankaBilgileriniDüzenleToolStripMenuItem.Text = "Banka Bilgilerini Düzenle";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 101);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "IBAN :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(53, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Hesap No :";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.txtIBAN);
            this.xtraTabPage1.Controls.Add(this.txtHesapNo);
            this.xtraTabPage1.Controls.Add(this.txtHesapAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(215, 399);
            this.xtraTabPage1.Text = "Arama";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(13, 78);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(186, 20);
            this.txtHesapNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hesap Adı/Türü :";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(221, 427);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(869, 427);
            this.splitContainerControl1.SplitterPosition = 221;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // Liste
            // 
            this.Liste.ContextMenuStrip = this.SagTik;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(643, 427);
            this.Liste.TabIndex = 1;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.BankaAdi,
            this.HesapNo,
            this.IBAN,
            this.HesapAdi,
            this.EvrakID,
            this.Giris,
            this.Cikis,
            this.Bakiye});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // HesapNo
            // 
            this.HesapNo.Caption = "Hesap Nu.";
            this.HesapNo.FieldName = "HesapNo";
            this.HesapNo.Name = "HesapNo";
            this.HesapNo.Visible = true;
            this.HesapNo.VisibleIndex = 1;
            this.HesapNo.Width = 120;
            // 
            // IBAN
            // 
            this.IBAN.Caption = "IBAN";
            this.IBAN.FieldName = "IBAN";
            this.IBAN.Name = "IBAN";
            this.IBAN.OptionsColumn.AllowEdit = false;
            this.IBAN.OptionsColumn.AllowFocus = false;
            this.IBAN.OptionsColumn.FixedWidth = true;
            this.IBAN.Visible = true;
            this.IBAN.VisibleIndex = 2;
            this.IBAN.Width = 100;
            // 
            // BankaAdi
            // 
            this.BankaAdi.Caption = "Banka Adı";
            this.BankaAdi.FieldName = "BankaAdi";
            this.BankaAdi.Name = "BankaAdi";
            this.BankaAdi.OptionsColumn.AllowEdit = false;
            this.BankaAdi.OptionsColumn.AllowFocus = false;
            this.BankaAdi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.BankaAdi.OptionsColumn.FixedWidth = true;
            this.BankaAdi.Visible = true;
            this.BankaAdi.VisibleIndex = 0;
            // 
            // HesapAdi
            // 
            this.HesapAdi.Caption = "Hesap Adı";
            this.HesapAdi.FieldName = "HesapAdi";
            this.HesapAdi.Name = "HesapAdi";
            this.HesapAdi.OptionsColumn.AllowEdit = false;
            this.HesapAdi.OptionsColumn.AllowFocus = false;
            this.HesapAdi.OptionsColumn.FixedWidth = true;
            this.HesapAdi.Visible = true;
            this.HesapAdi.VisibleIndex = 3;
            this.HesapAdi.Width = 100;
            // 
            // EvrakID
            // 
            this.EvrakID.Caption = "Evrak ID";
            this.EvrakID.FieldName = "EvrakID";
            this.EvrakID.Name = "EvrakID";
            // 
            // Giris
            // 
            this.Giris.Caption = "Giriş";
            this.Giris.FieldName = "Giris";
            this.Giris.Name = "Giris";
            this.Giris.OptionsColumn.AllowEdit = false;
            this.Giris.OptionsColumn.AllowFocus = false;
            this.Giris.OptionsColumn.FixedWidth = true;
            this.Giris.Visible = true;
            this.Giris.VisibleIndex = 4;
            // 
            // Cikis
            // 
            this.Cikis.Caption = "Çıkış";
            this.Cikis.FieldName = "Cikis";
            this.Cikis.Name = "Cikis";
            this.Cikis.OptionsColumn.AllowEdit = false;
            this.Cikis.OptionsColumn.AllowFocus = false;
            this.Cikis.OptionsColumn.FixedWidth = true;
            this.Cikis.Visible = true;
            this.Cikis.VisibleIndex = 5;
            // 
            // Bakiye
            // 
            this.Bakiye.Caption = "Bakiye";
            this.Bakiye.FieldName = "Bakiye";
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.OptionsColumn.AllowEdit = false;
            this.Bakiye.OptionsColumn.AllowFocus = false;
            this.Bakiye.Visible = true;
            this.Bakiye.VisibleIndex = 6;
            this.Bakiye.Width = 80;
            // 
            // frmBankaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 427);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBankaListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Listesi";
            this.Load += new System.EventHandler(this.frmBankaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIBAN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdi.Properties)).EndInit();
            this.SagTik.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtIBAN;
        private DevExpress.XtraEditors.TextEdit txtHesapAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.ContextMenuStrip SagTik;
        private System.Windows.Forms.ToolStripMenuItem bankaBilgileriniDüzenleToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn HesapNo;
        private DevExpress.XtraGrid.Columns.GridColumn IBAN;
        private DevExpress.XtraGrid.Columns.GridColumn BankaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn HesapAdi;
        private DevExpress.XtraGrid.Columns.GridColumn EvrakID;
        private DevExpress.XtraGrid.Columns.GridColumn Giris;
        private DevExpress.XtraGrid.Columns.GridColumn Cikis;
        private DevExpress.XtraGrid.Columns.GridColumn Bakiye;
    }
}
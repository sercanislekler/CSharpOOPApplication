namespace Otomasyon.Modul_Fatura
{
    partial class frmFaturaListesi
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
            this.CariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.StokListeGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CariListe = new DevExpress.XtraGrid.GridControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txtCariKodu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCariGrup = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokListeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CariListe)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CariKodu
            // 
            this.CariKodu.Caption = "Cari Kodu";
            this.CariKodu.FieldName = "CariKodu";
            this.CariKodu.Name = "CariKodu";
            this.CariKodu.OptionsColumn.AllowEdit = false;
            this.CariKodu.OptionsColumn.AllowFocus = false;
            this.CariKodu.OptionsColumn.FixedWidth = true;
            this.CariKodu.Visible = true;
            this.CariKodu.VisibleIndex = 0;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // btnAra
            // 
            this.btnAra.Image = global::Otomasyon.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 142);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(74, 46);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // btnSil
            // 
            this.btnSil.Image = global::Otomasyon.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(94, 142);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 46);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Temizle";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(13, 78);
            this.txtCariAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(169, 20);
            this.txtCariAdi.TabIndex = 1;
            // 
            // StokListeGrid
            // 
            this.StokListeGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.CariKodu,
            this.CariAdi});
            this.StokListeGrid.GridControl = this.CariListe;
            this.StokListeGrid.Name = "StokListeGrid";
            this.StokListeGrid.OptionsView.ShowGroupPanel = false;
            // 
            // CariAdi
            // 
            this.CariAdi.Caption = "Cari Adı";
            this.CariAdi.FieldName = "CariAdi";
            this.CariAdi.Name = "CariAdi";
            this.CariAdi.OptionsColumn.AllowEdit = false;
            this.CariAdi.OptionsColumn.AllowFocus = false;
            this.CariAdi.OptionsColumn.FixedWidth = true;
            this.CariAdi.Visible = true;
            this.CariAdi.VisibleIndex = 1;
            // 
            // CariListe
            // 
            this.CariListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CariListe.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.CariListe.Location = new System.Drawing.Point(0, 0);
            this.CariListe.MainView = this.StokListeGrid;
            this.CariListe.Margin = new System.Windows.Forms.Padding(2);
            this.CariListe.Name = "CariListe";
            this.CariListe.Size = new System.Drawing.Size(692, 437);
            this.CariListe.TabIndex = 0;
            this.CariListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StokListeGrid});
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 101);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Tarih :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Fatura No :";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.btnSil);
            this.xtraTabPage1.Controls.Add(this.txtCariAdi);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtCariKodu);
            this.xtraTabPage1.Controls.Add(this.txtCariGrup);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(215, 409);
            this.xtraTabPage1.Text = "Arama";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 20);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Fatura Türü :";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(221, 437);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.CariListe);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(918, 437);
            this.splitContainerControl1.SplitterPosition = 221;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.EditValue = "Satış Faturası";
            this.txtCariKodu.Location = new System.Drawing.Point(13, 37);
            this.txtCariKodu.Margin = new System.Windows.Forms.Padding(2);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCariKodu.Properties.Items.AddRange(new object[] {
            "Satış Faturası",
            "Satış İade Faturası ",
            "Alış Faturası",
            "Alış İade Faturası"});
            this.txtCariKodu.Size = new System.Drawing.Size(169, 20);
            this.txtCariKodu.TabIndex = 1;
            // 
            // txtCariGrup
            // 
            this.txtCariGrup.EditValue = null;
            this.txtCariGrup.Location = new System.Drawing.Point(13, 118);
            this.txtCariGrup.Margin = new System.Windows.Forms.Padding(2);
            this.txtCariGrup.Name = "txtCariGrup";
            this.txtCariGrup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCariGrup.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCariGrup.Properties.DisplayFormat.FormatString = "";
            this.txtCariGrup.Properties.EditFormat.FormatString = "";
            this.txtCariGrup.Properties.Mask.EditMask = "";
            this.txtCariGrup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtCariGrup.Size = new System.Drawing.Size(169, 20);
            this.txtCariGrup.TabIndex = 1;
            // 
            // frmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 437);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmFaturaListesi";
            this.Text = "frmFaturaListesi";
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StokListeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CariListe)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn CariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraGrid.Views.Grid.GridView StokListeGrid;
        private DevExpress.XtraGrid.Columns.GridColumn CariAdi;
        private DevExpress.XtraGrid.GridControl CariListe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtCariKodu;
        private DevExpress.XtraEditors.DateEdit txtCariGrup;
    }
}
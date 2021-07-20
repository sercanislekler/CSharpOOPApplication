using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar form = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesaj = new Fonksiyonlar.Mesajlar();
        SaveFileDialog dialog = new SaveFileDialog();
        int StokID = -1;
        int SecimID = -1;
        public bool Secim = false;

        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {

        }
        void Listele()
        {
            var lst = from s in DB.Tbl_Stoklar
                      where s.StokAdi.Contains(txtStokKodu.Text) || s.StokKodu.Contains(txtStokAdi.Text) || s.Barkod.Contains(txtBarkod.Text) || s.UreticiFirma.Contains(txtUreticiFir.Text)
                      select s;
            StokListe.DataSource = lst;
        }
        void listele1()
        {
            if (RadKdvDahil.Checked)
            {
                var lst = from s in DB.Tbl_Stoklar where s.KdvDahil.Contains("E") select s;
                StokListe.DataSource = lst;
            }
            else if (RadKdvHaric.Checked)
            {
                var lst = from s in DB.Tbl_Stoklar where s.KdvDahil.Contains("H") select s;
                StokListe.DataSource = lst;
            }
            else if (RadTumunuListele.Checked)
            {
                var lst = from s in DB.Tbl_Stoklar select s;
                StokListe.DataSource = lst;
            }

            else if (RadIskonto.Checked)
            {
                var lst = from s in DB.Tbl_Stoklar where s.IskontoDahil.Contains("E") select s;
                StokListe.DataSource = lst;
            }
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            listele1();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtStokKodu.Text = "";
            txtStokAdi.Text = "";
            txtBarkod.Text = "";
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(StokListeGrid.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {

                SecimID = -1;
            }

        }
        private void StokListeGrid_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
        public void sec2()
        {
            try
            {
                StokID = int.Parse(StokListeGrid.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                StokID = -1;
            }

        }
        public void Ac(int ID)
        {
            StokID = ID;
            frmStokKarti frm = new frmStokKarti();
            frm.Ac(ID);
            frm.Show();
            listele1();
        }
        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            sec2();
        }

        private void stokBilgileriniGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sec2();
            Ac(StokID);
            if (Secim && StokID > 0)
            {
                AnaForm.Aktarma = StokID;
                this.Close();
                listele1();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = StokListe.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null)
            {
                dialog.Filter = "Excel Çalışma Kitabı(*.xls)|*.xls|Excel 2010(XLSX)|*.xlsx";
                dialog.FileName = string.Empty;
                DialogResult soru = dialog.ShowDialog();
                if (soru == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        var DosyaAdi = dialog.FileName;
                        if (dialog.FilterIndex == 1)
                        {
                            view.ExportToXls(DosyaAdi);
                        }
                        else if (dialog.FilterIndex == 2)
                        {
                            view.ExportToXlsx(DosyaAdi);
                        }
                    }
                    catch (Exception hata)
                    {

                        mesaj.Hata(hata);
                    }

                }
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = StokListe;
            link.Landscape = true;
            link.ShowPreview();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modul_Stok.frmStokKarti stok = new frmStokKarti();
            stok.ShowDialog();
        }
    }
}
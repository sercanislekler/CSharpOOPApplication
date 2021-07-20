using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;

namespace Otomasyon.Modul_Kasa
{

    public partial class frmKasaHareketleri : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        int HareketID = -1;
        int EvrakiD = -1;
        int KasaID = -1;
        SaveFileDialog dialog = new SaveFileDialog();
        string EvrakTURU1;
        StringFormat strFormat;
        ArrayList arrColumnLefts = new ArrayList();
        ArrayList arrColumnWidths = new ArrayList();
        int iCellHeight = 0;
        int iTotalWidth = 0;
        int iCount = 0;
        int iRow = 0;
        bool bFirstPage = false;
        bool bNewPage = false;
        int iHeaderHeight = 0; 
        public frmKasaHareketleri()
        {
            InitializeComponent();
        }
      
        
        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }
        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaKodu.Text = DB.Tbl_Kasalar.First(s=> s.Id == KasaID).KasaKodu;
                txtKasaAdi.Text = DB.Tbl_Kasalar.First(s => s.Id == KasaID).KasaAdi;
                DurumGetir();
                Listele();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        
        }

        void DurumGetir()
        {
            Fonksiyonlar.VW_KASADURUM kasa = DB.VW_KASADURUM.First(s => s.KasaId == KasaID);
            txtGiris.Text = kasa.GIRIS.Value.ToString();
            txtCikis.Text = kasa.CIKIS.Value.ToString();
            txtBakiye.Text = kasa.Bakiye.Value.ToString();

        }
        void Listele()
        {
            var lst = from s in DB.VW_KASAHAREKETLERI where s.KasaId == KasaID 
                      select s;
            gridView1.DataSource = lst;  
        }

        private void txtKasaAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.KasaListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }
        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView2.GetFocusedRowCellValue("Id").ToString());
                try
                {
                    EvrakiD = int.Parse(gridView2.GetFocusedRowCellValue("EvrakId").ToString());
                }
                catch (Exception)
                {
                    EvrakiD = -1;
                }
                EvrakTURU1 = gridView2.GetFocusedRowCellValue(EvrakTuru).ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                EvrakiD = -1;
                EvrakTURU1 = "";
            }
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (EvrakTURU1 == "Kasa Devir Kartı")
            {
                DevirKartiDuzenle.Enabled = true;
                TahsilatOdemeDuzenle.Enabled = false;
            }
            else if (EvrakTURU1 == "Kasa Ödeme" || EvrakTURU1 == "Kasa Tahsilat")
            {
                DevirKartiDuzenle.Enabled = false;
                TahsilatOdemeDuzenle.Enabled = true;
            }
           
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }

        private void DevirKartiDuzenle_Click(object sender, EventArgs e)
        {
            formlar.Ac(true,HareketID);
            Listele();
        }

        private void TahsilatOdemeDuzenle_Click(object sender, EventArgs e)
        {
            formlar.KasaTahsilatOdemeKarti(true,HareketID);
            Listele();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = gridView1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
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

                        mesajlar.Hata(hata);
                    }
                }
            }
            
            
            
            
            
            
            
            
            /*if (dialog.ShowDialog() == DialogResult.OK)
            {
                gridView2.ExportToXlsx(dialog.FileName + ".xlsx");
                gridView2.ExportToXls(dialog.FileName + ".xls");
            }*/
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridView1;
            link.Landscape = true;
            link.ShowPreview();
        }
    }
}

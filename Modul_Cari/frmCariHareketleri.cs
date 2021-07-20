using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariHareketleri : Form
    {
        public bool secim = false;
        Fonksiyonlar.Formlar frm = new Fonksiyonlar.Formlar();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesaj = new Fonksiyonlar.Mesajlar();
        SaveFileDialog dialog = new SaveFileDialog();
        int SecimID = -1;
        int CariID = -1;
        public frmCariHareketleri()
        {
            InitializeComponent();
        }
        public void sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }
        public void listele()
        {
            var lst = from s in DB.VW_Cari where s.CariID == CariID select s;
            gridControl1.DataSource = lst;
        }
        void DurumGetir()
        {
            try
            {
                Fonksiyonlar.VW_Cari cari = DB.VW_Cari.First(s => s.CariID == CariID);
                txtGiris.Text = cari.Alacak.ToString();
                txtCikis.Text = cari.Borc.ToString();
                txtCariAdi.Text = cari.CariAdi.ToString();
                txtCariKodu.Text = cari.CariKodu.ToString();
                listele();
            }
            catch (Exception e)
            {
                mesaj.Hata(e);
            }
        }
        public void Ac(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = DB.VW_Cari.First(s => s.CariID == ID).CariKodu;
                txtCariAdi.Text = DB.VW_Cari.First(s => s.CariID == ID).CariAdi;
                DurumGetir();
            }
            catch (Exception e)
            {

                mesaj.Hata(e);
            }

        }
        private void frmCariHareketleri_Load(object sender, EventArgs e)
        {

        }
        private void txtHesapTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = frm.CariListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Ac(SecimID);
                sec();
                DurumGetir();
                listele();
            }
            catch (Exception hata)
            {
                mesaj.Hata(hata);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = gridControl1.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
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
    }
}

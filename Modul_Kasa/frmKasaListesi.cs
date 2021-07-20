using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Modul_Kasa
{
    public partial class frmKasaListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesaj = new Fonksiyonlar.Mesajlar();
        SaveFileDialog dialog = new SaveFileDialog();


        public bool secim = false;
        int secimID = -1;
        public frmKasaListesi()
        {
            InitializeComponent();
        }

        private void frmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.VW_KASALISTESI
                      where s.KasaKodu.Contains(txtKasaAdi.Text) && s.KasaKodu.Contains(txtKasaKodu.Text)
                      select s;

            KasaListe.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                secim = true;
                secimID = int.Parse(StokListeGrid.GetFocusedRowCellValue("Id").ToString());
                txtKasaAdi.Text = StokListeGrid.GetFocusedRowCellValue("KasaAdi").ToString();
                txtKasaKodu.Text = StokListeGrid.GetFocusedRowCellValue("KasaKodu").ToString();
            }
            catch (Exception e)
            {
                mesaj.Hata(e);
            }
        }

        private void StokListeGrid_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && secimID > 0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }

        private void KasaListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && secimID > 0)
            {
                AnaForm.Aktarma = secimID;
                this.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = KasaListe.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
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
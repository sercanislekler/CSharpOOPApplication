using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Modul_Cari
{
    public partial class frmCariListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesaj = new Fonksiyonlar.Mesajlar();
        public bool Secim = false;
        int SecimID = -1;
        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            try
            {
                var lst = from s in DB.Tbl_Cariler
                          where s.CariAdi.Contains(txtCariAdi.Text) && s.CariKodu.Contains(txtCariKodu.Text)
                          select s;
                CariListe.DataSource = lst;
            }
            catch (Exception hata) 
            {

                mesaj.Hata(hata);
            }
            
        }
        void sec()
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

        private void CariListe_DoubleClick(object sender, EventArgs e)
        {
            sec();
            if ( Secim && SecimID >0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCariGrup.Text = "";
        }
    }
}

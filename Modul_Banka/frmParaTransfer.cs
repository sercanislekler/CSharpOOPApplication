using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Modul_Banka
{
    public partial class frmParaTransfer : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar form = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesaj = new Fonksiyonlar.Mesajlar();
        int SecimID = -1;
        int BankaID = -1;
        string IslemTuru;
        public frmParaTransfer()
        {
            InitializeComponent();
        }

        private void txttransferturu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txttransferturu.SelectedIndex == 0)
            {
                rbtngelen.Text = "Gelen Havale";
                rbtnGiden.Text = "Giden Havale";
                IslemTuru = "Banka Havale";
            }
            else if (txttransferturu.SelectedIndex == 1)
            {
                rbtngelen.Text = "Gelen EFT";
                rbtnGiden.Text = "Giden EFT";
                IslemTuru = "Banka EFT";
            }
            
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
        public void CariAc(int ID) 
        {
            try
            {
                SecimID = ID;
                txtCariKodu.Text = DB.Tbl_Cariler.First(s => s.Id == SecimID).CariKodu;
                txtCariAdı.Text = DB.Tbl_Cariler.First(s => s.Id == SecimID).CariAdi;
            }
            catch (Exception)
            {

                SecimID = -1;
            }
        }
        public void HesapAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = DB.Tbl_Bankalar.First(s => s.Id == BankaID).HesapAdi;
                txtHesapNo.Text = DB.Tbl_Bankalar.First(s => s.Id == BankaID).HesapNo;
            }
            catch (Exception)
            {
                BankaID = -1;
                
            }
        }
        private void textEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = form.BankaListesi(true);
            if (ID>0)
            {
                HesapAc(ID); AnaForm.Aktarma = -1;
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = form.CariListesi(true);
            if (ID > 0)
            {
                CariAc(ID); AnaForm.Aktarma = -1;
            }
        }
    }
}

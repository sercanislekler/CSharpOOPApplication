using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        public bool Secim = false;
        int SecimID = -1;
        bool Edit = false;
        
        public frmStokGruplari()
        {
            InitializeComponent();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }
        void Listele()
        {
            var LST = from s in DB.Tbl_StokGruplarii
                      select s;
            Liste.DataSource = LST;
        }

        void Temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_StokGruplarii grup = new Fonksiyonlar.Tbl_StokGruplarii();
                grup.GrupAdi = txtGrupAdi.Text;
                grup.GrupKodu = txtGrupKodu.Text;
                grup.GrupSaveDate = DateTime.Now;
                grup.GrupSaveUser = AnaForm.userID;
                DB.Tbl_StokGruplarii.InsertOnSubmit(grup);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni grup kaydı oluşturuldu.");
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            } 
        
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.Tbl_StokGruplarii grup = DB.Tbl_StokGruplarii.First(s => s.Id == SecimID);
                grup.GrupKodu = txtGrupKodu.Text;
                grup.GrupAdi = txtGrupAdi.Text;
                grup.GrupEditUser = AnaForm.userID;
                grup.GrupEditDate = DateTime.Now;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
           
        
        }

        void sil()
        {
            try
            {
                DB.Tbl_StokGruplarii.DeleteOnSubmit(DB.Tbl_StokGruplarii.First(s => s.Id == SecimID));
                DB.SubmitChanges();
                Listele();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Sil(true) == DialogResult.Yes) sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GrupAdi").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GrupKodu").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
           

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }

        private void Liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}

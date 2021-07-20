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
    public partial class frmCariGruplari : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();

        public bool secim = false;
        bool Edit = false;
        int SecimID = -1;

        public frmCariGruplari()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            SecimID = -1;
        }
        void Listele()
        {
            var LST = from s in DB.Tbl_CariGruplari select s;
            Liste.DataSource = LST;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_CariGruplari grup = new Fonksiyonlar.Tbl_CariGruplari();
                grup.GrupAdi = txtGrupAdi.Text;
                grup.GrupKodu = txtGrupKodu.Text;
                grup.SaveDate = DateTime.Now;
                grup.SaveUser = AnaForm.userID;
                DB.Tbl_CariGruplari.InsertOnSubmit(grup);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni cari grup kaydı oluşturuldu.");
                temizle();
                
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
                Fonksiyonlar.Tbl_CariGruplari grup = DB.Tbl_CariGruplari.First(s => s.Id == SecimID);
                grup.GrupAdi = txtGrupAdi.Text;
                grup.GrupKodu = txtGrupKodu.Text;
                grup.SaveDate = DateTime.Now;
                grup.SaveUser = AnaForm.userID;
                DB.Tbl_CariGruplari.InsertOnSubmit(grup);
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
           
        }
        void Silme()
        {
            try
            {
                DB.Tbl_CariGruplari.DeleteOnSubmit(DB.Tbl_CariGruplari.First(s => s.Id == SecimID));
                DB.SubmitChanges();
                temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }
        void Sec()  
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GrupKodu").ToString();
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GrupAdi").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        
        }
        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Sil(true) == DialogResult.Yes) Silme();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet(); 
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmKasaAcilisKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar numaralar = new Fonksiyonlar.Numaralar();

        bool Edit = false;
        int SecimID = -1;
        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Text = numaralar.KasaGrupNumarasi();
            Listele();
        }

        void Temizle()
        {
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtAciklama.Text = "";
            Listele();
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_Kasalar kasa = new Fonksiyonlar.Tbl_Kasalar();
                kasa.Aciklama = txtAciklama.Text;
                kasa.KasaAdi = txtKasaAdi.Text;
                kasa.KasaKodu = txtKasaKodu.Text;
                kasa.SaveDate = DateTime.Now;
                kasa.SaveUser = AnaForm.userID;
                DB.Tbl_Kasalar.InsertOnSubmit(kasa);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni kasa kaydı oluşturulmuştur.");
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
                Fonksiyonlar.Tbl_Kasalar kasa = DB.Tbl_Kasalar.First(s => s.Id == SecimID);
                kasa.Aciklama = txtAciklama.Text;
                kasa.KasaAdi = txtKasaAdi.Text;
                kasa.KasaKodu = txtKasaKodu.Text;
                kasa.EditDate = DateTime.Now;
                kasa.EditUser = AnaForm.userID;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        void Sil()
        {
            try
            {
                DB.Tbl_Kasalar.DeleteOnSubmit(DB.Tbl_Kasalar.First(s => s.Id == SecimID));
                DB.SubmitChanges();
                Temizle();
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
              SecimID=int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
              txtAciklama.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
              txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KasaKodu").ToString();
              txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KasaAdi").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }

        void Listele()
        {
            var LST = from s in DB.Tbl_Kasalar
                      select s;
            gridControl1.DataSource = LST;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Sil(true) == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();   
        }
    }
}

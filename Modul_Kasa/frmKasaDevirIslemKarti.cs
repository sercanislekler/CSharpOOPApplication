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
    public partial class frmKasaDevirIslemKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar numaralar = new Fonksiyonlar.Numaralar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int KasaID = -1;
        int IslemID = -1;
        public frmKasaDevirIslemKarti()
        {
            InitializeComponent();
        }

        private void frmKasaDevirIslemKarti_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        void Temizle()
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtBelgeMakbuz.Text = "";
            txtKasaKodu.Text = "";
            txtKasaAdi.Text = "";
            txtTutar.Text = "0";
            txtAciklama.Text = "";
            Edit = false;
            KasaID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri Hareket = new Fonksiyonlar.Tbl_KasaHareketleri();
                Hareket.Aciklama = txtAciklama.Text;
                Hareket.BelgeNo = txtBelgeMakbuz.Text;
                Hareket.EvrakTuru = "Kasa Devir Kartı";
                if (rbtncikis.Checked) Hareket.GCKodu = "C";
                if (rbtngiris.Checked) Hareket.GCKodu = "G";
                Hareket.KasaId = KasaID;
                Hareket.Tarih = DateTime.Parse(txtTarih.Text);
                Hareket.Tutar = decimal.Parse(txtTutar.Text);
                Hareket.SaveDate = DateTime.Now;
                Hareket.SaveUser = AnaForm.userID;
                DB.Tbl_KasaHareketleri.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Devir kartı hareket kaydı işlenmiştir.");
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
                Fonksiyonlar.Tbl_KasaHareketleri Hareket = DB.Tbl_KasaHareketleri.First(s => s.Id == IslemID);
                Hareket.Aciklama = txtAciklama.Text;
                Hareket.BelgeNo = txtBelgeMakbuz.Text;
                Hareket.EvrakTuru = "Kasa Devir Kartı";
                if (rbtncikis.Checked) Hareket.GCKodu = "C";
                if (rbtngiris.Checked) Hareket.GCKodu = "G";
                Hareket.KasaId = KasaID;
                Hareket.Tarih = DateTime.Parse(txtTarih.Text);
                Hareket.Tutar = decimal.Parse(txtTutar.Text);
                Hareket.EditDate = DateTime.Now;
                Hareket.EditUser = AnaForm.userID;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        void Sil()
        {
            DB.Tbl_KasaHareketleri.DeleteOnSubmit(DB.Tbl_KasaHareketleri.First(s => s.Id == IslemID));
            DB.SubmitChanges();
            Temizle();
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                Fonksiyonlar.Tbl_KasaHareketleri Hareket = DB.Tbl_KasaHareketleri.First(s => s.Id == IslemID);
                txtAciklama.Text = Hareket.Aciklama;
                txtBelgeMakbuz.Text = Hareket.BelgeNo;
                KasaAc(Hareket.KasaId.Value);
                txtTarih.Text = Hareket.Tarih.Value.ToShortDateString();
                txtTutar.Text = Hareket.Tarih.Value.ToShortDateString();
                if (Hareket.GCKodu == "G") rbtngiris.Checked = true;
                if (Hareket.GCKodu == "C") rbtncikis.Checked = true;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdi.Text = DB.Tbl_Kasalar.First(s => s.Id == KasaID).KasaAdi;
                txtKasaKodu.Text = DB.Tbl_Kasalar.First(s => s.Id == KasaID).KasaKodu;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();   
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && mesajlar.Sil(true) == DialogResult.Yes) Sil();  
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.KasaListesi(true);
            if (ID > 0)
            {
                KasaAc(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtBelgeMakbuz_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}

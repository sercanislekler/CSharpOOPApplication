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
    public partial class frmBankaIslemleri : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;
        int secimID = -1;
        public frmBankaIslemleri()
        {
            InitializeComponent();
        }
        void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.Tbl_BankaHareketleri hareket = new Fonksiyonlar.Tbl_BankaHareketleri();
                BankaAc(hareket.BankaID.Value);
                txtAciklama.Text = hareket.Aciklama;
                txtBelgeNo.Text = hareket.BelgeNo;
                txtTarih.Text = hareket.Tarih.Value.ToShortDateString();
                txtTutar.Text = hareket.Tutar.ToString();
                if (hareket.GCKodu == "G") rbtGiris.Checked = true;
                if (hareket.GCKodu == "C") rbtCikis.Checked = true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdi.Text = DB.Tbl_Bankalar.First(s => s.Id == BankaID).HesapAdi;
                txtHesapNo.Text = DB.Tbl_Bankalar.First(s => s.Id == BankaID).HesapNo;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void frmBankaIslemleri_Load(object sender, EventArgs e)
        {

        }
       
        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = "";
            txtTutar.Text = "0";
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_BankaHareketleri hareket = new Fonksiyonlar.Tbl_BankaHareketleri();
                hareket.Aciklama = txtAciklama.Text;
                hareket.BankaID = BankaID;
                hareket.BelgeNo = txtBelgeNo.Text;
                hareket.EvrakTuru = "Banka İşlem";
                if (rbtGiris.Checked) hareket.GCKodu = "G";
                if (rbtCikis.Checked) hareket.GCKodu = "C";
                hareket.Tarih = DateTime.Parse(txtTarih.Text);
                hareket.Tutar = decimal.Parse(txtTutar.Text);
                hareket.SaveDate = DateTime.Now;
                hareket.SaveUser = AnaForm.userID;
                DB.Tbl_BankaHareketleri.InsertOnSubmit(hareket);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni banka işlemi eklenmiştir.");
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
                Fonksiyonlar.Tbl_BankaHareketleri hareket = DB.Tbl_BankaHareketleri.First(s => s.Id == IslemID);
                hareket.Aciklama = txtAciklama.Text;
                hareket.BankaID = BankaID;
                hareket.BelgeNo = txtBelgeNo.Text;
                hareket.EvrakTuru = "Banka İşlem";
                if (rbtGiris.Checked) hareket.GCKodu = "G";
                if (rbtCikis.Checked) hareket.GCKodu = "C";
                hareket.Tarih = DateTime.Parse(txtTarih.Text);
                hareket.Tutar = decimal.Parse(txtTutar.Text);
                hareket.EditDate = DateTime.Now;
                hareket.EditUser = AnaForm.userID;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
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
                DB.Tbl_BankaHareketleri.DeleteOnSubmit(DB.Tbl_BankaHareketleri.First(s => s.Id == IslemID));
                DB.SubmitChanges();
                Temizle();
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
            if (Edit && IslemID > 0 && mesajlar.Sil(true) == DialogResult.Yes) Silme();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}

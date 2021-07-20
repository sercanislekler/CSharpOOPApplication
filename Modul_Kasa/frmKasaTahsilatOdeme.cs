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
    public partial class frmKasaTahsilatOdeme : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar numara = new Fonksiyonlar.Numaralar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int IslemID = -1;
        int CariHareketID = -1;
        int KasaID = -1;
        int CariID = -1;
        int StokID = -1;
        decimal Miktar = 1;
        decimal Tutar = 0;
        public frmKasaTahsilatOdeme()
        {
            InitializeComponent();
        }

        private void frmKasaTahsilatOdeme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        void Temize()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtIslemTuru.SelectedIndex = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            CariID = -1;
            KasaID = -1;
            CariHareketID = -1;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int HareketID)
        {
            try
            {
                Edit = true;
                IslemID = HareketID;
                Fonksiyonlar.Tbl_KasaHareketleri KasaHareketi = DB.Tbl_KasaHareketleri.First(s => s.Id == IslemID);
                CariHareketID = DB.Tbl_CariHareketleri.First(s => s.EvrakTuru == KasaHareketi.EvrakTuru && s.EvrakID == IslemID).Id;
                MessageBox.Show("Cari Hareket ID :" + CariHareketID.ToString());
                txtAciklama.Text = KasaHareketi.Aciklama;
                txtBelgeNo.Text = KasaHareketi.BelgeNo;
                if (KasaHareketi.EvrakTuru == "Kasa Tahsilat") txtIslemTuru.SelectedIndex = 0;
                if (KasaHareketi.EvrakTuru == "Kasa Ödeme") txtIslemTuru.SelectedIndex = 1;
                txtTarih.Text = KasaHareketi.Tarih.Value.ToShortDateString();
                txtTutar.Text = KasaHareketi.Tutar.Value.ToString();
                KasaAc(KasaHareketi.KasaId.Value);
                CariAc(KasaHareketi.CariId.Value);
            }
            catch (Exception e)
            {
                Temize();
                mesajlar.Hata(e);
            }
        }
        public void StokAc(int ID)
        {
            try
            {
                StokID = ID;
                txtStokKodu.Text = DB.Tbl_Stoklar.First(s => s.Id == StokID).StokKodu;
                txtStokAdi.Text = DB.Tbl_Stoklar.First(s => s.Id == StokID).StokAdi;
            }
            catch (Exception)
            {

                StokID = -1;
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
            catch (Exception)
            {
                KasaID = -1;
            }
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariAdi.Text = DB.Tbl_Cariler.First(s => s.Id == CariID).CariAdi;
                txtCariKodu.Text = DB.Tbl_Cariler.First(s => s.Id == CariID).CariKodu;
            }
            catch (Exception )
            {
                CariID = -1;
            }
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_KasaHareketleri KasaHareketi = new Fonksiyonlar.Tbl_KasaHareketleri();
                KasaHareketi.Aciklama = txtAciklama.Text;
                KasaHareketi.BelgeNo = txtBelgeNo.Text;
                KasaHareketi.CariId = CariID;
                KasaHareketi.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.GCKodu = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.GCKodu = "C";
                KasaHareketi.KasaId = KasaID;
                KasaHareketi.SaveDate = DateTime.Now;
                KasaHareketi.SaveUser = AnaForm.userID;
                KasaHareketi.Tarih = DateTime.Parse(txtTarih.Text);
                KasaHareketi.Tutar = decimal.Parse(txtTutar.Text);
                DB.Tbl_KasaHareketleri.InsertOnSubmit(KasaHareketi);
                DB.SubmitChanges();
                mesajlar.YeniKayit(txtIslemTuru.SelectedText+"\n" + "*yeni kasa hareketi olarak işlenmiştir.");
                Fonksiyonlar.Tbl_CariHareketleri carihareket = new Fonksiyonlar.Tbl_CariHareketleri();
                carihareket.Aciklama = txtBelgeNo.Text + "\n"+" belge numaralı "+"\n" +txtIslemTuru.SelectedText.ToString()+ "\n"+"işlemi";
                if (txtIslemTuru.SelectedIndex == 0) carihareket.Alacak = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) carihareket.Borc = decimal.Parse(txtTutar.Text);
                carihareket.CariID = CariID;
                carihareket.EvrakID = KasaHareketi.Id;
               // carihareket.StokKodu = txtStokKodu.Text;
                carihareket.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                carihareket.Tarih = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) carihareket.Tipi = "KT";
                if (txtIslemTuru.SelectedIndex == 1) carihareket.Tipi = "KÖ";
                carihareket.SaveDate = DateTime.Now;
                carihareket.SaveUser = AnaForm.userID;
                carihareket.CariKodu = txtCariKodu.Text;
                carihareket.StokKodu = txtStokKodu.Text;
                DB.Tbl_CariHareketleri.InsertOnSubmit(carihareket);
                DB.SubmitChanges();
                mesajlar.YeniKayit(txtIslemTuru.SelectedItem.ToString()+ "\n"+"*yeni cari hareketi olarak işlenmiştir.");
               /* Fonksiyonlar.Tbl_Stoklar stok = new Fonksiyonlar.Tbl_Stoklar();
                stok.StokAdi = txtStokAdi.Text;
                stok.StokKodu = txtStokKodu.Text;*/
                Miktar = decimal.Parse(txtMiktar.Text);
                Tutar = decimal.Parse(txtTutar.Text);
                txtTutar.Text = (Tutar * Miktar).ToString();
                /*stok.StokSatisFiyat = decimal.Parse (txtTutar.Text);
                DB.Tbl_Stoklar.InsertOnSubmit(stok);*/
                DB.SubmitChanges();

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
                Fonksiyonlar.Tbl_KasaHareketleri KasaHareketi = DB.Tbl_KasaHareketleri.First(s => s.Id == IslemID);
                KasaHareketi.Aciklama = txtAciklama.Text;
                KasaHareketi.BelgeNo = txtBelgeNo.Text;
                KasaHareketi.CariId = CariID;
                KasaHareketi.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.GCKodu = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.GCKodu = "C";
                KasaHareketi.KasaId = KasaID;
                KasaHareketi.EditDate = DateTime.Now;
                KasaHareketi.EditUser = AnaForm.userID;
                KasaHareketi.Tarih = DateTime.Parse(txtTarih.Text);
                KasaHareketi.Tutar = decimal.Parse(txtTutar.Text);
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                Fonksiyonlar.Tbl_CariHareketleri carihareket = DB.Tbl_CariHareketleri.First(s => s.Id == CariHareketID);
                carihareket.Aciklama = txtBelgeNo.Text + "belge numaralı" + txtIslemTuru.SelectedText.ToString() + "işlemi";
                if (txtIslemTuru.SelectedIndex == 0) carihareket.Alacak = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) carihareket.Borc = decimal.Parse(txtTutar.Text);
                carihareket.CariID = CariID;
                carihareket.EvrakID = KasaHareketi.Id;
                carihareket.EvrakTuru = txtIslemTuru.SelectedItem.ToString();
                carihareket.Tarih = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) carihareket.Tipi = "KT";
                if (txtIslemTuru.SelectedIndex == 1) carihareket.Tipi = "KÖ";
                carihareket.EditDate = DateTime.Now;
                carihareket.EditUser = AnaForm.userID;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                DB.Tbl_KasaHareketleri.DeleteOnSubmit(DB.Tbl_KasaHareketleri.First(s => s.Id == IslemID));
                DB.Tbl_CariHareketleri.DeleteOnSubmit(DB.Tbl_CariHareketleri.First(s => s.Id == CariHareketID));
                Temize();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
            
        }
        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.KasaListesi(true);
            if (Id > 0) KasaAc(Id); AnaForm.Aktarma = -1;
        }
        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.CariListesi(true);
            if (Id > 0)
            { CariAc(Id); AnaForm.Aktarma = -1; }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && mesajlar.Sil(true) == DialogResult.Yes) Sil();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.StokListesi(true);
            if (Id > 0)
            {
                StokAc(Id); AnaForm.Aktarma = -1; 
            }
        }
    }
}

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
    
    public partial class frmCariAcilisKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numaralar numara = new Fonksiyonlar.Numaralar();
        int KasaID = -1;
        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;
        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            txtCariKodu.Text = numara.CariGrupNumarasi();
        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
            {
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit || CT is DevExpress.XtraEditors.MemoEdit)
                {
                    CT.Text = "";
                }
                foreach (Control CE in groupControl2.Controls)
                {
                    if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.MemoEdit)
                    {
                        CE.Text = "";
                    }
                    
                }
                    Edit = false;
                    CariID = -1;
                    GrupID = -1;
                    AnaForm.Aktarma = -1;
               
            }
                  
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_Cariler cari = new Fonksiyonlar.Tbl_Cariler();
                cari.Adres = txtAdres.Text;
                cari.CariAdi = txtCariAdi.Text;
                cari.CariKodu = txtCariKodu.Text;
                cari.Fax1 = txtFax1.Text;
                cari.Fax2 = txtFax2.Text;
                cari.GrupId = GrupID;
                cari.Ilce = txtIlce.Text;
                cari.MailInfo = txtMailInfo.Text;
                cari.Il = txtIl.Text;
                cari.Telefon1 = txtTelefon1.Text;
                cari.Telefon2 = txtTelefon2.Text;
                cari.Ulke = txtUlke.Text;
                cari.VergiDairesi = txtVergiDairesi.Text;
                cari.VergiNo = txtVergiNo.Text;
                cari.WebAdres = txtWebAdresi.Text;
                cari.Yetkili1 = txtYetkili.Text;
                cari.Yetkili2 = txtYetkili1.Text;
                cari.YetkiliEmail1 = txtYetkiliEmail.Text;
                cari.YetkiliEmail2 = txtYetkiliEmail2.Text;
                cari.SaveDate = DateTime.Now;
                cari.SaveUser = AnaForm.userID;
                DB.Tbl_Cariler.InsertOnSubmit(cari);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni cari kaydınız oluşturuldu.");
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
                Fonksiyonlar.Tbl_Cariler cari = DB.Tbl_Cariler.First(s => s.Id==CariID);
                cari.Adres = txtAdres.Text;
                cari.CariAdi = txtCariAdi.Text;
                cari.CariKodu = txtCariKodu.Text;
                cari.Fax1 = txtFax1.Text;
                cari.Fax2 = txtFax2.Text;
                cari.GrupId = GrupID;
                cari.Ilce = txtIlce.Text;
                cari.MailInfo = txtMailInfo.Text;
                cari.Il = txtIl.Text;
                cari.Telefon1 = txtTelefon1.Text;
                cari.Telefon2 = txtTelefon2.Text;
                cari.Ulke = txtUlke.Text;
                cari.VergiDairesi = txtVergiDairesi.Text;
                cari.VergiNo = txtVergiNo.Text;
                cari.WebAdres = txtWebAdresi.Text;
                cari.Yetkili1 = txtYetkili.Text;
                cari.Yetkili2 = txtYetkili1.Text;
                cari.YetkiliEmail1 = txtYetkiliEmail.Text;
                cari.YetkiliEmail2 = txtYetkiliEmail2.Text;
                cari.EditDate = DateTime.Now;
                cari.EditUser = AnaForm.userID;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                
               mesajlar.Hata(e);
            }
            
        }
        public void MusteriVarMi(bool varmi)
        {
            try
            {
                varmi = false;
                Fonksiyonlar.Tbl_Cariler cari = DB.Tbl_Cariler.First(s => s.Id == KasaID);
                if (KasaID > 0)
                {
                    varmi = true;
                    mesajlar.KullaniciVar(true);
                    return;
                }
            }
            catch (Exception)
            {

                ;
            }
        
         }
        void Sil()
        {
            try
            {
                DB.Tbl_Cariler.DeleteOnSubmit(DB.Tbl_Cariler.First(s => s.Id == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.Tbl_CariGruplari grup = DB.Tbl_CariGruplari.First(s => s.Id == GrupID);
                txtCariGrupAdi.Text = grup.GrupAdi;
                txtCariGrupKodu.Text = grup.GrupKodu;
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                CariID = ID;
                Fonksiyonlar.Tbl_Cariler cari = DB.Tbl_Cariler.First(s => s.Id == CariID);
                txtAdres.Text = cari.Adres;
                txtCariAdi.Text = cari.CariAdi;
                txtCariKodu.Text = cari.CariKodu;
                txtFax1.Text = cari.Fax1;
                txtFax2.Text = cari.Fax2;
                txtIlce.Text = cari.Ilce;
                txtMailInfo.Text = cari.MailInfo;
                txtIl.Text = cari.Il;
                txtTelefon1.Text = cari.Telefon1;
                txtTelefon2.Text = cari.Telefon2;
                txtUlke.Text = cari.Ulke;
                txtVergiDairesi.Text = cari.VergiDairesi;
                txtVergiNo.Text = cari.VergiNo;
                txtWebAdresi.Text = cari.WebAdres;
                txtYetkili.Text = cari.Yetkili1;
                txtYetkili1.Text = cari.Yetkili2;
                txtYetkiliEmail.Text = cari.YetkiliEmail1;
                txtYetkiliEmail2.Text = cari.YetkiliEmail2;
                GrupAc(cari.GrupId.Value);

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
            
             MusteriVarMi(true);
            if (Edit && CariID > 0 && mesajlar.Sil(true) == DialogResult.Yes) Sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void txtCariGrupAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.CariGruplarim(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.CariListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;

        }
    }
}

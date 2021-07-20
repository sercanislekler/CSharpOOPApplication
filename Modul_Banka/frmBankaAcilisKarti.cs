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
    public partial class frmBankaAcilisKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int BankaID = -1;
        int secimID = -1;
        public frmBankaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmBankaAcilisKarti_Load(object sender, EventArgs e)
        {

        }

        void Temizle()
        {
            txtAdres.Text = "";
            txtBankaAdi.Text = "";
            txtHesapAdi.Text = "";
            txtHesapNo.Text = "";
            txtIBAN.Text = "";
            txtSube.Text = "";
            txtTelefon.Text = "";
            txtTemsilci.Text = "";
            txtTemsilciEmail.Text = "";
            Edit = false;
            secimID = -1;
            Listele();
        }

        void Listele()
        {
            var LST = from s in DB.Tbl_Bankalar select s;
            Liste.DataSource = LST;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.Tbl_Bankalar banka = new Fonksiyonlar.Tbl_Bankalar();
                banka.Adres = txtAdres.Text;
                banka.BankaAdi = txtBankaAdi.Text;
                banka.HesapAdi = txtHesapAdi.Text;
                banka.HesapNo = txtHesapNo.Text;
                banka.IBAN = txtIBAN.Text;
                banka.Sube = txtSube.Text;
                banka.Telefon = txtTelefon.Text;
                banka.Temsilci = txtTemsilci.Text;
                banka.TemsilciEmail = txtTemsilciEmail.Text;
                banka.SaveDate = DateTime.Now;
                banka.SaveUser = AnaForm.userID;
                DB.Tbl_Bankalar.InsertOnSubmit(banka);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni banka kaydı açılmıştır.");
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
                Fonksiyonlar.Tbl_Bankalar banka = DB.Tbl_Bankalar.First(s => s.Id == secimID);
                banka.Adres = txtAdres.Text;
                banka.BankaAdi = txtBankaAdi.Text;
                banka.HesapAdi = txtHesapAdi.Text;
                banka.HesapNo = txtHesapNo.Text;
                banka.IBAN = txtIBAN.Text;
                banka.Sube = txtSube.Text;
                banka.Telefon = txtTelefon.Text;
                banka.Temsilci = txtTemsilci.Text;
                banka.TemsilciEmail = txtTemsilciEmail.Text;
                banka.EditDate = DateTime.Now;
                banka.EditUser = AnaForm.userID;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
                Listele();
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
                DB.Tbl_Bankalar.DeleteOnSubmit(DB.Tbl_Bankalar.First(s => s.Id == secimID));
                DB.SubmitChanges();
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
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
                
            }
            catch (Exception)
            {

                Edit = false;
                secimID = -1;
            }


        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                BankaID = ID;
                Fonksiyonlar.Tbl_Bankalar banka = DB.Tbl_Bankalar.First(s => s.Id == BankaID);
                txtAdres.Text = banka.Adres;
                txtBankaAdi.Text = banka.BankaAdi;
                txtHesapAdi.Text = banka.HesapAdi;
                txtHesapNo.Text = banka.HesapNo;
                txtIBAN.Text = banka.IBAN;
                txtSube.Text = banka.Sube;
                txtTelefon.Text = banka.Telefon;
                txtTemsilci.Text = banka.Temsilci;
                txtTemsilciEmail.Text = banka.TemsilciEmail;
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && secimID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && secimID > 0 && mesajlar.Sil(true) == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

    }
}

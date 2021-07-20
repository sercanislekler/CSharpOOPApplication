using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otomasyon.Modul_Stok
{
    public partial class frmStokKarti : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numaralar numaralar = new Fonksiyonlar.Numaralar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme resimleme = new Fonksiyonlar.Resimleme();
        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// </summary>
        OpenFileDialog Dosya = new OpenFileDialog();
        bool Resim = false;
        bool Edit = false;
        int GrupId = -1;
        int StokId = -1;
        bool KDV = false;
        double KDVORan,Fiyat,Toplam,KDVOran2,Fiyat2;
        double AdetFiyat,Adet=0;
        decimal iskontotutar, iskontoyuzde, tutar, indirimlifiyat, indirimmik, FiyatIskonto,Fiyat3, indirimyuzde,Fiyat4;
        DialogResult soru = new DialogResult();
        public frmStokKarti()
        {
            InitializeComponent();
        }

       


        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            
            DB = new Fonksiyonlar.DatabaseDataContext();
            txtKategori.ValueMember = "Id";
            txtKategori.DisplayMember = "StokKategori";
            txtKategori.DataSource = DB.Tbl_Stoklar.ToList();
            txtStokKodu.Text = numaralar.StokNumarasi();
            txtGrupKodu.Text = numaralar.StokGrupNumarasi();
        }
       public void Doldur()
        {
            if (txtKategori.SelectedIndex == -1)
            {
                var lst = from s in DB.Tbl_Stoklar
                          where s.StokKategori == txtKategori.SelectedValue
                          select s;
                
                txtKategori.DataSource = lst;
            }
                
           
        }
        void ResimSec()
        {
                Dosya.Filter = "Jpg(*.jpg)|*.jpg|jpeg(*.jpeg)|*.jpeg";
                if (Dosya.ShowDialog() == DialogResult.OK)
                {
                    txtResimKutusu.ImageLocation = Dosya.FileName;
                    Resim = true;
                }  
        }
        void temizle()
        {
            txtStokKodu.Text = numaralar.StokGrupKodNumarasi();
            txtStokAdi.Text = "";
            txtSatisKDV.Text = "0";
            txtStokGrubu.Text = "";
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            txtBirim.SelectedIndex = 0;
            txtBarkod.Text = "";
            txtAlisKDV.Text = "0";
            Edit = false;
            Resim = false;
            GrupId = -1;
            StokId = -1;
            AnaForm.Aktarma = -1;
        } 
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }
        void YeniKaydet()
        {
           try
            {
                Fonksiyonlar.Tbl_Stoklar Stok = new Fonksiyonlar.Tbl_Stoklar();
                Stok.StokAdi = txtStokAdi.Text;
                Stok.StokAlisFiyat = decimal.Parse(txtalis.Text);
                Stok.StokSatisFiyat = decimal.Parse(txtSatis.Text);
                Stok.Barkod = txtBarkod.Text;
                Stok.UreticiFirma = txtureticiFirmaAdi.Text;
                if (txtBirim.SelectedIndex == 0)
                {
                Stok.StokMiktar = int.Parse(txtAdet.Text);
                }
                 if (txtBirim.SelectedIndex == 1)
                {
                Stok.StokMiktar = int.Parse(txtAdet.Text);
                Stok.StokPaket = int.Parse(txtPaket.Text);
                }
                Stok.UreticiFirmaKod = txtureticifirmakodu.Text;
                Stok.StokKrtkSev = int.Parse(txtStokKrtkSev.Text);
                Stok.StokMaksSev = int.Parse(txtMaksSev.Text);
                Stok.StokKategori = txtKategori.Text;
                Stok.StokGrup = txtStokGrubu.Text;
                Stok.StokBirim = txtBirim.Text;
                Stok.StokGrupID = GrupId;
                Stok.StokKodu = txtStokKodu.Text;
                if(checkResim.Checked)Stok.StokResim = new System.Data.Linq.Binary(resimleme.ResimYukleme(txtResimKutusu.Image));else
                Stok.StokSaveDate = DateTime.Now;
                Stok.StokSaveUser = AnaForm.userID;
                if (CheckIskonto.Checked)
                {
                    Stok.IskontoOran = txtIskontoOran.Text;
                    Stok.IndirimliFiyat = decimal.Parse(txtIndirimliFiyat.Text);
                    Stok.IndirimMiktari = decimal.Parse(txtIndirimMiktari.Text);
                    Stok.IskontoDahil = "E";
                }
                else
                {
                    Stok.IndirimliFiyat = 0;
                    Stok.IndirimMiktari = 0;
                    Stok.IskontoDahil = "H";
                }
                if (RadKdvDahil.Checked)
	            {
                soru = MessageBox.Show("Bu ürünü 'kdv dahil' olarak eklemek üzeresiniz devam etmek istiyor musunuz?", "Kdv Dahil Edilsin Mi ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes) {
                    Stok.StokAlisKDV = decimal.Parse(txtAlisKDV.Text);
                    Stok.StokSatisKDV = decimal.Parse(txtSatisKDV.Text);
                    Stok.KdvDahil = "E";
                    DB.Tbl_Stoklar.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni stok kaydı oluşturuldu.");
                temizle();
                }
	            }
                else if (RadKdvHaric.Checked)
	            {
		        soru = MessageBox.Show("Bu ürünü 'kdv hariç' olarak eklemek üzeresiniz devam etmek istiyor musunuz?","Kdv Hariç Mi?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
	            if (soru == DialogResult.Yes )
	            {
                Stok.StokAlisKDV = 0;
                Stok.StokSatisKDV = 0;
                Stok.KdvDahil = "H"; 
		        DB.Tbl_Stoklar.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                mesajlar.YeniKayit("Yeni stok kaydı oluşturuldu.");
                temizle(); 
	            }
                }
                else
	            {
                    MessageBox.Show("KDV durumunu belirtiniz.","Kdv Durum",MessageBoxButtons.OK,MessageBoxIcon.Error);
	            }
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
                Fonksiyonlar.Tbl_Stoklar Stok = DB.Tbl_Stoklar.First(s => s.Id == StokId);
                Stok.StokAdi = txtStokAdi.Text;
                Stok.StokAlisFiyat = decimal.Parse(txtalis.Text);
                Stok.StokSatisFiyat = decimal.Parse(txtSatis.Text);
                Stok.Barkod = txtBarkod.Text;
                Stok.StokBirim = txtBirim.Text;
                Stok.StokGrupID = GrupId;
                Stok.StokKodu = txtStokKodu.Text;
                if (Resim) Stok.StokResim = new System.Data.Linq.Binary(resimleme.ResimYukleme(txtResimKutusu.Image));
                Stok.StokSatisFiyat = decimal.Parse(txtStokGrubu.Text);
                Stok.StokSatisKDV = decimal.Parse(txtSatisKDV.Text);
                Stok.StokEditTime = DateTime.Now;
                Stok.StokSaveUser = AnaForm.userID;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                temizle();
            }
           catch (Exception e)
           {
               mesajlar.Hata(e);
           }  
        }
        void Sill()
        {
            try
            {
             DB.Tbl_Stoklar.DeleteOnSubmit(DB.Tbl_Stoklar.First(s => s.Id == StokId));
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        void GrupAc(int Id)
        {
           try
           {
                GrupId = Id;
                txtGrupAdi.Text = DB.Tbl_StokGruplarii.First(s => s.Id == GrupId).GrupAdi;
                txtGrupKodu.Text = DB.Tbl_StokGruplarii.First(s => s.Id == GrupId).GrupKodu;
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
                StokId = ID;
                Fonksiyonlar.Tbl_Stoklar stok = DB.Tbl_Stoklar.First(s => s.Id == StokId);
                GrupAc(stok.StokGrupID.Value);
                //txtResimKutusu.Image = resimleme.ResimGetirme(stok.StokResim.ToArray());
                txtAlisKDV.Text = stok.StokAlisKDV.ToString();
                txtBarkod.Text = stok.Barkod;
                txtalis.Text = stok.StokAlisFiyat.ToString();
                txtureticiFirmaAdi.Text = stok.UreticiFirma;
                txtBirim.Text = stok.StokBirim;
                txtKategori.Text = stok.StokKategori;
                txtStokGrubu.Text = stok.StokGrup;
                txtSatis.Text = stok.StokSatisFiyat.ToString();
                txtSatisKDV.Text = stok.StokSatisKDV.ToString();
                txtStokAdi.Text = stok.StokAdi;
                txtStokKodu.Text = stok.StokKodu;
           }
           catch (Exception e)
            {

                mesajlar.Hata(e);
            }
            
        }

        public void AdetBirim()
        {
            try
            {
                if (CheckIskonto.Checked)
                {
                    iskontoyuzde = decimal.Parse(txtIskontoOran.Text);
                    FiyatIskonto = decimal.Parse(txtalis.Text);
                    tutar = ((iskontoyuzde - iskontotutar) * decimal.Parse(txtalis.Text) / 100);
                    txtIndirimMiktari.Text = tutar.ToString();
                    indirimlifiyat = FiyatIskonto - iskontotutar;
                    txtIndirimliFiyat.Text = (indirimlifiyat - tutar).ToString();
                }
                else
                {
                    MessageBox.Show("İskonto uygulamak için 'İskonto Uygula (%) seçeneğini işaretlemelisiniz.", "İskonto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception hata)
            {
                mesajlar.Hata(hata);
            }
           
        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.StokListesi(true);
            if (Id > 0)
            {
                Ac(Id);
            } 
            AnaForm.Aktarma = -1;
        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.StokGruplari(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            if (Edit && StokId > 0 && mesajlar.Guncelle() == DialogResult.Yes)Guncelle();
            else YeniKaydet();
	
       
	
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokId > 0 && mesajlar.Sil(true) == DialogResult.Yes) Sill();
        }

        private void txtBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBirim_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void txtBirim_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBirim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtBirim.SelectedIndex == 1)
                {
                    txtPaket.ReadOnly = false;
                }
                else
                {
                    txtPaket.ReadOnly = true;
                }
            }
            catch (Exception Hata)
            {
                mesajlar.Hata(Hata);
            }
           
        }
        public void KDVDurumSecim()
        {
           
            
        }

        private void RadKdvHaric_CheckedChanged(object sender, EventArgs e)
        {
            if (RadKdvHaric.Checked)
            {
                txtAlisKDV.ReadOnly = true;
                txtSatisKDV.ReadOnly = true;
                button2.Enabled = false;
            }
            else if (RadKdvDahil.Checked)
            {
                txtAlisKDV.ReadOnly = false;
                txtSatisKDV.ReadOnly = false;
                button2.Enabled = true;
            }
        }
        private void txtAlisKDV_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtAlisKDV_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtAlisKDV_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdetBirim();
        }

        private void txtAlisKDV_Enter_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtalis.Text == "" || txtSatis.Text == "")
                {
                errorProvider1.SetError (txtSatis , "Lütfen fiyat giriniz.");
                errorProvider1.SetError (txtalis,"Lütfen fiyat giriniz.");
                }
                else
                {
                    KDVORan = Convert.ToDouble(txtAlisKDV.Text);
                    Fiyat = Convert.ToDouble(txtalis.Text);
                    txtalis.Text = (Fiyat + Fiyat * KDVORan / 100).ToString();
                    KDVOran2 = Convert.ToDouble(txtSatisKDV.Text);
                    Fiyat2 = Convert.ToDouble(txtSatis.Text);
                    txtSatis.Text = (Fiyat2 + Fiyat2 * KDVOran2 / 100).ToString();   
                }
            }
            catch (Exception hata)
            {
                mesajlar.Hata(hata);
            }
        }
        private void txtSatisKDV_Enter(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                indirimyuzde = Convert.ToDecimal(txtKarYuzde.Value);
                Fiyat4 = decimal.Parse(txtalis.Text);
                tutar = (indirimyuzde + Fiyat4) / 100;
                txtKarMikt.Text = tutar.ToString();
                txtKarTutar.Text = (Fiyat4 + tutar).ToString();
                txtSatis.Text = tutar.ToString();
            }
            catch (Exception hata)
            {
                mesajlar.Hata(hata);
            }
        }

        private void txtKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doldur();
        }     
    }
}

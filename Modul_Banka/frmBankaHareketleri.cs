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
    public partial class frmBankaHareketleri : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar form = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesaj = new Fonksiyonlar.Mesajlar();
        public bool secim = false;
        int BankaId = -1;
        int IslemID = -1;
        int secimID = -1;
        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {
           
        }
        void Listele()
        {
            var lst = from s in DB.Tbl_Bankalar where s.Id == BankaId select s;
            Liste.DataSource = lst;
        }

        public void Sec()
        {
            try
            {
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("BankaID").ToString());
                secim = true;
            }
            catch (Exception)
            {

                secimID = -1;
            }
        }
     /*  public void BankaAc(int ID)
        {
            
            try
            {
                BankaId = ID;
                Fonksiyonlar.VW_BankaHareketleris banka = DB.VW_BankaHareketleri.First(s => s.Id == BankaId);
                txtHesapAdi.Text = banka.HesapAdi;
                txtHesapNo.Text = banka.HesapNo;
                txtGiris.Text = banka.Giris.Value.ToString();
                txtCikis.Text = banka.Cikis.Value.ToString();
                Listele();
            }
            catch (Exception e)
            {
                mesaj.Hata(e);
            }

        }*/

        private void txtHesapAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          /*  int Id = form.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            Listele();
            Sec();
            AnaForm.Aktarma = -1;*/
        }
    }
}

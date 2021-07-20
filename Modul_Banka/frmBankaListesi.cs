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
   
    public partial class frmBankaListesi : Form
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar form = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();

        int BankaID = -1;
        int SecimID = -1;
        public bool Secim = false;
        
        public frmBankaListesi()
        {
            InitializeComponent();
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            var lst = from s in DB.Tbl_Bankalar select s;
            Liste.DataSource = lst;
        }
        public void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("Id").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
               
            }
           
        }
        public void Listele()
        {
            var lst = from s in DB.VW_BankaHareketleri where s.BankaID == SecimID select s;
            Liste.DataSource = lst;
        }

       public  void Ac(int ID)
        {
            Sec();
            BankaID = ID;
            frmBankaAcilisKarti frm = new frmBankaAcilisKarti();
            frm.Ac(ID);
            frm.Show();
            Listele();
        }

       private void bankaBilgileriniDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ac(BankaID);
            if (Secim && BankaID>0)
            {
                AnaForm.Aktarma = BankaID;
                this.Close();
                Listele();
            }
            
        }

        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
        }

        private void BankaListe_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
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

        private void gridView1_DoubleClick(object sender, EventArgs e)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Xml;

namespace Otomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public static int userID = -1;
        public static int Aktarma = -1;
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
           
           
        }

        public void DovizKur()
        {
            try
            {
                XmlDocument xmlVerisi = new XmlDocument();
                xmlVerisi.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
                decimal dolar = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlVerisi.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                textEdit1.Text = dolar.ToString();
                textEdit2.Text = euro.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("İnternet bağlantınızı kontrol ediniz.", "İnternet Bağlantı Hatası.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void barBtnStokKart_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokKarti();
        }

        private void barBtnStokListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokListesi();
        }

        private void barBtnStokGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokGruplari();
        }

        private void barBtnStokHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokHareketleri();
        }

        private void barBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplarim();
        }

        private void barBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void barBtnKasaAcilis_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaAcilisKarti();
        }

        private void barBtnKasaDevir_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.Ac();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void barBtnTahsilatOdeme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaTahsilatOdemeKarti();
        }

        private void barBtnKasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaHareketleri();
        }

        private void barbrnKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KasaListesi();
        }

        private void barBtnBankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaAcilisKarti();
        }

        private void barBtnbankaIslemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaIslemleri();
        }

        private void barBtnBankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaListesi();
        }

        private void printPreviewStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariHareketleri();
        }

        private void barBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void barBankaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.BankaHareketleri();
        }

        private void barBtnParaTransferi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.ParaTransfer();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult soru = MessageBox.Show("Programdan çıkış yapmak istiyor musunuz?", "Çıkış Yap?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.StokRapor();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.NakitSatis();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
          
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            DovizKur();
        }

        private void barBtnAlisFaturasi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.FaturaGiris();
        }
    }
}
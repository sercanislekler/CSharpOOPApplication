using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Otomasyon.Fonksiyonlar
{
    class Formlar
    {
        #region StokFormları
        public int StokListesi(bool Secim = false)
        {
            Modul_Stok.frmStokListesi frm = new Modul_Stok.frmStokListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public int StokGruplari(bool Secim = false)
        {

            Modul_Stok.frmStokGruplari frm = new Modul_Stok.frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void StokHareketleri(bool Ac = false)
        {
            Modul_Stok.frmStokHareketleri frm = new Modul_Stok.frmStokHareketleri();
            frm.Show();
        }

        public void StokKarti(bool Ac = false)
        {
            Modul_Stok.frmStokKarti frm = new Modul_Stok.frmStokKarti();
            frm.Show();
        }
        #endregion 
        #region CariFormlari
        public int CariGruplarim(bool secim = false)
        {
            Modul_Cari.frmCariGruplari frm = new Modul_Cari.frmCariGruplari();
            if (secim) frm.secim = secim; frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public int CariListesi(bool secim = false)
        {
            Modul_Cari.frmCariListesi frm = new Modul_Cari.frmCariListesi();
            if (secim)
            {
                frm.Secim = secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void CariAcilisKarti(bool Ac = false ,int CariID = -1)
        {
            Modul_Cari.frmCariAcilisKarti carikart = new Modul_Cari.frmCariAcilisKarti();
            if (Ac) carikart.Ac(CariID); carikart.ShowDialog();
        }
        public void CariHareketleri(bool secim = false)
        {
            Modul_Cari.frmCariHareketleri carihareket = new Modul_Cari.frmCariHareketleri();
            if (secim)
            {
                carihareket.secim = secim;
                carihareket.Show();
            }
            else
            {
                carihareket.MdiParent = AnaForm.ActiveForm;
                carihareket.Show();
            }
            

        }
        #endregion
        #region KasaFormlari
        public void KasaAcilisKarti()
        {
            Modul_Kasa.frmKasaAcilisKarti frm = new Modul_Kasa.frmKasaAcilisKarti();
            frm.ShowDialog();
        }

        public void Ac(bool Ac = false, int IslemID = -1)
        {
            Modul_Kasa.frmKasaDevirIslemKarti frm = new Modul_Kasa.frmKasaDevirIslemKarti();
            if (Ac) frm.Ac(IslemID); frm.ShowDialog();
        }

        public int KasaListesi(bool secim = false)
        {
            Modul_Kasa.frmKasaListesi frm = new Modul_Kasa.frmKasaListesi();
            if (secim)
            {
                frm.secim = secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }

        public void KasaTahsilatOdemeKarti(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmKasaTahsilatOdeme frm = new Modul_Kasa.frmKasaTahsilatOdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public void KasaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.frmKasaHareketleri frm = new Modul_Kasa.frmKasaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.Ac(ID);
            frm.Show();
        }
        #endregion
        #region BankaFormları
        public void BankaAcilisKarti()
        {
            Modul_Banka.frmBankaAcilisKarti frm = new Modul_Banka.frmBankaAcilisKarti();
            frm.ShowDialog();  
        }
        public void BankaIslemleri(bool Ac = false,int ID=-1)
        {

            Modul_Banka.frmBankaIslemleri frm = new Modul_Banka.frmBankaIslemleri();
            frm.ShowDialog();            
        }

        public int BankaListesi(bool secim = false)
        {
            Modul_Banka.frmBankaListesi liste = new Modul_Banka.frmBankaListesi();
            if (secim)
            {
                liste.Secim = secim;
                liste.ShowDialog();
            }
            else
            {
                liste.MdiParent = AnaForm.ActiveForm;
                liste.Show();
            }
            return AnaForm.Aktarma = -1;
        }

        public void BankaHareketleri(bool Ac = false, int ID = -1)
        {
          /*  Modul_Banka.frmBankaHareketleri frm = new Modul_Banka.frmBankaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.BankaAc(ID);
            frm.Show();*/
        }

        public void ParaTransfer()
        {
            Modul_Banka.frmParaTransfer frm = new Modul_Banka.frmParaTransfer();
            frm.ShowDialog();

        }
        #endregion
        #region Analizler

        public void StokRapor()
        {
            Analiz.StokRapor rpr = new Analiz.StokRapor();
            rpr.Show();
        }


        #endregion
        #region SatışEkranları
        public void NakitSatis()
        {
            Modul_Satis.NakitSatis satis = new Modul_Satis.NakitSatis();
            satis.ShowDialog();
        }

        #endregion
        #region FaturaEkranları
        public void FaturaGiris()
        {
            Modul_Fatura.frmFaturaGiris frm = new Modul_Fatura.frmFaturaGiris();
            frm.Show();
        }
        #endregion

    }

}

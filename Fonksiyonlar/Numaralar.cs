using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Otomasyon.Fonksiyonlar
{
    class Numaralar
    {
        Fonksiyonlar.DatabaseDataContext DB = new DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        public string StokNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.Tbl_Stoklar orderby s.Id descending select s).First().StokKodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000001";
            }
        }

        public string StokGrupNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.Tbl_StokGruplarii orderby s.Id descending select s).First().GrupKodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000001";
            }

        }
        public string StokGrupKodNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.Tbl_Cariler orderby s.Id descending select s).First().CariKodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {

                return "0000001";
            }
        
        }
        public string CariGrupNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.Tbl_CariGruplari orderby s.Id descending select s).First().GrupKodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;

            
            }
            catch (Exception)
            {

                return "0000001";
            }
        }
        public string KasaGrupNumarasi()
        {
            try
            {
                int numara = int.Parse((from s in DB.Tbl_Kasalar orderby s.Id descending select s).First().KasaKodu);
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;


            }
            catch (Exception)
            {

                return "0000001";
            }
        }

    }
}

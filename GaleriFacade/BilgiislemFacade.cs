using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galeri.Entity;
using Galeri.DAL;
using System.Data.SqlClient;
namespace GaleriFacade
{
    public class BilgiislemFacade
    {
        public int PersonelEklemeSPile(PersonelEntity EklenecekpersonelEntity)
        {
            SqlParameter[] Sqlgelendizi = new SqlParameter[8];
            Sqlgelendizi[0] = new SqlParameter("personelTC",EklenecekpersonelEntity.PersonelTC);
            Sqlgelendizi[1] = new SqlParameter("personelAd", EklenecekpersonelEntity.PersonelAd);
            Sqlgelendizi[2] = new SqlParameter("personelSoyad", EklenecekpersonelEntity.PersonelSoyad);
            Sqlgelendizi[3] = new SqlParameter("personelTel", EklenecekpersonelEntity.PersonelTEL);
            Sqlgelendizi[4] = new SqlParameter("personelAdres", EklenecekpersonelEntity.PersonelAdres);
            Sqlgelendizi[5] = new SqlParameter("personelMaas", EklenecekpersonelEntity.PersonelMaas);
            Sqlgelendizi[6] = new SqlParameter("iseGirisTarihi", EklenecekpersonelEntity.iseGirisTarihi);
            Sqlgelendizi[7] = new SqlParameter("istenAyrilmaTarihi", EklenecekpersonelEntity.istenAyrilmaTarihi);
            int donen = HelperSql.SqlGeriDondurmezWithSp("sp_personelEkleme", true, Sqlgelendizi);
            return donen;



        }
    }
    //public int PersonelGuncellemeSpile(PersonelEntity)
}

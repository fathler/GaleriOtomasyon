using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galeri;
using Galeri.Entity;
using Galeri.DAL;
using System.Windows.Forms;
namespace GaleriFacade
{
    public class AracFacade
    {
        public int AracEkleSPile(AracEntity eklenecekArac)
        {
            SqlParameter[] Cmd = new SqlParameter[9];
            Cmd[0] = new SqlParameter("aracPlaka", eklenecekArac.AracPlaka);
            Cmd[1] = new SqlParameter("markaID", eklenecekArac.AracMarka);
            Cmd[2] = new SqlParameter("modelID", eklenecekArac.AracModel);
            Cmd[3] = new SqlParameter("aracDurum", eklenecekArac.AracDurum);
            Cmd[4] = new SqlParameter("aracYil", eklenecekArac.AracYil);
            Cmd[5] = new SqlParameter("aracKM", eklenecekArac.AracKm);
            Cmd[6] = new SqlParameter("aracGelisFiyat", eklenecekArac.AracGelisFiyat);
            Cmd[7] = new SqlParameter("aracSatisFiyat", eklenecekArac.AracGelisFiyat);
            Cmd[8] = new SqlParameter("satisDurum", eklenecekArac.AracSatisDurumu);
            int donen = HelperSql.SqlGeriDondurmezWithSp("sp_aracekleme", true, Cmd);
            return donen;
        }
        public /*List<AracEntity>*/ void AracBilgiGetirmeSpile(AracEntity AracIDentity )
        {
            //List<AracEntity> result = new List<AracEntity>();
            AracEntity bilgisigelecekaracentity = new AracEntity();
            //SqlParameter[] ID = new SqlParameter[1];
            //ID[0] = new SqlParameter("AracID",AracIDentity.AracID);
            //SqlDataReader dr = HelperSql.SqlOkuyucuDondurWithSp("sp_birlestirilmisAracGoruntuleme", true,ID);
            //if (dr.HasRows)
            //{
            //    while (dr.Read())
            //    {
            //        bilgisigelecekaracentity.AracPlaka = (dr["aracPlaka"].ToString());
            //        bilgisigelecekaracentity.AracMarka = int.Parse(dr["markaID"].ToString());
            //        bilgisigelecekaracentity.AracModel = int.Parse(dr["modelID"].ToString());
            //        bilgisigelecekaracentity.AracDurum = (dr["aracDurum"].ToString());
            //        bilgisigelecekaracentity.AracYil = (dr["aracYil"].ToString());
            //        bilgisigelecekaracentity.AracKm = (dr["aracKM"].ToString());
            //        bilgisigelecekaracentity.AracGelisFiyat = Convert.ToDecimal(dr["aracGelisFiyat"]);
            //        bilgisigelecekaracentity.AracSatisFiyat = Convert.ToDecimal(dr["aracSatisFiyat"]);
            //        bilgisigelecekaracentity.AracSatisDurumu = Convert.ToBoolean(dr["satisDurum"]);
            //        bilgisigelecekaracentity.resimID = int.Parse(dr["resimID"].ToString());
            //        //result.Add(bilgisigelecekaracentity);
            //    }
            //    dr.Close();
            //    return ;
            }
            }
            
            

            //SqlParameter[] Cmd = new SqlParameter[1];
            //Cmd[0]= new SqlParameter()
            //Cmd[0] = new SqlParameter("aracPlaka", bilgisigelecekaracentity.AracPlaka);
            //Cmd[1] = new SqlParameter("markaID", bilgisigelecekaracentity.AracMarka);
            //Cmd[2] = new SqlParameter("modelID", bilgisigelecekaracentity.AracModel);
            //Cmd[3] = new SqlParameter("aracDurum", bilgisigelecekaracentity.AracDurum);
            //Cmd[4] = new SqlParameter("aracYil", bilgisigelecekaracentity.AracYil);
            //Cmd[5] = new SqlParameter("aracKM", bilgisigelecekaracentity.AracKm);
            //Cmd[6] = new SqlParameter("aracGelisFiyat", bilgisigelecekaracentity.AracGelisFiyat);
            //Cmd[7] = new SqlParameter("aracSatisFiyat", bilgisigelecekaracentity.AracGelisFiyat);
            //Cmd[8] = new SqlParameter("satisDurum", bilgisigelecekaracentity.AracSatisDurumu);
            //Cmd[9] = new SqlParameter("resim", bilgisigelecekaracentity.resimID);
            //SqlDataReader sqlDataReader = HelperSql.SqlOkuyucuDondurWithSp("sp_birlestirilmisAracGoruntuleme", true, Cmd);
            //return sqlDataReader;
        }
    //public int AracGuncellemeSp(AracEntity guncellenecekAracentity )
    //{
    //    SqlParameter[] sqlParameters = new SqlParameter[9];
    //    sqlParameters[0] = new SqlParameter("aracPlaka", guncellenecekAracentity.AracPlaka);
    //    sqlParameters[1] = new SqlParameter("markaID", guncellenecekAracentity.AracMarka);
    //    sqlParameters[2] = new SqlParameter("modelID", guncellenecekAracentity.AracModel);
    //    sqlParameters[3] = new SqlParameter("aracDurum", guncellenecekAracentity.AracDurum);
    //    sqlParameters[4] = new SqlParameter("aracYil", guncellenecekAracentity.AracYil);
    //    sqlParameters[5] = new SqlParameter("aracKM", guncellenecekAracentity.AracKm);
    //    sqlParameters[6] = new SqlParameter("aracGelisFiyat", guncellenecekAracentity.AracGelisFiyat);
    //    sqlParameters[7] = new SqlParameter("aracSatisFiyat", guncellenecekAracentity.AracGelisFiyat);
    //    sqlParameters[8] = new SqlParameter("satisDurum", guncellenecekAracentity.AracSatisDurumu);
    //    int gelen = HelperSql.SqlGeriDondurmezWithSp("sp_aracguncelleme", true, sqlParameters);
    //    return gelen;
    

        

        //public int AracMarkaComboDoldurmaSpile()
        //{
        //    SqlDataReader Okuyucu1 = HelperSql.SqlOkuyucuDondurWithSp("sp_AracModelTablosuDoldurma", true, prm);
        //}

        //public int AracGuncellemeSpİle(AracEntity guncellenecekArac)
        //{
        //    int donen = 0;
        //}
    

 

    
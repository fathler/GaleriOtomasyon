using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galeri;
namespace Galeri.DAL
{
        public static class HelperSql
        {
            //SqlConnection
            public static SqlConnection getSqlConnection()
            {
                //Geriye SqlConnection Tipinden Nesne döndürecek
                return new SqlConnection(Tools.CnnStrng);

            }

            //SqlCommand, nesnesi hazırlıyoruz
            public static SqlCommand getSqlCommand(string spName, bool spOK, SqlParameter[] cmdParams)
            {
                SqlCommand Cmd = new SqlCommand(spName, getSqlConnection());

                if (spOK)
                {
                    Cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    Cmd.CommandType = System.Data.CommandType.Text;
                }

                if (cmdParams != null)
                {
                    Cmd.Parameters.AddRange(cmdParams);
                }
                return Cmd;
            }

            //SqlCommand, ExecuteNonQuery
            public static int SqlGeriDondurmezWithSp(string spName, bool spOk4, SqlParameter[] cmdParams)
            {
                SqlCommand cmd = getSqlCommand(spName, spOk4, cmdParams);
                cmd.Connection.Open();
                int ess = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return ess;
            }


            //SqlCommand, ExecuteScalar
            public static object SqlNesneDondurWithSP(string spName, bool spOk1, SqlParameter[] cmdParams)
            {

                SqlCommand cmd = getSqlCommand(spName, spOk1, cmdParams);
                cmd.Connection.Open();
                object donenDeger = cmd.ExecuteScalar();
                cmd.Connection.Close();
                return donenDeger;
            }

            //SqlDataReader -- SqlCommand, ExecuteReader
            public static SqlDataReader SqlOkuyucuDondurWithSp(string spName, bool spOk2,SqlParameter[] cmdParams)
            {

                SqlCommand cmd = getSqlCommand(spName, spOk2,cmdParams);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                return rd;
                cmd.Connection.Close();
        }

        //public static SqlDataReader SqlOkuyucuDondurWithSp(string v1, bool v2, SqlParameter a)
        //{
        //    throw new NotImplementedException();
        //}
    }
    }



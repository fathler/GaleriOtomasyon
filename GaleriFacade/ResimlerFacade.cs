using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galeri;
using Galeri.Entity;
using Galeri.DAL;
using GaleriFacade;
using System.Data.SqlClient;
namespace GaleriFacade
{
    public class ResimlerFacade
    {
        public int ResimEklemeSpile(ResimlerEntity resimentit)
        {
            SqlParameter[] Cmd = new SqlParameter[1];
             Cmd[0] = new SqlParameter("resim",resimentit.resim);

            int donen = HelperSql.SqlGeriDondurmezWithSp("sp_fotoekleme", true, Cmd);
            return donen;
        }
        //public int ResimGoruntulemeSpile()
    }

}

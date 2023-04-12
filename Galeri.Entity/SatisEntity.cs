using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entity
{
    public class SatisEntity
    {
        public int SatisID { get; set; }
        public DateTime SatisTarih { get; set; }
        public decimal SatisBedeli { get; set; }
        public int PersonelTC { get; set; }
        public int MusteriTC { get; set; }
        public string AracPlaka { get; set; }


    }
}

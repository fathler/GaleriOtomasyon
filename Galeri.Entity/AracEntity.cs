using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entity
{
    public class AracEntity
    {
        public int AracID { get; set; } 
        public string AracPlaka { get; set; }
        public int AracMarka { get; set; }
        public int AracModel { get; set; }
        public string AracDurum { get; set; }
        public string AracYil { get; set; }
        public string AracKm { get; set; }
        public decimal AracGelisFiyat { get; set; }
        public decimal AracSatisFiyat { get; set; }
        public  bool AracSatisDurumu { get; set; }
        public int resimID { get; set; }    
    }
}

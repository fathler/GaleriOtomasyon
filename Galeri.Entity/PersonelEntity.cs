using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entity
{
    public class PersonelEntity
    {
        public int PersonelID { get; set; }
        public string PersonelTC { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelTEL { get; set; }
        public string PersonelAdres { get; set; }
        public decimal  PersonelMaas { get; set; }
        public DateTime iseGirisTarihi { get; set; }
        public DateTime istenAyrilmaTarihi { get; set; }

    }
}

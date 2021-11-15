using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Birimler
    {
        public int BirimID { get; set; }
        public string BirimAdi { get; set; }
        public int UstBirimKodu { get; set; }
        public string BulunduguAdres { get; set; }
        public string PostaKodu { get; set; }
        public string BirimMudurKullaniciAdi { get; set; }
    }
}

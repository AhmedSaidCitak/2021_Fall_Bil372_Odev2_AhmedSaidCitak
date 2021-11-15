using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Personel
    {
        [Key]
        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SicilNo { get; set; }
        public int Cep { get; set; }
        public string EvAdresi { get; set; }
        public int PostaKodu { get; set; }
        public string UstKullaniciAdi { get; set; }

    }
}

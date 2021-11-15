using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Kullanici
    {
        [Key]
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Problem
    {
        public int ProblemID { get; set; }
        public string ProblemTanimi { get; set; }
        public string ProblemiTanimlayiciAdi { get; set; }
        public string ProblemiTanimlayiciSoyadi { get; set; }
        public int ProblemiTanimlayanTCnoPasaportno { get; set; }
        public string HedefAmacTanimi { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Pole
    {
        public int Broj { get; set; }
        public string Slika { get; set; }
        public Pole(int broj,string slika)
        {
            Broj = broj;
            Slika = slika;
        }
    }
}

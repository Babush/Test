using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Pole
    {
        public int Broj { get; set; }
        public Image Slika { get; set; }
        public Pole(int broj,Image slika)
        {
            Broj = broj;
            Slika = slika;
        }
    }
}

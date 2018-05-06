using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Poslovnica
    {
        private Menager menager;
        private string adresa;
        private List<Uposlenik> uposleni;

        public Menager Menager
        {
            get { return menager; }
            set { menager = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public List<Uposlenik> Uposleni
        {
            get { return uposleni; }
            set { uposleni = value; }
        }
    }
}

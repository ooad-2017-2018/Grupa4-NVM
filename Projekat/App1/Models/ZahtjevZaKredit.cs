using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
   public  class ZahtjevZaKredit
    {
        private double glavnica;
        private Klijent klijent;
        private int brRata;
        private string valuta;


        public double Glavnica
        {
            get { return glavnica; }
            set { glavnica = value; }
        }
        public Klijent Klijent
        {
            get { return klijent; }
            set { klijent = value; }
        }
        public int BrRata
        {
            get { return brRata; }
            set { brRata = value; }
        }
        public String Valuta
        {
            get { return valuta; }
            set { valuta = value; }
        }
    }
}

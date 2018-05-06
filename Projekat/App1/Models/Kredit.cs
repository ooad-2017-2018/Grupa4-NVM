using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Kredit : ZahtjevZaKredit
    {
        private Uposlenik uposlenik;
        private double vratitiNovca;
        private double iznosKamate;
        private DateTime danDizanja;
        private DateTime danVracanja;

        public Uposlenik Uposlenik
        {
            get { return uposlenik; }
            set { uposlenik = value; }
        }
        public double VratitiNovca
        {
            get { return vratitiNovca; }
            set { vratitiNovca = value; }
        }
        public double IznosKamate
        {
            get { return iznosKamate; }
            set { iznosKamate = value; }
        }

        public DateTime DanVracanja
        {
            get { return danVracanja; }
            set { danVracanja = value; }
        }
     
        public DateTime DanDizanja
  
        {
            get { return danDizanja; }
            set { danDizanja = value; }
        }




    }
}

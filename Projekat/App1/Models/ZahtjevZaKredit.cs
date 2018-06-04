using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
   public  class ZahtjevZaKredit :INotifyPropertyChanged
    {
        private double glavnica;
        private Klijent klijent;
        private string idklijenta;
        private int brRata;
        private string valuta;

        public event PropertyChangedEventHandler PropertyChanged;
        public ZahtjevZaKredit()
        {

        }
        public ZahtjevZaKredit(double g, string idk, int brr, string v)
        {
            glavnica = g;
            idklijenta = idk;
            brRata = brr;
            valuta = v;
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

      

        public double Glavnica
        {
            get { return glavnica; }
            //set { glavnica = value; }
            set { glavnica = value; OnPropertyChanged("Glavnica"); }
        }
        public Klijent Klijent
        {
            get { return klijent; }
            //set { klijent = value; }
            set { klijent = value; OnPropertyChanged("Klijent"); }
        }
        public int BrRata
        {
            get { return brRata; }
          //  set { brRata = value; }
            set { brRata = value; OnPropertyChanged("BrRata"); }
        }
        public String Valuta
        {
            get { return valuta; }
           // set { valuta = value; }
            set { valuta = value; OnPropertyChanged("Valuta"); }
        }
    }
}

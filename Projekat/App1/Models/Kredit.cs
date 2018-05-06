using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Kredit : ZahtjevZaKredit, INotifyPropertyChanged
    {
        private Uposlenik uposlenik;
        private double vratitiNovca;
        private double iznosKamate;
        private DateTime danDizanja;
        private DateTime danVracanja;

        public Uposlenik Uposlenik
        {
            get { return uposlenik; }
            set { uposlenik = value; OnPropertyChanged("Uposlenik"); }
        }
        public double VratitiNovca
        {
            get { return vratitiNovca; }
            set { vratitiNovca = value; OnPropertyChanged("VratitiNovca"); }
        }
        public double IznosKamate
        {
            get { return iznosKamate; }
         
            set { iznosKamate = value; OnPropertyChanged("IznosKamate"); }

        }

        public DateTime DanVracanja
        {
            get { return danVracanja; }
            set { danVracanja = value; OnPropertyChanged("DanVracanja"); }
        }
     
        public DateTime DanDizanja
  
        {
            get { return danDizanja; }
            set { danDizanja = value; OnPropertyChanged("DanDizanja"); }
        }





        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }




    }
}

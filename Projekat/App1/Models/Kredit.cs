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
        private string idklijenta;
        private string idzaposlenika;
        private double vratitiNovca;
        private double iznosKamate;
        private DateTime danDizanja;
        private DateTime danVracanja;
        public Kredit()
        {

        }
        public Kredit(double vn, double ik, string idk, string idz, DateTime dd, DateTime dv)
        {
            vratitiNovca = vn; iznosKamate = ik;
            idklijenta = idk; Idzaposlenika = idz;
            danDizanja = dd; danVracanja = dv;

        }
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

        public string Idklijenta { get => idklijenta; set => idklijenta = value; }
        public string Idzaposlenika { get => idzaposlenika; set => idzaposlenika = value; }

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

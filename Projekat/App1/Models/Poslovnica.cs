using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Poslovnica : INotifyPropertyChanged
    {
        private Menager menager;
        private string adresa;
        private List<Uposlenik> uposleni;
      public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Menager Menager
        {
            get { return menager; }
            set { menager = value; OnPropertyChanged("Menager"); }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public List<Uposlenik> Uposleni
        {
            get { return uposleni; }
           // set { uposleni = value; }
            set { uposleni = value; OnPropertyChanged("Uposleni"); }
        }
    }
}

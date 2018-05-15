using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Uposlenik : Osoba, INotifyPropertyChanged
    {
        List<Kredit> krediti;
        public event PropertyChangedEventHandler PropertyChanged;
        public Uposlenik(string ime, string prezime, int jMBG, string brTel, string adresa) : base(ime, prezime, jMBG, brTel, adresa)
        {

        }
        public Uposlenik()
        {

        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
      
        public List<Kredit> Krediti
        {
            get { return krediti; }
            //set { krediti = value; }
            set { krediti = value; OnPropertyChanged("Krediti"); }
        }
    }
}

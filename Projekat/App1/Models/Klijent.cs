using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace App1
{
   public class Klijent : Osoba, INotifyPropertyChanged
    {
        private Kredit kredit;
        private double plata;
        private BitmapImage slika;
        public Kredit Kredit
        {
            get { return kredit; }
            set { kredit = value; OnPropertyChanged("Kredit"); }
        }

        public double Plata
        {
            get { return plata; }
            set { plata = value; OnPropertyChanged("Plata"); }
        }

        public BitmapImage Slika
        {
            get { return slika; }
            set { slika = value; OnPropertyChanged("Slika"); }
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

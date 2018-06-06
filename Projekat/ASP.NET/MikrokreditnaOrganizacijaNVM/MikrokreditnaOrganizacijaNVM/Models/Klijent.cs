using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MikrokreditnaOrganizacijaNVM.Models
{
    public class Klijent : Osoba
    {
        private Kredit kredit;
        private double plata;
        //private BitmapImage slika;
        public Klijent(string ime, string prezime, string jMBG, string brTel, string adresa, double p, string un, string pass) : base(ime, prezime, jMBG, brTel, adresa, un, pass)
        {
            plata = p;
        }
        public Klijent()
        {

        }
        public Kredit Kredit
        {
            get { return kredit; }
            set { kredit = value; /*OnPropertyChanged("Kredit");*/ }
        }

        public double Plata
        {
            get { return plata; }
            set { plata = value; /*OnPropertyChanged("Plata"); */}
        }

        /*public BitmapImage Slika
        {
            get { return slika; }
            set { slika = value; OnPropertyChanged("Slika"); }
        }*/



        /*public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/

        public string ispisiKlijenta()
        {
            string s = "";
            s += Ime + " " + Prezime + " " + JMBG + " " + Adresa + " " + BrTel + " " + Username + " " + Password;
            return s;
        }

    }
}
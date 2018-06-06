using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MikrokreditnaOrganizacijaNVM.Models
{
    public class Uposlenik : Osoba
    {
        List<Kredit> krediti;
        //public event PropertyChangedEventHandler PropertyChanged;
        public Uposlenik(string ime, string prezime, string jMBG, string brTel, string adresa, string un, string pass) : base(ime, prezime, jMBG, brTel, adresa, un, pass)
        {

        }
        public Uposlenik()
        {

        }
        /*protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/

        public List<Kredit> Krediti
        {
            get { return krediti; }
            //set { krediti = value; }
            set { krediti = value; /*OnPropertyChanged("Krediti");*/ }
        }
    }
}
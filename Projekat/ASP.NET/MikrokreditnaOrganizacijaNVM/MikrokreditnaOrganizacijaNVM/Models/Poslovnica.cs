using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MikrokreditnaOrganizacijaNVM.Models
{
    public class Poslovnica// : INotifyPropertyChanged
    {
        private Manager menager;
        private string adresa;
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private string poslovnicaID;
        private List<Uposlenik> uposleni;
        //public event PropertyChangedEventHandler PropertyChanged;
        public Poslovnica()
        {

        }
        public Poslovnica(string id, string adr)
        {
            poslovnicaID = id;
            adresa = adr;
        }
        /*protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/
        public Manager Menager
        {
            get { return menager; }
            set { menager = value; /*OnPropertyChanged("Menager"); */}
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public string PoslovnicaID
        {
            get { return poslovnicaID; }
            set { poslovnicaID = value; }
        }
        public List<Uposlenik> Uposleni
        {
            get { return uposleni; }
            // set { uposleni = value; }
            set { uposleni = value; /*OnPropertyChanged("Uposleni");*/ }
        }
    }
}
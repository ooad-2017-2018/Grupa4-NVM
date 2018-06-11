using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MikrokreditnaOrganizacijaNVM.Models
{
    public class ZahtjevZaKredit// : INotifyPropertyChanged
    {
        private int id;
        [Required]
        private double glavnica;
        private Klijent klijent;
        [Required]
        private string idklijenta;
        [Required]
        private int brRata;
        [Required]
        private string valuta;

        //public event PropertyChangedEventHandler PropertyChanged;
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
        /*protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/


        [Required]
        [DisplayName("Glavnica: ")]
        public double Glavnica
        {
            get { return glavnica; }
            //set { glavnica = value; }
            set { glavnica = value;/* OnPropertyChanged("Glavnica");*/ }
        }
        [Required]
        [DisplayName("ID klijenta: ")]
        public Klijent Klijent
        {
            get { return klijent; }
            //set { klijent = value; }
            set { klijent = value; /*OnPropertyChanged("Klijent");*/ }
        }
        [Required]
        [DisplayName("Broj rata: ")]
        public int BrRata
        {
            get { return brRata; }
            //  set { brRata = value; }
            set { brRata = value;/* OnPropertyChanged("BrRata"); */}
        }
        [Required]
        [DisplayName("Valuta: ")]
        public String Valuta
        {
            get { return valuta; }
            // set { valuta = value; }
            set { valuta = value;/* OnPropertyChanged("Valuta");*/ }
        }

        public int Id { get => id; set => id = value; }
    }
}
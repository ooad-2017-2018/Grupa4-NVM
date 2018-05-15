using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Poslovnica : INotifyPropertyChanged
    {
        private Manager menager;
        private string adresa;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int poslovnicaID;
        private List<Uposlenik> uposleni;
        public event PropertyChangedEventHandler PropertyChanged;
        public Poslovnica()
        {

        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Manager Menager
        {
            get { return menager; }
            set { menager = value; OnPropertyChanged("Menager"); }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public int PoslovnicaID
        {
            get { return poslovnicaID; }
            set { poslovnicaID = value; }
        }
        public List<Uposlenik> Uposleni
        {
            get { return uposleni; }
           // set { uposleni = value; }
            set { uposleni = value; OnPropertyChanged("Uposleni"); }
        }
    }
}

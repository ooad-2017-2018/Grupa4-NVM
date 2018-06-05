using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class TabelaZahtjev
    {
        private double glavnica;
        private int brojRata;
        private string idKlijenta;
        private string valuta;
        private string id;
        public double Glavnica
        {
            get { return glavnica; }
            set { glavnica = value; }
        }
        public int BrojRata
        {
            get { return brojRata; }
            set { brojRata = value; }
        }
        public string IdKlijenta
        {
            get { return idKlijenta; }
            set { idKlijenta = value; }
        }
        public string Valuta
        {
            get { return valuta; }
            set { valuta = value; }
        }

        public string Id { get => id; set => id = value; }
    }
}

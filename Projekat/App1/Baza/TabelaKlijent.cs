using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class TabelaKlijent
    {
        public TabelaKlijent(string id, string ime, string prezime, string adresa, string brTel, double plata, string username, string password)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.brTel = brTel;
            this.plata = plata;
            this.username = username;
            this.password = password;
        }
        public TabelaKlijent()
        {

        }
        public string id
        {
            get;
            set;
        }
        public string ime
        {
            get;
            set;
        }
        public string prezime
        {
            get;
            set;
        }
        public string adresa
        {
            get;
            set;
        }
        public string brTel
        {
            get;
            set;
        }
        public double plata
        {
            get;
            set;
        }
        public string username
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
    }
}

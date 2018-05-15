using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
   public class Manager : Osoba
    {
        public Manager()
        {

        }
        public Manager(string ime, string prezime, int jMBG, string brTel, string adresa) : base(ime, prezime, jMBG, brTel, adresa)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Uposlenik : Osoba
    {
        List<Kredit> krediti;
        public List<Kredit> Krediti
        {
            get { return krediti; }
            set { krediti = value; }
        }
    }
}

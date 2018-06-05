using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class TabelaKredit
    {
        private double vratitiNovca;
        private double iznosKamate;
        private string idKlijenta;
        private string idUposlenika;
        private DateTime datumDizanja;
        private DateTime datumVracanja;
        private string id;
        public double VratitiNovca
        {
            get { return vratitiNovca; }
            set { vratitiNovca = value; }
        }
        public double IznosKamate
        {
            get { return iznosKamate; }
            set { iznosKamate = value; }
        }
        public string IdKlijenta
        {
            get { return idKlijenta; }
            set { idKlijenta = value; }
        }
        public string IdUposlenika
        {
            get { return idUposlenika; }
            set { idUposlenika = value; }
        }

        public DateTime DatumDizanja { get => datumDizanja; set => datumDizanja = value; }
        public DateTime DatumVracanja { get => datumVracanja; set => datumVracanja = value; }
        public string Id { get => id; set => id = value; }
    }
}

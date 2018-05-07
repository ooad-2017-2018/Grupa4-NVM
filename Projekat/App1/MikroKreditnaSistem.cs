using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App1
{
    public class MikroKreditnaSistem
    {
        #region Atributi
        public List<Klijent> klijenti { get; set; }
        public List<Kredit> krediti { get; set; }
        public List<Menager> menageri { get; set; }
        public List<Poslovnica> poslovnice { get; set; }
        public List<Uposlenik> uposlenici { get; set; }
        public List<ZahtjevZaKredit> zahtjevi { get; set; }
        #endregion

        public MikroKreditnaSistem()
        {
            klijenti = new List<Klijent>();
            krediti = new List<Kredit>();
            menageri = new List<Menager>();
            poslovnice = new List<Poslovnica>();
            uposlenici = new List<Uposlenik>();
            zahtjevi = new List<ZahtjevZaKredit>();
        }

        #region Konstruktor
        public MikroKreditnaSistem(List<Klijent> klijenti, List<Kredit> krediti, List<Menager> menageri, List<Poslovnica> poslovnice, List<Uposlenik> uposlenici, List<ZahtjevZaKredit> zahtjevi)
        {
            this.klijenti = klijenti;
            this.krediti = krediti;
            this.menageri = menageri;
            this.poslovnice = poslovnice;
            this.uposlenici = uposlenici;
            this.zahtjevi = zahtjevi;
        }
        #endregion
    }



}
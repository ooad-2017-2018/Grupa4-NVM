using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App1
{
   public class KlijentKontaktViewModel
    {
        ICommand stanjeKredita;
        ICommand zahtjevZaKredit;
        ICommand nazad;

        public ICommand StanjeKredita
        {
            get
            {
                return stanjeKredita;
            }
            set
            {
                stanjeKredita = value;
            }
        }

        public ICommand Nazad
        {
            get
            {
                return nazad;
            }
            set
            {
                nazad = value;
            }
        }
        public ICommand ZahtjevZaKredit
        {
            get
            {
                return zahtjevZaKredit;
            }
            set
            {
                zahtjevZaKredit = value;
            }
        }


        public Menager Menager { get; set; }
        public MikroKreditnaSistem Sistem { get; set; }
        public ZahtjevZaKredit zahtjev { get; set; }

        public KlijentKontaktViewModel()
        {

            Menager = new Menager();
            Sistem = new MikroKreditnaSistem();
            zahtjev = new ZahtjevZaKredit();

            ZahtjevZaKredit = new RelayCommand<object>(podnesi, boolObrisi);

        }

        public bool boolObrisi(Object o)
        {
            return true;
        }
        public void podnesi(Object o)
        {

            Sistem.zahtjevi.Add(zahtjev);
        }
    }
}

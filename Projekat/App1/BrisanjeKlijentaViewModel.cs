using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;

namespace App1
{
   public class BrisanjeKlijentaViewModel
    {
        ICommand obrisiKlijenta;
        ICommand nazad;

        public ICommand ObrisiKlijenta
        {
            get
            {
                return obrisiKlijenta;
            }
            set
            {
                obrisiKlijenta = value;
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

        public List<Klijent> ListaKlijenata { get; set; }
        public Menager Menager { get; set; }
        public MikroKreditnaSistem Sistem { get; set; }
        public Klijent klijent { get; set; }

        public BrisanjeKlijentaViewModel()
        {
            ListaKlijenata = new List<Klijent>();
            Menager = new Menager();
            Sistem = new MikroKreditnaSistem();
            klijent = new Klijent();

            ObrisiKlijenta = new RelayCommand<object>(brisi, boolObrisi);

        }

        public bool boolObrisi(Object o)
        {
            return true;
        }
        public void brisi(Object o)
        {
            
            for (int i = 0; i < Sistem.klijenti.Count ; i++)
            {
                if (Sistem.klijenti[i].JMBG == klijent.JMBG)
                {
                    Sistem.klijenti.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

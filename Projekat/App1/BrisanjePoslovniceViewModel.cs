using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App1
{
   public class BrisanjePoslovniceViewModel
    {
        ICommand obrisiPoslovnicu;
        ICommand nazad;

        public ICommand ObrisiPoslovnice
        {
            get
            {
                return obrisiPoslovnicu;
            }
            set
            {
                obrisiPoslovnicu = value;
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

        
        public Manager Menager { get; set; }
        public MikroKreditnaSistem Sistem { get; set; }
        public Poslovnica Poslovnica { get; set; }

        public BrisanjePoslovniceViewModel()
        {
            
            Menager = new Manager();
            Sistem = new MikroKreditnaSistem();
            Poslovnica = new Poslovnica();

            ObrisiPoslovnice = new RelayCommand<object>(brisi, boolObrisi);

        }

        public bool boolObrisi(Object o)
        {
            return true;
        }
        public void brisi(Object o)
        {

            for (int i = 0; i < Sistem.poslovnice.Count; i++)
            {
                if (Sistem.poslovnice[i].Adresa == Poslovnica.Adresa)
                {
                    Sistem.poslovnice.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

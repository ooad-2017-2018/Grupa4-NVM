using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App1
{
    public class BrisanjeUposlenikaViewModel
    {
        ICommand obrisiUposlenika;
        ICommand nazad;

        public ICommand ObrisiUposlenika
        {
            get
            {
                return obrisiUposlenika;
            }
            set
            {
                obrisiUposlenika = value;
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


        public Menager Menager { get; set; }
        public MikroKreditnaSistem Sistem { get; set; }
        public Uposlenik Uposlenik { get; set; }

        public BrisanjeUposlenikaViewModel()
        {

            Menager = new Menager();
            Sistem = new MikroKreditnaSistem();
            Uposlenik = new Uposlenik();

            ObrisiUposlenika = new RelayCommand<object>(brisi, boolObrisi);

        }

        public bool boolObrisi(Object o)
        {
            return true;
        }
        public void brisi(Object o)
        {

            for (int i = 0; i < Sistem.uposlenici.Count; i++)
            {
                if (Sistem.uposlenici[i].JMBG == Uposlenik.JMBG)
                {
                    Sistem.uposlenici.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

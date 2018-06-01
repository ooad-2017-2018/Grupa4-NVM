using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Models;
using Microsoft.WindowsAzure.MobileServices;

namespace App1
{
    public class Bazzza
    {
        public static async void registrujKlijenta(string jmbg, string ime, string prezime, string adresa, string brTel, double plata)
        {
            IMobileServiceTable<TabelaKlijent> Klijenti = App.MobileService.GetTable<TabelaKlijent>();
            TabelaKlijent tk = new TabelaKlijent();
            tk.id = jmbg;
            tk.ime = ime;
            tk.prezime = prezime;
            tk.adresa = adresa;
            tk.brTel = brTel;
            tk.plata = plata;
            try
            {
                await Klijenti.InsertAsync(tk);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void registrujUposlenika(string jmbg, string ime, string prezime, string adresa, string brTel)
        {
            IMobileServiceTable<TabelaUposlenik> Uposlenici = App.MobileService.GetTable<TabelaUposlenik>();
            TabelaUposlenik tu = new TabelaUposlenik();
            tu.id = jmbg;
            tu.ime = ime;
            tu.prezime = prezime;
            tu.adresa = adresa;
            tu.brTel = brTel;
            try
            {
                await Uposlenici.InsertAsync(tu);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void registrujManagera(string jmbg, string ime, string prezime, string adresa, string brTel)
        {
            IMobileServiceTable<TabelaManager> Manageri = App.MobileService.GetTable<TabelaManager>();
            TabelaManager tm = new TabelaManager();
            tm.id = jmbg;
            tm.ime = ime;
            tm.prezime = prezime;
            tm.adresa = adresa;
            tm.brTel = brTel;
            try
            {
                await Manageri.InsertAsync(tm);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void registrujZahtjev(double glavnica, string valuta, int brRata, string idKlijenta)
        {
            IMobileServiceTable<TabelaZahtjev> Zahtjevi = App.MobileService.GetTable<TabelaZahtjev>();
            TabelaZahtjev tz = new TabelaZahtjev();
            tz.Glavnica = glavnica;
            tz.Valuta = valuta;
            tz.BrojRata = brRata;
            tz.IdKlijenta = idKlijenta;
            
            try
            {
                await Zahtjevi.InsertAsync(tz);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void registrujKredit(double ostaloVratiti, string idUposlenika, double iznosKamate, string idKlijenta, DateTime dd, DateTime dv)
        {
            IMobileServiceTable<TabelaKredit> Zahtjevi = App.MobileService.GetTable<TabelaKredit>();
            TabelaKredit tkr = new TabelaKredit();
            tkr.VratitiNovca = ostaloVratiti;
            tkr.IdUposlenika = idUposlenika;
            tkr.IznosKamate = iznosKamate;
            tkr.IdKlijenta = idKlijenta;
            tkr.DatumDizanja = dd;
            tkr.DatumVracanja = dv;
            try
            {
                await Zahtjevi.InsertAsync(tkr);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void dajKlijenta()
        {
            try
            {
                IMobileServiceTable<TabelaKlijent> TabelaKlijent = App.MobileService.GetTable<TabelaKlijent>();
                /*IEnumerable<TabelaKlijent> Klijent = await TabelaKlijent.ReadAsync();
                ITotalCountProvider prov = (ITotalCountProvider)Klijent;

                long count = ((ITotalCountProvider)Klijent).TotalCount;
                Debug.WriteLine("Broj upisanih klijenata 1 : " + count.ToString());
                foreach (var element in Klijent)
                {
                    MikroKreditnaGrupaNVM.listaKlijenata.Add(new Klijent(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.plata));
                    
                }*/
                IMobileServiceTableQuery<TabelaKlijent> query = TabelaKlijent.Where(p => p.plata >= 0).IncludeTotalCount();
                IEnumerable<TabelaKlijent> Klijenti = await query.ToEnumerableAsync();
                ITotalCountProvider prov2 = (ITotalCountProvider)Klijenti;

                long count2 = ((ITotalCountProvider)Klijenti).TotalCount;
                Debug.WriteLine("Broj upisanih klijenata 2 : " + count2.ToString());
                foreach (var element in Klijenti)
                {
                    //return new Klijent(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.plata);
                    MikroKreditnaGrupaNVM.listaKlijenata.Add(new Klijent(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.plata));
                    Klijent k = new Klijent(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.plata);
                    Debug.WriteLine("Broj upisanih klijenata : " + k.ispisiKlijenta());

                }
                var films = await (from a in TabelaKlijent select a).ToListAsync();
                foreach (TabelaKlijent film in films)
                {
                    MikroKreditnaGrupaNVM.listaKlijenata.Add(new Klijent(film.ime,film.prezime, film.id,film.brTel,film.adresa,film.plata));
                }
            }
            catch (Exception e)
            {
                throw;
            }


            //return new Klijent(); // nece se nikada izvrsiti


        }
    }
}

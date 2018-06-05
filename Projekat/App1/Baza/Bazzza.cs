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
        public static async void dajKlijente()
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaKlijent>();
                var listatmp = await lista.ToListAsync();
                Debug.WriteLine("Broj dobavljenih : "+listatmp.Count());
                MikroKreditnaGrupaNVM.listaKlijenata.Clear();
                foreach (var element in listatmp)
                {

                    MikroKreditnaGrupaNVM.listaKlijenata.Add(new Klijent(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.plata));
                    Klijent k = new Klijent(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.plata);
                    Debug.WriteLine("Broj upisanih klijenata : " + k.ispisiKlijenta());
                }
                Debug.WriteLine("Broj upisanih klijenata : " + MikroKreditnaGrupaNVM.listaKlijenata.Count());
            }
            catch (Exception e)
            {
                throw;
            }

        }
        public static async void dajKredite()
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaKredit>();
                var listatmp = await lista.ToListAsync();
                Debug.WriteLine("Broj dobavljenih : " + listatmp.Count());
                foreach (var element in listatmp)
                {
                    MikroKreditnaGrupaNVM.listaKredita.Add(new Kredit(element.VratitiNovca, element.IznosKamate, element.IdKlijenta, element.IdUposlenika, element.DatumDizanja, element.DatumVracanja));
                }

            }
            catch (Exception e)
            {
                throw;
            }

        }
        public static async void dajUposlene()
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaUposlenik>();
                var listatmp = await lista.ToListAsync();
                Debug.WriteLine("Broj dobavljenih : " + listatmp.Count());
                MikroKreditnaGrupaNVM.listaUposlenika.Clear();
                foreach (var element in listatmp)
                {
                    MikroKreditnaGrupaNVM.listaUposlenika.Add(new Uposlenik(element.ime, element.prezime, element.id, element.brTel, element.adresa));
                }

            }
            catch (Exception e)
            {
                throw;
            }

        }
        public static async void dajManagere()
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaManager>();
                var listatmp = await lista.ToListAsync();
                Debug.WriteLine("Broj dobavljenih : " + listatmp.Count());
                MikroKreditnaGrupaNVM.listaManagera.Count();
                foreach (var element in listatmp)
                {
                    MikroKreditnaGrupaNVM.listaManagera.Add(new Manager(element.ime, element.prezime, element.id, element.brTel, element.adresa));
                }

            }
            catch (Exception e)
            {
                throw;
            }

        }
        public static async void dajZahtjeve()
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaZahtjev>();
                var listatmp = await lista.ToListAsync();
                Debug.WriteLine("Broj dobavljenih : " + listatmp.Count());
                foreach (var element in listatmp)
                {
                    MikroKreditnaGrupaNVM.listaZahtjeva.Add(new ZahtjevZaKredit(element.Glavnica, element.IdKlijenta, element.BrojRata, element.Valuta));
                }

            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}

﻿using System;
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
        private static Bazzza instance = new Bazzza();
        private Bazzza() { }
        public static Bazzza dajBazu(){
            return instance;
        }
        public static async void registrujKlijenta(string jmbg, string ime, string prezime, string adresa, string brTel, double plata, string un, string pass)
        {
            IMobileServiceTable<TabelaKlijent> Klijenti = App.MobileService.GetTable<TabelaKlijent>();
            TabelaKlijent tk = new TabelaKlijent();
            tk.id = jmbg;
            tk.ime = ime;
            tk.prezime = prezime;
            tk.adresa = adresa;
            tk.brTel = brTel;
            tk.plata = plata;
            tk.username = un;
            tk.password = pass;
            try
            {
                await Klijenti.InsertAsync(tk);
              
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void registrujUposlenika(string jmbg, string ime, string prezime, string adresa, string brTel, string un, string pass)
        {
            IMobileServiceTable<TabelaUposlenik> Uposlenici = App.MobileService.GetTable<TabelaUposlenik>();
            TabelaUposlenik tu = new TabelaUposlenik();
            tu.id = jmbg;
            tu.ime = ime;
            tu.prezime = prezime;
            tu.adresa = adresa;
            tu.brTel = brTel;
            tu.username = un;
            tu.password = pass;
            try
            {
                await Uposlenici.InsertAsync(tu);
            }
            catch (Exception e)
            {
                throw;
            }
        }
        public static async void registrujManagera(string jmbg, string ime, string prezime, string adresa, string brTel, string un, string pass)
        {
            IMobileServiceTable<TabelaManager> Manageri = App.MobileService.GetTable<TabelaManager>();
            TabelaManager tm = new TabelaManager();
            tm.id = jmbg;
            tm.ime = ime;
            tm.prezime = prezime;
            tm.adresa = adresa;
            tm.brTel = brTel;
            tm.username = un;
            tm.password = pass;
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
        public static async void registrujPoslovnicu(string id, string adresa)
        {
            IMobileServiceTable<TabelaPoslovnica> Poslovnice = App.MobileService.GetTable<TabelaPoslovnica>();
            TabelaPoslovnica tz = new TabelaPoslovnica();
            tz.id = id;
            tz.adresa = adresa;

            try
            {
                await Poslovnice.InsertAsync(tz);
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

                    MikroKreditnaGrupaNVM.listaKlijenata.Add(new Klijent(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.plata,element.username,element.password));
                    
                }
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
                MikroKreditnaGrupaNVM.listaUposlenika.Clear();
                var lista = App.MobileService.GetTable<TabelaUposlenik>();
                var listatmp = await lista.ToListAsync();
                Debug.WriteLine("Broj dobavljenih : " + listatmp.Count());
                MikroKreditnaGrupaNVM.listaUposlenika.Clear();
                foreach (var element in listatmp)
                {
                    MikroKreditnaGrupaNVM.listaUposlenika.Add(new Uposlenik(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.username, element.password));
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
                MikroKreditnaGrupaNVM.listaManagera.Clear();
                var lista = App.MobileService.GetTable<TabelaManager>();
                var listatmp = await lista.ToListAsync();
                Debug.WriteLine("Broj dobavljenih : " + listatmp.Count());
                MikroKreditnaGrupaNVM.listaManagera.Count();
                foreach (var element in listatmp)
                {
                    MikroKreditnaGrupaNVM.listaManagera.Add(new Manager(element.ime, element.prezime, element.id, element.brTel, element.adresa, element.username, element.password));
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
        public static async void dajPoslovnice()
        {
            try
            {
                MikroKreditnaGrupaNVM.listaPoslovnica.Clear();
                var lista = App.MobileService.GetTable<TabelaPoslovnica>();
                var listatmp = await lista.ToListAsync();
                foreach (var element in listatmp)
                {
                    MikroKreditnaGrupaNVM.listaPoslovnica.Add(new Poslovnica(element.id, element.adresa));
                }

            }
            catch (Exception e)
            {
                throw;
            }

        }
        public static async void obrisiKlijenta(string p)
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaKlijent>();
                var listatmp = await lista.ToListAsync();
                TabelaKlijent tk = listatmp.Find(x => x.username.Equals(p));
                /*foreach (var element in listatmp)
                {
                    if (element.username.Equals(p))
                    {
                        await lista.DeleteAsync(element);
                    }
                }*/
                await lista.DeleteAsync(tk);
            }
            catch(Exception e)
            {
                Debug.WriteLine("Greska");
                throw;
            }

        }
        public static async void obrisiUposlenika(string p)
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaUposlenik>();
                var listatmp = await lista.ToListAsync();
                TabelaUposlenik tk = listatmp.Find(x => x.username.Equals(p));
                await lista.DeleteAsync(tk);
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("Greska");
                throw;
            }

        }
        public static async void obrisiManagera(string p)
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaManager>();
                var listatmp = await lista.ToListAsync();
                TabelaManager tk = listatmp.Find(x => x.username.Equals(p));
                await lista.DeleteAsync(tk);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Greska");
                throw;
            }

        }
        public static async void obrisiZahtjev(string p)
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaZahtjev>();
                var listatmp = await lista.ToListAsync();
                TabelaZahtjev tk = listatmp.Find(x => x.Id.Equals(p));
                await lista.DeleteAsync(tk);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Greska");
                throw;
            }

        }
        public static async void obrisiKredit(string p)
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaKredit>();
                var listatmp = await lista.ToListAsync();
                TabelaKredit tk = listatmp.Find(x => x.Id.Equals(p));
                await lista.DeleteAsync(tk);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Greska");
                throw;
            }

        }
        public static async void obrisiPoslovnicu(string p)
        {
            try
            {
                var lista = App.MobileService.GetTable<TabelaPoslovnica>();
                var listatmp = await lista.ToListAsync();
                TabelaPoslovnica tk = listatmp.Find(x => x.id.Equals(p));
                await lista.DeleteAsync(tk);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Greska");
                throw;
            }

        }
    }
}

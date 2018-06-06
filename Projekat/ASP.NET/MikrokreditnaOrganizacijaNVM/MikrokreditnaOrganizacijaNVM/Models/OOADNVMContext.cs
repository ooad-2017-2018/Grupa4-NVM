using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace MikrokreditnaOrganizacijaNVM.Models
{
    public class OOADNVMContext : DbContext
    {
        public OOADNVMContext() : base("AzureConnection") //AzureConnection je naziv connection stringa u Web.config-u
        {

        }        
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka 
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Uposlenik> Uposlenici { get; set; }
        public DbSet<Manager> Manageri { get; set; }
        public DbSet<Kredit> Krediti { get; set; }
        public DbSet<ZahtjevZaKredit> Zahtjevi { get; set; }
        public DbSet<Poslovnica> Poslovnice { get; set; }

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        } 
    }
}
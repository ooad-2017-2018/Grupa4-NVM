using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using System.IO;
using Windows.Storage;


namespace App1
{
    class MikroKreditNVMContext : DbContext
    {
        public DbSet<Klijent> Klijenti { get; set; }
        public DbSet<Uposlenik> Uposlenici { get; set; }
        public DbSet<Manager> Manageri { get; set; }
        public DbSet<Kredit> Krediti { get; set; }
        public DbSet<ZahtjevZaKredit> Zahtjevi { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databaseFilePath = "NVMBaza.db";
            try
            {
                //za tačnu putanju gdje se nalazi baza uraditi ovdje debug i procitati Path
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path,
                databaseFilePath);
                
            }
            catch (InvalidOperationException) { }
            //Sqlite baza
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //jedno od polja je image da se zna šta je zapravo predstavlja byte[]
            modelBuilder.Entity<Klijent>().Property(p => p.Slika).HasColumnType("image");
        }*/


    }
}

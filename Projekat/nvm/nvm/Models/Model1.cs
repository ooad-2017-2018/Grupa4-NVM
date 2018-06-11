namespace nvm.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Manager> Manager { get; set; }
        public virtual DbSet<Poslovnica> Poslovnica { get; set; }
        public virtual DbSet<Uposlenik> Uposlenik { get; set; }
        public virtual DbSet<ZahtjevZaKredit> ZahtjevZaKredit { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klijent>()
                .HasMany(e => e.ZahtjevZaKredit1)
                .WithRequired(e => e.Klijent1)
                .HasForeignKey(e => e.Klijent_Id);

            modelBuilder.Entity<Manager>()
                .HasMany(e => e.Poslovnica)
                .WithOptional(e => e.Manager)
                .HasForeignKey(e => e.Menager_Id);

            modelBuilder.Entity<Poslovnica>()
                .HasMany(e => e.Uposlenik)
                .WithOptional(e => e.Poslovnica)
                .HasForeignKey(e => e.Poslovnica_Id);

            modelBuilder.Entity<Uposlenik>()
                .HasMany(e => e.ZahtjevZaKredit)
                .WithOptional(e => e.Uposlenik)
                .HasForeignKey(e => e.Uposlenik_Id);

            modelBuilder.Entity<ZahtjevZaKredit>()
                .HasMany(e => e.Klijent)
                .WithOptional(e => e.ZahtjevZaKredit)
                .HasForeignKey(e => e.Kredit_Id);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}

namespace MikrokreditnaOrganizacijaNVM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Klijent",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plata = c.Double(nullable: false),
                        fourSqaureId = c.String(),
                        Ime = c.String(),
                        Prezime = c.String(),
                        JMBG = c.String(),
                        BrTel = c.String(),
                        Adresa = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Kredit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ZahtjevZaKredit", t => t.Kredit_Id)
                .Index(t => t.Kredit_Id);
            
            CreateTable(
                "dbo.ZahtjevZaKredit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Glavnica = c.Double(nullable: false),
                        BrRata = c.Int(nullable: false),
                        Valuta = c.String(),
                        VratitiNovca = c.Double(),
                        IznosKamate = c.Double(),
                        DanVracanja = c.DateTime(),
                        DanDizanja = c.DateTime(),
                        Idklijenta = c.String(),
                        Idzaposlenika = c.String(),
                        Id1 = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Uposlenik_Id = c.Int(),
                        Klijent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uposlenik", t => t.Uposlenik_Id)
                .ForeignKey("dbo.Klijent", t => t.Klijent_Id)
                .Index(t => t.Uposlenik_Id)
                .Index(t => t.Klijent_Id);
            
            CreateTable(
                "dbo.Uposlenik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fourSqaureId = c.String(),
                        Ime = c.String(),
                        Prezime = c.String(),
                        JMBG = c.String(),
                        BrTel = c.String(),
                        Adresa = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Poslovnica_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Poslovnica", t => t.Poslovnica_Id)
                .Index(t => t.Poslovnica_Id);
            
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fourSqaureId = c.String(),
                        Ime = c.String(),
                        Prezime = c.String(),
                        JMBG = c.String(),
                        BrTel = c.String(),
                        Adresa = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Poslovnica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adresa = c.String(),
                        PoslovnicaID = c.String(),
                        Menager_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Manager", t => t.Menager_Id)
                .Index(t => t.Menager_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ZahtjevZaKredit", "Klijent_Id", "dbo.Klijent");
            DropForeignKey("dbo.Uposlenik", "Poslovnica_Id", "dbo.Poslovnica");
            DropForeignKey("dbo.Poslovnica", "Menager_Id", "dbo.Manager");
            DropForeignKey("dbo.Klijent", "Kredit_Id", "dbo.ZahtjevZaKredit");
            DropForeignKey("dbo.ZahtjevZaKredit", "Uposlenik_Id", "dbo.Uposlenik");
            DropIndex("dbo.Poslovnica", new[] { "Menager_Id" });
            DropIndex("dbo.Uposlenik", new[] { "Poslovnica_Id" });
            DropIndex("dbo.ZahtjevZaKredit", new[] { "Klijent_Id" });
            DropIndex("dbo.ZahtjevZaKredit", new[] { "Uposlenik_Id" });
            DropIndex("dbo.Klijent", new[] { "Kredit_Id" });
            DropTable("dbo.Poslovnica");
            DropTable("dbo.Manager");
            DropTable("dbo.Uposlenik");
            DropTable("dbo.ZahtjevZaKredit");
            DropTable("dbo.Klijent");
        }
    }
}

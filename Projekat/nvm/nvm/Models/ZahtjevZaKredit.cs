namespace nvm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZahtjevZaKredit")]
    public partial class ZahtjevZaKredit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ZahtjevZaKredit()
        {
            Klijent = new HashSet<Klijent>();
        }

        public int Id { get; set; }

        public double Glavnica { get; set; }

        public int BrRata { get; set; }

        [Required]
        public string Valuta { get; set; }

        public double? VratitiNovca { get; set; }

        public double? IznosKamate { get; set; }

        public DateTime? DanVracanja { get; set; }

        public DateTime? DanDizanja { get; set; }

        public string Idklijenta { get; set; }

        public string Idzaposlenika { get; set; }

        public int? Id1 { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        public int? Uposlenik_Id { get; set; }

        public int Klijent_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klijent> Klijent { get; set; }

        public virtual Klijent Klijent1 { get; set; }

        public virtual Uposlenik Uposlenik { get; set; }
    }
}

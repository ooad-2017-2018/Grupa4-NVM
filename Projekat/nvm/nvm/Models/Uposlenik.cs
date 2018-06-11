namespace nvm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uposlenik")]
    public partial class Uposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uposlenik()
        {
            ZahtjevZaKredit = new HashSet<ZahtjevZaKredit>();
        }

        public int Id { get; set; }

        public string fourSqaureId { get; set; }

        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        public string JMBG { get; set; }

        public string BrTel { get; set; }

        public string Adresa { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public int? Poslovnica_Id { get; set; }

        public virtual Poslovnica Poslovnica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZahtjevZaKredit> ZahtjevZaKredit { get; set; }
    }
}

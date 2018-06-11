namespace nvm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Poslovnica")]
    public partial class Poslovnica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poslovnica()
        {
            Uposlenik = new HashSet<Uposlenik>();
        }

        public int Id { get; set; }

        public string Adresa { get; set; }

        public string PoslovnicaID { get; set; }

        public int? Menager_Id { get; set; }

        public virtual Manager Manager { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uposlenik> Uposlenik { get; set; }
    }
}

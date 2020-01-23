namespace SampleEF.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    [Table("Kategori")]
    public partial class Kategori
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Kategori()
        //{
        //    Beritas = new HashSet<Berita>();
        //}

        [Key]
        public int id_kat { get; set; }

        [Required]
        [StringLength(50)]
        public string nama_kat { get; set; }

        
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Berita> Beritas { get; set; }
    }
}

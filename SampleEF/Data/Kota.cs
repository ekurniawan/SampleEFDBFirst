namespace SampleEF.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kota")]
    public partial class Kota
    {
        public int KotaId { get; set; }

        [StringLength(50)]
        public string NamaKota { get; set; }
    }
}

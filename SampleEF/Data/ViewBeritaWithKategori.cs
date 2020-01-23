namespace SampleEF.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViewBeritaWithKategori")]
    public partial class ViewBeritaWithKategori
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_berita { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kat { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string nama_kat { get; set; }

        [StringLength(50)]
        public string judul_berita { get; set; }

        [StringLength(50)]
        public string detail_berita { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime tanggal { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool isapprove { get; set; }

        public string pics { get; set; }
    }
}

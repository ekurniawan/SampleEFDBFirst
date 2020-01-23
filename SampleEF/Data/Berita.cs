namespace SampleEF.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Berita")]
    public partial class Berita
    {
        [Key]
        public int id_berita { get; set; }

        public int id_kat { get; set; }

        [StringLength(50)]
        public string judul_berita { get; set; }

        [StringLength(50)]
        public string detail_berita { get; set; }

        public DateTime tanggal { get; set; }

        public bool isapprove { get; set; }

        public string pics { get; set; }

        [StringLength(50)]
        public string pengarang { get; set; }

        public int? tahun_terbit { get; set; }

        public virtual Kategori Kategori { get; set; }
    }
}

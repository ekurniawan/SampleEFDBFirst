//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleEF.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Berita
    {
        public int id_berita { get; set; }
        public int id_kat { get; set; }
        public string judul_berita { get; set; }
        public string detail_berita { get; set; }
        public System.DateTime tanggal { get; set; }
        public bool isapprove { get; set; }
        public string pics { get; set; }
        public string pengarang { get; set; }
    
        public virtual Kategori Kategori { get; set; }
    }
}
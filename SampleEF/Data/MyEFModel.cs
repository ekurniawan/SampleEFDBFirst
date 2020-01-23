namespace SampleEF.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyEFModel : DbContext
    {
        public MyEFModel()
            : base("name=MyEFModel")
        {
        }

        public virtual DbSet<Berita> Berita { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kota> Kota { get; set; }
        public virtual DbSet<ViewBeritaWithKategori> ViewBeritaWithKategoris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Berita>()
                .Property(e => e.judul_berita)
                .IsUnicode(false);

            modelBuilder.Entity<Berita>()
                .Property(e => e.detail_berita)
                .IsUnicode(false);

            modelBuilder.Entity<Berita>()
                .Property(e => e.pics)
                .IsUnicode(false);

            modelBuilder.Entity<Berita>()
                .Property(e => e.pengarang)
                .IsUnicode(false);

            //modelBuilder.Entity<Kategori>()
            //    .HasMany(e => e.Beritas)
            //    .WithRequired(e => e.Kategori)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kota>()
                .Property(e => e.NamaKota)
                .IsUnicode(false);

            modelBuilder.Entity<ViewBeritaWithKategori>()
                .Property(e => e.judul_berita)
                .IsUnicode(false);

            modelBuilder.Entity<ViewBeritaWithKategori>()
                .Property(e => e.detail_berita)
                .IsUnicode(false);

            modelBuilder.Entity<ViewBeritaWithKategori>()
                .Property(e => e.pics)
                .IsUnicode(false);
        }
    }
}

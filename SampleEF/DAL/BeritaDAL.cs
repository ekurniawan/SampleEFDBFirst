using SampleEF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleEF.DAL
{
    public class BeritaDAL
    {
        private MyEFModel _db;
        public BeritaDAL()
        {
            _db = new MyEFModel();
        }

        public IEnumerable<Berita> GetAll()
        {
            //var results = _db.Berita.Include("Kategori").OrderBy(b => b.judul_berita);
            var results = from b in _db.Berita.Include("Kategori")
                          orderby b.judul_berita
                          select b;

            return results;
        }
    }
}
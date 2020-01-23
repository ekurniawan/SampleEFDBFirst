using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleEF.Data;

namespace SampleEF.DAL
{
    public class KategoriDAL
    {
        private SampleDbEntities _db;
        public KategoriDAL()
        {
            _db = new SampleDbEntities();
        }

        public IEnumerable<Kategori> GetAll()
        {
            //var results = _db.Kategori.OrderBy(k=>k.nama_kat);
            var results = from k in _db.Kategori
                          orderby k.nama_kat ascending
                          select k;
            return results;
        }

        public Kategori GetById(int id_kat)
        {
            //var result = _db.Kategori.Where(k => k.id_kat == id_kat).SingleOrDefault();
            var result = (from k in _db.Kategori
                          where k.id_kat == id_kat
                          select k).SingleOrDefault();
            return result;
        }

        public void Insert(string nama_kat)
        {
            var newKat = new Kategori
            {
                nama_kat = nama_kat
            };
            try
            {
                _db.Kategori.Add(newKat);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(int id_kat,string nama_kat)
        {
            var kategori = _db.Kategori.Where(k => k.id_kat == id_kat)
                .SingleOrDefault();

            if (kategori != null)
            {
                try
                {
                    kategori.nama_kat = nama_kat;
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
            {
                throw new Exception("Data tidak ditemukan");
            }
        }
    }
}
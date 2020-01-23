using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleEF.MyServices;

namespace SampleEF.Services
{
    public class KategoriServices
    {
        private SampleSOAPSoapClient _client;
        public KategoriServices()
        {
            _client = new SampleSOAPSoapClient();
        }

        public IEnumerable<Kategori> GetAll()
        {
            var results = _client.GetAll();
            return results;
        }

        public void Insert(string nama_kat)
        {
            try
            {
                _client.Insert(nama_kat);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
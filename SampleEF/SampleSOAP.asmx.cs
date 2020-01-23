using SampleEF.DAL;
using SampleEF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SampleEF
{
    /// <summary>
    /// Summary description for SampleSOAP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SampleSOAP : System.Web.Services.WebService
    {
        private KategoriDAL kategoriDAL;

        public SampleSOAP()
        {
            kategoriDAL = new KategoriDAL();
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
      
        [WebMethod]
        public List<Kategori> GetAll()
        {
            kategoriDAL = new KategoriDAL();
            return kategoriDAL.GetAll().ToList();
        }

        [WebMethod]
        public void Insert(string nama_kat)
        {
            try
            {
                kategoriDAL.Insert(nama_kat);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

using SampleEF.DAL;
using SampleEF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleEF
{
    public partial class SampleModelBinding : System.Web.UI.Page
    {
        private KategoriDAL kategoriDal;

        public SampleModelBinding()
        {
            kategoriDal = new KategoriDAL();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<SampleEF.Data.Kategori> gvKategori_GetData()
        {
            kategoriDal = new KategoriDAL();
            return kategoriDal.GetAll();
        }

       
    }
}
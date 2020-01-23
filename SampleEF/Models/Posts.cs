using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleEF.Models
{
    public class Posts
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
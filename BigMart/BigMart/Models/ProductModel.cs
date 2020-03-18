using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigMart.Models
{
    public class ProductModel
    { [key]
    public int id { get; set; }
        public string p_name { get; set; }
        public string category { get; set; }
        public int stock { get; set; }
        public DateTime m_date { get; set; }
        public DateTime e_date { get; set; }
        public int price { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigMart.Models
{
    public class InventoryModel
    {
        [key]
       public int id { get; set; }
        public string items { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int r_quantity { get; set; }
        public string supplier { get; set; }

    }
}

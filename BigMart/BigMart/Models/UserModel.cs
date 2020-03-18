using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigMart.Models
{
    public class UserModel
    { 
        [key]
        public int id { get; set; }
        public string tpin { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}

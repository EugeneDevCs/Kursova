using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemartone_3_core.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public List<Product> Products { set; get; }
    }
}

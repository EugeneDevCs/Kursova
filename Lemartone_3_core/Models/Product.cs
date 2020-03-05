using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemartone_3_core.Models
{
    public class Product
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isAvailable { set; get; }
        public int quantity { set; get; }
        public int categoryId { set; get; }

    }
}

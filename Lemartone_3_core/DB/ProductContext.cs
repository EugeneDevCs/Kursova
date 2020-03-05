using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lemartone_3_core.Interfaces;
using Lemartone_3_core.Models;
using System.Data.Entity;

namespace Lemartone_3_core.DB
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

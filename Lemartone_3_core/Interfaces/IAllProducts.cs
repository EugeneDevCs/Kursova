using Lemartone_3_core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemartone_3_core.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> ProductList { get;  }
        Product GetObjectProduct(int CarId);
    }
}

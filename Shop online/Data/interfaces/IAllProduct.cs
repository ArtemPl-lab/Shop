using Shop_online.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop_online.Data.interfaces
{
    interface IAllProduct
    {
        IEnumerable<Instance> Products { get; set; }
        IEnumerable<Instance> FavouriteProducts { get; set; }
        Instance getObjectProduct(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop_online.Data.Models;
namespace Shop_online.Data.interfaces
{
    interface IProducCategory
    {

        IEnumerable<Category> AllCategories { get; }
    }
}

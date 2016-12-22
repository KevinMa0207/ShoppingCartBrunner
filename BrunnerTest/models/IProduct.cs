using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerTest.models
{
    // the interface for products,has three properties: Id,Name,Price
    public interface IProduct
    {
        int ProductId { get; }
        string ProductName { get; }
        decimal ProductPrice { get; }
    }
}

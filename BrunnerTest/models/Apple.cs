using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerTest.models
{
    public class Apple : IProduct
    {
        public int ProductId
        {
            get
            {
                return 1;
            }
            
        }

        public string ProductName
        {
            get
            {
                return "Apple";
            }
            
        }

        public decimal ProductPrice
        {
            get
            {
                return 0.45m;
            }

        }
    }
}

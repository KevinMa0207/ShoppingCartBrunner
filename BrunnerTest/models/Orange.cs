using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerTest.models
{
    public class Orange : IProduct
    {
        public int ProductId
        {
            get
            {
                return 2;
            }
        }

        public string ProductName
        {
            get
            {
                return "Orange";
            }
        }

        public decimal ProductPrice
        {
            get
            {
                return 0.65m;
            }
        }
    }
}

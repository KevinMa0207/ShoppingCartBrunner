using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerTest.exceptions
{
    public class ProductNotAvailableException : Exception
    {
        public ProductNotAvailableException()
        {

        }
        public ProductNotAvailableException(string message) : base(message)
        {

        }
        public ProductNotAvailableException(string message, Exception inner): base(message,inner)
        {

        }

    }
}

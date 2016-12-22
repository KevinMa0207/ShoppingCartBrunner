using BrunnerTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrunnerTest.exceptions;

namespace BrunnerTest.calculateLogic
{
    //this is the dependence of regular calculation logic
    //there is no discount applied
    public class RegularCalculateCost : ICalculateCost
    {
        public decimal CalculateCost(List<IProduct> products)
        {
            decimal cost = 0.0m;
            foreach (IProduct str in products)
            {
                switch (str.ProductName)
                {
                    case "Apple":
                        cost = decimal.Add(cost,str.ProductPrice);
                        break;
                    case "Orange":
                        cost = decimal.Add(cost,str.ProductPrice);
                        break;
                    default:
                        throw new ProductNotAvailableException("product is not available");

                }
            }
            return cost;
        }
    }
}

using BrunnerTest.calculateLogic;
using BrunnerTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrunnerTest.exceptions;

namespace BrunnerTest
{
    public class checkout
    {
        decimal cost = 0.0m;
        private ICalculateCost _calculateLogic;

        //constructor injection
        //so we can inject different way of calculate the total cost
        public checkout(ICalculateCost logic)
        {
            _calculateLogic = logic;
        }

        //consider the input is a string that contains name of products
        //for example: "apple|apple|orange|apple"
        public decimal calculateCost(string input)
        {
           List<IProduct> products = new List<IProduct>();

            //parse string into a list with product names
            //and then tranfer the list to a list with products
           List<string> strs = input.Split('|').ToList();
           foreach(string str in strs)
            {
                switch (str)
                {
                    case "apple":
                        products.Add(new Apple());
                        break;
                    case "orange":
                        products.Add(new Orange());
                        break;
                    default:
                        throw new InvalidInputException("Input is not valid");
                }
            }

           cost=_calculateLogic.CalculateCost(products);
           return cost;
        }
    }
}

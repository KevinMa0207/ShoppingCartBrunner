using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrunnerTest;
using BrunnerTest.calculateLogic;
using BrunnerTest.models;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input products:");
            //make user input not case sensetive
            string input = Console.ReadLine().ToLower();
            //use regular way to calculate the cost
            checkout client = new checkout(new RegularCalculateCost());
            Console.WriteLine("Total Cost is:");
            Console.WriteLine(client.calculateCost(input));
            Console.ReadKey();
        }
    }
}

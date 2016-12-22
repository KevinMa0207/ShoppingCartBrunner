using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrunnerTest;
using BrunnerTest.calculateLogic;
using BrunnerTest.models;
using System.Collections.Generic;
using BrunnerTest.exceptions;

namespace testBrunnerShoppingCart
{
     [TestClass]
    public class testBrunner
    {
        //create some mock data for testing
        //the total cost of these list should be 2.00m;
        List<IProduct> demoProducts = new List<IProduct>
        {
            new Apple(),
            new Apple(),
            new Orange(),
            new Apple()
        };

        //create an invalid product
        class banana : IProduct
        {
            public int ProductId { get { return 3; } }
            public string ProductName { get { return "Banana"; } }
            public decimal ProductPrice { get { return 1.00m; } }
        }


        //test the regular calculation logic with proper input
        [TestMethod]
        public void testRegularCalculateWithValidInput()
        {
            RegularCalculateCost client = new RegularCalculateCost();
            var res=client.CalculateCost(demoProducts);
            Assert.AreEqual(2.00m, res);
        }

        //test the regular calculation logic with no input
        [TestMethod]
        public void testRegularCalculateWithEmptyInput()
        {
            List<IProduct> demo = new List<IProduct>();
            RegularCalculateCost client = new RegularCalculateCost();
            var res = client.CalculateCost(demo);
            Assert.AreEqual(0.0m, res);
        }

        //test the regular calculation logic with invalid products
        //should throw the ProductNotAvailableException
        [TestMethod]
        [ExpectedException(typeof(ProductNotAvailableException))]
        public void testRegularCalculateWithInvalidProduct()
        {

            List<IProduct> demo = new List<IProduct>
            {
                new Apple(),
                new Orange(),
                new banana()
            };
            RegularCalculateCost client = new RegularCalculateCost();
            var res = client.CalculateCost(demo);
        }

        //test checkout woth regular calculation logic using proper input
        [TestMethod]
        public void testCheckoutWithProperInput()
        {
            checkout client = new checkout(new RegularCalculateCost());
            var res= client.calculateCost("apple|orange|apple|apple");
            Assert.AreEqual(2.00m, res);
        }

        //test checkout woth regular calculation logic using invalid input
        [TestMethod]
        [ExpectedException(typeof(InvalidInputException))]
        public void testCheckoutWithInvalidInput()
        {
            checkout client = new checkout(new RegularCalculateCost());
            var res = client.calculateCost("asdasdasd");
        }
    }
}

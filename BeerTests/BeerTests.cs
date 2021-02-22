using Microsoft.VisualStudio.TestTools.UnitTesting;
using Beer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Beer.Tests
{
    [TestClass()]
    public class BeerTests
    {
        Beer beer;

        [TestInitialize]
        public void StartTest()
        {
            beer = new Beer(1, "Heineken", 39, 4);
        }

        [TestMethod()]
        public void BeerNameTest()
        {

            try
            {
                beer.Name = "øl";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Specified argument was out of the range of valid values.", ex.Message);
            }

            beer.Name = "Carlsberg";
            Assert.AreEqual("Carlsberg", beer.Name);

        }
        [TestMethod]
        public void BeerIdTest()
        {
            Assert.AreEqual(1, beer.ID);
            Assert.AreNotEqual(2, beer.ID);

            beer.ID = 3;
            Assert.AreEqual(3, beer.ID);
        }

        [TestMethod]
        public void BeerPriceTest()
        {
            try
            {
                beer.Price = -1;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Specified argument was out of the range of valid values.", ex.Message);
            }

            beer.Price = 40;
            Assert.AreEqual(40, beer.Price);
        }

        [TestMethod]
        public void BeerAbvTest()
        {
            try
            {
                beer.Abv = 0;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Specified argument was out of the range of valid values.", ex.Message);
            }

            beer.Abv = 50;
            Assert.AreEqual(50, beer.Abv);
        }
    }
}
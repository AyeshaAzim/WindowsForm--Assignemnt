using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment4Original;
using System.Collections.Generic;

namespace UnitTestingCatalog
{
    [TestClass]
    public class UnitTestingCatalog
    {
        
        [TestMethod]
        public void TestInitialization()
        {
            Catalog testCatalog = DataStore.Load("testCatalog.txt");
            Assert.AreEqual(5, testCatalog._list.Count);
        }

        [TestMethod]
        public void TestAdding()
        {

            Catalog testCatalog = DataStore.Load("testCatalog.txt");
            Product newTestProduct = new Product
            {
                Name = "TestProduct3",
                Department = Department.Home,
                Price = 10.5M

            };

            testCatalog.Add(newTestProduct);
            newTestProduct = new Product
            {
                Name = "TestProduct4",
                Department = Department.Toys,
                Price = 100.2M

            };
            testCatalog.Add(newTestProduct);


            Assert.AreEqual(7, testCatalog._list.Count);

        }
        [TestMethod]
        public void TestGetAllProducts()
        {

            Catalog testCatalog = DataStore.Load("testCatalog.txt");
            List<Product> testProductList = new List<Product>();
            testProductList = (List<Product>)testCatalog.GetAllProducts();

            Assert.AreEqual(5, testCatalog._list.Count);

        }

        [TestMethod]
        public void TestGetProducts()
        {

            Catalog testCatalog = DataStore.Load("testCatalog.txt");
            List<Product> testProductList = new List<Product>();
            string filterText = "TestItemComputer";

            testProductList = (List<Product>)testCatalog.GetProducts(filterText);
            Assert.AreEqual(2, testProductList.Count);

        }
    }
}

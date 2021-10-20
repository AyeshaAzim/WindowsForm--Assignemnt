using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Assignment4Original;

namespace UnitTestingProduct
{
    [TestClass]
    public class UnitTestingProduct
    {
        [TestMethod]
        public void TestProductInitialize()
        {
            Product testProduct = new Product
            {
                Name = "TestProductItemCalculator",
                Department = Department.Electronics,
                Price = 50.55M
            };

            Assert.AreEqual("TestProductItemCalculator", testProduct.Name);
            Assert.AreEqual(Department.Electronics, testProduct.Department);
            Assert.AreEqual(50.55M, testProduct.Price);

        }
    }
}

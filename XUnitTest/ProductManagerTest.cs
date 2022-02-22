using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Moq;
using Xunit;

namespace XUnitTest
{
    public class ProductManagerTest
    {
        private readonly Mock<IProductDal> _mockProductDal;
        private readonly ProductManager _productManager;
        private List<Product> _productList;

        public ProductManagerTest()
        {
            _mockProductDal = new Mock<IProductDal>();
            _productManager = new ProductManager(_mockProductDal.Object);


            _productList = new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    CategoryId = 1,
                    UnitPrice = 10.0M,
                    QuantityPerUnit = "box",
                    UnitsInStock = 10
                }
            };
        }

        [Fact]
        public void GetList_Execute()
        {
            _mockProductDal.Setup(p => p.GetList(null)).Returns(_productList);
            var result = _productManager.GetList();
            Assert.Equal(1, result.Data.Count);
        }
    }
}

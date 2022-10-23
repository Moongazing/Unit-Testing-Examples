using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart_Tests
{
  [TestClass]
  public class CartTests
  {
    private CartItem _cartItem;
    private CartManager _cartManager;
    [TestInitialize]
    public void TestInitialize()
    {
      _cartManager = new CartManager();
      _cartItem = new CartItem
      {
        Product = new Product
        {
          Id = 1,
          Name = "Laptop",
          UnitPrice = 2500
        },
        Quantity = 1
      };
      _cartManager.Add(_cartItem);
    }

    [TestMethod]
    public void AddProductInShoppingCart()
    {
      //Arrange 
      const int excepted = 1;

      //Act 
      var totalItems = _cartManager.TotalItems();

      //Assert
      Assert.AreEqual(excepted, totalItems);
    }
    [TestMethod]
    public void RemoveProductInShoppingCart()
    {
      //Arrange 
      var totalItemsInShopingCart = _cartManager.TotalItems();

      //Act 
      _cartManager.Remove(1);
      var totalItems = _cartManager.TotalItems();

      //Assert
      Assert.AreEqual(totalItemsInShopingCart - 1, totalItems);
    }

    [TestMethod]
    public void ShoppingCartCanCleanable()
    {
      //Arrange 
      
      //Act 
      _cartManager.Clear();

      //Assert
      Assert.AreEqual(0, _cartManager.TotalItems());
    }
  }
}

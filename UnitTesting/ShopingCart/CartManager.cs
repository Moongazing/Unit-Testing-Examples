using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart
{
  public class CartManager
  {

    /*
     1-)User can added product in shoping cart,
     2-)User can delete product in shoping cart,
     3-)User can clear shoping cart
    */
    private readonly List<CartItem> _cartItems;
    public CartManager()
    {
      _cartItems = new List<CartItem>();
    }
    public void Add(CartItem cartItem)
    {
      _cartItems.Add(cartItem);
    }
    public void Remove(int productId)
    {
      var product = _cartItems.FirstOrDefault(t => t.Product.Id == productId);
      _cartItems.Remove(product);
    }
    public List<CartItem> cartItems
    {
        get
        {
          return _cartItems;
        }
    }
    public void Clear()
    {
      _cartItems.Clear();
    }
    public decimal TotalPrice()
    {
        return _cartItems.Sum(t => t.Quantity * t.Product.UnitPrice);
    }
    public int TotalItems()
    {
      return _cartItems.Count;
    }
    


  }
}

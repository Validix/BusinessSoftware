using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Cart
    {
    }
    // Define a class to represent a product
    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    // Define a class to represent an item in the cart
    class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    // Define a class to represent the cart itself
    class ShoppingCart
    {
        private List<CartItem> cartItems;

        public ShoppingCart()
        {
            cartItems = new List<CartItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            // Check if the item is already in the cart
            CartItem existingItem = cartItems.FirstOrDefault(item => item.Product.ProductID == product.ProductID);

            if (existingItem != null)
            {
                // If it is, just update the quantity
                existingItem.Quantity = quantity;
            }
            else
            {
                // If it's not, add a new item to the cart
                cartItems.Add(new CartItem { Product = product, Quantity = quantity });
            }
        }

        public void RemoveCustomItem(int id)
        {
            cartItems.RemoveAll(x => x.Product.ProductID == id);

            //artItems.FirstOrDefault(x => x.Product.ProductID== id);
        }

        public void ClearCart()
        {
            cartItems.Clear();
        }

        public void RemoveItem(CartItem item)
        {
            cartItems.Remove(item);
        }

        public List<CartItem> GetItems()
        {
            return cartItems;
        }
    }


    /*
     * 
     * 
     * 
     * 
     * 
     * 
   // Usage:
// Create a new instance of the ShoppingCart class
ShoppingCart cart = new ShoppingCart();

// Get the product to add to the cart (e.g. from a database)
Product product = new Product { ProductID = 1, Name = "Product 1", Price = 9.99m };

// Add the product to the cart
cart.AddItem(product, 2);

// Display the contents of the cart
List<CartItem> items = cart.GetItems();
foreach (CartItem item in items)
{
    Console.WriteLine($"{item.Product.Name} ({item.Quantity})");
}
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     * 
     */
}

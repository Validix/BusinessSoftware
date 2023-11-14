using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class StockToOrder
    {
    }

    // Define a class to represent a product
    class ProductToOrder
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
    }

    

    // Define a class to represent the cart itself
    class Stock
    {
        private List<ProductToOrder> stockProductItems;

        public Stock()
        {
            stockProductItems = new List<ProductToOrder>();
        }

        public void AddItem(ProductToOrder product)
        {
            // Check if the item is already in the cart
            ProductToOrder existingItem = stockProductItems.FirstOrDefault(item => item.ProductID == product.ProductID);

            if (existingItem != null)
            {
                // If it is, just update the quantity
                existingItem.Quantity = product.Quantity;
            }
            else
            {
                // If it's not, add a new item to the cart
                stockProductItems.Add(new ProductToOrder { Name = product.Name, Quantity = product.Quantity, ProductID=product.ProductID });
            }
        }

        public void RemoveCustomItem(int id)
        {
            stockProductItems.RemoveAll(x => x.ProductID == id);

            //artItems.FirstOrDefault(x => x.Product.ProductID== id);
        }

        public void ClearCart()
        {
            stockProductItems.Clear();
        }

        public void RemoveItem(ProductToOrder item)
        {
            stockProductItems.Remove(item);
        }

        public List<ProductToOrder> GetItems()
        {
            return stockProductItems;
        }
    }

}

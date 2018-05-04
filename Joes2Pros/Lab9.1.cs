using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Products
    {
        class Product
        {
            public int ProductID;
            public string ProductName;
            public double RetailPrice;

            public Product()
            {
                ProductID = 1001;
                ProductName = "Cell Phone";
                RetailPrice = 49.99;
            }

            public Product(int productID,string productName,double retailPrice)
            {
                ProductID = productID;
                ProductName = productName;
                RetailPrice = retailPrice;
            }

            public static void Display(Product product)
            {
                Console.WriteLine($"Product ID: {product.ProductID}");
                Console.WriteLine($"Product Name: {product.ProductName}");
                Console.WriteLine($"Retail Price: {product.RetailPrice}");
            }

        }


        public static void ShowTestProducts()
        {
            Product test = new Product();
            Product test2 = new Product(2001, "Guitar", 499.99);
            Product.Display(test);
            Product.Display(test2);
        }
    }

    class Orders
    {
        class Order
        {
            public readonly long OrderID;
            public readonly string Product;
            public readonly string Customer;

            public Order(long id,string prod,string cust)
            {
                OrderID = id;
                Product = prod;
                Customer = cust;
            }

            public static void Display(Order order)
            {
                Console.WriteLine($"Order ID = {order.OrderID}");
                Console.WriteLine($"Product = {order.Product}");
                Console.WriteLine($"Customer = {order.Customer}");
            }
        }


        public static void Test()
        {
            Order order = new Order(22, "Drumkit", "Chase Moltedo");
            //order.Customer = "Chase's Evil Twin";
            Order.Display(order);
        }

    }

}

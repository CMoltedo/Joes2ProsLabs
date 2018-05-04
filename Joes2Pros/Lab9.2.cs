using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class PurchaseActivity
    {
        class Order
        {
            public readonly int OrderID;
            public string ProductName;
            public string CustomerName;
            private DateTime orderDate;

            public Order(int order, string pName,string cName)
            {
                OrderID = order;
                ProductName = pName;
                CustomerName = cName;
                orderDate = DateTime.Now;
            }

            public static void ShowOrder(Order ord)
            {
                Console.WriteLine($"Order ID: {ord.OrderID}");
                Console.WriteLine($"Product: {ord.ProductName}");
                Console.WriteLine($"Customer: {ord.CustomerName}");
                Console.WriteLine($"Ordered: {ord.orderDate}");
            }
        }

        public static void Test()
        {
            Order ord = new Order(123, "Keyboard", "Chase");
            Order ord2 = new Order(456, "Trumpet", "Jason");
            Order[] orders = { new Order(1, "Drums", "Joe"), new Order(2, "Guitar", "Moe") };
            Order.ShowOrder(ord);
            Order.ShowOrder(ord2);
            foreach(Order orderInstance in orders)
            {
                Order.ShowOrder(orderInstance);
            }

        }
    }

    class FancyBoard
    {
        class Board
        {
            public static void WriteToSimple(string message)
            {
                Console.WriteLine($"{message}");
            }
            public static void WriteToDash(string message)
            {
                Console.WriteLine($"--{message}--");
            }
            public static void WriteToHash(string message)
            {
                Console.WriteLine($"##{message}##");
            }
        }

        public static void Test()
        {
            Board.WriteToSimple("Hello");
            Board.WriteToDash("Hello");
            Board.WriteToHash("Hello");
        }
    }

}

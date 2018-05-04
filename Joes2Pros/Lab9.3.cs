using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joes2Pros
{
    class Products
    {
        class Product
        {
            //public int ID;
            //public string Code;
            //public DateTime ReleaseDate;

            readonly int ID;
            readonly string Code;
            readonly DateTime ReleaseDate;

            public Product()
            {

            }

            public Product(int id, string code, DateTime releaseDate)
            {
                ID = id;
                Code = code;
                releaseDate = ReleaseDate;
            }


            public static void Display(Product prod)
            {
                Console.WriteLine($"ID:{prod.ID} Code:{prod.Code} Release:{prod.ReleaseDate}");
            }


        }

        //public static void Test931()
        //{
        //    Product product = new Product();
        //    product.ID = 1;
        //    product.Code = "LT-3030";
        //    product.ReleaseDate = DateTime.Parse("1/1/2013");

        //    Product product2 = new Product();
        //    product2.ID = 2;
        //    product2.Code = "CP-1010";
        //    product2.ReleaseDate = DateTime.Parse("1/1/2012");

        //    Product.Display(product);
        //    Product.Display(product2);

        //}

        public static void Test932()
        {
            Product product = new Product(1, "LT-3030", DateTime.Parse("1/1/2013"));
            Product product2 = new Product(2, "CP-1010", DateTime.Parse("1/1/2012"));

            Product.Display(product);
            Product.Display(product2);

        }

    }
}

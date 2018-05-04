using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{

    
    class Books
    {
        public struct Book
        {
            public int ID;
            public string Title;
            public string ISBN;
            public DateTime ReleaseDate;

        }
        public static void ShowBooks()
        {
            Book book1;
            Book book2;

            book1.ID = 1;
            book1.Title = "C# Series 1";
            book1.ISBN = "111";
            book1.ReleaseDate = DateTime.Now;

            book2.ID = 2;
            book2.Title = "C# Series 2";
            book2.ISBN = "222";
            book2.ReleaseDate = DateTime.Today;

            Book[] books = new Book[2];
            books[0] = book1;
            books[1] = book2;
            
            

            foreach(Book book in books)
            {
                Console.WriteLine("ID:" + book.ID.ToString()
                                + " Title:" + book.Title 
                                + " ISBN:" + book.ISBN
                                + " Release Date:"+book.ReleaseDate.ToString());
            }

        Console.ReadKey();
        }
        
    }
}

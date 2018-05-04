using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joes2Pros
{
    //class NameList
    //{
    //    public static List<string> names = new List<string>();

    //    public static void Populate()
    //    {
    //        names.Add("John");
    //        names.Add("David");
    //        names.Add("Megan");
    //        names.Add("Roger");
    //        names.Add("Steven");
    //    }

    //    public static void Display()
    //    {
    //        NameList.Populate();
    //        names.Sort();//Lab 10.1.2
    //        foreach (string name in names) Console.WriteLine(name);
    //    }

    //}
    
    //class CandyHolder
    //{

    //    public static Stack<string> candies = new Stack<string>();
    //    public static string sfx = " Candy";

    //    public static void Add()
    //    {
    //        candies.Push($"Red{sfx}");
    //        candies.Push($"Green{sfx}");
    //        candies.Push($"Blue{sfx}");
    //        candies.Push($"Green{sfx}");
    //        candies.Push($"Yellow{sfx}");
    //        candies.Push($"Green{sfx}");
    //    }

    //    public static void Display()
    //    {
    //        CandyHolder.Add();

    //        while(candies.Count() > 0) Console.WriteLine($"{candies.Pop()}");
    //    }


    //}

    class TicketCounter
    {
        private static Queue<Person> people;
        private static Queue<Person> People { get => people; set => people = value; }

        class Person
        {
            private static int id;
            private static string name;
            private static int age;
            private static int zipCode;

            public int Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public int Age { get => age; set => age = value; }
            public int ZipCode { get => zipCode; set => zipCode = value; }

            public Person(int _id, string _name,int _age, int _zip)
            {
                Id = _id;
                Name = _name;
                Age = _age;
                ZipCode = _zip;

            }

        }


        public static void Display()
        {
            Person displayPerson;
            foreach (Person person in TicketCounter.People)
            {
                displayPerson = people.Dequeue();
                Console.WriteLine($"ID:{displayPerson.Id}");
                Console.WriteLine($"Name:{displayPerson.Id}");
                Console.WriteLine($"Age:{displayPerson.Id}");
                Console.WriteLine($"ZipCode:{displayPerson.Id}");
            }
            
        }

        public static void Add()
        {
            Person person1 = new Person(1, "Roger", 24, 11111);
            Person person2 = new Person(2, "Roger", 22, 22222);
            Person person3 = new Person(3, "Roger", 21, 33333);
            Person person4 = new Person(4, "Roger", 27, 44444);
            
            People.Enqueue(person1);
            People.Enqueue(person2);
            People.Enqueue(person3);
            People.Enqueue(person4);
        }

        public static void Test()
        {
            TicketCounter.Add();
            TicketCounter.Display();


        }
    }
}

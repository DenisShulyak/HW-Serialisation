
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;

namespace HomeWorkSerialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            task3();

        }
        static void task1()
        {
            System.Console.WriteLine("1)");
            List<Book> list = new List<Book>()
            {
                new Book()
                {
                    Author="Рик Риордан",
                    Name="Перси Джексон",
                    Price=245,
                    Year=2017
                },
                new Book()
                {
                    Author="Филип Рив",
                    Name="Хроники хищных городов",
                    Price=324,
                    Year=2019
                },
                new Book()
                {
                    Author="Дж.Роллинк",
                    Name="Гарри Поттер",
                    Price=300,
                    Year=2016
                }
            };
            using (FileStream stream = new FileStream("text.txt", FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, list);
            }
            Console.ReadLine();
           
        }
       
        static void task3()
        {
            Console.WriteLine("3)");

            List<Book> list3 = new List<Book>()
            {
                new Book()
                {
                    Author="Рик Риордан",
                    Name="Перси Джексон",
                    Price=245,
                    Year=2017
                },
                new Book()
                {
                    Author="Филип Рив",
                    Name="Хроники хищных городов",
                    Price=324,
                    Year=2019
                },
                new Book()
                {
                    Author="Дж.Роллинк",
                    Name="Гарри Поттер",
                    Price=300,
                    Year=2016
                }
            };
            foreach (var book in list3)
            {
                Console.WriteLine("Книга " + book.Name);
                Console.WriteLine("Аттрибуты");
                foreach (var property in book.GetType().GetRuntimeProperties())
                {
                    PropertyInfo propertyInfo = property;
                    var attrs = propertyInfo.GetCustomAttributes(false);
                    if (attrs != null)
                    {

                        foreach (var attr in attrs)
                        {
                            if (attr is UserAtribute)
                            {
                                Console.WriteLine("\t\t" + (attr as UserAtribute).Name);
                            }
                        }
                    }
                }

            }
            Console.ReadLine();
        }
    }
}

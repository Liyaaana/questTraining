using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
IEnumerable: Provides simple, read-only sequential access to a collection. Useful for data retrieval.
ICollection: Extends IEnumerable and adds methods for adding, removing, and counting elements.
IList: Extends ICollection and adds support for indexed access, allowing retrieval and modification of elements at specific indexes.
*/
namespace IEnumerable_Icollection__Ilist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("IEnumerable:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            ICollection<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
            fruits.Add("Orange");
            Console.WriteLine("\nICollection:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            IList<string> cities = new List<string> { "New York", "London", "Tokyo" };
            cities.Add("San Francisco");
            cities[1] = "Paris";
            Console.WriteLine("\nIList:");
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}




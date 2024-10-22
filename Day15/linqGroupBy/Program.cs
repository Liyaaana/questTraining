using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqGroupBy
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        // Specifying which property of the Person class you want to display.
        // Overrode the ToString() method in the Person class to provide a custom string representation.
        public override string ToString()
        {
            return $"{Name} ({Country}), Age: {Age}"; 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person{Name= "Person1", Country= "US", Age= 20},
                new Person{Name= "Person10", Country= "US", Age= 20},
                new Person{Name= "Person2", Country= "US", Age= 30},
                new Person{Name= "Person3", Country= "US", Age= 40},
                new Person{Name= "Person4", Country= "IN", Age= 50}
            };
            var groups = data.GroupBy(p => p.Country);
            /*foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
            }
            */
            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key} - {group.Count()}");
                foreach (var person in group)
                {
                    Console.WriteLine($"\t{person}");
                }
            }
        }
    }
}

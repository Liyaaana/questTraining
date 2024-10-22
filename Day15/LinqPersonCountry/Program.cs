using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPersonCountry
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
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
            //var res = data.Where(p => p.Country == "US");
            //foreach ( var person in res)
            //{
            //    Console.WriteLine(person.Name);
            //}
            //var minAge = data.Where(p => p.Country == "US").Min(p => p.Age);
            //var person = data.Where(p => p.Country == "US" && p.Age == minAge).FirstOrDefault();
            //var res1 = data.OrderByDescending(x => x.Age);
            //foreach ( var person in res1)
            //{
            //    Console.WriteLine(person.Name);
            //}
            //var res2 = data.Select(p => p.Country).Distinct();


        }
    }
}

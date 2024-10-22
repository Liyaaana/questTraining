using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPersonEmail
{
    class Person
    {
        public string Name { get; set; }
        public string[] Emails { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person{Name = "Person1", Emails= new string[]{"a@gmail.com", "a@outlook.com"}},
                new Person{Name = "Person10", Emails= new string[]{"b@gmail.com", "b@outlook.com"}},
                new Person{Name = "Person2", Emails= new string[]{"c@gmail.com", "coutlook.com"}},
                new Person{Name = "Person3", Emails= new string[]{"d@gmail.com", "d@outlook.com"}},
                new Person{Name = "Person4", Emails= new string[]{"e@gmail.com", "e@outlook.com"}}
            };
            
            var emailArraysList= data.Select(p => p.Emails).ToList();
            var emails = data.SelectMany(p => p.Emails).ToList();
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}

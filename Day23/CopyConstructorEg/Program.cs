using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructorEg
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alice", 25);
            Console.WriteLine("Original person:");
            person1.Display();

            Person person2 = new Person(person1);
            Console.WriteLine("Copied person:");
            person2.Display();

            person2.Name = "Bob";
            person2.Age = 30;

            Console.WriteLine("After modifying the copied person:");
            Console.WriteLine("Original person:");
            person1.Display();
            Console.WriteLine("Copied person:");
            person2.Display();
        }
    }
}

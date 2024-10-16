using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone
{
    class Smartphone
    {
        public string Name;
        public string Manufacturer;
        public List<int> Memory;

        public void Display()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Manufacturer = {Manufacturer}");
            Console.WriteLine($"Memory = {string.Join(",",Memory)}");
            Console.WriteLine("------------------------------------");
        }

    }
    internal class Program
    {
        static void Main()
        {
            var smartphone1 = new Smartphone();
            smartphone1.Name = "iphone";
            smartphone1.Manufacturer = "Apple";
            smartphone1.Memory = new List<int>() {128, 256, 512};

            var smartphone2 = new Smartphone();
            smartphone2.Name = "samsung Galaxy S23";
            smartphone2.Manufacturer = "Samsung";
            smartphone2.Memory = new List<int>() { 128, 256, 512 };

            smartphone1.Display();
            smartphone2.Display();
        }
    }
}

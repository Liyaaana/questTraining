using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    internal class Program
    {
        class ShoppingList
        {
            private string[] _items = new string[10];
            public string this[int index]
            {
                get => _items[index];
                set { _items[index] = value; }
            }
            public int TotalItems => _items.Count(i => i != null);
        }
        static void Main(string[] args)
        {
            var list = new ShoppingList();
            list[0] = "apple";
            list[1] = "banana";
            Console.WriteLine(list[0]);
            Console.WriteLine(list.TotalItems);
        }
    }
}

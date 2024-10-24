using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class ShoppingList
    {
        private List<string> _items = new List<string>();
        public string this[int index]
        {
            get
            {
                if (index >= _items.Count)
                {
                    throw new IndexOutOfRangeException("index out of range");
                }
                return _items[index];
            }
            set
            {
                if (index >= _items.Count)
                {
                    _items.Add(value);
                }
                else
                {
                    _items[index] = value;
                }
            }
        }
        public int TotalItems => _items.Count;

        static void Main(string[] args)
        {
            try
            {
                var shoppingList = new ShoppingList();
                shoppingList[0] = "apple";
                shoppingList[1] = "banana";
                Console.WriteLine(shoppingList[0]);
                Console.WriteLine(shoppingList.TotalItems);
            }
            catch (Exception e)
            {
            }
        }
    }
}


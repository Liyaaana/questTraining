using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictDay16
{
    class MyDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();
        public int Count => _data.Count();
        public void Add(TKey key, TValue value)
        { 
            _data.Add(key, value);
        }
        // Additional method to display the dictionary contents
        public void DisplayContents()
        {
            foreach (var item in _data)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new MyDictionary<string, string>();
            data.Add("Name", "Mishel");
            // Display the contents of the dictionary
            Console.WriteLine("Dictionary contents:");
            data.DisplayContents();
        }
    }
}

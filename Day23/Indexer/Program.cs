using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//An indexer in C# allows an object to be indexed in the same way as an array. 
//It's a special type of property that enables you to access elements of an object using the array-like syntax.

namespace Indexer
{
    class Sample
    {
        private string[] arr = new string[10];
        public string this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample sample = new Sample();

            sample[0] = "Hello";
            sample[1] = "World";

            Console.WriteLine(sample[0]); 
            Console.WriteLine(sample[1]); 
        }
    }

}

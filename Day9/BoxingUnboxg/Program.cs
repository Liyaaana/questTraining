using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int i = 5;
            // Boxing: Converting value type 'int' to reference type 'object'
            object o = i;
            // Unboxing: Converting 'o' (boxed 'int') back to 'int'
            int j = (int)o;
        }
    }
}

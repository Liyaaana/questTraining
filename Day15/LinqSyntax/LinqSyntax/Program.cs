using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] { 1, 2, 3, 4, 5, -3, -5 };
            var res = from i in data
                      where i < 0
                      select i;
            var r = data.Where(i => i < 0);
        }
    }
}

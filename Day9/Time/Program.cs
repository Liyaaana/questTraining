using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace Time
{
    internal class Program
    {
        static void Main()
        {
            var text = "ThisIsALongText";
            var dt = DateTime.Now - TimeSpan.FromDays(365);
            Console.WriteLine(text.Humanize());
            Console.WriteLine(dt.Humanize());
        }
    }
}

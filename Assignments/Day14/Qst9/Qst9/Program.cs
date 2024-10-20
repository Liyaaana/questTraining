//9: Define an Action<string> delegate that prints a string to the console. Use this delegate to call a method that prints a welcome message.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst9
{
    internal class ActionDelegate
    {
        public static void Display(string msg) => Console.WriteLine(msg);
        static void Main(string[] args)
        {
            Action<string> a = Display;
            a("Hello Welcome");
        }
    }
}




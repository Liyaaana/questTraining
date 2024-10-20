//13: Define an abstract class Appliance with an abstract method TurnOn(). Create a derived class Fan that implements the TurnOn() method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst13
{
    internal class Program
    {
        abstract class Appliance
        {
            public abstract void TurnOn();
        }
        class Fan : Appliance
        {
            public override void TurnOn()
            {
                Console.WriteLine(" Fan is turned on");
            }
        }
        static void Main(string[] args)
        {
            var fan = new Fan();
            fan.TurnOn();
        }
    }
}

//15: Write a class Animal with a virtual method MakeSound(). Create a derived class Dog that overrides MakeSound() to print "Bark!".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst15
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal is making sound");

        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            //base.MakeSound();
            Console.WriteLine("Bark!");
        }
    }
    internal class virtualOne
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.MakeSound();

        }
    }
}

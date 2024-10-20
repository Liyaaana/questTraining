using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst3
{
    /* 3: Create an interface IAnimal with a method Speak(). 
       Implement the interface in two classes Dog and Cat, 
    each providing their own implementation of Speak().
    */
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof! I'm a dog.");
        }
    }

    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow! I'm a cat.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
    }
}

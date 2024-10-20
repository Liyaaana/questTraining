//14: Create an abstract class Person with an abstract method Work(). Implement Work() in derived classes Doctor and Engineer to describe their specific jobs.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qst14
{
    abstract class Person
    {
        public abstract void Work();
    }
    class Doctor : Person
    {
        public override void Work()
        {
            Console.WriteLine("The job of Doctor is patient treatment");
        }
    }
    class Engineer : Person
    {
        public override void Work()
        {
            Console.WriteLine("The job of Engineer is to solve problems");
        }
    }
    internal class AbstractTwo
    {
        static void Main(string[] args)
        {
            var doctor = new Doctor();
            doctor.Work();
            var engineer = new Engineer();
            engineer.Work();
        }
    }
}



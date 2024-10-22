using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
/* 
Design two classes:
Circle(with a Radius property)
Rectangle(with Length and Width properties)
Each class should have methods:
double GetArea(): to calculate the area of the shape.
double GetPerimeter(): to calculate the perimeter of the shape.
Store the shapes in a single list and then display the area and  perimeter of the shapes stored.
*/

/* keerthana
namespace Shapes
{
    // Circle class with a generic type
    public class Circle<T> where T : struct, IConvertible
    {
        public T Radius { get; set; }

        public Circle(T radius)
        {
            Radius = radius;
        }

        // Method to calculate the area of the circle
        public double GetArea()
        {
            double radius = Convert.ToDouble(Radius);
            return Math.PI * radius * radius;
        }

        // Method to calculate the perimeter of the circle
        public double GetPerimeter()
        {
            double radius = Convert.ToDouble(Radius);
            return 2 * Math.PI * radius;
        }
    }

    // Rectangle class with a generic type
    public class Rectangle<T> where T : struct, IConvertible
    {
        public T Length { get; set; }
        public T Width { get; set; }

        public Rectangle(T length, T width)
        {
            Length = length;
            Width = width;
        }

        // Method to calculate the area of the rectangle
        public double GetArea()
        {
            double length = Convert.ToDouble(Length);
            double width = Convert.ToDouble(Width);
            return length * width;
        }

        // Method to calculate the perimeter of the rectangle
        public double GetPerimeter()
        {
            double length = Convert.ToDouble(Length);
            double width = Convert.ToDouble(Width);
            return 2 * (length + width);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store shapes as object types
            List<object> shapes = new List<object>();

            // Adding shapes to the list
            shapes.Add(new Circle<double>(5.0)); // Circle with radius 5.0
            shapes.Add(new Rectangle<double>(4.0, 6.0)); // Rectangle with length 4.0 and width 6.0

            // Displaying area and perimeter of each shape
            foreach (var shape in shapes)
            {
                if (shape is Circle<double> circle)
                {
                    Console.WriteLine($"Circle: Area = {circle.GetArea()}, Perimeter = {circle.GetPerimeter()}");
                }
                else if (shape is Rectangle<double> rectangle)
                {
                    Console.WriteLine($"Rectangle: Area = {rectangle.GetArea()}, Perimeter = {rectangle.GetPerimeter()}");
                }
            }
        }
    }

}
*/

namespace Shapes
{
    interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }
    class Circle : IShape
    {
        public double Radius { get; set; }
        public double GetArea() => Math.PI * Radius * Radius;
        public double GetPerimeter() => 2 * Math.PI * Radius;
    }
    class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double GetArea() => Length * Width;
        public double GetPerimeter() => 2 * (Length + Width);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<IShape>
            {
                new Circle() { Radius = 10 },
                new Rectangle() { Length = 10, Width = 20 }
            };
            foreach (var item in shapes)
            {
                Console.WriteLine($"Area: {item.GetArea()}, Perimeter: {item.GetPerimeter()}");
            }
        }
    }
}
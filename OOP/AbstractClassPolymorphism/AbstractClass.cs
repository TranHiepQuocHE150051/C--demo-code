using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPolymorphism
{
    abstract class Shape
    {
        public string Name { get; set; }

        // You can define non-abstract
        // methods in an abstract class
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        // We want subclasses to override
        // this method so mark it as abstract
        // You can only make abstract methods 
        // in abstract classes
        public abstract double Area();

    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        // You can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            Console.WriteLine($"It has a Radius of {Radius}");
        }

    }
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length,
            double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        // You can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            Console.WriteLine($"It has a Length of {Length} and Width of {Width}");
        }
    }

}

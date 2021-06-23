using System;

namespace Abstraction_Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            // create the shapes, pass in the length
            // the .ToString("#.00000") changes the display to only show up to 5 decimal places
            Circle circle = new Circle(10);
            Console.WriteLine("Circle radius is 10, Area is {0} and Circumference is {1}.", circle.getArea().ToString("#.00000"), circle.getPerimeter().ToString("#.00000"));

            Square square = new Square(10);
            Console.WriteLine("Square length is 10, Area is {0} and Perimeter is {1}.", square.getArea().ToString("#.00000"), square.getPerimeter().ToString("#.00000"));

            // rectangle needs height and a way to set the width
            Rectangle rectangle = new Rectangle(5);
            rectangle.Width = 10;
            Console.WriteLine("Rectangle height is 5, width is " + rectangle.getWidth() + ",  Area is {0} and Perimeter is {1}.", rectangle.getArea().ToString("#.00000"), rectangle.getPerimeter().ToString("#.00000"));

            Console.WriteLine();

            Sphere sphereOne = new Sphere(5);
            Console.WriteLine("Sphere radius is 5, Surface Area is {0} and Volume is {1}.", sphereOne.getArea().ToString("#.00000"), sphereOne.getPerimeter().ToString("#.00000"));

            Sphere sphereTwo = new Sphere(10);
            Console.WriteLine("Sphere radius is 10, Surface Area is {0} and Volume is {1}.", sphereTwo.getArea().ToString("#.00000"), sphereTwo.getPerimeter().ToString("#.00000"));

            Console.WriteLine("\nNotice how the radius is doubled but the volume is way more than doubled? Thats the Square-Cube law in effect!");


            // wait for user to press any key to exit program
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();

        }
    }
}

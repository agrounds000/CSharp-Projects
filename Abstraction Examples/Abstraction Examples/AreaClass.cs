
namespace Abstraction_Examples
{
    abstract class AreaClass
    {

        /*
         * About Abstract classes:
         * 
         * An abstract method has no implmentation, just the declaration.
         * Not all methods in an abstract class has to be marked abstract.
         * Abstract classes also cannot be instantiated.
         * The purpose of abstract classes and methods is to provide a
         * blueprint of derived classes (such as the shapes in this example)
         * of what methods they must implement. In other words, it provides
         * a common implemented functionality between anything that is inherited from it.
         * Any method labeled as abstract must be overriden in a child class.
         * 
         */

        // abstract methods for area and perimeter/volume
        public abstract double getArea();
        public abstract double getPerimeter();


    }
}

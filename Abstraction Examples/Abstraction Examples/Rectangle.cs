
namespace Abstraction_Examples
{
    class Rectangle : AreaClass
    {

        private int width;
        private int height;

        public Rectangle(int height)
        {
            this.height = height;
        }

        // allows a width to be set in the main class
        public int Width { set => width = value; }

        public int getWidth()
        {
            return this.width;
        }

        public override double getArea() 
        {
            return this.width * this.height;
        }

        public override double getPerimeter()
        {
            return (this.width * 2) + (this.height * 2);
        }

    }
}

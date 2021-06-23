using System;

namespace Abstraction_Examples
{
    class Sphere : AreaClass
    {

        private int radius;

        public Sphere(int radius)
        {
            this.radius = radius;
        }

        // area of a sphere is 4 PI r^2
        public override double getArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        // we will be getting the volume of the sphere for this, not perimiter
        public override double getPerimeter()
        {
            return (4 / 3) * Math.PI * Math.Pow(radius, 3);
        }
    }
}

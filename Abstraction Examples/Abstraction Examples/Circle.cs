using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Examples
{
    // inherit from AreaClass
    // class Circle has to implement a getArea function and override it
    class Circle : AreaClass
    {

        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        // area of a circle is PI * r^2
        public override double getArea()
        {
            return Math.PI * radius * radius;
        }

        // perimeter of a circle is the same thing as circumference
        public override double getPerimeter()
        {
            return 2 * Math.PI * radius;
        }

    }
}

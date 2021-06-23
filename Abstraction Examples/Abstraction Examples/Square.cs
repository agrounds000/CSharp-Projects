using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Examples
{
    class Square : AreaClass
    {

        private int length;

        public Square(int length)
        {
            this.length = length;
        }

        // squares have the same length on every side, area is length * width
        public override double getArea()
        {
            return Math.Pow(length, 2);
        }

        // perimeter of a square is 4 * length
        public override double getPerimeter()
        {
            return length * 4;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_Shape
{
    public  class Rectangle : Quadriateral
    {
        public Rectangle(double pside1length, double pside2length, string pcolor) : base(pside1length, pside2length, pside1length, pside2length, pcolor)
        {
        }

        public override double GetArea()
        {
            return Side1Length * Side2Length;
        }

        public override double GetPerimeter()
        {
            return 2*(Side1Length + Side2Length);
        }

    }
}

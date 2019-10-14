using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_Shape
{
    public class Square : Quadriateral
    {
        public Square(double pside1length, string pcolor) : base(pside1length, pside1length, pside1length, pside1length, pcolor)
        {
        }

        public override double GetArea()
        {
            return Side1Length * Side1Length;
        }

        public override double GetPerimeter()
        {
            return Side1Length * 4;
        }
    }
}

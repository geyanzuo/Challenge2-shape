using System;
using System.Collections.Generic;
using System.Text;


namespace Challenge2_Shape
{
    public class Equilateral : Triangle, IShapeCalculate
    {
        public Equilateral(double pside1length, string pcolor) : base(pside1length, pside1length, pside1length, pcolor)
        {

        }

        public  double GetArea()
        {
            return Math.Round( (Math.Sqrt(3) / 4) * Side1Length*Side1Length, 2);
        }

        public  double GetPerimeter()
        {
            return Math.Round( Side1Length * 3,2);
        }
    }
}

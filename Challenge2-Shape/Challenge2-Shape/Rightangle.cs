using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_Shape
{
    public class Rightangle : Triangle, IShapeCalculate
    {
        public Rightangle(double pside1length, double pside2length, string pcolor) : base(pside1length, pside2length,pside3length: Math.Sqrt(Math.Pow(pside1length, 2) + Math.Pow(pside2length, 2)), pcolor)
        {
        }

        public double SetHypotenuse()
        {
            return Side3Length =Math.Round(Math.Sqrt(Math.Pow(Side1Length, 2) + Math.Pow(Side2Length, 2)),2) ;
        }

        public double GetArea()
        {
            return Math.Round(0.5 * (Side1Length * Side2Length),2);
        }

        public double GetPerimeter()
        {
            return Math.Round(Side1Length + Side2Length + Side3Length,2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_Shape
{
    public class Triangle : Shape
    {
        public double Side1Length;
        public double Side2Length;
        public double Side3Length;


        public Triangle (double pside1length, double pside2length, double pside3length, string pcolor) : base(pcolor)
        {
            Side1Length = pside1length;
            Side2Length = pside2length;
            Side3Length = pside3length;
        }

       

       
    }
}

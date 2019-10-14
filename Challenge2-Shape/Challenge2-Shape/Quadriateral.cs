using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_Shape
{
    public abstract class Quadriateral:Shape, IShapeCalculate
    {
        public double Side1Length;
        public double Side2Length;
        public double Side3Length;
        public double Side4Length;

        public Quadriateral(double pside1length, double pside2length, double pside3length, double pside4length, string pcolor): base(pcolor)
        {
            Side1Length = pside1length;
            Side2Length = pside2length;
            Side3Length = pside3length;
            Side4Length = pside4length;
        }

        public abstract double GetArea();


        public abstract double GetPerimeter();
        
    }
}

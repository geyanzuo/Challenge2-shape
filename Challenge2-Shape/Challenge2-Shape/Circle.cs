using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_Shape
{
    public class Circle : Shape,IShapeCalculate
    {
        public readonly double PI = Math.PI;
        public double Radios;

        public Circle( double pradios, string pcolor) : base(pcolor)
        {
            
            Radios = pradios;
        }

        public double GetArea()
        {
            return Math.Round(PI * Math.Pow(Radios, 2),2); 
        }

        public double GetPerimeter()
        {
            return Math.Round(2 * Radios * PI,2); 
        }
    }
}

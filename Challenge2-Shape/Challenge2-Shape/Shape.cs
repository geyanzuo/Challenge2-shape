using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2_Shape
{
    public abstract class Shape
    {
       public string Color;

        public Shape(string pcolor)
        {
            Color = pcolor;
        }

        public void Operation1()
        {
            return;
        }
    }
}

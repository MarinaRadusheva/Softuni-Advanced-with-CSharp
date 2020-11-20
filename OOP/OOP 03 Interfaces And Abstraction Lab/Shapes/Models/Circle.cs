using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Circle : Shape
    {
        private int radius;

        private int Radius 
        { get => this.radius;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid value");
                }
            }
        }
        public Circle(int radius)
        {
            this.Radius = radius;
        }
        public override void Draw()
        {
            double rIn = this.Radius - 0.4;
            double rOut = this.Radius + 0.4;
            for (double y = this.Radius; y >= -this.Radius; --y)
            {
                for (double x = -this.Radius; x < rOut; x+=0.5)
                {
                    double value = x * x + y * y;
                    if (value>=rIn*rIn&&value<=rOut*rOut)
                    {
                        this.Drawer.Write("*");
                    }
                    else
                    {
                        this.Drawer.Write(" ");
                    }
                }
            this.Drawer.WriteLine();

            }
        }
    }
}

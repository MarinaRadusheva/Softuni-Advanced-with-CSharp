using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        private int Width
        {
            get => this.width;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid value");
                }
                this.width = value;
            }
        }

        private int Height
        {
            get => this.height;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid value");
                }
                this.height = value;
            }
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.Height = height;
        }
        public override void Draw()
        {
            this.Drawer.WriteLine(DrawLine(Width, '*', '*'));
            for (int i = 1; i < Height - 1; i++)
            {
                this.Drawer.WriteLine(DrawLine(Width, '*', ' '));
            }
            this.Drawer.WriteLine(DrawLine(Width, '*', '*'));

        }
        private string DrawLine(int length, char end, char middle)
        {
            string line = end.ToString();
            for (int i = 1; i < length - 2; i++)
            {
                line += middle.ToString();
            }
            line += end.ToString();
            return line;
        }
    }
}

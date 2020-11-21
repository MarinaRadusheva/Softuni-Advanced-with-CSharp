using System;
using System.Collections.Generic;
using System.Text;

namespace P02.Graphic_Editor
{
    public abstract class Shape : IShape
    {
        public string Draw()
        {
            return ("I am a " + this.GetType().Name);
        }
    }
}

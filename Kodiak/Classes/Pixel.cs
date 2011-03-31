using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Transformations.Classes
{
    class Pixel
    {
        public Color Color { get; set; }

        public int X { get; set; }
        public int Y { get; set; }

        public Pixel(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
}

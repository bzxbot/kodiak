using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transformations.Classes
{
    class Shear : ITransformation
    {
        private float dx;
        private float dy;

        public Shear(float dx, float dy)
        {
            this.dx = dx;
            this.dy = dy;
        }

        public void Apply(Matrix matrix)
        {
            float[,] shearMatrix = new float[,] { {  1, dx, 0 }, 
                                                { dy,  1, 0 }, 
                                                {  0,  0, 1 } };

            matrix.Multiply(shearMatrix);
        }
    }
}

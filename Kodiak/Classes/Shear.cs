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
            matrix.Shear(dx, dy);
        }
    }
}

using System;
namespace Transformations.Classes
{
    class Rotate : ITransformation
    {
        private int Angle { get; set; }

        public Rotate(int angle)
        {
            Angle = angle;
        }

        public void Apply(Matrix matrix)
        {
            float[,] rotateMatrix;

            if (Angle > 0)
            {
                rotateMatrix = new float[,] { {(float)Math.Cos(Trig.DegreeToRadian(Angle)) ,  (float)Math.Sin(Trig.DegreeToRadian(Angle)), 0},
                                        { -(float)Math.Sin(Trig.DegreeToRadian(Angle)),  (float)Math.Cos(Trig.DegreeToRadian(Angle)), 0},
                                        {                 0                     ,                    0                   , 1} };
            }
            else
            {
                rotateMatrix = new float[,] { {(float)Math.Cos(Trig.DegreeToRadian(Angle)), (float)Math.Sin(Trig.DegreeToRadian(Angle)), 0},
                                        {(float)Math.Sin(Trig.DegreeToRadian(Angle)), (float)Math.Cos(Trig.DegreeToRadian(Angle)), 0},
                                        {                 0                    ,                  0                    , 1} };
            }

            matrix.Multiply(rotateMatrix);
        }
    }
}

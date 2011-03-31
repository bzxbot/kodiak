using System;

namespace Transformations.Classes
{
    class Matrix
    {
        public float[,] Elements { get; private set; }
        private float[,] translation;

        private int side = 3;

        public Matrix()
        {
            Elements = new float[,] { { 1, 0, 0 }, 
                                      { 0, 1, 0 }, 
                                      { 0, 0, 1 } };

            translation = new float[,] { { 1, 0, 0 }, 
                                         { 0, 1, 0 }, 
                                         { 0, 0, 1 } };
        }

        public void Scale(float scaleX, float scaleY)
        {
            float[,] matrix = new float[,] { { scaleX, 0, 0 }, 
                                             { 0, scaleY, 0 }, 
                                             { 0,   0,    1 }};

            Multiply(matrix);
        }

        public void Rotate(int angle)
        {
            float[,] matrix;

            if (angle > 0)
            {
                matrix = new float[,] { {(float)Math.Cos(DegreeToRadian(angle)) ,  (float)Math.Sin(DegreeToRadian(angle)), 0},
                                        {-(float)Math.Sin(DegreeToRadian(angle)),  (float)Math.Cos(DegreeToRadian(angle)), 0},
                                        {                 0                     ,                    0                   , 1} };
            }
            else
            {
                matrix = new float[,] { {(float)Math.Cos(DegreeToRadian(angle)), (float)Math.Sin(DegreeToRadian(angle)), 0},
                                        {(float)Math.Sin(DegreeToRadian(angle)), (float)Math.Cos(DegreeToRadian(angle)), 0},
                                        {                 0                    ,                  0                    , 1} };
            }

            Multiply(matrix);
        }

        public void Invert(Inversion invert)
        {
            float[,] matrix;

            switch (invert)
            {
                case Inversion.Horizontal:
                    matrix = new float[,] { { -1, 0, 0 }, 
                                            {  0, 1, 0 },
                                            {  0, 0, 1 } };
                    break;
                case Inversion.Vertical:
                    matrix = new float[,] { { 1,  0, 0 }, 
                                            { 0, -1, 0 },
                                            { 0,  0, 1 } };
                    break;
                default:
                    matrix = new float[,] { { 1, 0, 0 }, 
                                            { 0, 1, 0 }, 
                                            { 0, 0, 1 } };
                    break;
            }

            Multiply(matrix);
        }

        public void Translate(int dx, int dy)
        {
            translation[2, 0] += dx;
            translation[2, 1] += dy;
        }

        public void Shear(float dx, float dy)
        {
            float[,] matrix = new float[,] { {  1, dx, 0 }, 
                                             { dy,  1, 0 }, 
                                             {  0,  0, 1 } };

            Multiply(matrix);
        }

        public void ApplyTranslation()
        {
            Multiply(translation);
        }

        private void Multiply(float[,] matrix)
        {
            float[,] result = new float[side, side];

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    for (int k = 0; k < side; k++)
                    {
                        result[i, j] += Elements[i, k] * matrix[k, j];
                    }
                }
            }

            Elements = result;
        }

        private double DegreeToRadian(int angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}

using System;

namespace Transformations.Classes
{
    class Matrix
    {
        public float[,] Elements { get; private set; }

        private int side = 3;

        public Matrix()
        {
            Elements = new float[,] { { 1, 0, 0 }, 
                                      { 0, 1, 0 }, 
                                      { 0, 0, 1 } };
        }     

        public void Multiply(float[,] matrix)
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
    }
}

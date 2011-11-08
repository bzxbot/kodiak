namespace Transformations.Classes
{
    class Scale : ITransformation
    {
        public float ScaleX { get; set;}
        public float ScaleY { get; set; }

        public Scale(float scaleX, float scaleY)
        {
            ScaleX = scaleX;
            ScaleY = scaleY;
        }

        public void Apply(Matrix matrix)
        {
            float[,] scaleMatrix = new float[,] { { ScaleX,   0,    0 }, 
                                                {   0,      ScaleY, 0 }, 
                                                {   0,        0,    1 }};

            matrix.Multiply(scaleMatrix);
        }
    }
}

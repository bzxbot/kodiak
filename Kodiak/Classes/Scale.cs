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
            matrix.Scale(ScaleX, ScaleY);
        }
    }
}

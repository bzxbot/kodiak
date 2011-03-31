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
            matrix.Rotate(Angle);
        }
    }
}

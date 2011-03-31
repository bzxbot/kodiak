namespace Transformations.Classes
{
    class Translate : ITransformation
    {
        int dx;
        int dy;

        public Translate(int dx, int dy)
        {
            this.dx = dx;
            this.dy = dy;
        }

        public void Apply(Matrix matrix)
        {
            matrix.Translate(dx, dy);
        }
    }
}

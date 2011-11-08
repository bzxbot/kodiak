namespace Transformations.Classes
{
    class Translate : ITransformation
    {
        private int dx;
        private int dy;

        public Translate(int dx, int dy)
        {
            this.dx = dx;
            this.dy = dy;
        }

        public void Apply(Matrix matrix)
        {
            matrix.Elements[2, 0] += this.dx;
            matrix.Elements[2, 1] += this.dy;            
        }
    }
}

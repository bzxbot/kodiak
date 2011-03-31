namespace Transformations.Classes
{
    class Invert : ITransformation
    {
        private Inversion invertion;

        public Invert(Inversion invertion)
        {
            this.invertion = invertion;
        }

        public void Apply(Matrix matrix)
        {
            matrix.Invert(invertion);
        }
    }
}

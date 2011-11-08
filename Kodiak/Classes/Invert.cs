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
            float[,] inversionMatrix;

            switch (this.invertion)
            {
                case Inversion.Horizontal:
                    inversionMatrix = new float[,] { { -1, 0, 0 }, 
                                            {  0, 1, 0 },
                                            {  0, 0, 1 } };
                    break;
                case Inversion.Vertical:
                    inversionMatrix = new float[,] { { 1,  0, 0 }, 
                                            { 0, -1, 0 },
                                            { 0,  0, 1 } };
                    break;
                default:
                    inversionMatrix = new float[,] { { 1, 0, 0 }, 
                                            { 0, 1, 0 }, 
                                            { 0, 0, 1 } };
                    break;
            }

            matrix.Multiply(inversionMatrix);
        }
    }
}

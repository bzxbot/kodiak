using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Transformations.Classes
{
    class Transformer
    {
        private Stack<ITransformation> transformations = new Stack<ITransformation>();
        public Stack<ITransformation> Transformations
        {
            get
            {
                return transformations;
            }
            private set
            {
                transformations = value;
            }
        }

        private Matrix matrix = new Matrix();

        public Bitmap ApplyTransformation(Bitmap bitmap, PictureBox picbox)
        {
            ComputeMatrix();

            Bitmap transformed = new Bitmap(picbox.Width, picbox.Height);

            List<Pixel> pixels = new List<Pixel>();

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    int xcentralizado = i - bitmap.Width / 2;
                    int ycentralizado = j - bitmap.Height / 2;

                    int x = (int)(matrix.Elements[0, 0] * xcentralizado + matrix.Elements[1, 0] * ycentralizado + matrix.Elements[2, 0] * 1);
                    int y = (int)(matrix.Elements[0, 1] * xcentralizado + matrix.Elements[1, 1] * ycentralizado + matrix.Elements[2, 1] * 1);

                    x += picbox.Width / 2;
                    y += picbox.Height / 2;

                    pixels.Add(new Pixel(x, y, color));       
                }
            }

            foreach(Pixel pixel in pixels)
            {
                if (pixel.X >= 0 && pixel.Y >= 0 && pixel.X < transformed.Width && pixel.Y < transformed.Height)
                {
                    transformed.SetPixel(pixel.X, pixel.Y, pixel.Color);
                }
            }

            Clear();

            return transformed;
        }

        public void ComputeMatrix()
        {
            while (Transformations.Count > 0)
            {
                ITransformation transformation = Transformations.Pop();

                transformation.Apply(matrix);
            }

            matrix.ApplyTranslation();
        }

        public void Clear()
        {
            matrix = new Matrix();
        }
    }
}

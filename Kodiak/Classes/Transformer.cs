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

        public Bitmap ApplyTransformations(Bitmap bitmap, PictureBox pictureBox)
        {
            int maximumX = 0;
            int maximumY = 0;

            ComputeMatrix();

            List<Pixel> pixels = new List<Pixel>();

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    // Each point is centered on 0,0
                    int centralX = i - bitmap.Width / 2;
                    int centralY = j - bitmap.Height / 2;

                    int x = (int)(matrix.Elements[0, 0] * centralX + matrix.Elements[1, 0] * centralY + matrix.Elements[2, 0] * 1);
                    int y = (int)(matrix.Elements[0, 1] * centralX + matrix.Elements[1, 1] * centralY + matrix.Elements[2, 1] * 1);

                    // Point back to format where 0,0 is the top right corner.
                    x += pictureBox.Width / 2;
                    y += pictureBox.Height / 2;

                    // On some transformations the image width and height might change, we store the maximum of them.
                    if (x > maximumX)
                        maximumX = x;

                    if (y > maximumY)
                        maximumY = y;

                    pixels.Add(new Pixel(x, y, color));
                }
            }

            Bitmap transformed = new Bitmap(maximumX, maximumY);

            foreach(Pixel pixel in pixels)
            {
                if (pixel.X >= 0 && pixel.Y >= 0 && pixel.X < transformed.Width && pixel.Y < transformed.Height)
                {
                    transformed.SetPixel(pixel.X, pixel.Y, pixel.Color);
                }
            }

            ClearTransformations();

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

        public void ClearTransformations()
        {
            matrix = new Matrix();
        }
    }
}

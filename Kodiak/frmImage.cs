using System.Drawing;
using System.Windows.Forms;

namespace Transformations
{
    public partial class frmImage : Form
    {
        public Bitmap Image
        {
            set
            {
                pictureBox1.Image = value;
            }
            get
            {
                return (Bitmap)pictureBox1.Image;
            }
        }

        public PictureBox picbox
        {
            get
            {
                return pictureBox1;
            }
        }

        public frmImage()
        {
            InitializeComponent();
        }
    }
}

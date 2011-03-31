using System.Windows.Forms;

namespace Transformations
{
    public partial class frmScale : Form
    {
        public float ScaleX
        {
            get
            {
                return (float)numericUpDown1.Value;
            }
        }

        public float ScaleY
        {
            get
            {
                return (float)numericUpDown2.Value;
            }
        }

        public frmScale()
        {
            InitializeComponent();
        }
    }
}

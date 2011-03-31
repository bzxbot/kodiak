using System.Windows.Forms;

namespace Transformations
{
    public partial class frmTransformations : Form
    {
        public ListBox Transformations
        {
            get
            {
                return listBox1;
            }
        }


        public frmTransformations()
        {
            InitializeComponent();
        }
    }
}

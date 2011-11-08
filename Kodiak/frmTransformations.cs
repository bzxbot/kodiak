using System.Windows.Forms;

namespace Transformations
{
    public partial class frmTransformations : Form
    {
        public ListBox Transformations
        {
            get
            {
                return lboTransformations;
            }
        }

        public frmTransformations()
        {
            InitializeComponent();
        }

        private void frmTransformations_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();

            e.Cancel = true;
        }
    }
}

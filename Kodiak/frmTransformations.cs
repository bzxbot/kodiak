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
            if (e.CloseReason == CloseReason.MdiFormClosing)
            {
                this.Hide();

                e.Cancel = true;
            }
        }
    }
}

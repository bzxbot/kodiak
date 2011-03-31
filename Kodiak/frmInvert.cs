using System.Windows.Forms;
using Transformations.Classes;

namespace Transformations
{
    public partial class frmInvert : Form
    {
        public Inversion Invertion
        {
            get
            {
                if (horizontal.Checked)
                {
                    return Inversion.Horizontal;
                }
                else
                {
                    return Inversion.Vertical;
                }
            }
        }

        public frmInvert()
        {
            InitializeComponent();
        }
    }
}

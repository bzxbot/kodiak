using System;
using System.Windows.Forms;

namespace Transformations
{
    public partial class frmTranslate : Form
    {
        public int TranslationX
        {
            get
            {
                return (int)numericUpDown1.Value;
            }
        }

        public int TranslationY
        {
            get
            {
                return (int)numericUpDown2.Value;
            }
        }

        public frmTranslate()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

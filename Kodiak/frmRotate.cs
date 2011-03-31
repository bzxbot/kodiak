using System;
using System.Windows.Forms;
using Transformations.Classes;

namespace Transformations
{
    public partial class frmRotate : Form
    {
        public int Angle
        {
            get
            {
                return (int)numericUpDown1.Value;
            }
        }

        public frmRotate()
        {
            InitializeComponent();
        }
    }
}

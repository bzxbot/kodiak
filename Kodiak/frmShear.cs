using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transformations
{
    public partial class frmShear : Form
    {
        public float ShearX
        {
            get
            {
                return (float)numericUpDown1.Value;
            }
        }

        public float ShearY
        {
            get
            {
                return (float)numericUpDown2.Value;
            }
        }


        public frmShear()
        {
            InitializeComponent();
        }
    }
}

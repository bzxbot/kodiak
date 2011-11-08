using System.Drawing;
using System.Windows.Forms;
using Transformations.Classes;
using System.Collections.Generic;

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

        public PictureBox PictureBox
        {
            get
            {
                return pictureBox1;
            }
        }

        private List<IObserver> observers = new List<IObserver>();

        public void NotifyOnClose()
        {
            foreach(IObserver observer in observers)
            {
                observer.Notify(this);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public frmImage()
        {
            InitializeComponent();
        }

        private void frmImage_Load(object sender, System.EventArgs e)
        {

        }

        private void frmImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotifyOnClose();
        }
    }
}

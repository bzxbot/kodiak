using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using Greyhound;
using Transformations.Classes;

namespace Transformations
{
    public partial class frmMain : Form, IObserver
    {
        private PNMReader pnmReader = new PNMReader();
        private frmImage frmImage;
        private frmScale frmScale = new frmScale();
        private frmRotate frmRotate = new frmRotate();
        private frmInvert frmInvert = new frmInvert();
        private frmShear frmShear = new frmShear();
        private frmTranslate frmTranslation = new frmTranslate();
        private frmTransformations frmTransformations = new frmTransformations();
        private Transformer transformer = new Transformer();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is MdiClient)
                {
                    (control as MdiClient).BackColor = System.Drawing.SystemColors.Control;
                    (control as MdiClient).ForeColor = System.Drawing.SystemColors.Control;
                }
            }
            
            frmTransformations.MdiParent = this;
            
            ShowTransformationsPanel();
        }

        private void mniOpen_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            if (string.IsNullOrEmpty(ofd.FileName))
                return;

            FileInfo fInfo = new FileInfo(ofd.FileName);

            string fileExtension = fInfo.Extension.ToLower();

            if (frmImage != null)
            {
                frmImage.Close();
                frmImage.Dispose();
                frmImage = null;
            }

            frmImage = new frmImage();
            frmImage.MdiParent = this;
            frmImage.RegisterObserver(this);

            Cursor = Cursors.WaitCursor;

            if (fileExtension == ".pbm" || fileExtension == ".pgm" || fileExtension == ".ppm")
            {
                frmImage.Image = (Bitmap)(new PNMReader().ReadImage(fInfo.FullName));
            }
            else
            {
                frmImage.Image = (Bitmap)(Image.FromFile(ofd.FileName));
            }

            Cursor = Cursors.Arrow;

            mniAdd.Enabled = true;
            mniRemove.Enabled = true;
            mniExecute.Enabled = true;

            frmImage.Show();
        }

        private void mniTranslate_Click(object sender, EventArgs e)
        {
            if (frmTranslation.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Translate(frmTranslation.TranslationX, frmTranslation.TranslationY));
                frmTransformations.Transformations.Items.Insert(0, "Translação");
                ShowTransformationsPanel();
            }
        }

        private void mniScale_Click(object sender, EventArgs e)
        {            
            if (frmScale.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Scale(frmScale.ScaleX, frmScale.ScaleY));
                frmTransformations.Transformations.Items.Insert(0, "Escala");
                ShowTransformationsPanel();
            }
        }

        private void mniRotate_Click(object sender, EventArgs e)
        {
            if (frmRotate.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Rotate(frmRotate.Angle));
                frmTransformations.Transformations.Items.Insert(0, "Rotação");
                ShowTransformationsPanel();
            }
        }

        private void mniInvert_Click(object sender, EventArgs e)
        {           
            if (frmInvert.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Invert(frmInvert.Invertion));
                frmTransformations.Transformations.Items.Insert(0, "Inversão");
                ShowTransformationsPanel();
            }
        }

        private void mniShear_Click(object sender, EventArgs e)
        {
            if (frmShear.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Shear(frmShear.ShearX, frmShear.ShearY));
                frmTransformations.Transformations.Items.Insert(0, "Shear");
                ShowTransformationsPanel();
            }
        }

        private void mniRemove_Click(object sender, EventArgs e)
        {          
            if (transformer.Transformations.Count > 0)
            {
                ITransformation t = transformer.Transformations.Pop();

                if (frmTransformations.Transformations.Items.Count > 0)
                {
                    frmTransformations.Transformations.Items.RemoveAt(0);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma transformação na pilha.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mniExecute_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            frmImage.Image = transformer.ApplyTransformations((Bitmap)frmImage.Image, frmImage.PictureBox);

            frmTransformations.Transformations.Items.Clear();

            Cursor = Cursors.Arrow;
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Notify(object obj)
        {
            if (obj is frmImage)
            {
                transformer.ClearTransformations();

                frmTransformations.Transformations.Items.Clear();

                mniAdd.Enabled = false;
                mniRemove.Enabled = false;
                mniExecute.Enabled = false;
            }
        }

        private void ShowTransformationsPanel()
        {
            if (!frmTransformations.Visible)
            {
                frmTransformations.StartPosition = FormStartPosition.Manual;
                frmTransformations.Location = new Point(this.Width - 165, 5);
                frmTransformations.Show();
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using Greyhound;
using Transformations.Classes;
using System.IO;

namespace Transformations
{
    public partial class frmMain : Form
    {
        private PNMReader pnmReader = new PNMReader();
        private frmScale frmScale = new frmScale();
        private frmRotate frmRotate = new frmRotate();
        private frmInvert frmInvert = new frmInvert();
        private frmImage frmImage = new frmImage();
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

            frmImage.MdiParent = this;
            frmTransformations.MdiParent = this;
            frmTransformations.Show();
            frmTransformations.Location = new Point(this.Width - 165, 5);
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(ofd.FileName))
                {
                    FileInfo fInfo = new FileInfo(ofd.FileName);

                    string fileExtension = fInfo.Extension.ToLower();

                    if (fileExtension == ".pbm" || fileExtension == ".pgm" || fileExtension == ".ppm")
                    {
                        frmImage.Image = (Bitmap)new PNMReader().ReadImage(fInfo.FullName);
                    }
                    else
                    {
                        frmImage.Image = (Bitmap)Image.FromFile(ofd.FileName);
                    }

                    frmImage.Show();
                }
            }
        }

        private void traToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmImage.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (frmTranslation.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Translate(frmTranslation.TranslationX, frmTranslation.TranslationY));
                frmTransformations.Transformations.Items.Insert(0, "Translação");
            }
        }

        private void escalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmImage.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (frmScale.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Scale(frmScale.ScaleX, frmScale.ScaleY));
                frmTransformations.Transformations.Items.Insert(0, "Escala");
            }
        }

        private void rotaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmImage.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (frmRotate.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Rotate(frmRotate.Angle));
                frmTransformations.Transformations.Items.Insert(0, "Rotação");
            }
        }

        private void inverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmImage.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (frmInvert.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Invert(frmInvert.Invertion));
                frmTransformations.Transformations.Items.Insert(0, "Inversão");
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmImage.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

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

        private void executarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmImage.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (transformer.Transformations.Count == 0)
            {
                MessageBox.Show("Nenhuma transformação na pilha.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            Cursor = Cursors.WaitCursor;

            frmImage.Image = transformer.ApplyTransformation((Bitmap)frmImage.Image, frmImage.picbox);

            frmTransformations.Transformations.Items.Clear();

            Cursor = Cursors.Arrow;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmImage.Image == null)
            {
                MessageBox.Show("Nenhuma imagem carregada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (frmShear.ShowDialog() == DialogResult.OK)
            {
                transformer.Transformations.Push(new Shear(frmShear.ShearX, frmShear.ShearY));
                frmTransformations.Transformations.Items.Insert(0, "Shear");
            }
        }
    }
}

namespace Transformations
{
    partial class frmTransformations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboTransformations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lboTransformations
            // 
            this.lboTransformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboTransformations.FormattingEnabled = true;
            this.lboTransformations.Location = new System.Drawing.Point(0, 0);
            this.lboTransformations.Name = "lboTransformations";
            this.lboTransformations.Size = new System.Drawing.Size(136, 303);
            this.lboTransformations.TabIndex = 0;
            // 
            // frmTransformations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 303);
            this.Controls.Add(this.lboTransformations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTransformations";
            this.ShowIcon = false;
            this.Text = "Transformações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTransformations_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboTransformations;
    }
}
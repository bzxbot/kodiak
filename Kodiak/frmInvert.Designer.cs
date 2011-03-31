namespace Transformations
{
    partial class frmInvert
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
            this.horizontal = new System.Windows.Forms.RadioButton();
            this.vertical = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // horizontal
            // 
            this.horizontal.AutoSize = true;
            this.horizontal.Checked = true;
            this.horizontal.Location = new System.Drawing.Point(12, 12);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(72, 17);
            this.horizontal.TabIndex = 0;
            this.horizontal.TabStop = true;
            this.horizontal.Text = "Horizontal";
            this.horizontal.UseVisualStyleBackColor = true;
            // 
            // vertical
            // 
            this.vertical.AutoSize = true;
            this.vertical.Location = new System.Drawing.Point(98, 12);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(60, 17);
            this.vertical.TabIndex = 1;
            this.vertical.Text = "Vertical";
            this.vertical.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(9, 35);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(90, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmInvert
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(172, 66);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.vertical);
            this.Controls.Add(this.horizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(178, 92);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(178, 92);
            this.Name = "frmInvert";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton horizontal;
        private System.Windows.Forms.RadioButton vertical;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button button1;
    }
}
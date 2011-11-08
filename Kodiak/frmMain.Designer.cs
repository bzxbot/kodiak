namespace Transformations
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mniOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTranslate = new System.Windows.Forms.ToolStripMenuItem();
            this.mniScale = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.mniShear = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOpen,
            this.mniAdd,
            this.mniRemove,
            this.mniExecute,
            this.mniExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(592, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // mniOpen
            // 
            this.mniOpen.Name = "mniOpen";
            this.mniOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.mniOpen.Size = new System.Drawing.Size(45, 20);
            this.mniOpen.Text = "A&brir";
            this.mniOpen.Click += new System.EventHandler(this.mniOpen_Click);
            // 
            // mniAdd
            // 
            this.mniAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTranslate,
            this.mniScale,
            this.mniRotate,
            this.mniInvert,
            this.mniShear});
            this.mniAdd.Enabled = false;
            this.mniAdd.Name = "mniAdd";
            this.mniAdd.ShortcutKeyDisplayString = "";
            this.mniAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mniAdd.Size = new System.Drawing.Size(70, 20);
            this.mniAdd.Text = "&Adicionar";
            // 
            // mniTranslate
            // 
            this.mniTranslate.Name = "mniTranslate";
            this.mniTranslate.Size = new System.Drawing.Size(152, 22);
            this.mniTranslate.Text = "Translação";
            this.mniTranslate.Click += new System.EventHandler(this.mniTranslate_Click);
            // 
            // mniScale
            // 
            this.mniScale.Name = "mniScale";
            this.mniScale.Size = new System.Drawing.Size(152, 22);
            this.mniScale.Text = "Escala";
            this.mniScale.Click += new System.EventHandler(this.mniScale_Click);
            // 
            // mniRotate
            // 
            this.mniRotate.Name = "mniRotate";
            this.mniRotate.Size = new System.Drawing.Size(152, 22);
            this.mniRotate.Text = "Rotação";
            this.mniRotate.Click += new System.EventHandler(this.mniRotate_Click);
            // 
            // mniInvert
            // 
            this.mniInvert.Name = "mniInvert";
            this.mniInvert.Size = new System.Drawing.Size(152, 22);
            this.mniInvert.Text = "Inverter";
            this.mniInvert.Click += new System.EventHandler(this.mniInvert_Click);
            // 
            // mniShear
            // 
            this.mniShear.Name = "mniShear";
            this.mniShear.Size = new System.Drawing.Size(152, 22);
            this.mniShear.Text = "Shear";
            this.mniShear.Click += new System.EventHandler(this.mniShear_Click);
            // 
            // mniRemove
            // 
            this.mniRemove.Enabled = false;
            this.mniRemove.Name = "mniRemove";
            this.mniRemove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.mniRemove.Size = new System.Drawing.Size(66, 20);
            this.mniRemove.Text = "&Remover";
            this.mniRemove.Click += new System.EventHandler(this.mniRemove_Click);
            // 
            // mniExecute
            // 
            this.mniExecute.Enabled = false;
            this.mniExecute.Name = "mniExecute";
            this.mniExecute.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.mniExecute.Size = new System.Drawing.Size(63, 20);
            this.mniExecute.Text = "&Executar";
            this.mniExecute.Click += new System.EventHandler(this.mniExecute_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.mniExit.Size = new System.Drawing.Size(38, 20);
            this.mniExit.Text = "&Sair";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(592, 572);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmMain";
            this.Text = "Kodiak";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mniAdd;
        private System.Windows.Forms.ToolStripMenuItem mniRemove;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniExecute;
        private System.Windows.Forms.ToolStripMenuItem mniScale;
        private System.Windows.Forms.ToolStripMenuItem mniRotate;
        private System.Windows.Forms.ToolStripMenuItem mniOpen;
        private System.Windows.Forms.ToolStripMenuItem mniInvert;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem mniTranslate;
        private System.Windows.Forms.ToolStripMenuItem mniShear;
    }
}
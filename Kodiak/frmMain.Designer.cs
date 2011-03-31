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
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.adicionarToolStripMenuItem,
            this.removerToolStripMenuItem,
            this.executarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(592, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.abrirImagemToolStripMenuItem.Text = "A&brir";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traToolStripMenuItem,
            this.escalaToolStripMenuItem,
            this.rotaçãoToolStripMenuItem,
            this.inverToolStripMenuItem,
            this.sToolStripMenuItem});
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.adicionarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adicionarToolStripMenuItem.Text = "&Adicionar";
            // 
            // traToolStripMenuItem
            // 
            this.traToolStripMenuItem.Name = "traToolStripMenuItem";
            this.traToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.traToolStripMenuItem.Text = "Translação";
            this.traToolStripMenuItem.Click += new System.EventHandler(this.traToolStripMenuItem_Click);
            // 
            // escalaToolStripMenuItem
            // 
            this.escalaToolStripMenuItem.Name = "escalaToolStripMenuItem";
            this.escalaToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.escalaToolStripMenuItem.Text = "Escala";
            this.escalaToolStripMenuItem.Click += new System.EventHandler(this.escalaToolStripMenuItem_Click);
            // 
            // rotaçãoToolStripMenuItem
            // 
            this.rotaçãoToolStripMenuItem.Name = "rotaçãoToolStripMenuItem";
            this.rotaçãoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.rotaçãoToolStripMenuItem.Text = "Rotação";
            this.rotaçãoToolStripMenuItem.Click += new System.EventHandler(this.rotaçãoToolStripMenuItem_Click);
            // 
            // inverToolStripMenuItem
            // 
            this.inverToolStripMenuItem.Name = "inverToolStripMenuItem";
            this.inverToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.inverToolStripMenuItem.Text = "Inverter";
            this.inverToolStripMenuItem.Click += new System.EventHandler(this.inverToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sToolStripMenuItem.Text = "Shear";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.removerToolStripMenuItem.Text = "&Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.removerToolStripMenuItem_Click);
            // 
            // executarToolStripMenuItem
            // 
            this.executarToolStripMenuItem.Name = "executarToolStripMenuItem";
            this.executarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.executarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.executarToolStripMenuItem.Text = "&Executar";
            this.executarToolStripMenuItem.Click += new System.EventHandler(this.executarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Space)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ToolStripMenuItem traToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
    }
}
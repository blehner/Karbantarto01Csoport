namespace Karbantarto01Csoport
{
    partial class Admistrator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközökToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategóriaFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközRögzítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.végzettségekFelvételeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.eszközökToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // eszközökToolStripMenuItem
            // 
            this.eszközökToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategóriaFelvételeToolStripMenuItem,
            this.eszközRögzítéseToolStripMenuItem,
            this.végzettségekFelvételeToolStripMenuItem});
            this.eszközökToolStripMenuItem.Name = "eszközökToolStripMenuItem";
            this.eszközökToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.eszközökToolStripMenuItem.Text = "Eszközök";
            // 
            // kategóriaFelvételeToolStripMenuItem
            // 
            this.kategóriaFelvételeToolStripMenuItem.Name = "kategóriaFelvételeToolStripMenuItem";
            this.kategóriaFelvételeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kategóriaFelvételeToolStripMenuItem.Text = "Kategória felvétele";
            // 
            // eszközRögzítéseToolStripMenuItem
            // 
            this.eszközRögzítéseToolStripMenuItem.Name = "eszközRögzítéseToolStripMenuItem";
            this.eszközRögzítéseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eszközRögzítéseToolStripMenuItem.Text = "Eszköz rögzítése";
            // 
            // végzettségekFelvételeToolStripMenuItem
            // 
            this.végzettségekFelvételeToolStripMenuItem.Name = "végzettségekFelvételeToolStripMenuItem";
            this.végzettségekFelvételeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.végzettségekFelvételeToolStripMenuItem.Text = "Végzettségek felvétele";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Admistrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Admistrator";
            this.Text = "Admistrator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszközökToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategóriaFelvételeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszközRögzítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem végzettségekFelvételeToolStripMenuItem;
    }
}
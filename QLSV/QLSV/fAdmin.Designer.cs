
namespace QLSV
{
    partial class fAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLySinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyGiangVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLylopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySinhVienToolStripMenuItem,
            this.quanLyGiangVienToolStripMenuItem,
            this.quanLyMonHocToolStripMenuItem,
            this.quanLylopHocToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // quanLySinhVienToolStripMenuItem
            // 
            this.quanLySinhVienToolStripMenuItem.Name = "quanLySinhVienToolStripMenuItem";
            resources.ApplyResources(this.quanLySinhVienToolStripMenuItem, "quanLySinhVienToolStripMenuItem");
            this.quanLySinhVienToolStripMenuItem.Click += new System.EventHandler(this.quanLySinhVienToolStripMenuItem_Click);
            // 
            // quanLyGiangVienToolStripMenuItem
            // 
            this.quanLyGiangVienToolStripMenuItem.Name = "quanLyGiangVienToolStripMenuItem";
            resources.ApplyResources(this.quanLyGiangVienToolStripMenuItem, "quanLyGiangVienToolStripMenuItem");
            this.quanLyGiangVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyGiangVienToolStripMenuItem_Click);
            // 
            // quanLyMonHocToolStripMenuItem
            // 
            this.quanLyMonHocToolStripMenuItem.Name = "quanLyMonHocToolStripMenuItem";
            resources.ApplyResources(this.quanLyMonHocToolStripMenuItem, "quanLyMonHocToolStripMenuItem");
            this.quanLyMonHocToolStripMenuItem.Click += new System.EventHandler(this.quanLyMonHocToolStripMenuItem_Click);
            // 
            // quanLylopHocToolStripMenuItem
            // 
            this.quanLylopHocToolStripMenuItem.Name = "quanLylopHocToolStripMenuItem";
            resources.ApplyResources(this.quanLylopHocToolStripMenuItem, "quanLylopHocToolStripMenuItem");
            this.quanLylopHocToolStripMenuItem.Click += new System.EventHandler(this.quanLylopHocToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            resources.ApplyResources(this.pnlContent, "pnlContent");
            this.pnlContent.Name = "pnlContent";
            // 
            // fAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fAdmin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLySinhVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyGiangVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyMonHocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLylopHocToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}
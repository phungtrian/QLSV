
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLySinhVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyGiangVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyMonHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLylopHocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySinhVienToolStripMenuItem,
            this.quanLyGiangVienToolStripMenuItem,
            this.quanLyMonHocToolStripMenuItem,
            this.quanLylopHocToolStripMenuItem,
            this.DangXuatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 30);
            this.menuStrip1.TabIndex = 1;
            // 
            // quanLySinhVienToolStripMenuItem
            // 
            this.quanLySinhVienToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLySinhVienToolStripMenuItem.Name = "quanLySinhVienToolStripMenuItem";
            this.quanLySinhVienToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.quanLySinhVienToolStripMenuItem.Text = "Quản Lý Sinh Viên";
            this.quanLySinhVienToolStripMenuItem.Click += new System.EventHandler(this.quanLySinhVienToolStripMenuItem_Click);
            // 
            // quanLyGiangVienToolStripMenuItem
            // 
            this.quanLyGiangVienToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyGiangVienToolStripMenuItem.Name = "quanLyGiangVienToolStripMenuItem";
            this.quanLyGiangVienToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.quanLyGiangVienToolStripMenuItem.Text = "Quản Lý Giảng Viên";
            this.quanLyGiangVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyGiangVienToolStripMenuItem_Click);
            // 
            // quanLyMonHocToolStripMenuItem
            // 
            this.quanLyMonHocToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyMonHocToolStripMenuItem.Name = "quanLyMonHocToolStripMenuItem";
            this.quanLyMonHocToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.quanLyMonHocToolStripMenuItem.Text = "Quản Lý Môn Học";
            this.quanLyMonHocToolStripMenuItem.Click += new System.EventHandler(this.quanLyMonHocToolStripMenuItem_Click);
            // 
            // quanLylopHocToolStripMenuItem
            // 
            this.quanLylopHocToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLylopHocToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.quanLylopHocToolStripMenuItem.Name = "quanLylopHocToolStripMenuItem";
            this.quanLylopHocToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.quanLylopHocToolStripMenuItem.Text = "Quản Lý Lớp Học";
            this.quanLylopHocToolStripMenuItem.Click += new System.EventHandler(this.quanLylopHocToolStripMenuItem_Click);
            // 
            // DangXuatToolStripMenuItem
            // 
            this.DangXuatToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem";
            this.DangXuatToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.DangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.DangXuatToolStripMenuItem.Click += new System.EventHandler(this.DangXuatToolStripMenuItem_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.LightCyan;
            this.pnlContent.Location = new System.Drawing.Point(0, 33);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1196, 734);
            this.pnlContent.TabIndex = 2;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1043, 767);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fAdmin_FormClosed);
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
        private System.Windows.Forms.ToolStripMenuItem DangXuatToolStripMenuItem;
    }
}
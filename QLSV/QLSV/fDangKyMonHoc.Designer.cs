
namespace QLSV
{
    partial class fDangKyMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMonDaDK = new System.Windows.Forms.DataGridView();
            this.dgvMonChuaDK = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDaDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonChuaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Môn Học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMonDaDK);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 403);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn Đã Đăng Ký";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMonChuaDK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(517, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 403);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Môn Chưa Đăng Ký";
            // 
            // dgvMonDaDK
            // 
            this.dgvMonDaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonDaDK.Location = new System.Drawing.Point(6, 26);
            this.dgvMonDaDK.Name = "dgvMonDaDK";
            this.dgvMonDaDK.RowHeadersWidth = 51;
            this.dgvMonDaDK.RowTemplate.Height = 24;
            this.dgvMonDaDK.Size = new System.Drawing.Size(380, 342);
            this.dgvMonDaDK.TabIndex = 0;
            // 
            // dgvMonChuaDK
            // 
            this.dgvMonChuaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonChuaDK.Location = new System.Drawing.Point(6, 26);
            this.dgvMonChuaDK.Name = "dgvMonChuaDK";
            this.dgvMonChuaDK.RowHeadersWidth = 51;
            this.dgvMonChuaDK.RowTemplate.Height = 24;
            this.dgvMonChuaDK.Size = new System.Drawing.Size(380, 342);
            this.dgvMonChuaDK.TabIndex = 0;
            // 
            // fDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1004, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fDangKyMonHoc";
            this.Text = "fDangKyMonHoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDaDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonChuaDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMonDaDK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMonChuaDK;
    }
}

namespace QLSV
{
    partial class fQLDSSV
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btTraCuu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTuKhoa.Location = new System.Drawing.Point(167, 365);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(290, 30);
            this.txtTuKhoa.TabIndex = 1;
            this.txtTuKhoa.Text = "Nhập tên sinh viên";
            // 
            // btTraCuu
            // 
            this.btTraCuu.Location = new System.Drawing.Point(592, 365);
            this.btTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(151, 30);
            this.btTraCuu.TabIndex = 0;
            this.btTraCuu.Text = "Tra cứu";
            this.btTraCuu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSV);
            this.groupBox2.Location = new System.Drawing.Point(36, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(959, 262);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng thông tin sinh viên";
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Location = new System.Drawing.Point(6, 19);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 62;
            this.dgvDSSV.RowTemplate.Height = 28;
            this.dgvDSSV.Size = new System.Drawing.Size(948, 236);
            this.dgvDSSV.TabIndex = 0;
            this.dgvDSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sách Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(166, 214);
            this.btThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(134, 38);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quê Quán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Năm Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "SĐT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.btCapNhat);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtNamSinh);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtHo);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(167, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 264);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông TIn Sinh Viên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(438, 32);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(199, 22);
            this.txtTen.TabIndex = 8;
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(105, 32);
            this.txtHo.Multiline = true;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(263, 22);
            this.txtHo.TabIndex = 8;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(438, 63);
            this.txtGioiTinh.Multiline = true;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(199, 22);
            this.txtGioiTinh.TabIndex = 8;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(105, 105);
            this.txtNamSinh.Multiline = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(263, 22);
            this.txtNamSinh.TabIndex = 8;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(105, 147);
            this.txtQueQuan.Multiline = true;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(532, 22);
            this.txtQueQuan.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(438, 105);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(196, 22);
            this.txtSDT.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(105, 187);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(532, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(456, 214);
            this.btCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(134, 38);
            this.btCapNhat.TabIndex = 6;
            this.btCapNhat.Text = "Cập Nhật";
            this.btCapNhat.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "MSSV";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(105, 66);
            this.txtMSSV.Multiline = true;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(263, 22);
            this.txtMSSV.TabIndex = 8;
            // 
            // fQLDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 706);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btTraCuu);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fQLDSSV";
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.fQLDSSV_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btTraCuu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMSSV;
    }
}
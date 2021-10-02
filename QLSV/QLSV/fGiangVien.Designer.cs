
namespace QLSV
{
    partial class fGiangVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSLH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaLopHoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGiangVien = new System.Windows.Forms.ComboBox();
            this.btKetThucMon = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.btChamDiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Quản Lý Lớp Học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSLH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 308);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lớp Học";
            // 
            // dgvDSLH
            // 
            this.dgvDSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLH.Location = new System.Drawing.Point(70, 21);
            this.dgvDSLH.Name = "dgvDSLH";
            this.dgvDSLH.RowHeadersWidth = 51;
            this.dgvDSLH.RowTemplate.Height = 24;
            this.dgvDSLH.Size = new System.Drawing.Size(849, 281);
            this.dgvDSLH.TabIndex = 4;
            this.dgvDSLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLH_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSoTinChi);
            this.groupBox2.Controls.Add(this.txtTenMonHoc);
            this.groupBox2.Controls.Add(this.txtSiSo);
            this.groupBox2.Controls.Add(this.txtMaMonHoc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMaLopHoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbGiangVien);
            this.groupBox2.Controls.Add(this.btKetThucMon);
            this.groupBox2.Controls.Add(this.btDangXuat);
            this.groupBox2.Controls.Add(this.btChamDiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(81, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 219);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Lớp Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Lớp học";
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(601, 125);
            this.txtSoTinChi.Multiline = true;
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(185, 22);
            this.txtSoTinChi.TabIndex = 6;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(601, 80);
            this.txtTenMonHoc.Multiline = true;
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(185, 22);
            this.txtTenMonHoc.TabIndex = 6;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Location = new System.Drawing.Point(159, 78);
            this.txtSiSo.Multiline = true;
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(185, 22);
            this.txtSiSo.TabIndex = 6;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Location = new System.Drawing.Point(601, 34);
            this.txtMaMonHoc.Multiline = true;
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(185, 22);
            this.txtMaMonHoc.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số Tín Chỉ";
            // 
            // txtMaLopHoc
            // 
            this.txtMaLopHoc.Location = new System.Drawing.Point(159, 32);
            this.txtMaLopHoc.Multiline = true;
            this.txtMaLopHoc.Name = "txtMaLopHoc";
            this.txtMaLopHoc.Size = new System.Drawing.Size(185, 22);
            this.txtMaLopHoc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sỉ Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giáo viên";
            // 
            // cbGiangVien
            // 
            this.cbGiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbGiangVien.Enabled = false;
            this.cbGiangVien.FormattingEnabled = true;
            this.cbGiangVien.Location = new System.Drawing.Point(159, 120);
            this.cbGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbGiangVien.Name = "cbGiangVien";
            this.cbGiangVien.Size = new System.Drawing.Size(185, 27);
            this.cbGiangVien.TabIndex = 1;
            // 
            // btKetThucMon
            // 
            this.btKetThucMon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetThucMon.Location = new System.Drawing.Point(334, 172);
            this.btKetThucMon.Margin = new System.Windows.Forms.Padding(4);
            this.btKetThucMon.Name = "btKetThucMon";
            this.btKetThucMon.Size = new System.Drawing.Size(203, 40);
            this.btKetThucMon.TabIndex = 2;
            this.btKetThucMon.Text = "Kết Thúc Môn";
            this.btKetThucMon.UseVisualStyleBackColor = true;
            this.btKetThucMon.Click += new System.EventHandler(this.btKetThucMon_Click);
            // 
            // btDangXuat
            // 
            this.btDangXuat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.Location = new System.Drawing.Point(621, 172);
            this.btDangXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(165, 40);
            this.btDangXuat.TabIndex = 2;
            this.btDangXuat.Text = "Đăng Xuất";
            this.btDangXuat.UseVisualStyleBackColor = true;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // btChamDiem
            // 
            this.btChamDiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChamDiem.Location = new System.Drawing.Point(86, 172);
            this.btChamDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btChamDiem.Name = "btChamDiem";
            this.btChamDiem.Size = new System.Drawing.Size(165, 40);
            this.btChamDiem.TabIndex = 2;
            this.btChamDiem.Text = "Chấm Điểm";
            this.btChamDiem.UseVisualStyleBackColor = true;
            this.btChamDiem.Click += new System.EventHandler(this.btChamDiem_Click);
            // 
            // fGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1007, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "fGiangVien";
            this.Text = "fGiangVien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fGiangVien_FormClosed);
            this.Load += new System.EventHandler(this.fGiangVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSLH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.TextBox txtMaLopHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGiangVien;
        private System.Windows.Forms.Button btKetThucMon;
        private System.Windows.Forms.Button btChamDiem;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDangXuat;
    }
}

namespace QLSV
{
    partial class fChamDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btChonLop = new System.Windows.Forms.Button();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiemLan1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiemTongKet = new System.Windows.Forms.TextBox();
            this.txtDiemLan2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btThoat = new System.Windows.Forms.Button();
            this.btNhap = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN ĐIỂM SINH VIÊN ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChonLop);
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // btChonLop
            // 
            this.btChonLop.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChonLop.Location = new System.Drawing.Point(272, 111);
            this.btChonLop.Name = "btChonLop";
            this.btChonLop.Size = new System.Drawing.Size(75, 23);
            this.btChonLop.TabIndex = 9;
            this.btChonLop.Text = "Chọn";
            this.btChonLop.UseVisualStyleBackColor = true;
            this.btChonLop.Click += new System.EventHandler(this.btChonLop_Click);
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(85, 77);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(292, 27);
            this.cbMonHoc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Môn học";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(85, 31);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(292, 27);
            this.cbLop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDiemLan1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDiemTongKet);
            this.groupBox2.Controls.Add(this.txtDiemLan2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(21, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtDiemLan1
            // 
            this.txtDiemLan1.Location = new System.Drawing.Point(197, 69);
            this.txtDiemLan1.Name = "txtDiemLan1";
            this.txtDiemLan1.Size = new System.Drawing.Size(70, 26);
            this.txtDiemLan1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Điểm Giữa Kỳ";
            // 
            // txtDiemTongKet
            // 
            this.txtDiemTongKet.Location = new System.Drawing.Point(655, 69);
            this.txtDiemTongKet.Name = "txtDiemTongKet";
            this.txtDiemTongKet.Size = new System.Drawing.Size(59, 26);
            this.txtDiemTongKet.TabIndex = 11;
            // 
            // txtDiemLan2
            // 
            this.txtDiemLan2.Location = new System.Drawing.Point(431, 69);
            this.txtDiemLan2.Name = "txtDiemLan2";
            this.txtDiemLan2.Size = new System.Drawing.Size(59, 26);
            this.txtDiemLan2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Điểm tổng kết";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điểm Cuối Kỳ";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(524, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(163, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Họ và tên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(197, 28);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(112, 26);
            this.txtMaSV.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Location = new System.Drawing.Point(419, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(344, 141);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(6, 20);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(333, 105);
            this.txtGhiChu.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDiem);
            this.groupBox4.Location = new System.Drawing.Point(21, 297);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 166);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dgvDiem
            // 
            this.dgvDiem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(10, 18);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.Size = new System.Drawing.Size(727, 136);
            this.dgvDiem.TabIndex = 0;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(769, 308);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(92, 39);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát ";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btNhap
            // 
            this.btNhap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNhap.Location = new System.Drawing.Point(769, 237);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(92, 39);
            this.btNhap.TabIndex = 5;
            this.btNhap.Text = "Nhập";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.Color.Blue;
            this.btIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIn.Location = new System.Drawing.Point(769, 384);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(92, 37);
            this.btIn.TabIndex = 12;
            this.btIn.Text = "In Bảng Điểm";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // fChamDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(873, 463);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fChamDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập điểm sinh viên";
            this.Load += new System.EventHandler(this.fChamDiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemLan1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiemLan2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvDiem;
        // private Quản_lý_điểm_sinh_vien_CNTT.QuanlydiemDataSet47TableAdapters.tblKET_QUATableAdapter tblKET_QUATableAdapter;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemThiLan1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTongKetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanhKiemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDiemTongKet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btChonLop;
    }
}

namespace QLSV
{
    partial class fQLLopHoc
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
            this.cbMonhoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGiangVien = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvDSLH = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaLopHoc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btTraCuu = new System.Windows.Forms.Button();
            this.btXemDSSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn học";
            // 
            // cbMonhoc
            // 
            this.cbMonhoc.FormattingEnabled = true;
            this.cbMonhoc.Location = new System.Drawing.Point(244, 72);
            this.cbMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonhoc.Name = "cbMonhoc";
            this.cbMonhoc.Size = new System.Drawing.Size(432, 27);
            this.cbMonhoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giáo viên";
            // 
            // cbGiangVien
            // 
            this.cbGiangVien.FormattingEnabled = true;
            this.cbGiangVien.Location = new System.Drawing.Point(244, 120);
            this.cbGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbGiangVien.Name = "cbGiangVien";
            this.cbGiangVien.Size = new System.Drawing.Size(432, 27);
            this.cbGiangVien.TabIndex = 1;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(55, 159);
            this.btThem.Margin = new System.Windows.Forms.Padding(4);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(109, 53);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvDSLH
            // 
            this.dgvDSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLH.Location = new System.Drawing.Point(70, 21);
            this.dgvDSLH.Name = "dgvDSLH";
            this.dgvDSLH.RowHeadersWidth = 51;
            this.dgvDSLH.RowTemplate.Height = 24;
            this.dgvDSLH.Size = new System.Drawing.Size(849, 260);
            this.dgvDSLH.TabIndex = 4;
            this.dgvDSLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLH_CellClick);
            this.dgvDSLH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLH_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSLH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 297);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lớp Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Lớp học";
            // 
            // txtMaLopHoc
            // 
            this.txtMaLopHoc.Enabled = false;
            this.txtMaLopHoc.Location = new System.Drawing.Point(244, 32);
            this.txtMaLopHoc.Multiline = true;
            this.txtMaLopHoc.Name = "txtMaLopHoc";
            this.txtMaLopHoc.Size = new System.Drawing.Size(432, 22);
            this.txtMaLopHoc.TabIndex = 6;
            this.txtMaLopHoc.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMaLopHoc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbGiangVien);
            this.groupBox2.Controls.Add(this.btXemDSSV);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Controls.Add(this.cbMonhoc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(85, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 219);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Lớp Học";
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(475, 159);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(133, 53);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(244, 159);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(133, 53);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Cập nhật";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quản Lý Lớp Học";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTuKhoa);
            this.groupBox3.Controls.Add(this.btTraCuu);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(183, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 60);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra Cứu";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(70, 26);
            this.txtTuKhoa.Multiline = true;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(331, 26);
            this.txtTuKhoa.TabIndex = 0;
            this.txtTuKhoa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTuKhoa_KeyDown);
            // 
            // btTraCuu
            // 
            this.btTraCuu.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraCuu.Location = new System.Drawing.Point(473, 15);
            this.btTraCuu.Margin = new System.Windows.Forms.Padding(4);
            this.btTraCuu.Name = "btTraCuu";
            this.btTraCuu.Size = new System.Drawing.Size(133, 40);
            this.btTraCuu.TabIndex = 2;
            this.btTraCuu.Text = "Tra Cứu";
            this.btTraCuu.UseVisualStyleBackColor = true;
            this.btTraCuu.Click += new System.EventHandler(this.btTraCuu_Click);
            // 
            // btXemDSSV
            // 
            this.btXemDSSV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXemDSSV.Location = new System.Drawing.Point(686, 159);
            this.btXemDSSV.Margin = new System.Windows.Forms.Padding(4);
            this.btXemDSSV.Name = "btXemDSSV";
            this.btXemDSSV.Size = new System.Drawing.Size(106, 53);
            this.btXemDSSV.TabIndex = 2;
            this.btXemDSSV.Text = "Xem Danh Sách Sinh Viên";
            this.btXemDSSV.UseVisualStyleBackColor = true;
            this.btXemDSSV.Click += new System.EventHandler(this.btXemDSSV_Click);
            // 
            // fQLLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1029, 679);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fQLLopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Lớp Học";
            this.Load += new System.EventHandler(this.fQLLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMonhoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGiangVien;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvDSLH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaLopHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Button btTraCuu;
        private System.Windows.Forms.Button btXemDSSV;
    }
}


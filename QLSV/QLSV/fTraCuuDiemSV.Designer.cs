
namespace QLSV
{
    partial class fTraCuuDiemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTraCuuDiemSV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDiemSV = new System.Windows.Forms.DataGridView();
            this.btTatCaHK = new System.Windows.Forms.Button();
            this.btHKHienTai = new System.Windows.Forms.Button();
            this.btXuatExcel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Môn";
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(351, 21);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 24);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn Học";
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(121, 21);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(199, 27);
            this.cbMonHoc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tra Cứu Điểm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDiemSV);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 371);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách điểm";
            // 
            // dgvDiemSV
            // 
            this.dgvDiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemSV.Location = new System.Drawing.Point(6, 27);
            this.dgvDiemSV.Name = "dgvDiemSV";
            this.dgvDiemSV.RowHeadersWidth = 51;
            this.dgvDiemSV.RowTemplate.Height = 24;
            this.dgvDiemSV.Size = new System.Drawing.Size(921, 338);
            this.dgvDiemSV.TabIndex = 0;
            // 
            // btTatCaHK
            // 
            this.btTatCaHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTatCaHK.Location = new System.Drawing.Point(521, 63);
            this.btTatCaHK.Name = "btTatCaHK";
            this.btTatCaHK.Size = new System.Drawing.Size(98, 58);
            this.btTatCaHK.TabIndex = 3;
            this.btTatCaHK.Text = "Tất Cả học kỳ";
            this.btTatCaHK.UseVisualStyleBackColor = true;
            this.btTatCaHK.Click += new System.EventHandler(this.btTatCaHK_Click);
            // 
            // btHKHienTai
            // 
            this.btHKHienTai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHKHienTai.Location = new System.Drawing.Point(660, 63);
            this.btHKHienTai.Name = "btHKHienTai";
            this.btHKHienTai.Size = new System.Drawing.Size(98, 58);
            this.btHKHienTai.TabIndex = 3;
            this.btHKHienTai.Text = "Học Kỳ hiện tại";
            this.btHKHienTai.UseVisualStyleBackColor = true;
            this.btHKHienTai.Click += new System.EventHandler(this.btHKHienTai_Click);
            // 
            // btXuatExcel
            // 
            this.btXuatExcel.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXuatExcel.Location = new System.Drawing.Point(801, 63);
            this.btXuatExcel.Name = "btXuatExcel";
            this.btXuatExcel.Size = new System.Drawing.Size(103, 58);
            this.btXuatExcel.TabIndex = 3;
            this.btXuatExcel.Text = "Xuất excel bảng điểm";
            this.btXuatExcel.UseVisualStyleBackColor = true;
            this.btXuatExcel.Click += new System.EventHandler(this.btXuatExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2019|*.xlsx|Excel 2003|*.xls";
            // 
            // fTraCuuDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(951, 510);
            this.Controls.Add(this.btXuatExcel);
            this.Controls.Add(this.btHKHienTai);
            this.Controls.Add(this.btTatCaHK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTraCuuDiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTraCuuDiemSV";
            this.Load += new System.EventHandler(this.fTraCuuDiemSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDiemSV;
        private System.Windows.Forms.Button btTatCaHK;
        private System.Windows.Forms.Button btHKHienTai;
        private System.Windows.Forms.Button btXuatExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
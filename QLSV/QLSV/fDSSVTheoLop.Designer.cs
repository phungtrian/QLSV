
namespace QLSV
{
    partial class fDSSVTheoLop
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.btChon = new System.Windows.Forms.Button();
            this.btHuyMon = new System.Windows.Forms.Button();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btChamDiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Sinh Viên Theo Lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChon);
            this.groupBox1.Controls.Add(this.cbMonHoc);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 66);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDiem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 464);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btHuyMon);
            this.groupBox3.Controls.Add(this.txtMSSV);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(556, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(491, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sinh Viên được chọn";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(6, 26);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(101, 27);
            this.cbLop.TabIndex = 0;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(24, 27);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(197, 27);
            this.txtMSSV.TabIndex = 0;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(113, 26);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(243, 27);
            this.cbMonHoc.TabIndex = 0;
            // 
            // btChon
            // 
            this.btChon.Location = new System.Drawing.Point(391, 22);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(104, 33);
            this.btChon.TabIndex = 1;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // btHuyMon
            // 
            this.btHuyMon.Location = new System.Drawing.Point(367, 21);
            this.btHuyMon.Name = "btHuyMon";
            this.btHuyMon.Size = new System.Drawing.Size(104, 33);
            this.btHuyMon.TabIndex = 1;
            this.btHuyMon.Text = "Hủy Môn";
            this.btHuyMon.UseVisualStyleBackColor = true;
            this.btHuyMon.Click += new System.EventHandler(this.btHuyMon_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(6, 26);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.Size = new System.Drawing.Size(965, 432);
            this.dgvDiem.TabIndex = 0;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // btChamDiem
            // 
            this.btChamDiem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChamDiem.Location = new System.Drawing.Point(996, 177);
            this.btChamDiem.Name = "btChamDiem";
            this.btChamDiem.Size = new System.Drawing.Size(68, 81);
            this.btChamDiem.TabIndex = 4;
            this.btChamDiem.Text = "Nhập Điểm";
            this.btChamDiem.UseVisualStyleBackColor = true;
            this.btChamDiem.Click += new System.EventHandler(this.btChamDiem_Click);
            // 
            // fDSSVTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1070, 612);
            this.Controls.Add(this.btChamDiem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fDSSVTheoLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fDSSVTheoLop";
            this.Load += new System.EventHandler(this.fDSSVTheoLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btHuyMon;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btChamDiem;
    }
}
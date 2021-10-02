using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }
        private void addForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            //this.mnsMain.Show();
            f.TopLevel = false;
            f.AutoScroll = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.StartPosition = FormStartPosition.Manual;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }

        private void quanLySinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new fQLDSSV();
            addForm(f);
        }

        private void quanLyGiangVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new fQLDSGV();
            addForm(f);
        }

        private void quanLyMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new fQLDSMH();
            addForm(f);
        }

        private void quanLylopHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new fQLLopHoc();
            addForm(f);
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.StartPosition = FormStartPosition.CenterScreen;

        }

        private void fAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.Close();
        }
    }
}

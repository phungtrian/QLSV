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
    public partial class QLGV : Form
    {
        public QLGV()
        {
            InitializeComponent();
        }

        private void txtTuKhoa_Enter(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                txtTuKhoa.Text = "Nhập tên giảng viên";
                txtTuKhoa.ForeColor = Color.Silver;
            }    
        }

        private void btThem_Click(object sender, EventArgs e)
        {

        }
    }
}

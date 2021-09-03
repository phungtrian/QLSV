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
    public partial class fQLDSGV : Form
    {
        public fQLDSGV()
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

        //private string tukhoa = "";
        //private void loadDSGV()
        //{
        //    string sql = "selectAllGV";
        //    List<CustomParameter> lstPara = new List<CustomParameter>();
        //    lstPara.Add(new CustomParameter()
        //    {
        //        key = "@tukhoa",
        //        value = tukhoa
        //    });
        //    dgvDSGV.DataSource = new Database().SelectData(sql, lstPara);
        //}
    }
}

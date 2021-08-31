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
    public partial class fQLDSMH : Form
    {
        public fQLDSMH()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("select maMonHoc, tenMonHoc,soTinChi from MonHoc", lstPara);
        }

        private void fQLDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["maMonHoc"].HeaderText = "Mã Môn Học";
            dgvDSMH.Columns["tenMonHoc"].HeaderText = "Tên Môn Học";
            dgvDSMH.Columns["soTinChi"].HeaderText = "Số Tín Chỉ";
            
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSMH();
        }
    }
}

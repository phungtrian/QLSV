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
        BUS_DSMH busDSMH;
        public fQLDSMH()
        {
            InitializeComponent();
            busDSMH = new BUS_DSMH();
        }

        private void fQLDSMH_Load(object sender, EventArgs e)
        {
            busDSMH.DSMonHoc(dgvDSMH);
            //Chia các cột đều đẹp mắt
            dgvDSMH.Columns[0].Width = (int)(0.3 * dgvDSMH.Width);
            dgvDSMH.Columns[1].Width = (int)(0.4 * dgvDSMH.Width);
            dgvDSMH.Columns[2].Width = (int)(0.25 * dgvDSMH.Width);
        }

        private void dgvDSMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSMH.Rows.Count )
            {
                txtMaMon.Text = dgvDSMH.Rows[e.RowIndex].Cells["maMonHoc"].Value.ToString();
                txtTenMon.Text = dgvDSMH.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTinChi.Text = dgvDSMH.Rows[e.RowIndex].Cells[2].Value.ToString(); 
            }
        }


        //private string tukhoa = "";
        //private void LoadDSMH()
        //{
        //    List<CustomParameter> lstPara = new List<CustomParameter>();
        //    lstPara.Add(new CustomParameter()
        //    {
        //        key = "@tukhoa",
        //        value = tukhoa
        //    });
        //    dgvDSMH.DataSource = new Database().SelectData("select maMonHoc, tenMonHoc,soTinChi from MonHoc", lstPara);
        //}

        //private void fQLDSMH_Load(object sender, EventArgs e)
        //{
        //    LoadDSMH();
        //    dgvDSMH.Columns["maMonHoc"].HeaderText = "Mã Môn Học";
        //    dgvDSMH.Columns["tenMonHoc"].HeaderText = "Tên Môn Học";
        //    dgvDSMH.Columns["soTinChi"].HeaderText = "Số Tín Chỉ";

        //}

        //private void btTraCuu_Click(object sender, EventArgs e)
        //{
        //    tukhoa = txtTuKhoa.Text;
        //    LoadDSMH();
        //}
    }
}

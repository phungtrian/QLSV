using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.BUS;

namespace QLSV
{
    public partial class fQLDSMH : Form
    {
        BUSMonHoc busDSMH;
        public fQLDSMH()
        {
            InitializeComponent();
            busDSMH = new BUSMonHoc();
        }

        private void HienThiDSMH()
        {
            busDSMH.DSMonHoc(dgvDSMH);
            //Chia các cột đều đẹp mắt
            dgvDSMH.Columns[0].Width = (int)(0.3 * dgvDSMH.Width);
            dgvDSMH.Columns[1].Width = (int)(0.35 * dgvDSMH.Width);
            dgvDSMH.Columns[2].Width = (int)(0.25 * dgvDSMH.Width);

        }

        private void fQLDSMH_Load(object sender, EventArgs e)
        {
            HienThiDSMH();
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

        private void btThem_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = new MonHoc();
            //monHoc.maMonHoc = int.Parse(txtMaMon.Text);
            monHoc.tenMonHoc = txtTenMon.Text;
            monHoc.soTinChi = int.Parse(txtTinChi.Text);
            busDSMH.ThemMH(monHoc);
            busDSMH.DSMonHoc(dgvDSMH);
            HienThiDSMH();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = new MonHoc();
            monHoc.maMonHoc = int.Parse(txtMaMon.Text);
            monHoc.tenMonHoc = txtTenMon.Text;
            monHoc.soTinChi = int.Parse(txtTinChi.Text);

            if (busDSMH.SuaMonHoc(monHoc))
            {
                MessageBox.Show("Sửa thông tin Môn Học thành công");
            }
            else
                MessageBox.Show("Không tìm thấy mã môn học");
            HienThiDSMH();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            MonHoc monHoc = new MonHoc();
            monHoc.maMonHoc = int.Parse(txtMaMon.Text);
            monHoc.tenMonHoc = txtTenMon.Text;
            monHoc.soTinChi = int.Parse(txtTinChi.Text);

            if (busDSMH.XoaMonHoc(monHoc))
            {
                MessageBox.Show("Xóa thông tin Môn Học thành công");
            }
            else
                MessageBox.Show("Không tìm thấy mã môn học");
            HienThiDSMH();

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

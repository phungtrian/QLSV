using QLSV.BUS;
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
        BUSGiangVien busGV;
        public fQLDSGV()
        {
            InitializeComponent();
            busGV = new BUSGiangVien();
        }

        private void txtTuKhoa_Enter(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text == "")
            {
                txtTuKhoa.Text = "Nhập tên giảng viên";
                txtTuKhoa.ForeColor = Color.Silver;
            }
        }

        private void HienThiDSGV()
        {
            busGV.DSGiangVien(dgvDSGV);

            dgvDSGV.Columns[0].Width = (int)(0.075 * dgvDSGV.Width);
            dgvDSGV.Columns[1].Width = (int)(0.195 * dgvDSGV.Width);
            dgvDSGV.Columns[2].Width = (int)(0.1 * dgvDSGV.Width);
            dgvDSGV.Columns[3].Width = (int)(0.075 * dgvDSGV.Width);
            dgvDSGV.Columns[4].Width = (int)(0.1 * dgvDSGV.Width);
            dgvDSGV.Columns[5].Width = (int)(0.19 * dgvDSGV.Width);
            dgvDSGV.Columns[6].Width = (int)(0.15 * dgvDSGV.Width);
            dgvDSGV.Columns[7].Width = (int)(0.12 * dgvDSGV.Width);
            dgvDSGV.RowHeadersVisible = false;
        }

        private bool KiemTraTXTMa()
        {
            string kt = txtMaGV.Text;
            kt = kt.Replace(" ", string.Empty);

            if (kt == "")
            {
                MessageBox.Show("bạn chưa nhập Mã Giảng Viên");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void fQLDSGV_Load(object sender, EventArgs e)
        {
            HienThiDSGV();
            busGV.HienThiLoaiGioiTinh(cbLoaiGioiTinh);

        }

        private void dgvDSGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSGV.Rows.Count)
            {

                txtMaGV.Text = dgvDSGV.Rows[e.RowIndex].Cells["maGiangVien"].Value.ToString();
                txtHo.Text = dgvDSGV.Rows[e.RowIndex].Cells["ho"].Value.ToString();
                txtTen.Text = dgvDSGV.Rows[e.RowIndex].Cells["ten"].Value.ToString();
                cbLoaiGioiTinh.Text = dgvDSGV.Rows[e.RowIndex].Cells["gioiTinh"].Value.ToString();
                dtpNamSinh.Value = (DateTime)dgvDSGV.Rows[e.RowIndex].Cells["namSinh"].Value;
                txtEmail.Text = dgvDSGV.Rows[e.RowIndex].Cells["email"].Value.ToString();
                txtDiaChi.Text = dgvDSGV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvDSGV.Rows[e.RowIndex].Cells["soDienThoai"].Value.ToString();

            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            gv.maGiangVien = int.Parse(txtMaGV.Text.ToString());
            gv.ho = txtHo.Text.ToString();
            gv.ten = txtTen.Text.ToString();
            gv.gioiTinh = cbLoaiGioiTinh.Text;
            gv.namSinh = dtpNamSinh.Value;
            gv.email = txtEmail.Text.ToString();
            gv.diaChi = txtDiaChi.Text.ToString();
            gv.soDienThoai = int.Parse(txtSDT.Text.ToString());
            gv.matKhau = "1234";

            busGV.ThemGV(gv);

            HienThiDSGV();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraTXTMa())
            {
                GiangVien gv = new GiangVien();
                gv.maGiangVien = int.Parse(txtMaGV.Text.ToString());
                gv.ho = txtHo.Text.ToString();
                gv.ten = txtTen.Text.ToString();
                gv.gioiTinh = cbLoaiGioiTinh.Text;
                gv.namSinh = dtpNamSinh.Value;
                gv.email = txtEmail.Text.ToString();
                gv.diaChi = txtDiaChi.Text.ToString();
                gv.soDienThoai = int.Parse(txtSDT.Text.ToString());
                gv.matKhau = "1234";



                if (busGV.SuaGV(gv))
                {
                    MessageBox.Show("Cập nhật thông tin Giảng Viên Thành Công");
                }
                else
                    MessageBox.Show("Bạn nhập Mã Giảng Viên sai. Hoặc không tìm thấy Giảng Viên");

                HienThiDSGV();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraTXTMa())
            {
                GiangVien gv = new GiangVien();
                gv.maGiangVien = int.Parse(txtMaGV.Text.ToString());
                gv.ho = txtHo.Text.ToString();
                gv.ten = txtTen.Text.ToString();
                gv.gioiTinh = cbLoaiGioiTinh.Text;
                gv.namSinh = dtpNamSinh.Value;
                gv.email = txtEmail.Text.ToString();
                gv.diaChi = txtDiaChi.Text.ToString();
                gv.soDienThoai = int.Parse(txtSDT.Text.ToString());
                gv.matKhau = "1234";


                if (busGV.XoaGV(gv))
                {
                    MessageBox.Show("Xóa thông tin Giảng Viên Thành Công");
                }
                else
                    MessageBox.Show("Bạn nhập Mã Giảng Viên sai. Hoặc không tìm thấy Giảng Viên");

                HienThiDSGV();
            }
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            busGV.TimKiemHienThiMH(txtTuKhoa.Text, dgvDSGV);

        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTraCuu.PerformClick();
            }
        }
    }
}

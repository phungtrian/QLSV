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
    public partial class fQLDSSV : Form
    {
        BUSSinhVien busDSSV;
        public fQLDSSV()
        {
            InitializeComponent();
            busDSSV = new BUSSinhVien();
        }

        private void HienThiDSSV()
        {
            busDSSV.DSSinhVien(dgvDSSV);

            dgvDSSV.Columns[0].Width = (int)(0.13 * dgvDSSV.Width);
            dgvDSSV.Columns[1].Width = (int)(0.195 * dgvDSSV.Width);
            dgvDSSV.Columns[2].Width = (int)(0.1 * dgvDSSV.Width);
            dgvDSSV.Columns[3].Width = (int)(0.06 * dgvDSSV.Width);
            dgvDSSV.Columns[4].Width = (int)(0.1 * dgvDSSV.Width);
            dgvDSSV.Columns[5].Width = (int)(0.19 * dgvDSSV.Width);
            dgvDSSV.Columns[6].Width = (int)(0.1 * dgvDSSV.Width);
            dgvDSSV.Columns[7].Width = (int)(0.125 * dgvDSSV.Width);
            //dgvDSSV.RowHeadersVisible = false;
            //dgvDSSV.AllowUserToAddRows = true;
            //dgvDSSV.AllowUserToDeleteRows = true;
            //dgvDSSV.AllowUserToOrderColumns = true;
            
            //for (int i = 0; i < dgvDSSV.Rows.Count; i++)
            //{
            //    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
            //    dgvDSSV[8, i] = linkCell;
            //}
        }
        private bool KiemTraTXTMa()
        {
            string kt = txtMSSV.Text;
            kt = kt.Replace(" ", string.Empty);

            if (kt == "")
            {
                MessageBox.Show("bạn chưa nhập Mã Số Sinh Viên");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void fQLDSSV_Load(object sender, EventArgs e)
        {
            HienThiDSSV();

        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraTXTMa())
            {
                SinhVien sv;
                sv = new SinhVien();
                sv.maSinhVien = int.Parse(txtMSSV.Text);
                sv.Ho = txtHo.Text;
                sv.Ten = txtTen.Text;
                sv.namSinh = dtpNamSinh.Value;
                sv.gioiTinh = cbLoaiGioiTinh.Text;
                sv.diaChi = txtDiaChi.Text;
                sv.dienThoai = int.Parse(txtSDT.Text);
                sv.queQuan = txtQueQuan.Text;
                sv.matKhau = "123";

                if (busDSSV.SuaSinhVien(sv))
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên Thành Công");
                }
                else
                    MessageBox.Show("Bạn nhập MSSV sai hoặc không tìm thấy sinh viên");
                HienThiDSSV();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraTXTMa())
            {
                SinhVien sv;
                sv = new SinhVien();
                sv.maSinhVien = int.Parse(txtMSSV.Text);
                sv.Ho = txtHo.Text;
                sv.Ten = txtTen.Text;
                sv.namSinh = dtpNamSinh.Value;
                sv.gioiTinh = cbLoaiGioiTinh.Text;
                sv.diaChi = txtDiaChi.Text;
                sv.queQuan = txtQueQuan.Text;
                sv.matKhau = "1233";

                if (busDSSV.XoaSinhVien(sv))
                {
                    MessageBox.Show("Xóa thông tin sinh viên Thành Công");
                }
                else
                    MessageBox.Show("Bạn nhập MSSV sai. Hoặc không tìm thấy sinh viên");
                HienThiDSSV();
            }
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSSV.Rows.Count)
            {

                txtMSSV.Text = dgvDSSV.Rows[e.RowIndex].Cells["maSinhVien"].Value.ToString();
                txtHo.Text = dgvDSSV.Rows[e.RowIndex].Cells["Ho"].Value.ToString();
                txtTen.Text = dgvDSSV.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                cbLoaiGioiTinh.Text = dgvDSSV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                dtpNamSinh.Value = (DateTime)dgvDSSV.Rows[e.RowIndex].Cells["NamSinh"].Value;
                txtQueQuan.Text = dgvDSSV.Rows[e.RowIndex].Cells["QueQuan"].Value.ToString();
                txtDiaChi.Text = dgvDSSV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvDSSV.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();

            }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTraCuu.PerformClick();
            }
        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            busDSSV.TimKiemHienThiSinhVien(txtTuKhoa.Text, dgvDSSV);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.maSinhVien = int.Parse(txtMSSV.Text.ToString());
            sv.Ho = txtHo.Text.ToString();
            sv.Ten = txtTen.Text.ToString();
            sv.gioiTinh = cbLoaiGioiTinh.Text;
            sv.namSinh = dtpNamSinh.Value;
            sv.queQuan = txtQueQuan.Text.ToString();
            sv.diaChi = txtDiaChi.Text.ToString();
            sv.dienThoai = int.Parse(txtSDT.Text.ToString());
            sv.matKhau = "123";

            busDSSV.ThemSV(sv);

            HienThiDSSV();
        }


        private void dgvDSSV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                MessageBox.Show("Không thể sửa mã sv");
            }
            else
            {
                SinhVien sv = new SinhVien();
                sv.maSinhVien = int.Parse(dgvDSSV.Rows[e.RowIndex].Cells["maSinhVien"].Value.ToString());
                sv.Ho = dgvDSSV.Rows[e.RowIndex].Cells["Ho"].Value.ToString();
                sv.Ten = dgvDSSV.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                sv.gioiTinh = dgvDSSV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                sv.namSinh = (DateTime)dgvDSSV.Rows[e.RowIndex].Cells["NamSinh"].Value;
                sv.queQuan = dgvDSSV.Rows[e.RowIndex].Cells["QueQuan"].Value.ToString();
                sv.diaChi = dgvDSSV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                sv.dienThoai = int.Parse(dgvDSSV.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString());
                sv.matKhau = "123";
                busDSSV.SuaSinhVien(sv);
            }
        }
    }
}

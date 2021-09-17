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

            dgvDSSV.Columns[0].Width = (int)(0.109 * dgvDSSV.Width);
            dgvDSSV.Columns[1].Width = (int)(0.195 * dgvDSSV.Width);
            dgvDSSV.Columns[2].Width = (int)(0.05 * dgvDSSV.Width);
            dgvDSSV.Columns[3].Width = (int)(0.075 * dgvDSSV.Width);
            dgvDSSV.Columns[4].Width = (int)(0.1 * dgvDSSV.Width);
            dgvDSSV.Columns[5].Width = (int)(0.19 * dgvDSSV.Width);
            dgvDSSV.Columns[6].Width = (int)(0.1 * dgvDSSV.Width);
            dgvDSSV.Columns[7].Width = (int)(0.1 * dgvDSSV.Width);
        }

        private void fQLDSSV_Load(object sender, EventArgs e)
        {
            HienThiDSSV();
            busDSSV.HienThiLoaiGioiTinh(cbLoaiGioiTinh);
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

            busDSSV.ThemSV(sv);

            HienThiDSSV();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
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

            if (busDSSV.SuaSinhViem(sv))
            {
                MessageBox.Show("Cập nhật thông tin sinh viên Thành Công");
            }
            else
                MessageBox.Show("Bạn nhập MSSV sai. Hoặc không tìm thấy sinh viên");
            HienThiDSSV();

        }

        private void btXoa_Click(object sender, EventArgs e)
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

            if (busDSSV.XoaSinhVien(sv))
            {
                MessageBox.Show("Xóa thông tin sinh viên Thành Công");
            }
            else
                MessageBox.Show("Bạn nhập MSSV sai. Hoặc không tìm thấy sinh viên");
            HienThiDSSV();
        }
    }

}

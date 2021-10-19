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
    public partial class fQLLopHoc : Form
    {
        BUSLopHoc busLH;
        XuatExcel xuatFile;
        public fQLLopHoc()
        {
            InitializeComponent();
            busLH = new BUSLopHoc();
            xuatFile = new XuatExcel();
        }

        private void DieuChinhCBTrangThai()
        {
            dynamic items = new[] {
            new { Text = "Đang Mở", Value = 0 },
            new { Text = "Đã kết Thúc", Value = 1 }
            }.ToList();
            cbTrangThai.DataSource = items;
            cbTrangThai.DisplayMember = "Text";
            cbTrangThai.ValueMember = "Value";
            
        }

        private void HienThiDSLH()
        {
            busLH.DSLopHoc(dgvDSLH);

            dgvDSLH.Columns[0].Width = (int)(0.1 * dgvDSLH.Width);
            dgvDSLH.Columns[1].Width = (int)(0.35 * dgvDSLH.Width);
            dgvDSLH.Columns[2].Width = (int)(0.35 * dgvDSLH.Width);
            dgvDSLH.Columns[3].Width = (int)(0.1 * dgvDSLH.Width);
            dgvDSLH.Columns[4].Width = (int)(0.1 * dgvDSLH.Width);
            dgvDSLH.RowHeadersVisible = false;

        }

        private void fQLLopHoc_Load(object sender, EventArgs e)
        {
            HienThiDSLH();
            busLH.HienThiMonHoc(cbMonhoc);
            busLH.HienThicbGiangVien(cbGiangVien);
            DieuChinhCBTrangThai();


        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LopHoc lh = new LopHoc();
            lh.maLopHoc = int.Parse(txtMaLopHoc.Text);
            lh.maGiangVien = int.Parse(cbGiangVien.SelectedValue.ToString());
            lh.maMonHoc = int.Parse(cbMonhoc.SelectedValue.ToString());
            lh.daKetThuc = 0;

            busLH.ThemLopHoc(lh);

            HienThiDSLH();
        }
        private bool KiemTraTXTMa()
        {
            string kt = txtMaLopHoc.Text;
            kt = kt.Replace(" ", string.Empty);

            if (kt == "")
            {
                MessageBox.Show("bạn chưa nhập Mã lớp học");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTXTMa())
            {
                LopHoc lh = new LopHoc();
                lh.maLopHoc = int.Parse(txtMaLopHoc.Text);
                lh.maGiangVien = int.Parse(cbGiangVien.SelectedValue.ToString());
                lh.maMonHoc = int.Parse(cbMonhoc.SelectedValue.ToString());
                lh.daKetThuc = byte.Parse(cbTrangThai.SelectedValue.ToString());

                if (busLH.SuaLopHoc(lh))
                {
                    MessageBox.Show("Cập nhật thông tin Lớp Học Thành Công");
                }
                else
                    MessageBox.Show("Bạn nhập Mã Lớp Học sai. Hoặc không tìm thấy Lớp Học");
                HienThiDSLH();
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (KiemTraTXTMa())
            {
                LopHoc lh = new LopHoc();
                lh.maLopHoc = int.Parse(txtMaLopHoc.Text);
                lh.maGiangVien = int.Parse(cbGiangVien.SelectedValue.ToString());
                lh.maMonHoc = int.Parse(cbMonhoc.SelectedValue.ToString());

                if (busLH.XoaLopHoc(lh))
                {
                    MessageBox.Show("Xóa thông tin Lớp Học Thành Công");
                }
                else
                    MessageBox.Show("Bạn nhập Mã Lớp Học sai. Hoặc không tìm thấy Lớp Học");
                HienThiDSLH();
            }

        }

        private void btTraCuu_Click(object sender, EventArgs e)
        {
            busLH.TimKiemHienThiLH(txtTuKhoa.Text, dgvDSLH);

        }

        private void dgvDSLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSLH.Rows.Count)
            {
                txtMaLopHoc.Text = dgvDSLH.Rows[e.RowIndex].Cells["maLopHoc"].Value.ToString();
                cbGiangVien.Text = dgvDSLH.Rows[e.RowIndex].Cells["HoTenGiangVien"].Value.ToString();
                cbMonhoc.Text = dgvDSLH.Rows[e.RowIndex].Cells["tenMonHoc"].Value.ToString();
                cbTrangThai.SelectedValue = int.Parse(dgvDSLH.Rows[e.RowIndex].Cells["daKetThuc"].Value.ToString());
            }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTraCuu.PerformClick();
            }
        }

        private void btXemDSSV_Click(object sender, EventArgs e)
        {
            fDSSVTheoLop f = new fDSSVTheoLop();
            f.maLop = int.Parse(txtMaLopHoc.Text);
            f.Show();
        }

        private void dgvDSLH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fDSSVTheoLop f = new fDSSVTheoLop();
            f.maLop = int.Parse(dgvDSLH.Rows[e.RowIndex].Cells["maLopHoc"].Value.ToString());
            f.Show();
        }

        private void btXuatDS_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xuatFile.XuatFileExcelDanhSach(dgvDSLH, saveFileDialog1.FileName, "Danh Sách Tất Cả Các Lớp Học");
            }
            
        }
    }
}

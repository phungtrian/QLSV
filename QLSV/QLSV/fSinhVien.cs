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
    public partial class fSinhVien : Form
    {
        BUSSinhVien bus;
        public int maSV;
        public fSinhVien()
        {
            InitializeComponent();
            bus = new BUSSinhVien();
        }

        private void HienThiDSLH()
        {
            bus.HienThiTatCaMonHocTheoSV(maSV, dgvLopHoc);

            dgvLopHoc.Columns[0].Width = (int)(0.1 * dgvLopHoc.Width);
            dgvLopHoc.Columns[1].Width = (int)(0.1 * dgvLopHoc.Width);
            dgvLopHoc.Columns[2].Width = (int)(0.6 * dgvLopHoc.Width);
            dgvLopHoc.Columns[3].Width = (int)(0.1 * dgvLopHoc.Width);
            dgvLopHoc.Columns[4].Width = (int)(0.1 * dgvLopHoc.Width);
            dgvLopHoc.RowHeadersVisible = false;

        }

        private void HienThiTHongTinSV()
        {
            bus.HienThiThongTinSV(maSV, cbMSSV, cbHoTen, cbNamSinh, cbQueQuan, cbDiaChi, cbSDT);
        }

        private void fSinhVien_Load(object sender, EventArgs e)
        {
            HienThiDSLH();
            HienThiTHongTinSV();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fTraCuuDiemSV f = new fTraCuuDiemSV();
            f.maSV = maSV;
            f.maMon = 0;
            f.Show();
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fTraCuuDiemSV f = new fTraCuuDiemSV();
            f.maSV = maSV;
            f.maMon = int.Parse(dgvLopHoc.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString());
            f.ShowDialog();
            HienThiDSLH();
        }

        private void btDKMonHoc_Click(object sender, EventArgs e)
        {
            fDangKyMonHoc f = new fDangKyMonHoc();
            f.maSV = maSV;
            f.ShowDialog();
            HienThiDSLH();
        }
    }
}

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
    public partial class fDangKyMonHoc : Form
    {
        BUSSinhVien bus;
        public int maSV;
        public fDangKyMonHoc()
        {
            InitializeComponent();
            bus = new BUSSinhVien();
        }

        private void HienThiDSLHDaDK()
        {
            bus.HienThiTatCaMonHocTheoSV(maSV, dgvMonDaDK);

            dgvMonDaDK.Columns[0].Width = (int)(0.1 * dgvMonDaDK.Width);
            dgvMonDaDK.Columns[1].Width = (int)(0.1 * dgvMonDaDK.Width);
            dgvMonDaDK.Columns[2].Width = (int)(0.6 * dgvMonDaDK.Width);
            dgvMonDaDK.Columns[3].Width = (int)(0.1 * dgvMonDaDK.Width);
            dgvMonDaDK.Columns[4].Width = (int)(0.1 * dgvMonDaDK.Width);
            dgvMonDaDK.RowHeadersVisible = false;

        }

        private void HienThiDSLHChuaDK()
        {
            bus.HienThiLopChuaDK(maSV, dgvMonChuaDK);

            dgvMonChuaDK.Columns[0].Width = (int)(0.1 * dgvMonChuaDK.Width);
            dgvMonChuaDK.Columns[1].Width = (int)(0.1 * dgvMonChuaDK.Width);
            dgvMonChuaDK.Columns[2].Width = (int)(0.4 * dgvMonChuaDK.Width);
            dgvMonChuaDK.Columns[3].Width = (int)(0.1 * dgvMonChuaDK.Width);
            dgvMonChuaDK.Columns[4].Width = (int)(0.3 * dgvMonChuaDK.Width);
            dgvMonChuaDK.RowHeadersVisible = false;

        }

        

        private void fDangKyMonHoc_Load(object sender, EventArgs e)
        {
            HienThiDSLHChuaDK();
            HienThiDSLHDaDK();
        }

        private void dgvMonChuaDK_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Đăng Ký môn Sẽ không thể hủy được. Bạn cho chắc chắn muốm Đăng ký môn này", "Xác Nhận Đăng Ký Môn", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int kq;
                kq = bus.DangKyMonHoc(maSV, int.Parse(dgvMonChuaDK.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()));
                if (kq == -1)
                {
                    MessageBox.Show("Bạn Đã đăng Ký môn này rồi");
                    HienThiDSLHChuaDK();
                    HienThiDSLHDaDK();
                }
                else if (kq == 1)
                {
                    MessageBox.Show("Đăng Ký Môn Học Thành Công");
                    HienThiDSLHChuaDK();
                    HienThiDSLHDaDK();
                }
                else
                {
                    MessageBox.Show("Đăng Ký Môn Học Thất Bại. Thử lại sau");
                    HienThiDSLHChuaDK();
                    HienThiDSLHDaDK();
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class fGiangVien : Form
    {
        public int maGV;
        BUSGiangVien bus;
        public fGiangVien()
        {
            InitializeComponent();
            bus = new BUSGiangVien();
        }

        private void HienThiTenGiangVien()
        {
            bus.HienThiGiangVien(cbGiangVien);
            cbGiangVien.SelectedValue = maGV;
        }

        private void HienThiDSLH()
        {
            bus.HienThiDSLopTheoGV(maGV,dgvDSLH);

            dgvDSLH.Columns[0].Width = (int)(0.2 * dgvDSLH.Width);
            dgvDSLH.Columns[1].Width = (int)(0.2 * dgvDSLH.Width);
            dgvDSLH.Columns[2].Width = (int)(0.2 * dgvDSLH.Width);
            dgvDSLH.Columns[3].Width = (int)(0.2 * dgvDSLH.Width);
            dgvDSLH.Columns[4].Width = (int)(0.2 * dgvDSLH.Width);

        }

        private void fGiangVien_Load(object sender, EventArgs e)
        {
            HienThiDSLH();
            HienThiTenGiangVien();
        }



        private void btKetThucMon_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn kết thúc lớp này. Mã lớp Học " + txtMaLopHoc.Text, "Xác Nhận Kết Thúc Lớp", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int kt = bus.KetThucLopHoc(maGV, int.Parse(txtMaLopHoc.Text));
                if(kt == 1)
                {
                    MessageBox.Show("Kết thúc học phần thành công");
                }
                else if(kt == 0)
                {
                    MessageBox.Show("Kết thúc học phần Thất bại");
                } 
                else
                {
                    MessageBox.Show("Lỗi dữ Liệu");
                }
                HienThiDSLH();
            }
            

            
        }
            private void dgvDSLH_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvDSLH.Rows.Count)
                {
                    txtMaLopHoc.Text = dgvDSLH.Rows[e.RowIndex].Cells["maLopHoc"].Value.ToString();
                    txtMaMonHoc.Text = dgvDSLH.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                    txtTenMonHoc.Text = dgvDSLH.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString();
                    txtSiSo.Text = dgvDSLH.Rows[e.RowIndex].Cells["siso"].Value.ToString();
                    txtSoTinChi.Text = dgvDSLH.Rows[e.RowIndex].Cells["sotinchi"].Value.ToString();
                }
            }

        private void btChamDiem_Click(object sender, EventArgs e)
        {
            if (txtMaLopHoc.Text == "")
            {
                MessageBox.Show("vui lòng chọn lớp trong danh sách lớp");
            }
            else
            {
                fNhapDiem f = new fNhapDiem();
                f.maLop = int.Parse(txtMaLopHoc.Text);
                f.maGV = maGV;
                f.ShowDialog();
            }

        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fGiangVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDangNhap f = new fDangNhap();
            f.Show();
        }
    }
}

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
    public partial class fDSSVTheoLop : Form
    {
        public int maLop;
        BUSGiangVien bus;
        public fDSSVTheoLop()
        {
            InitializeComponent();
            bus = new BUSGiangVien();
        }

        private void HienThicbLop()
        {
            bus.HienThicbTatCaLop(cbLop, cbMonHoc);
            cbLop.SelectedValue = maLop;
            cbMonHoc.SelectedValue = cbLop.SelectedValue;

        }

        private void HienThiDSSVTheoLop(int maLopDaChon)
        {

            bus.HienThiDSSVTheoLop(maLopDaChon, dgvDiem);

            dgvDiem.Columns[0].Width = (int)(0.2 * dgvDiem.Width);
            dgvDiem.Columns[1].Width = (int)(0.2 * dgvDiem.Width);
            dgvDiem.Columns[2].Width = (int)(0.2 * dgvDiem.Width);
            dgvDiem.Columns[3].Width = (int)(0.2 * dgvDiem.Width);
            dgvDiem.Columns[4].Width = (int)(0.2 * dgvDiem.Width);
            dgvDiem.RowHeadersVisible = false;

        }

        private void fDSSVTheoLop_Load(object sender, EventArgs e)
        {
            HienThicbLop();
            HienThiDSSVTheoLop(maLop);
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            maLop = int.Parse(cbLop.SelectedValue.ToString());
            HienThicbLop();
            HienThiDSSVTheoLop(maLop);

        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.Text = dgvDiem.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
        }

        private void btHuyMon_Click(object sender, EventArgs e)
        {
            int kq;

            kq = bus.HuyMon(maLop, int.Parse(txtMSSV.Text));

            if(kq == 1)
            {
                MessageBox.Show("Hủy đăng ký Lớp của sinh viên " + txtMSSV.Text + " Thành công");
                HienThiDSSVTheoLop(maLop);
            }
            else
            {
                MessageBox.Show("Hủy đăng ký Lớp của sinh viên " + txtMSSV.Text + " Thất bại");
                HienThiDSSVTheoLop(maLop);
            }    
        }

        private void btChamDiem_Click(object sender, EventArgs e)
        {
            fNhapDiem f = new fNhapDiem();
            f.maLop = maLop;
            f.maGV = 0;
            f.ShowDialog();
            HienThiDSSVTheoLop(maLop);
        }
    }
}

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
using System.IO;


namespace QLSV
{

    public partial class fNhapDiem : Form
    {
        XuatExcel xuatFile;
        public int maLop;
        public int maGV;
        BUSGiangVien bus;
        public fNhapDiem()
        {

            InitializeComponent();
            bus = new BUSGiangVien();
            xuatFile = new XuatExcel();

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

        private void HienThicbLop()
        {
            bus.HienThicbLop(maGV, cbLop,cbMonHoc);
            try
            {
                cbLop.SelectedValue = maLop;
                cbMonHoc.SelectedValue = cbLop.SelectedValue;
            }
            catch (Exception)
            {

                MessageBox.Show("lớp Chưa có sinh viên");

            }

        }

        private void fChamDiem_Load(object sender, EventArgs e)
        {
            HienThiDSSVTheoLop(maLop);
            HienThicbLop();

        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDiem.Rows.Count)
            {
                txtMaSV.Text = dgvDiem.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                txtHoTen.Text = dgvDiem.Rows[e.RowIndex].Cells["hoten"].Value.ToString();
                txtDiemLan1.Text = dgvDiem.Rows[e.RowIndex].Cells["diemlan1"].Value.ToString();
                txtDiemLan2.Text = dgvDiem.Rows[e.RowIndex].Cells["diemlan2"].Value.ToString();
               
                txtDiemTongKet.Text = dgvDiem.Rows[e.RowIndex].Cells["diemtongket"].Value.ToString();
            }
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            
            //kiểm tra ràng buộc
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn Sinh Viên muốn nhập điểm");
                return;
            }
         
            int maSV = int.Parse(txtMaSV.Text);

            try
            {
                float diemLan1 = float.Parse(txtDiemLan1.Text);
                float diemLan2 = float.Parse(txtDiemLan2.Text);
                float diemTK = float.Parse(txtDiemTongKet.Text);

                int kq = bus.ChamDiem(maGV, maLop, maSV, diemLan1, diemLan2, diemTK);

                if (kq == 1)
                {
                    MessageBox.Show("Nhập diểm thành công");
                    HienThiDSSVTheoLop(maLop);
                }
                else if (kq == 0)
                {
                    MessageBox.Show("Nhập diểm thất bại");
                    HienThiDSSVTheoLop(maLop);
                }
                else
                {
                    MessageBox.Show("lỗi phát sinh từ cơ sở dữ liệu");
                    HienThiDSSVTheoLop(maLop);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Chỉ được nhập điểm bằng số");
            }    
        }

        private void btChonLop_Click(object sender, EventArgs e)
        {
            maLop = int.Parse(cbLop.SelectedValue.ToString());
            HienThicbLop();
            HienThiDSSVTheoLop(maLop);
        }

        private void btIn_Click(object sender, EventArgs e)
        {

            #region xuất excel 

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xuatFile.XuatFileExcelBangDiem(dgvDiem, saveFileDialog1.FileName, "Bảng Điểm lớp " + maLop + " môn " + cbMonHoc.Text);
            }

            #endregion
        }

        
        
    }
}

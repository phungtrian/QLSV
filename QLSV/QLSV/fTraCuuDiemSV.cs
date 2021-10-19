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
    public partial class fTraCuuDiemSV : Form
    {
        XuatExcel xuatFile;
        BUSSinhVien bus;
        public int maSV;
        public int maMon;
        public fTraCuuDiemSV()
        {
            InitializeComponent();
            bus = new BUSSinhVien();
            xuatFile = new XuatExcel();
        }

        private void HienThiDiemTheoSinhVien (int maSinhVien, int maMonHoc)
        {
            if(maMonHoc == 0)
            {
                bus.HienThiDiemTatCaMonTheoSV(maSinhVien,dgvDiemSV);
            }
            else
            {
                bus.HienThiDiem1MonTheoSV(maSinhVien, maMonHoc, dgvDiemSV);
            }

            dgvDiemSV.Columns[0].Width = (int)(0.1 * dgvDiemSV.Width);
            dgvDiemSV.Columns[1].Width = (int)(0.1 * dgvDiemSV.Width);
            dgvDiemSV.Columns[2].Width = (int)(0.3 * dgvDiemSV.Width);
            dgvDiemSV.Columns[3].Width = (int)(0.125 * dgvDiemSV.Width);
            dgvDiemSV.Columns[4].Width = (int)(0.125 * dgvDiemSV.Width);
            dgvDiemSV.Columns[5].Width = (int)(0.125 * dgvDiemSV.Width);
            dgvDiemSV.Columns[6].Width = (int)(0.125 * dgvDiemSV.Width);
            
            dgvDiemSV.RowHeadersVisible = false;

        }

        private void HienThiCBMon()
        {
            bus.HienThiMon(cbMonHoc, maSV);
            if(maMon != 0)
            {
                cbMonHoc.SelectedValue = maMon;
            }    
        }

        private void fTraCuuDiemSV_Load(object sender, EventArgs e)
        {
            HienThiDiemTheoSinhVien(maSV, maMon);
            HienThiCBMon();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            HienThiDiemTheoSinhVien(maSV, int.Parse(cbMonHoc.SelectedValue.ToString()));
        }

        private void btTatCaHK_Click(object sender, EventArgs e)
        {
            bus.HienThiDiemTatCaHKTheoSV(maSV, dgvDiemSV);
        }

        private void btHKHienTai_Click(object sender, EventArgs e)
        {
            HienThiDiemTheoSinhVien(maSV, 0);
        }

        private void btXuatExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xuatFile.XuatFileExcelBangDiem(dgvDiemSV, saveFileDialog1.FileName,"Bảng Điểm Sinh Viên " + maSV);
            }
            
        }
    }
}

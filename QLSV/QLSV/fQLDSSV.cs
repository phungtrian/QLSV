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
        BUS busDSSV;
        public fQLDSSV()
        {
            InitializeComponent();
            busDSSV = new BUS();
        }

        private void fQLDSSV_Load(object sender, EventArgs e)
        {
            busDSSV.DSSinhVien(dgvDSSV);

            dgvDSSV.Columns[0].Width = (int)(0.109 * dgvDSSV.Width);
            dgvDSSV.Columns[1].Width = (int)(0.1 * dgvDSSV.Width);
            dgvDSSV.Columns[2].Width = (int)(0.05 * dgvDSSV.Width);
            dgvDSSV.Columns[3].Width = (int)(0.075 * dgvDSSV.Width);
            dgvDSSV.Columns[4].Width = (int)(0.1 * dgvDSSV.Width);
            dgvDSSV.Columns[5].Width = (int)(0.19 * dgvDSSV.Width);
            dgvDSSV.Columns[6].Width = (int)(0.195 * dgvDSSV.Width);
            dgvDSSV.Columns[7].Width = (int)(0.1 * dgvDSSV.Width);
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDSSV.Rows.Count)
            {
                
                txtMSSV.Text = dgvDSSV.Rows[e.RowIndex].Cells["maSinhVien"].Value.ToString();
                txtHo.Text = dgvDSSV.Rows[e.RowIndex].Cells["Ho"].Value.ToString();
                txtTen.Text = dgvDSSV.Rows[e.RowIndex].Cells["Ten"].Value.ToString();
                txtGioiTinh.Text = dgvDSSV.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
                txtNamSinh.Text = dgvDSSV.Rows[e.RowIndex].Cells["NamSinh"].Value.ToString();
                txtQueQuan.Text = dgvDSSV.Rows[e.RowIndex].Cells["QueQuan"].Value.ToString();
                txtDiaChi.Text = dgvDSSV.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgvDSSV.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
                
            }
        }
    }

}

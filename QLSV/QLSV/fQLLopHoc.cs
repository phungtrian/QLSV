﻿using QLSV.BUS;
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
        public fQLLopHoc()
        {
            InitializeComponent();
            busLH = new BUSLopHoc();
        }

        private void HienThiDSLH()
        {
            busLH.DSLopHoc(dgvDSLH);

            dgvDSLH.Columns[0].Width = (int)(0.3 * dgvDSLH.Width);
            dgvDSLH.Columns[1].Width = (int)(0.3 * dgvDSLH.Width);
            dgvDSLH.Columns[2].Width = (int)(0.3 * dgvDSLH.Width);

        }

        private void fQLLopHoc_Load(object sender, EventArgs e)
        {
            HienThiDSLH();
            busLH.HienThiMonHoc(cbMonhoc);
            busLH.HienThiGiangVien(cbGiangVien);


        }

        private void btThem_Click(object sender, EventArgs e)
        {
            LopHoc lh = new LopHoc();
            lh.maLopHoc = int.Parse(txtMaLopHoc.Text);
            lh.maGiangVien = int.Parse(cbGiangVien.SelectedValue.ToString());
            lh.maMonHoc = int.Parse(cbMonhoc.SelectedValue.ToString());

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
                cbGiangVien.Text = dgvDSLH.Rows[e.RowIndex].Cells["ten"].Value.ToString();
                cbMonhoc.Text = dgvDSLH.Rows[e.RowIndex].Cells["tenMonHoc"].Value.ToString();
            }
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btTraCuu.PerformClick();
            }
        }
    }
}

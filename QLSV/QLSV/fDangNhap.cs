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
    public partial class fDangNhap : Form
    {
        BUSDangNhap busDN;
        public fDangNhap()
        {
            InitializeComponent();
            busDN = new BUSDangNhap();
        }

        public string tenDangNhap = "";
        public string matKhau = "";
        public string loaiTK = "";

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            #region ktra_rbuoc
            //kiểm tra ràng buộc
            if (cbLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if (string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Tài khoản không được để trống");
                txtTenDN.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống");
            }
            #endregion


            tenDangNhap = txtTenDN.Text;
            loaiTK = "";

            #region swtk
            switch (cbLoaiTaiKhoan.Text)
            {
                case "Quản Trị Viên":
                    loaiTK = "admin";
                    break;
                case "Giáo Viên":
                    loaiTK = "gv";
                    break;
                case "Sinh Viên":
                    loaiTK = "sv";
                    break;
            }
            #endregion

            matKhau = txtMatKhau.Text;

            int kt = busDN.DangNhap(loaiTK, tenDangNhap, matKhau);

            if (kt == 1)
            {
                MessageBox.Show("Quản Trị Viên Đăng nhập thành công");
                fAdmin f = new fAdmin();
                f.Show();
                this.Hide();


            }
            else if (kt == 2)
            {
                MessageBox.Show("Giảng Viên Đăng nhập thành công ");
                fGiangVien f = new fGiangVien();
                f.maGV = int.Parse(txtTenDN.Text);
                f.Show();
                this.Hide();

            }
            else if (kt == 3)
            {
                MessageBox.Show("Sinh Viên Đăng nhập thành công ");
                fSinhVien f = new fSinhVien();
                f.Show();
                this.Hide();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

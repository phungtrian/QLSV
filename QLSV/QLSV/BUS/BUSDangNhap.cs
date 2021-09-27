using QLSV.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.BUS
{
    class BUSDangNhap
    {
        DAODangNhap da;

        public BUSDangNhap()
        {
            da = new DAODangNhap();
        }

        public int DangNhap(string loaiTK, string tenDN, string matKhau)
        {

            if (da.Dangnhap(loaiTK, tenDN, matKhau) != 0 && loaiTK == "admin")
            {



                return 1;


            }
            else if (da.Dangnhap(loaiTK, tenDN, matKhau) != 0 && loaiTK == "gv")
            {


                return 2;

            }
            else if (da.Dangnhap(loaiTK, tenDN, matKhau) != 0 && loaiTK == "sv")
            {


                return 3;

            }
            else
            {
                MessageBox.Show("Lỗi Đăng Nhập");
                return 0;
            }
        }
    }
}

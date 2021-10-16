using QLSV.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV.BUS
{
    class BUSSinhVien
    {
        DAOSinhVien da;

        public BUSSinhVien()
        {
            da = new DAOSinhVien();
        }

        //Bắt đâu phân quyền admin

        public void DSSinhVien(DataGridView dg)
        {
            dg.DataSource = da.LayDSSinhVIen();
            
        }

        public void ThemSV(SinhVien sv)
        {
            try
            {
                da.ThemSV(sv);
                MessageBox.Show("Bạn đã thêm Sinh viên thành công!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai!");

            }
        }

        public bool SuaSinhVien(SinhVien sv)
        {
            if (da.TimSinhVien(sv.maSinhVien))
            {
                try
                {
                    da.SuaSinhVien(sv);
                    return true;
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy Sinh Viên bằng mã Sinh Viên ");
                return false;
            }


        }

        public bool XoaSinhVien(SinhVien sv)
        {
            if (da.TimSinhVien(sv.maSinhVien))
            {
                try
                {
                    da.XoaSinhVien(sv);
                    return true;
                }
                catch (DbUpdateException ex)
                {

                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy Sinh Viên bằng mã Sinh Viên ");
                return false;
            }
        }




        public void TimKiemHienThiSinhVien(string tuKhoa, DataGridView dg)
        {
            dg.DataSource = da.TimKiemSinhVien(tuKhoa);
        }

        //Bắt đâu phân quyền Sinh Viên

        public void HienThiTatCaMonHocTheoSV (int maSV, DataGridView dg)
        {
            dg.DataSource = da.DSLopTheoSinhVien(maSV);
        }

        public void HienThiDiemTatCaMonTheoSV(int maSV, DataGridView dg)
        {
            dg.DataSource = da.DSDiemTatCaMonTheoSV(maSV);
        }

        public void HienThiDiem1MonTheoSV(int maSV,int maMon, DataGridView dg)
        {
            dg.DataSource = da.DSDiem1MonTheoSV(maSV, maMon);
        }

        public void HienThiThongTinSV(int maSV,ComboBox cbMSSV, ComboBox cbHoTen, ComboBox cbNamSinh, ComboBox cbQueQuan, ComboBox cbDiaChi, ComboBox cbSDT)
        {
            cbMSSV.DataSource = da.ThongTinChiTietSV(maSV);
            cbMSSV.ValueMember = "masinhvien";
            

            cbHoTen.DataSource = da.ThongTinChiTietSV(maSV);
            cbHoTen.ValueMember = "masinhvien";
            cbHoTen.DisplayMember = "hoten";

            cbNamSinh.DataSource = da.ThongTinChiTietSV(maSV);
            cbNamSinh.ValueMember = "masinhvien";
            cbNamSinh.DisplayMember = "namSinh";

            cbQueQuan.DataSource = da.ThongTinChiTietSV(maSV);
            cbQueQuan.ValueMember = "masinhvien";
            cbQueQuan.DisplayMember = "queQuan";

            cbDiaChi.DataSource = da.ThongTinChiTietSV(maSV);
            cbDiaChi.ValueMember = "masinhvien";
            cbDiaChi.DisplayMember = "diaChi";

            cbSDT.DataSource = da.ThongTinChiTietSV(maSV);
            cbSDT.ValueMember = "masinhvien";
            cbSDT.DisplayMember = "dienThoai";
        }


        public void HienThiMon(ComboBox cb, int maSV)
        {
            cb.DataSource = da.DSLopTheoSinhVien(maSV);
            cb.ValueMember = "mamonhoc";
            cb.DisplayMember = "tenmonhoc";
        }

        public void HienThiLopChuaDK(int maSV, DataGridView dg)
        {
            dg.DataSource = da.DSLopChuaDK(maSV);
        }

        public int DangKyMonHoc(int maSV,int MaLop)
        {
            int kq;
            kq = da.DangKyMonHoc(maSV, MaLop);
            return kq;
        }

        // kết thúc phan quyền Sinh Viên
    }
}

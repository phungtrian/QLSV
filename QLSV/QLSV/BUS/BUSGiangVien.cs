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
    class BUSGiangVien
    {
        DAOGiangVien da;

        public BUSGiangVien()
        {
            da = new DAOGiangVien();
        }

        public void DSGiangVien(DataGridView dg)
        {
            dg.DataSource = da.LayDSGiangVien();
        }

        public void ThemGV(GiangVien gv)
        {
            try
            {
                da.ThemGV(gv);
                MessageBox.Show("Bạn đã thêm Giảng Viên thành công!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai!");

            }
        }

        public bool SuaGV(GiangVien gv)
        {
            if (da.TimGV(gv.maGiangVien))
            {
                try
                {
                    da.SuaGiangVien(gv);
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
                MessageBox.Show("Không tìm thấy Giảng Viên bằng mã Sinh Giảng Viên ");
                return false;
            }


        }

        public bool XoaGV(GiangVien gv)
        {
            if (da.TimGV(gv.maGiangVien))
            {
                try
                {
                    da.XoaGiangVien(gv);
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
                MessageBox.Show("Không tìm thấy Giảng Viên bằng mã Sinh Giảng Viên ");
                return false;
            }
        }


        public void HienThicbLop(int maGV, ComboBox cbLop,ComboBox cbMonHoc)
        {
            cbLop.DataSource = da.LayDSLopTheoGV(maGV);
            cbLop.ValueMember = "malophoc";
            cbMonHoc.DataSource = da.LayDSLopTheoGV(maGV);
            cbMonHoc.ValueMember = "malophoc";
            cbMonHoc.DisplayMember = "tenmonhoc";
        }

        public void HienThicbTatCaLop(ComboBox cbLop, ComboBox cbMonHoc)
        {
            cbLop.DataSource = da.DSTatCaLop();
            cbLop.ValueMember = "maLopHoc";
            cbMonHoc.DataSource = da.DSTatCaLop();
            cbMonHoc.ValueMember = "maLopHoc";
            cbMonHoc.DisplayMember = "tenMonHoc";
        }

        

        public void TimKiemHienThiMH(string tuKhoa, DataGridView dg)
        {
            dg.DataSource = da.TimKiemGiangVien(tuKhoa);
        }

        public int HuyMon(int maLop, int maSV)
        {
            int kq;
            kq = da.HuyMon(maLop, maSV);
            return kq; // 1 xoa thành công 0 xóa thất bại
        }


        //kết thúc phân quyền admin

        //bắt đầu phân quyền Giang Viên
        public void HienThiDSLopTheoGV(int maGV, DataGridView dg)
        {
            dg.DataSource = da.LayDSLopTheoGV(maGV);
        }

        public void HienThiGiangVien(ComboBox cb)
        {
            cb.DataSource = da.LayDSGiangVien();
            cb.DisplayMember = "ten";
            cb.ValueMember = "maGiangVien";


        }

        public int KetThucLopHoc(int maGV, int maLop)
        {
            int kq;
            
            try
            {
                kq = da.KetThuLopHoc(maGV, maLop);
                return kq;
            }
            catch (DbUpdateException ex)
            {

                MessageBox.Show(ex.Message);
                return 2;
            }

        }

        public void HienThiDSSVTheoLop(int maLop, DataGridView dg)
        {
            dg.DataSource = da.LayDSSVTheoLop(maLop);
        }

       

        public int ChamDiem(int maGV, int maLop, int maSV, float diemLan1, float diemLan2, float diemTK)
        {
            int kq;
            try
            {
                kq = da.ChamDiem(maGV, maLop, maSV, diemLan1, diemLan2, diemTK);
                return kq;
            }
            catch (DbUpdateException ex)
            {

                return 2;
            }
        }

        // kết thức phân quyền Giảng Viên
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSV.DAO;

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
        public void HienThiLoaiGioiTinh(ComboBox cb)
        {
            cb.DataSource = da.LayLoaiGioiTinh();
            cb.DisplayMember = "TenGioiTinh";
            cb.ValueMember = "MaGioTinh";


        }

        public void TimKiemHienThiMH(string tuKhoa, DataGridView dg)
        {
            dg.DataSource = da.TimKiemGiangVien(tuKhoa);
        }
    }
}

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
    class BUSLopHoc
    {
        DAOLopHoc daLH;
        DAOMonHoc daMH;
        DAOGiangVien daGV;

        public BUSLopHoc()
        {
            daLH = new DAOLopHoc();
            daGV = new DAOGiangVien();
            daMH = new DAOMonHoc();
        }

        public void DSLopHoc(DataGridView dg)
        {
            dg.DataSource = daLH.LayDSLopHoc();
        }

        public void ThemLopHoc(LopHoc lh)
        {
            try
            {
                daLH.ThemLopHoc(lh);
                MessageBox.Show("Bạn đã Lớp Học thành công!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai!");

            }
        }

        public bool SuaLopHoc(LopHoc lh)
        {
            if (daLH.KiemTraLophoc(lh.maLopHoc))
            {
                try
                {
                    daLH.SuaLopHoc(lh);
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
                MessageBox.Show("Không tìm thấy Lớp học bằng mã lớp ");
                return false;
            }

        }

        public bool XoaLopHoc(LopHoc lh)
        {
            if (daLH.KiemTraLophoc(lh.maLopHoc))
            {
                try
                {
                    daLH.XoaLopHoc(lh);
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
                MessageBox.Show("Không tìm thấy Lớp học bằng mã lớp ");
                return false;
            }

        }

        public void HienThiGiangVien(ComboBox cb)
        {
            cb.DataSource = daGV.LayDSGiangVien();
            cb.DisplayMember = "ten";
            cb.ValueMember = "maGiangVien";


        }

        public void HienThiMonHoc(ComboBox cb)
        {
            cb.DataSource = daMH.LayDSMonHoc();
            cb.DisplayMember = "tenMonHoc";
            cb.ValueMember = "maMonHoc";


        }

        public void TimKiemHienThiLH(string tuKhoa, DataGridView dg)
        {
            dg.DataSource = daLH.TimKiemLopHoc(tuKhoa);
        }
    }
}

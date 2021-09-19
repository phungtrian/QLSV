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
    class BUSMonHoc
    {
        DAOMonHoc da;

        public BUSMonHoc()
        {
            da = new DAOMonHoc();
        }

        public void DSMonHoc(DataGridView dg)
        {
            dg.DataSource = da.LayDSMonHoc();
        }

        public void ThemMH(MonHoc monHoc)
        {
            try
            {
                da.ThemMonHoc(monHoc);
                MessageBox.Show("Bạn đã thêm môn học thành công!!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập sai!");

            }
        }

        public bool SuaMonHoc(MonHoc monHoc)
        {
            if (da.TimMonHoc(monHoc.maMonHoc))
            {
                try
                {
                    da.SuaMonHoc(monHoc);
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
                MessageBox.Show("Không tìm thấy Môn Học bằng mã Môn Học");
                return false;

            }
        }
            

        public bool XoaMonHoc(MonHoc mh)
        {
            if (da.TimMonHoc(mh.maMonHoc))
            {
                try
                {
                    da.XoaMonHoc(mh);
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
                MessageBox.Show("Không tìm thấy Môn Học bằng mã Môn Học ");
                return false;

            }
        }
        public void TimKiemHienThiMH(string tuKhoa, DataGridView dg)
        {
            dg.DataSource = da.TimKiemMonHoc(tuKhoa);
        }
    }
}

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

        public bool SuaSinhViem(SinhVien sv)
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
                return false;

            
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
                return false;
        }
        public void HienThiLoaiGioiTinh(ComboBox cb)
        {
            cb.DataSource = da.LayLoaiGioiTinh();
            cb.DisplayMember = "TenGioiTinh";
            cb.ValueMember = "MaGioTinh";
            

        }
    }
}

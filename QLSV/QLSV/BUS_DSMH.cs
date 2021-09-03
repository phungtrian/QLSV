using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    class BUS_DSMH
    {
        DAO_DSMH da;
        public BUS_DSMH()
        {
            da = new DAO_DSMH();
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
    }
}

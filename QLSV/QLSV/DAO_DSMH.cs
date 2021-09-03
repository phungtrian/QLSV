using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class DAO_DSMH
    {
        QLSVDataContext db;
        public DAO_DSMH()
        {
            db = new QLSVDataContext();
        }

        //Cach 1
        //(trả về danh sách môn học)
        //public List<MonHoc> LayDSMonHoc()
        //{
        //    List<MonHoc> dsMH = db.MonHocs.Select(s => s).ToList();
        //    return dsMH;
        //}

        //Cach 2
        //public IEnumerable<MonHoc> LayDSMonHoc2()
        //{
        //    IEnumerable<MonHoc> dsMH = db.MonHocs.Select(s => s);
        //    return dsMH;
        //}

        //chỉ lấy những cột muốn lấy thì sử dụng dynamic
        public dynamic LayDSMonHoc()
        {
            dynamic dsMH = db.MonHocs.Select(s => new
            {
                s.maMonHoc,
                s.tenMonHoc,
                s.soTinChi
            });
            return dsMH;
        }

        //Thêm môn học
        public void ThemMonHoc(MonHoc monHoc)
        {
            db.MonHocs.InsertOnSubmit(monHoc);
            db.SubmitChanges();
        }
    }
}

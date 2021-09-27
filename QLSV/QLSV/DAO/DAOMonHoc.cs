using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class DAOMonHoc
    {
        QLSVEntities db;
        public DAOMonHoc()
        {
            db = new QLSVEntities();
        }
        public dynamic LayDSMonHoc()
        {
            var dsMH = db.MonHocs.Select(s => new
            {
                s.maMonHoc,
                s.tenMonHoc,
                s.soTinChi
            }).ToList();
            return dsMH;
        }

        //Thêm môn học
        public void ThemMonHoc(MonHoc monHoc)
        {
            db.MonHocs.Add(monHoc);
            db.SaveChanges();
        }

        public bool TimMonHoc(int maMH)
        {
            MonHoc mh;
            mh = db.MonHocs.Find(maMH);
            if (mh != null)
            {
                return true;
            }
            else
                return false;


        }

        public void SuaMonHoc(MonHoc monHoc)
        {
            MonHoc o = db.MonHocs.Find(monHoc.maMonHoc);
            o.tenMonHoc = monHoc.tenMonHoc;
            o.soTinChi = monHoc.soTinChi;

            db.SaveChanges();
        }

        public void XoaMonHoc(MonHoc mh)
        {
            MonHoc o = db.MonHocs.Find(mh.maMonHoc);
            db.MonHocs.Remove(o);
            db.SaveChanges();
        }
        public dynamic TimKiemMonHoc(string tukhoa)
        {
            var dsMH = db.TraCuuMonHoc(tukhoa).Select(s => new
            {
                s.maMonHoc,
                s.tenMonHoc,
                s.soTinChi
            }).ToList();
            return dsMH;
        }
    }
}

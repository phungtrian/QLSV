using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class DAOLopHoc
    {
        QLSVEntities db;

        public DAOLopHoc()
        {
            db = new QLSVEntities();
        }

        public dynamic LayDSLopHoc()
        {
            var ds = db.LopHocs.Select(s => new
            {
                s.maLopHoc,
                s.maMonHoc,
                s.maGiangVien
            }).ToList();
            return ds;
        }

        public bool KiemTraLophoc(int maLopHoc)
        {
            LopHoc o = db.LopHocs.Find(maLopHoc);
            if (o != null)
            {
                return true;

            }
            else
                return false;
        }

        public void ThemLopHoc(LopHoc lh)
        {
            LopHoc o = db.LopHocs.Find(lh.maGiangVien);
            o.maLopHoc = lh.maLopHoc;
            o.maMonHoc = lh.maMonHoc;
            o.maGiangVien = lh.maGiangVien;

            db.LopHocs.Add(o);
            db.SaveChanges();

        }

        public void SuaLopHoc(LopHoc lh)
        {
            LopHoc o = db.LopHocs.Find(lh.maGiangVien);
            o.maLopHoc = lh.maLopHoc;
            o.maMonHoc = lh.maMonHoc;
            o.maGiangVien = lh.maGiangVien;

            
            db.SaveChanges();
        }

        public void XoaLopHoc(LopHoc lh)
        {
            LopHoc o = db.LopHocs.Find(lh.maGiangVien);
            db.LopHocs.Remove(o);
            db.SaveChanges();
        }

        public dynamic TimKiemLopHoc(string tuKhoa)
        {
            var ds = db.TraCuuLopHoc(tuKhoa).Select(s => new
            {
                s.maLopHoc,
                s.maMonHoc,
                s.maGiangVien
            }).ToList();
            return ds;
        }

    }
}

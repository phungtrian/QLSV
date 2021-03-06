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
            var ds = db.DSTatCaLopHoc().Select(s => new
            {
                s.maLopHoc,
                s.HoTenGiangVien,
                s.tenMonHoc,
                s.maGiangVien,
                s.daKetThuc
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


            db.LopHocs.Add(lh);
            db.SaveChanges();

        }

        public void SuaLopHoc(LopHoc lh)
        {
            LopHoc o = db.LopHocs.Find(lh.maLopHoc);
            o.maLopHoc = lh.maLopHoc;
            o.maMonHoc = lh.maMonHoc;
            o.maGiangVien = lh.maGiangVien;
            o.daKetThuc = lh.daKetThuc;


            db.SaveChanges();
        }

        public void XoaLopHoc(LopHoc lh)
        {
            LopHoc o = db.LopHocs.Find(lh.maLopHoc);
            db.LopHocs.Remove(o);
            db.SaveChanges();
        }

        public dynamic TimKiemLopHoc(string tuKhoa)
        {
            var ds = db.TraCuuLopHoc(tuKhoa).Select(s => new
            {
                s.maLopHoc,
                s.HoTenGiangVien,
                s.tenMonHoc,
                s.maGiangVien
            }).ToList();
            return ds;
        }
    }
}

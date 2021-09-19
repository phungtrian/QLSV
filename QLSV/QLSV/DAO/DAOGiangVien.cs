using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class DAOGiangVien
    {
        QLSVEntities db;
        public DAOGiangVien()
        {
            db = new QLSVEntities();
        }

        public dynamic LayDSGiangVien()
        {

            var dsGV = db.GiangViens.Select(s => new
            {
                s.maGiangVien,
                s.ho,
                s.ten,
                s.gioiTinh,
                s.namSinh,
                s.diaChi,
                s.email,
                s.soDienThoai
            }).ToList();
            return dsGV;
        }
        //thêm Giảng Viên

        public void ThemGV(GiangVien gv)
        {
            db.GiangViens.Add(gv);
            db.SaveChanges();
        }

        public bool TimGV(int magv)
        {
            GiangVien gv;
            gv = db.GiangViens.Find(magv);
            if (gv != null)
            {
                return true;
            }
            else
                return false;


        }

        public void SuaGiangVien(GiangVien gv)
        {
            GiangVien o = db.GiangViens.Find(gv.maGiangVien);
            o.ho = gv.ho;
            o.ten = gv.ten;
            o.namSinh = gv.namSinh;
            o.gioiTinh = gv.gioiTinh;
            o.soDienThoai = gv.soDienThoai;
            o.diaChi = gv.diaChi;
            o.email = gv.email;
            db.SaveChanges();

        }

        public dynamic LayLoaiGioiTinh()
        {
            var ds = db.LoaiGioiTinhs.Select(s => new
            {
                s.MaGioTinh,
                s.TenGioiTinh
            }).ToList();
            return ds;
        }

        public void XoaGiangVien(GiangVien gv)
        {
            GiangVien o = db.GiangViens.Find(gv.maGiangVien);
            db.GiangViens.Remove(o);
            db.SaveChanges();

        }

        public dynamic TimKiemGiangVien(string tuKhoa)
        {

            var dsGV = db.TraCuuGiangVien(tuKhoa).Select(s => new
            {
                s.maGiangVien,
                s.Ho,
                s.Ten,
                s.gioiTinh,
                s.namSinh,
                s.diaChi,
                s.email,
                s.soDienThoai
            }).ToList();
            return dsGV;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class DAOSinhVien
    {
        QLSVEntities db;
        public  DAOSinhVien()
        {
            db = new QLSVEntities();
        }

        public dynamic LayDSSinhVIen()
        {

            var dsSV = db.SinhViens.Select(s => new
            {
                s.maSinhVien,
                s.Ho,
                s.Ten,
                s.gioiTinh,
                s.namSinh,
                s.diaChi,
                s.queQuan,
                s.dienThoai
            }).ToList();
            return dsSV;
        }
        //thêm sinh viên
        public void ThemSV(SinhVien sv)
        {
            db.SinhViens.Add(sv);
            db.SaveChanges();
        }

        public bool TimSinhVien(int maSV)
        {
            SinhVien sv;
            sv = db.SinhViens.Find(maSV);
            if (sv != null)
            {
                return true;
            }
            else
                return false;
            
            
        }

        public void SuaSinhVien(SinhVien sv)
        {
            SinhVien o = db.SinhViens.Find(sv.maSinhVien);
            o.Ho = sv.Ho;
            o.Ten = sv.Ten;
            o.namSinh = sv.namSinh;
            o.gioiTinh = sv.gioiTinh;
            o.dienThoai = sv.dienThoai;
            o.diaChi = sv.diaChi;
            o.queQuan = sv.queQuan;
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

        public void XoaSinhVien(SinhVien sv)
        {
            SinhVien o = db.SinhViens.Find(sv.maSinhVien);
            db.SinhViens.Remove(o);
            db.SaveChanges();

        }

        public dynamic TimKiemSinhVien(string tuKhoa)
        {
            var ds = db.TraCuuSinhVien(tuKhoa).Select(s => new { 
                s.maSinhVien,
                s.Ho,
                s.Ten,
                s.gioiTinh,
                s.namSinh,
                s.queQuan,
                s.diaChi,
                s.dienThoai
            }).ToList();
            
            return ds;
        }
    }
}

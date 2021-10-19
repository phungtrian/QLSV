using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace QLSV.DAO
{
    class DAOSinhVien
    {
        QLSVEntities db;
        public DAOSinhVien()
        {
            db = new QLSVEntities();
        }

        //bắt đầu phân Quyền admin

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

        //kết thúc phân Quyền admin

        // bắt đầu phân quyền Sinh viên

        public dynamic DSLopTheoSinhVien (int maSV)
        {
            var ds = db.DSLopTheoSinhVien(maSV).Select(s => new
            {
                s.malophoc,
                s.mamonhoc,
                s.tenmonhoc,
                s.siso,
                s.sotinchi
            }).ToList();

            return ds;
        }

        public dynamic DSDiemTatCaMonTheoSV(int maSV)
        {
            var ds = db.DiemTatCaMonTheoSV(maSV).Select(s => new
            {
                s.malophoc,
                s.mamonhoc,
                s.tenmonhoc,                
                s.sotinchi,
                s.diemLan1,
                s.diemLan2,
                s.diemtongket
            }).ToList();

            return ds;
        }

        public dynamic DSDiemTatCaHKTheoSV(int maSV)
        {
            var ds = db.DiemTatCaHKTheoSV(maSV).Select(s => new
            {
                s.malophoc,
                s.mamonhoc,
                s.tenmonhoc,
                s.sotinchi,
                s.diemLan1,
                s.diemLan2,
                s.diemtongket
            }).ToList();

            return ds;
        }

        public dynamic DSDiem1MonTheoSV(int maSV , int maMonHoc)
        {
            var ds = db.Diem1MonTheoSV(maSV, maMonHoc).Select(s => new
            {
                s.malophoc,
                s.mamonhoc,
                s.tenmonhoc,
                s.sotinchi,
                s.diemLan1,
                s.diemLan2,
                s.diemtongket
            }).ToList();

            return ds;
        }

        public dynamic ThongTinChiTietSV(int maSV)
        {
            var ds = db.ThongTinChiTietSV(maSV).Select(s => new
            {
                s.masinhvien,
                s.hoten,
                s.namSinh,
                s.queQuan,
                s.diaChi,
                s.dienThoai,
                s.matKhau             
            }).ToList();
            return ds;
        }

        public dynamic DSLopChuaDK(int maSV)
        {
            var ds = db.DSLopChuaDK(maSV).Select(s => new
            {
                s.malophoc,
                s.mamonhoc,
                s.tenmonhoc,
                s.sotinchi,
                s.gvien,
                
            }).ToList();
            return ds;
        }

        public int DangKyMonHoc(int maSV, int maLop)
        {
            var kq = new ObjectParameter("kq", typeof(int));

            db.DangKyMonHoc(maSV, maLop, kq);

            return int.Parse(kq.Value.ToString()); // -1 đã đk môn này rôi , 1 đk thành công, o dk thất bại
        }

        //Kết thúc phân quyền Sinh viên
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;

namespace QLSV.DAO
{
    class DAOGiangVien
    {
        QLSVEntities db;
        public DAOGiangVien()
        {
            db = new QLSVEntities();
        }

        //bắt dầu phân quyền admin

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

        public dynamic DSTatCaLop()
        {
            var ds = db.DSTatCaLopHoc().Select(s => new
            {
                s.maLopHoc,
                s.HoTenGiangVien,
                s.tenMonHoc,
                s.maGiangVien
               
            }).ToList();
            return ds;
        }

        public int HuyMon(int maLop, int maSV)
        {
            var kq = new ObjectParameter("kq", typeof(int));
            db.HuyMon(maSV, maLop,kq);
            return int.Parse(kq.Value.ToString()); // 1 xóa thành công, 0 xóa thất bại
        }
        

        //Kết thúc phân quyền admin


        //bắt đầu phân quyền giảng viên
        public int ChamDiem (int maGV, int maLop, int maSV, float diemLan1, float diemLan2, float diemTK)
        {
            var kt = new ObjectParameter("trangthai", typeof(int));

            db.ChamDiem(maGV, maLop, maSV, diemLan1, diemLan2,diemTK, kt);

            return int.Parse(kt.Value.ToString());
        }

        public dynamic LayDSLopTheoGV (int maGV)
        {
            dynamic ds = db.HienThiLopTheoGV(maGV).Select(s => new
            {
                s.malophoc,
                s.mamonhoc,
                s.tenmonhoc,
                s.siso,
                s.sotinchi,
                
            }).ToList();
            return ds;
        }

        public int KetThuLopHoc(int maGV, int maLop)
        {
            var kt = new ObjectParameter("trangthai", typeof(int));

            db.KetThucHocPhan(maGV.ToString(), maLop, kt);

            return int.Parse(kt.Value.ToString());

        }

        public dynamic LayDSSVTheoLop( int maLop)
        {
            dynamic ds = db.DSSVTheoLop(maLop).Select(s => new
            {
                s.masinhvien,
                s.hoten,
                s.diemlan1,
                s.diemlan2,
                s.diemtongket
            }).ToList();
            return ds;
        }
        //kết thúc phân quyền giảng viên
    }
}

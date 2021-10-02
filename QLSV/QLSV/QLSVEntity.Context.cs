﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSV
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLSVEntities : DbContext
    {
        public QLSVEntities()
            : base("name=QLSVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<LoaiGioiTinh> LoaiGioiTinhs { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int chamdiem(Nullable<int> magiangvien, Nullable<int> malop, Nullable<int> masinhvien, Nullable<double> diemlan1, Nullable<double> diemlan2, Nullable<double> diemtrongket, ObjectParameter trangThai)
        {
            var magiangvienParameter = magiangvien.HasValue ?
                new ObjectParameter("magiangvien", magiangvien) :
                new ObjectParameter("magiangvien", typeof(int));
    
            var malopParameter = malop.HasValue ?
                new ObjectParameter("malop", malop) :
                new ObjectParameter("malop", typeof(int));
    
            var masinhvienParameter = masinhvien.HasValue ?
                new ObjectParameter("masinhvien", masinhvien) :
                new ObjectParameter("masinhvien", typeof(int));
    
            var diemlan1Parameter = diemlan1.HasValue ?
                new ObjectParameter("diemlan1", diemlan1) :
                new ObjectParameter("diemlan1", typeof(double));
    
            var diemlan2Parameter = diemlan2.HasValue ?
                new ObjectParameter("diemlan2", diemlan2) :
                new ObjectParameter("diemlan2", typeof(double));
    
            var diemtrongketParameter = diemtrongket.HasValue ?
                new ObjectParameter("diemtrongket", diemtrongket) :
                new ObjectParameter("diemtrongket", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("chamdiem", magiangvienParameter, malopParameter, masinhvienParameter, diemlan1Parameter, diemlan2Parameter, diemtrongketParameter, trangThai);
        }
    
        public virtual int dangnhap(string loaitaikhoan, string taikhoan, string matkhau, ObjectParameter dem)
        {
            var loaitaikhoanParameter = loaitaikhoan != null ?
                new ObjectParameter("loaitaikhoan", loaitaikhoan) :
                new ObjectParameter("loaitaikhoan", typeof(string));
    
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dangnhap", loaitaikhoanParameter, taikhoanParameter, matkhauParameter, dem);
        }
    
        public virtual ObjectResult<HienThiLopTheoGV_Result> HienThiLopTheoGV(Nullable<int> magiangvien)
        {
            var magiangvienParameter = magiangvien.HasValue ?
                new ObjectParameter("magiangvien", magiangvien) :
                new ObjectParameter("magiangvien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HienThiLopTheoGV_Result>("HienThiLopTheoGV", magiangvienParameter);
        }
    
        public virtual int insertlophoc(Nullable<int> magiaovien, Nullable<int> mamonhoc)
        {
            var magiaovienParameter = magiaovien.HasValue ?
                new ObjectParameter("magiaovien", magiaovien) :
                new ObjectParameter("magiaovien", typeof(int));
    
            var mamonhocParameter = mamonhoc.HasValue ?
                new ObjectParameter("mamonhoc", mamonhoc) :
                new ObjectParameter("mamonhoc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertlophoc", magiaovienParameter, mamonhocParameter);
        }
    
        public virtual int ketthuchocphan(string magiangvien, Nullable<int> malop, ObjectParameter trangThai)
        {
            var magiangvienParameter = magiangvien != null ?
                new ObjectParameter("magiangvien", magiangvien) :
                new ObjectParameter("magiangvien", typeof(string));
    
            var malopParameter = malop.HasValue ?
                new ObjectParameter("malop", malop) :
                new ObjectParameter("malop", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ketthuchocphan", magiangvienParameter, malopParameter, trangThai);
        }
    
        public virtual ObjectResult<selectALLLopHoc_Result> selectALLLopHoc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectALLLopHoc_Result>("selectALLLopHoc");
        }
    
        public virtual ObjectResult<selectLopHoc_Result> selectLopHoc(Nullable<long> malophoc)
        {
            var malophocParameter = malophoc.HasValue ?
                new ObjectParameter("malophoc", malophoc) :
                new ObjectParameter("malophoc", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectLopHoc_Result>("selectLopHoc", malophocParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<TraCuuGiangVien_Result> TraCuuGiangVien(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraCuuGiangVien_Result>("TraCuuGiangVien", tukhoaParameter);
        }
    
        public virtual ObjectResult<TraCuuLopHoc_Result> TraCuuLopHoc(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraCuuLopHoc_Result>("TraCuuLopHoc", tukhoaParameter);
        }
    
        public virtual ObjectResult<TraCuuMonHoc_Result> TraCuuMonHoc(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraCuuMonHoc_Result>("TraCuuMonHoc", tukhoaParameter);
        }
    
        public virtual ObjectResult<TraCuuSinhVien_Result> TraCuuSinhVien(string tukhoa)
        {
            var tukhoaParameter = tukhoa != null ?
                new ObjectParameter("tukhoa", tukhoa) :
                new ObjectParameter("tukhoa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TraCuuSinhVien_Result>("TraCuuSinhVien", tukhoaParameter);
        }
    
        public virtual ObjectResult<DSSVTheoLop_Result> DSSVTheoLop(Nullable<int> malophoc)
        {
            var malophocParameter = malophoc.HasValue ?
                new ObjectParameter("malophoc", malophoc) :
                new ObjectParameter("malophoc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DSSVTheoLop_Result>("DSSVTheoLop", malophocParameter);
        }
    }
}

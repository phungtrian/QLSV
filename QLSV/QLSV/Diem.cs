//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Diem
    {
        public int maMonHoc { get; set; }
        public int maGiangVien { get; set; }
        public int maSinhVien { get; set; }
        public double diemLan1 { get; set; }
        public double diemLan2 { get; set; }
        public Nullable<System.DateTime> ngayTao { get; set; }
        public Nullable<System.DateTime> ngayCapNhat { get; set; }
        public string nguoiTao { get; set; }
        public string nguoiCapNhat { get; set; }
        public Nullable<int> maLopHoc { get; set; }
        public Nullable<double> diemtongket { get; set; }
    
        public virtual MonHoc MonHoc { get; set; }
        public virtual SinhVien SinhVien { get; set; }
    }
}

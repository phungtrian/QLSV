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
    
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            this.Diems = new HashSet<Diem>();
        }
    
        public int maSinhVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public Nullable<System.DateTime> namSinh { get; set; }
        public string queQuan { get; set; }
        public int dienThoai { get; set; }
        public string diaChi { get; set; }
        public Nullable<System.DateTime> ngayTao { get; set; }
        public Nullable<System.DateTime> ngayCapNhat { get; set; }
        public string nguoiTao { get; set; }
        public string nguoiCapNhat { get; set; }
        public string gioiTinh { get; set; }
        public string matKhau { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }
    }
}

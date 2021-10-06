using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    class DAODangNhap
    {
        QLSVEntities db;

        public DAODangNhap()
        {
            db = new QLSVEntities();
        }


        public int Dangnhap(string loaiTK, string tenDN, string matKhau)
        {




            var kt = new ObjectParameter("dem", typeof(int));

            db.DangNhap(loaiTK, tenDN, matKhau, kt);



            return int.Parse(kt.Value.ToString());
        }
    }
}

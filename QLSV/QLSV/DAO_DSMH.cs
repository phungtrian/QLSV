using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class DAO_DSMH
    {
        QLSVDataContext db;
        public DAO_DSMH()
        {
            db = new QLSVDataContext();
        }
        
        public List<MonHoc> LayDSMonHoc()
        {
            List<MonHoc> dsMH = db.MonHocs.Select(s => s).ToList();
            return dsMH;
        }
    }
}

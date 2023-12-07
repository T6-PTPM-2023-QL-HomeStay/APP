using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DAL_KHACHHANG
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();

        public List<string> getAllMaKH()
        {
            return db.KHACHHANGs.Select(lp => lp.MAKH).ToList();
        }
    }
}

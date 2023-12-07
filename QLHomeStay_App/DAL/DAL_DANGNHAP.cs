using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DAL_DANGNHAP
    {

       static QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();

        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            List<TAIKHOAN> lstTaiKhoans = (db.TAIKHOANs.Where(tk => tk.TENDANGNHAP == tenDangNhap && tk.MATKHAU == matKhau)).ToList();
            return lstTaiKhoans.Count < 1 ? false : true;
        }
    }
}

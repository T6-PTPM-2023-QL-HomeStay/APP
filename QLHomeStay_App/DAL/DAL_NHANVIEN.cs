using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NHANVIEN
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();

        public List<TAIKHOAN> getAllTaiKhoan()
        {
            return (from tk in db.TAIKHOANs select tk).ToList();
        }

        public List<NHANVIEN> getAllNhanVien()
        {
            return (from nv in db.NHANVIENs select nv).ToList();
        }

        public bool checkExistTenDN(string tenDN)
        {
            List<TAIKHOAN> lstTaiKhoans = (db.TAIKHOANs.Where(tk => tk.TENDANGNHAP == tenDN)).ToList();
            return lstTaiKhoans.Count < 1 ? false : true;
        }

        public bool checkExistMaTaiKhoan(string maTaiKhoan)
        {
            List<TAIKHOAN> lstTaiKhoans = (db.TAIKHOANs.Where(tk => tk.MATK == maTaiKhoan)).ToList();
            return lstTaiKhoans.Count < 1 ? false : true;
        }

        public bool insertTaiKhoan(string maTaiKhoan, string tenDN, string matKhau, string maQuyen)
        {
            try
            {
                TAIKHOAN _taiKhoan = new TAIKHOAN { MATK = maTaiKhoan, TENDANGNHAP = tenDN, MATKHAU = matKhau, QUYEN = maQuyen };
                db.TAIKHOANs.InsertOnSubmit(_taiKhoan);
                db.SubmitChanges();
                return true;
            }
            catch(Exception _ex)
            {
                return false;
            }
        }

        public bool updateTaiKhoan(string maTaiKhoan, string matKhau, string maQuyen)
        {
            try
            {
                TAIKHOAN _taiKhoan = db.TAIKHOANs.Where(tk => tk.MATK == maTaiKhoan).FirstOrDefault();
                _taiKhoan.MATKHAU = matKhau;
                _taiKhoan.QUYEN = maQuyen;
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool xoaTaiKhoan(string maTaiKhoan)
        {
            try
            {
                TAIKHOAN _taiKhoan = db.TAIKHOANs.Where(tk => tk.MATK == maTaiKhoan).FirstOrDefault();
                db.TAIKHOANs.DeleteOnSubmit(_taiKhoan);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }
    }
}

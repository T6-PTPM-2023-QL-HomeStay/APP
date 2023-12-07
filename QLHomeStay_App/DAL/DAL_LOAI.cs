using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LOAI
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();

        public List<LOAIPHONG> getAllLoaiPhong()
        {
            return (from tk in db.LOAIPHONGs select tk).ToList();
        }

       

        public bool insertLoaiPhong(string ma, string ten, float gb)
        {
            try
            {
                LOAIPHONG lOAIPHONG = new LOAIPHONG { MALOAI = ma, TENLOAI = ten, GIAPH = gb, };
                db.LOAIPHONGs.InsertOnSubmit(lOAIPHONG);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool updateLoaiPhong(string ma, string ten, float gb)
        {
            try
            {
                LOAIPHONG _taiKhoan = db.LOAIPHONGs.Where(tk => tk.MALOAI == ma).FirstOrDefault();
                _taiKhoan.TENLOAI = ten;
                _taiKhoan.GIAPH = gb;
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool xoaLoaiPhong(string ma)
        {
            try
            {
                LOAIPHONG _taiKhoan = db.LOAIPHONGs.Where(tk => tk.MALOAI == ma).FirstOrDefault();
                db.LOAIPHONGs.DeleteOnSubmit(_taiKhoan);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool search(string tenLOAIPHONG)
        {
            try
            {
                LOAIPHONG _dv = db.LOAIPHONGs.Where(ph => ph.TENLOAI == tenLOAIPHONG).FirstOrDefault();
                if (_dv != null)
                {
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}

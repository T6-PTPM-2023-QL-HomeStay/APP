using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DALL_HOADON
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();

        public List<HOADON> GetHOADONs ()
        {
            var khu = from k in db.HOADONs select k;
            return khu.ToList();
        }

        public List<int> getmaHD()
        {
            return db.HOADONs.Select(lp => lp.MAHD).ToList();
        }


        public bool insertHD(int ma, string makh,DateTime ngay)
        {
            try
            {
                HOADON khu = new HOADON { MAHD = ma, MAKH = makh,NGAYTAO=ngay };
                db.HOADONs.InsertOnSubmit(khu);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool updateHD(int ma, string makh, DateTime ngay)
        {
            try
            {
                HOADON _taiKhoan = db.HOADONs.Where(tk => tk.MAHD == ma).FirstOrDefault();
                _taiKhoan.MAKH = makh;
                _taiKhoan.NGAYTAO = ngay;
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool xoaHD(int ma)
        {
            try
            {
                HOADON _taiKhoan = db.HOADONs.Where(tk => tk.MAHD == ma).FirstOrDefault();
                db.HOADONs.DeleteOnSubmit(_taiKhoan);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }

        }

        ///=======================================================================
        ///CTHD
        ///
        public List<CTHD> GetCTHDs()
        {
            var khu = from k in db.CTHDs select k;
            return khu.ToList();
        }

        public bool insertCTHD(int madv, int mahd, string maphong,float tien)
        {
            try
            {
                CTHD khu = new CTHD { MADV = madv,  MAHD= madv, MAPHONG = maphong, TONGTIENTHANHTOAN=tien };
                db.CTHDs.InsertOnSubmit(khu);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool updateCTHD(int mahd, float tien)
        {
            try
            {
                CTHD _taiKhoan = db.CTHDs.Where(tk => tk.MAHD == mahd).FirstOrDefault();
                _taiKhoan.TONGTIENTHANHTOAN = tien;
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool xoaCTHD(int mahd)
        {
            try
            {
                CTHD _taiKhoan = db.CTHDs.Where(tk => tk.MAHD == mahd).FirstOrDefault();
                db.CTHDs.DeleteOnSubmit(_taiKhoan);
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

using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KHU
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();

        public List<KHU> GetKHUs()
        {
            var khu = from k in db.KHUs select k;
            return khu.ToList();
        }
        public List<string> getMaKhu()
        {
            return db.KHUs.Select(lp => lp.MAKHU).ToList();

            // Hiển thị các tên loại

        }
        public bool insertKhu(string ma, string ten)
        {
            try
            {
                KHU khu = new KHU { MAKHU = ma, TENKHU = ten };
                db.KHUs.InsertOnSubmit(khu);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool updateKhu(string ma, string ten)
        {
            try
            {
                KHU _taiKhoan = db.KHUs.Where(tk => tk.MAKHU == ma).FirstOrDefault();
                _taiKhoan.TENKHU = ten;
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool xoaKhu(string ma)
        {
            try
            {
                KHU _taiKhoan = db.KHUs.Where(tk => tk.MAKHU == ma).FirstOrDefault();
                db.KHUs.DeleteOnSubmit(_taiKhoan);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }


        public bool checkPrimaryKey(string ma)
        {
            List<KHU> khus = db.KHUs.Where(p => p.MAKHU == ma).ToList();
            if (khus.Count > 0)
                return true;
            return false;
        }  
        
        public bool search(string tenkhu)
        {
            try
            {
                KHU _dv = db.KHUs.Where(ph => ph.TENKHU == tenkhu).FirstOrDefault();
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
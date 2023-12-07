using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DAL_PHONG
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();
        public List<PHONG> getAllPhong()
        {
            return (from tk in db.PHONGs select tk).ToList();
        }

        public List<string> getTenPhong()
        {
           return db.PHONGs.Select(lp => lp.MALOAIPHONG).ToList();


           

        }
        public List<string> getMaPhong()
        {
            return db.PHONGs.Select(lp => lp.MAPHONG).ToList();




        }

        public bool insertPhong(string map,string malp, string makhu, string tenp,int song,string trangthai)
        {
            try
            {
                PHONG pHONG = new PHONG { MAPHONG = map, MALOAIPHONG = malp, MAKHU = makhu, TENPHONG = tenp,SOLUONGNGUOIO=song,TRANGTHAI=trangthai };
                db.PHONGs.InsertOnSubmit(pHONG);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool updatePhong(string map, string malp, string makhu, string tenp, int song, string trangthai)
        {
            try
            {
                PHONG pHONG = db.PHONGs.Where(tk => tk.MAPHONG == map).FirstOrDefault();
                pHONG.MALOAIPHONG = malp;
                pHONG.MAKHU = makhu;
                pHONG.TENPHONG = tenp;
                pHONG.SOLUONGNGUOIO = song;
                pHONG.TRANGTHAI = trangthai;
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool xoaPhong(string map)
        {
            try
            {
                PHONG _taiKhoan = db.PHONGs.Where(tk => tk.MAPHONG == map).FirstOrDefault();
                db.PHONGs.DeleteOnSubmit(_taiKhoan);
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

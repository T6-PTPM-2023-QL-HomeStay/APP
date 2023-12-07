using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DICHVU
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();
        public List<DVu> GetDICHVUs()
        {
            var dichVu = from k in db.DVus select k;
            return dichVu.ToList();
        }

        public bool insertDV(int madv, string tendv,float dg)
        {
            try
            {
                DVu dv = new DVu { MADV = madv, TENDV = tendv,DONGIA=dg };
                db.DVus.InsertOnSubmit(dv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool updateDV(int map, string tendv,float dg)
        {
            try
            {
                DVu dVu = db.DVus.Where(tk => tk.MADV == map).FirstOrDefault();
                dVu.TENDV = tendv;
                dVu.DONGIA = dg;
                db.SubmitChanges();
                return true;
            }
            catch (Exception _ex)
            {
                return false;
            }
        }

        public bool xoaDV(int map)
        {
            try
            {
                DVu dVu = db.DVus.Where(tk => tk.MADV == map).FirstOrDefault();
                db.DVus.DeleteOnSubmit(dVu);
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

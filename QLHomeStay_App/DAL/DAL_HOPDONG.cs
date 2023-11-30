using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HOPDONG
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();
        public List<HOPDONG> GetHOPDONGs()
        {
            var hOPDONGs = from k in db.HOPDONGs select k;
            return hOPDONGs.ToList();
        }

        public DataTable ConvertHOPDONGsToDataTable()
        {
            List<HOPDONG> HOPDONGs = GetHOPDONGs();


            DataTable dataTable = new DataTable();


            foreach (var property in typeof(HOPDONG).GetProperties())
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var HOPDONG in HOPDONGs)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(HOPDONG).GetProperties())
                {
                    row[property.Name] = property.GetValue(HOPDONG);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public bool themHOPDONG(HOPDONG np)
        {
            try
            {
                db.HOPDONGs.InsertOnSubmit(np);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaHOPDONG(string maHOPDONG)
        {
            try
            {
                HOPDONG HOPDONG = db.HOPDONGs.Where(p => p.MAHOPDONG == maHOPDONG).FirstOrDefault();
                db.HOPDONGs.DeleteOnSubmit(HOPDONG);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaHOPDONG(HOPDONG p)
        {
            try
            {
                HOPDONG _dv = db.HOPDONGs.Where(ph => ph.MAHOPDONG == p.MAHOPDONG).FirstOrDefault();
                _dv.MAKHACH = p.MAKHACH;
                _dv.MAPHONG = p.MAPHONG;
                _dv.THOIGIANTAO = p.THOIGIANTAO;
                _dv.TRANGTHAI = p.TRANGTHAI;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool checkPrimaryKey(string ma)
        {
            List<HOPDONG> HOPDONGs = db.HOPDONGs.Where(p => p.MAHOPDONG == ma).ToList();
            if (HOPDONGs.Count > 0)
                return true;
            return false;
        }
        public List<String> loadKH()
        {
            var data = from entity in db.HOPDONGs
                       select entity.MAKHACH;

            return data.ToList();
        }
        public List<String> loadPH()
        {
            var data = from entity in db.HOPDONGs
                       select entity.MAPHONG;

            return data.ToList();
        }
        
    }
}

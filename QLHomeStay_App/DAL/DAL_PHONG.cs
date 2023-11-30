using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PHONG
    {
        QuanLyHomeStayDataContext db = new QuanLyHomeStayDataContext();
        public List<PHONG> GetPHONGs()
        {
            var PHONG = from k in db.PHONGs select k;
            return PHONG.ToList();
        }
        public DataTable ConvertPHONGsToDataTable()
        {
            List<PHONG> PHONGs = GetPHONGs();


            DataTable dataTable = new DataTable();


            foreach (var property in typeof(PHONG).GetProperties())
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var PHONG in PHONGs)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(PHONG).GetProperties())
                {
                    row[property.Name] = property.GetValue(PHONG);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public bool themPHONG(PHONG np)
        {
            try
            {
                db.PHONGs.InsertOnSubmit(np);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaPHONG(string maPHONG)
        {
            try
            {
                PHONG PHONG = db.PHONGs.Where(p => p.MAPHONG == maPHONG).FirstOrDefault();
                db.PHONGs.DeleteOnSubmit(PHONG);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaPHONG(PHONG p)
        {
            try
            {
                PHONG _dv = db.PHONGs.Where(ph => ph.MAPHONG == p.MAPHONG).FirstOrDefault();
                _dv.TENPHONG = p.TENPHONG;
                _dv.MAKHU = p.MAKHU;
                _dv.LOAIPHONG = p.LOAIPHONG;
                _dv.SOLUONGNGUOIO = p.SOLUONGNGUOIO;

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
            List<PHONG> PHONGs = db.PHONGs.Where(p => p.MAPHONG == ma).ToList();
            if (PHONGs.Count > 0)
                return true;
            return false;
        }

        public List<String> loadKhu()
        {
            var data = from entity in db.PHONGs
                       select entity.MAKHU;


            return data.ToList();
        }

        public List<String> loadLoai()
        {
            var data = from entity in db.PHONGs
                       select entity.MALOAIPHONG;


            return data.ToList();
        }
    }
}

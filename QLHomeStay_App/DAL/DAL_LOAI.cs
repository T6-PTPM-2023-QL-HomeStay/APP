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

        public List<LOAIPHONG> GetLOAIPHONGs()
        {
            var LOAIPHONG = from k in db.LOAIPHONGs select k;
            return LOAIPHONG.ToList();
        }
        public DataTable ConvertLOAIPHONGsToDataTable()
        {
            List<LOAIPHONG> LOAIPHONGs = GetLOAIPHONGs();


            DataTable dataTable = new DataTable();


            foreach (var property in typeof(LOAIPHONG).GetProperties())
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var LOAIPHONG in LOAIPHONGs)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(LOAIPHONG).GetProperties())
                {
                    row[property.Name] = property.GetValue(LOAIPHONG);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public bool themLOAIPHONG(LOAIPHONG np)
        {
            try
            {
                db.LOAIPHONGs.InsertOnSubmit(np);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaLOAIPHONG(string maLOAIPHONG)
        {
            try
            {
                LOAIPHONG LOAIPHONG = db.LOAIPHONGs.Where(p => p.MALOAI == maLOAIPHONG).FirstOrDefault();
                db.LOAIPHONGs.DeleteOnSubmit(LOAIPHONG);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaLoai(LOAIPHONG p)
        {
            try
            {
                LOAIPHONG _dv = db.LOAIPHONGs.Where(ph => ph.MALOAI == p.MALOAI).FirstOrDefault();
                _dv.TENLOAI = p.TENLOAI;
                _dv.GIAPH = p.GIAPH;

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
            List<LOAIPHONG> LOAIPHONGs = db.LOAIPHONGs.Where(p => p.MALOAI == ma).ToList();
            if (LOAIPHONGs.Count > 0)
                return true;
            return false;
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

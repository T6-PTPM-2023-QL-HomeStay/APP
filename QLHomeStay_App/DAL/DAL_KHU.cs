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
        public DataTable ConvertKHUsToDataTable()
        {
            List<KHU> khus = GetKHUs();


            DataTable dataTable = new DataTable();


            foreach (var property in typeof(KHU).GetProperties())
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var khu in khus)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(KHU).GetProperties())
                {
                    row[property.Name] = property.GetValue(khu);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
        public bool themKhu(KHU np)
        {
            try
            {
                db.KHUs.InsertOnSubmit(np);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaKhu(string maKhu)
        {
            try
            {
                KHU khu = db.KHUs.Where(p => p.MAKHU == maKhu).FirstOrDefault();
                db.KHUs.DeleteOnSubmit(khu);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool suaDichVu(KHU p)
        {
            try
            {
                KHU _dv = db.KHUs.Where(ph => ph.MAKHU == p.MAKHU).FirstOrDefault();
                _dv.TENKHU = p.TENKHU;
               
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
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

        public DataTable ConvertDICHVUsToDataTable()
        {
            List<DVu> dichVus = GetDICHVUs();


            DataTable dataTable = new DataTable();

            
            foreach (var property in typeof(DVu).GetProperties())
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var dichvu in dichVus)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(DVu).GetProperties())
                {
                    row[property.Name] = property.GetValue(dichvu);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        

        public bool themDichVu(DVu np)
        {
            try
            {
                db.DVus.InsertOnSubmit(np);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaDichVu(int maDV)
        {
            try
            {
                DVu dICHVU = db.DVus.Where(p => p.MADV == maDV).FirstOrDefault();
                db.DVus.DeleteOnSubmit(dICHVU);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaDichVu(DVu p)
        {
            try
            {
                DVu _dv = db.DVus.Where(ph => ph.MADV == p.MADV).FirstOrDefault();
                _dv.TENDV = p.TENDV;
                _dv.MADV = p.MADV;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool checkPrimaryKey(int ma)
        {
            List<DVu> dICHVUs = db.DVus.Where(p => p.MADV == ma).ToList();
            if (dICHVUs.Count > 0)
                return true;
            return false;
        }

        public List<int> loadPhong()
        {
            var data = from entity in db.DVus
                       select entity.MADV;
            return data.ToList();
        }


    }
}

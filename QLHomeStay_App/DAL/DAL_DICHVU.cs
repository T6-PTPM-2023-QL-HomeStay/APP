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
        public List<DICHVU> GetDICHVUs()
        {
            var dichVu = from k in db.DICHVUs select k;
            return dichVu.ToList();
        }

        public DataTable ConvertDICHVUsToDataTable()
        {
            List<DICHVU> dichVus = GetDICHVUs();


            DataTable dataTable = new DataTable();

            
            foreach (var property in typeof(DICHVU).GetProperties())
            {
                dataTable.Columns.Add(property.Name, property.PropertyType);
            }
            foreach (var dichvu in dichVus)
            {
                DataRow row = dataTable.NewRow();
                foreach (var property in typeof(DICHVU).GetProperties())
                {
                    row[property.Name] = property.GetValue(dichvu);
                }

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        

        public bool themNhanPhong(DICHVU np)
        {
            try
            {
                db.DICHVUs.InsertOnSubmit(np);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaNhanPhong(string maDV)
        {
            try
            {
                DICHVU dICHVU = db.DICHVUs.Where(p => p.MADV == maDV).FirstOrDefault();
                db.DICHVUs.DeleteOnSubmit(dICHVU);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool suaNhanPhong(DICHVU p)
        {
            try
            {
                DICHVU _dv = db.DICHVUs.Where(ph => ph.MADV == p.MADV).FirstOrDefault();
                _dv.TENDV = p.TENDV;
                _dv.MAPHONG = p.MAPHONG;
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
            List<DICHVU> dICHVUs = db.DICHVUs.Where(p => p.MAPHONG == ma).ToList();
            if (dICHVUs.Count > 0)
                return true;
            return false;
        }

        public List<String> loadPhong()
        {
            var data = from entity in db.DICHVUs
                       select entity.MAPHONG;


            return data.ToList();
        }


    }
}

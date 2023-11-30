using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
  public  class BLL_DICHVU
    {
         dalNP = new DAL_NhanPhong();

        public List<KhachHang> getAllKhachHang()
        {
            return dalNP.getAllKhachHang();
        }

        public List<Phong> getAllPhong()
        {
            return dalNP.getAllPhong();
        }

        public List<NhanPhong> getAllNhanPhong()
        {
            return dalNP.getAllNhanPhong();
        }

        public KhachHang getKhachHangfromTenKH(string tenKH)
        {
            return dalNP.getKhachHangfromTenKH(tenKH);
        }

        public bool themNhanPhong(NhanPhong np)
        {
            return dalNP.themNhanPhong(np);
        }

        public bool xoaNhanPhong(string maNhanPhong)
        {
            return dalNP.xoaNhanPhong(maNhanPhong);
        }

        public bool suaNhanPhong(NhanPhong p)
        {
            return dalNP.suaNhanPhong(p);
        }

        public bool checkPrimaryKey(string maNhanPhong)
        {
            return dalNP.checkPrimaryKey(maNhanPhong);
        }

        public Phong getPhongfromMaPhong(string mp)
        {
            return dalNP.getPhongfromMaPhong(mp);
        }

        public int getMaNhanPhongGanNhat()
        {
            return dalNP.getMaNhanPhongGanNhat();
        }

        public KhachHang getKhachHangfromMaKH(string maKH)
        {
            return dalNP.getKhachHangfromMaKH(maKH);
        }
    }
}

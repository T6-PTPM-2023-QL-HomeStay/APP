using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHomeStay_App.GUI
{
    public partial class frmQLPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmQLPhong()
        {
            InitializeComponent();
        }

        private void btn_khu_Click(object sender, EventArgs e)
        {
            frm_Khu khu = new frm_Khu();
            khu.ShowDialog();
        }

        private void btn_loai_Click(object sender, EventArgs e)
        {
            frm_LoaiPhong frm_LoaiPhong = new frm_LoaiPhong();
            frm_LoaiPhong.ShowDialog();
        }
    }
}
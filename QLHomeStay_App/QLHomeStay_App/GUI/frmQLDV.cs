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
    public partial class frmQLDV : DevExpress.XtraEditors.XtraForm
    {
        public frmQLDV()
        {
            InitializeComponent();
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            frmQLPhong ph  = new frmQLPhong();
            ph.ShowDialog();
        }
    }
}
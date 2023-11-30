using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLHomeStay_App.Resources
{
    public partial class frm_DichVu : Form
    {
        
        public frm_DichVu()
        {
            InitializeComponent();
        }

        private void btn_phong_Click(object sender, EventArgs e)
        {
            frm_Phong frm_Phong = new frm_Phong();
            frm_Phong.ShowDialog();
        }
    }
}

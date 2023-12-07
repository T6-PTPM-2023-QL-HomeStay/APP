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
using DAL;
namespace QLHomeStay_App.GUI
{
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        DAL_DANGNHAP dn = new DAL_DANGNHAP();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Trim() == string.Empty || txtUser.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            if (dn.DangNhap(txtUser.Text.Trim(), txtPass.Text.Trim()) == true)
            {
                frm_TrangChu tc = new frm_TrangChu();
                tc.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập và mật khẩu");
        }

    }
}
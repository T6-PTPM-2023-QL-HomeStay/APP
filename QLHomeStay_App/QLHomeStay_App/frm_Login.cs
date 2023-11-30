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

namespace QLHomeStay_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        DAL_DANGNHAP dn = new DAL_DANGNHAP();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dn.DangNhap(txtUser.Text, txtPass.Text)==true)
            {
                frm_Main frm_Main = new frm_Main();
                frm_Main.ShowDialog();
            }
            else
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập và mật khẩu");
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}

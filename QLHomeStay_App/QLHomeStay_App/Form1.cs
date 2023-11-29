using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHomeStay_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //open form into panel main
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panel_ViewMain_BotRight.Controls.Add(childForm);
            panel_ViewMain_BotRight.Tag = childForm;
            title.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }     

        private void btn_quanlinhanvien_Click(object sender, EventArgs e)
        {
            Form QLNV = new frm_QLNV();
            openChildForm(QLNV);
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            Form TC = new frm_Trangchu();
            openChildForm(TC);
        }

        private void btn_QLKH_Click(object sender, EventArgs e)
        {
            Form QLKH = new frm_QLKH();
            openChildForm(QLKH);
        }

        private void btn_QLHD_Click(object sender, EventArgs e)
        {
            Form QLHD = new frm_QLHD();
            openChildForm(QLHD);
        }       

        private void btn_QLDV_Click(object sender, EventArgs e)
        {
            Form QLDV = new frm_QLDichVu();
            openChildForm(QLDV);
        }

        private void btn_QLDanhGia_Click(object sender, EventArgs e)
        {
            Form QLDG = new frm_QLDanhGia();
            openChildForm(QLDG);
        }

        private void btn_QLKM_Click(object sender, EventArgs e)
        {
            Form QLKM = new frm_QLKM();
            openChildForm(QLKM);
        }

        private void btn_qlphong_Click(object sender, EventArgs e)
        {
            Form QLP= new frm_QLPHONG();
            openChildForm(QLP);
        }
    }
}

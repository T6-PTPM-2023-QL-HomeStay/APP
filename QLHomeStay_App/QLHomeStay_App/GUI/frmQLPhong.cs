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
    public partial class frmQLPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmQLPhong()
        {
            InitializeComponent();
            dataGridView1.DataSource = phong.getAllPhong();
        }
        DAL_PHONG phong = new DAL_PHONG();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphong.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbo_loai.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbo_khu.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tenphong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_soluong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
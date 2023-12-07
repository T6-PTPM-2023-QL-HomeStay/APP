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
    public partial class frmQLNV : DevExpress.XtraEditors.XtraForm
    {

        DAL_NHANVIEN nv = new DAL_NHANVIEN();
        public frmQLNV()
        {
            InitializeComponent();
           // dgv_nhanvien.DataSource = nv.getAllNhanVien();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            frm_QLTK frm_QLTK = new frm_QLTK();
            frm_QLTK.ShowDialog();
        }

        private void dgv_nhanvien_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            try
            {
                this.Validate();
                this.nHANVIENBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.qL_KH);
                MessageBox.Show("Lưu thành công");
            }
            catch
            {
                MessageBox.Show("Lưu Thất bại");
            }

        }

        private void frmQLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KH.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_KH.NHANVIEN);

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
        }
    }
}
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
    public partial class frmQLHD : DevExpress.XtraEditors.XtraForm
    {
        public frmQLHD()
        {
            InitializeComponent();
            mAKHComboBox.DataSource = kh.getAllMaKH();
            mAKHComboBox.SelectedItem = 0;

        }
        DAL_KHACHHANG kh = new DAL_KHACHHANG();

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.hOADONTableAdapter.Fill(this.qL_KH.HOADON);

        }


        private void frmQLHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_KH.CTHD' table. You can move, or remove it, as needed.
            this.cTHDTableAdapter.Fill(this.qL_KH.CTHD);
            // TODO: This line of code loads data into the 'qL_KH.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qL_KH.HOADON);

        }
    }
}
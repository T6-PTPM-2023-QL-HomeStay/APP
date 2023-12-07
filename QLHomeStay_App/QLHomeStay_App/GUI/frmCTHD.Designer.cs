
namespace QLHomeStay_App.GUI
{
    partial class frmCTHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAHDLabel1;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label nGAYTAOLabel;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_KH = new QLHomeStay_App.QL_KH();
            this.cbbMaDV = new System.Windows.Forms.ComboBox();
            this.cTHDTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.CTHDTableAdapter();
            this.hOADONTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.cbbMaHd = new System.Windows.Forms.ComboBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            mAHDLabel1 = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            nGAYTAOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qL_KH;
            // 
            // qL_KH
            // 
            this.qL_KH.DataSetName = "QL_KH";
            this.qL_KH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbbMaDV
            // 
            this.cbbMaDV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaDV.FormattingEnabled = true;
            this.cbbMaDV.Location = new System.Drawing.Point(152, 96);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(125, 24);
            this.cbbMaDV.TabIndex = 3;
            // 
            // cTHDTableAdapter
            // 
            this.cTHDTableAdapter.ClearBeforeFill = true;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // mAHDLabel1
            // 
            mAHDLabel1.AutoSize = true;
            mAHDLabel1.Location = new System.Drawing.Point(73, 66);
            mAHDLabel1.Name = "mAHDLabel1";
            mAHDLabel1.Size = new System.Drawing.Size(48, 17);
            mAHDLabel1.TabIndex = 0;
            mAHDLabel1.Text = "Mã HD";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(73, 99);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(47, 17);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "Mã DV";
            // 
            // nGAYTAOLabel
            // 
            nGAYTAOLabel.AutoSize = true;
            nGAYTAOLabel.Location = new System.Drawing.Point(73, 127);
            nGAYTAOLabel.Name = "nGAYTAOLabel";
            nGAYTAOLabel.Size = new System.Drawing.Size(69, 17);
            nGAYTAOLabel.TabIndex = 4;
            nGAYTAOLabel.Text = "Mã Phòng";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDichVuTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = this.cTHDTableAdapter;
            this.tableAdapterManager.CTKHUYENMAITableAdapter = null;
            this.tableAdapterManager.DANHGIATableAdapter = null;
            this.tableAdapterManager.DVuTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = this.hOADONTableAdapter;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTong);
            this.groupControl1.Controls.Add(label1);
            this.groupControl1.Controls.Add(this.cbbMaHd);
            this.groupControl1.Controls.Add(this.cbbMaPhong);
            this.groupControl1.Controls.Add(this.btn_sua);
            this.groupControl1.Controls.Add(this.btn_xoa);
            this.groupControl1.Controls.Add(this.btn_them);
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Controls.Add(mAHDLabel1);
            this.groupControl1.Controls.Add(mAKHLabel);
            this.groupControl1.Controls.Add(this.cbbMaDV);
            this.groupControl1.Controls.Add(nGAYTAOLabel);
            this.groupControl1.Location = new System.Drawing.Point(83, 47);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(655, 480);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chi tiết Hóa đơn";
            // 
            // btn_sua
            // 
            this.btn_sua.BorderColor = System.Drawing.Color.Transparent;
            this.btn_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sua.FillColor = System.Drawing.Color.Transparent;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_sua.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sua.Image = global::QLHomeStay_App.Properties.Resources.refresh;
            this.btn_sua.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_sua.Location = new System.Drawing.Point(335, 376);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(101, 80);
            this.btn_sua.TabIndex = 163;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BorderColor = System.Drawing.Color.Transparent;
            this.btn_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa.FillColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_xoa.ForeColor = System.Drawing.Color.Transparent;
            this.btn_xoa.Image = global::QLHomeStay_App.Properties.Resources.remove;
            this.btn_xoa.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_xoa.Location = new System.Drawing.Point(176, 376);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 80);
            this.btn_xoa.TabIndex = 164;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BorderColor = System.Drawing.Color.Transparent;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.Transparent;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_them.ForeColor = System.Drawing.Color.Transparent;
            this.btn_them.Image = global::QLHomeStay_App.Properties.Resources.checked3;
            this.btn_them.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_them.Location = new System.Drawing.Point(5, 376);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(101, 80);
            this.btn_them.TabIndex = 165;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "FK_CTHD_HD";
            this.cTHDBindingSource.DataSource = this.hOADONBindingSource;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(152, 127);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(125, 24);
            this.cbbMaPhong.TabIndex = 166;
            // 
            // cbbMaHd
            // 
            this.cbbMaHd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaHd.FormattingEnabled = true;
            this.cbbMaHd.Location = new System.Drawing.Point(152, 63);
            this.cbbMaHd.Name = "cbbMaHd";
            this.cbbMaHd.Size = new System.Drawing.Size(125, 24);
            this.cbbMaHd.TabIndex = 167;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(73, 163);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 17);
            label1.TabIndex = 168;
            label1.Text = "Tổng tiền";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(152, 157);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(125, 23);
            this.txtTong.TabIndex = 169;
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 772);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCTHD";
            this.Text = "frmCTHD";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QL_KH qL_KH;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private QL_KHTableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private QL_KHTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private QL_KHTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbMaHd;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.TextBox txtTong;
    }
}

namespace QLHomeStay_App.GUI
{
    partial class frmQLHD
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
            System.Windows.Forms.Label nGAYTAOLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label mAHDLabel1;
            this.qL_KH = new QLHomeStay_App.QL_KH();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager();
            this.cTHDTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.CTHDTableAdapter();
            this.mAKHComboBox = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_sua = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mAHDSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.nGAYTAODateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_CTHD = new Guna.UI2.WinForms.Guna2Button();
            nGAYTAOLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            mAHDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYTAOLabel
            // 
            nGAYTAOLabel.AutoSize = true;
            nGAYTAOLabel.Location = new System.Drawing.Point(73, 127);
            nGAYTAOLabel.Name = "nGAYTAOLabel";
            nGAYTAOLabel.Size = new System.Drawing.Size(67, 17);
            nGAYTAOLabel.TabIndex = 4;
            nGAYTAOLabel.Text = "Ngày Tạo";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(73, 99);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(46, 17);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "Mã KH";
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
            // qL_KH
            // 
            this.qL_KH.DataSetName = "QL_KH";
            this.qL_KH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.qL_KH;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
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
            // cTHDTableAdapter
            // 
            this.cTHDTableAdapter.ClearBeforeFill = true;
            // 
            // mAKHComboBox
            // 
            this.mAKHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.mAKHComboBox.FormattingEnabled = true;
            this.mAKHComboBox.Location = new System.Drawing.Point(152, 96);
            this.mAKHComboBox.Name = "mAKHComboBox";
            this.mAKHComboBox.Size = new System.Drawing.Size(125, 24);
            this.mAKHComboBox.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_CTHD);
            this.groupControl1.Controls.Add(this.btn_sua);
            this.groupControl1.Controls.Add(this.btn_xoa);
            this.groupControl1.Controls.Add(this.btn_them);
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Controls.Add(mAHDLabel1);
            this.groupControl1.Controls.Add(this.mAHDSpinEdit1);
            this.groupControl1.Controls.Add(mAKHLabel);
            this.groupControl1.Controls.Add(this.mAKHComboBox);
            this.groupControl1.Controls.Add(nGAYTAOLabel);
            this.groupControl1.Controls.Add(this.nGAYTAODateEdit);
            this.groupControl1.Location = new System.Drawing.Point(28, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 480);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Hóa đơn";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(433, 150);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // mAHDSpinEdit1
            // 
            this.mAHDSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "MAHD", true));
            this.mAHDSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mAHDSpinEdit1.Location = new System.Drawing.Point(152, 63);
            this.mAHDSpinEdit1.Name = "mAHDSpinEdit1";
            this.mAHDSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mAHDSpinEdit1.Size = new System.Drawing.Size(125, 24);
            this.mAHDSpinEdit1.TabIndex = 1;
            // 
            // nGAYTAODateEdit
            // 
            this.nGAYTAODateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "NGAYTAO", true));
            this.nGAYTAODateEdit.EditValue = null;
            this.nGAYTAODateEdit.Location = new System.Drawing.Point(152, 124);
            this.nGAYTAODateEdit.Name = "nGAYTAODateEdit";
            this.nGAYTAODateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTAODateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTAODateEdit.Size = new System.Drawing.Size(125, 22);
            this.nGAYTAODateEdit.TabIndex = 5;
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "FK_CTHD_HD";
            this.cTHDBindingSource.DataSource = this.hOADONBindingSource;
            // 
            // btn_CTHD
            // 
            this.btn_CTHD.BorderColor = System.Drawing.Color.Transparent;
            this.btn_CTHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CTHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CTHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CTHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CTHD.FillColor = System.Drawing.Color.Transparent;
            this.btn_CTHD.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_CTHD.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CTHD.Image = global::QLHomeStay_App.Properties.Resources.plus;
            this.btn_CTHD.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_CTHD.Location = new System.Drawing.Point(460, 376);
            this.btn_CTHD.Name = "btn_CTHD";
            this.btn_CTHD.Size = new System.Drawing.Size(101, 80);
            this.btn_CTHD.TabIndex = 171;
            this.btn_CTHD.Click += new System.EventHandler(this.btn_CTHD_Click);
            // 
            // frmQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 583);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmQLHD";
            this.Text = "frmQLHD";
            this.Load += new System.EventHandler(this.frmQLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QL_KH qL_KH;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QL_KHTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private QL_KHTableAdapters.TableAdapterManager tableAdapterManager;
        private QL_KHTableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private DevExpress.XtraEditors.DateEdit nGAYTAODateEdit;
        private System.Windows.Forms.ComboBox mAKHComboBox;
        private DevExpress.XtraEditors.SpinEdit mAHDSpinEdit1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btn_sua;
        private Guna.UI2.WinForms.Guna2Button btn_xoa;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private Guna.UI2.WinForms.Guna2Button btn_CTHD;
    }
}
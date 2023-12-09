
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
            System.Windows.Forms.Label mAHDLabel1;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label nGAYTAOLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.qL_KH = new QLHomeStay_App.QL_KH();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager();
            this.cTHDTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.CTHDTableAdapter();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mAKHComboBox = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.cbbMaHd = new System.Windows.Forms.ComboBox();
            this.cbbMaDV = new System.Windows.Forms.ComboBox();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.nGAYTAODateEdit = new DevExpress.XtraEditors.DateEdit();
            this.mAHDSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMADV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTONGTIENTHANHTOAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIAMGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLDICHVU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAHD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTAO = new DevExpress.XtraGrid.Columns.GridColumn();
            mAHDLabel1 = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            nGAYTAOLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
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
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.groupControl1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1409, 655);
            this.guna2Panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1409, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.gridControl1);
            this.guna2Panel2.Controls.Add(this.tableLayoutPanel1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(2, 28);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1405, 285);
            this.guna2Panel2.TabIndex = 172;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.73228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.26772F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.Controls.Add(nGAYTAOLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nGAYTAODateEdit, 1, 3);
            this.tableLayoutPanel1.Controls.Add(mAKHLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mAKHComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(mAHDLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mAHDSpinEdit1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 285);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // mAHDLabel1
            // 
            mAHDLabel1.AutoSize = true;
            mAHDLabel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAHDLabel1.Location = new System.Drawing.Point(3, 55);
            mAHDLabel1.Name = "mAHDLabel1";
            mAHDLabel1.Size = new System.Drawing.Size(63, 22);
            mAHDLabel1.TabIndex = 176;
            mAHDLabel1.Text = "Mã HD";
            // 
            // mAKHComboBox
            // 
            this.mAKHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.mAKHComboBox.FormattingEnabled = true;
            this.mAKHComboBox.Location = new System.Drawing.Point(211, 117);
            this.mAKHComboBox.Name = "mAKHComboBox";
            this.mAKHComboBox.Size = new System.Drawing.Size(285, 24);
            this.mAKHComboBox.TabIndex = 179;
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(3, 114);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(62, 22);
            mAKHLabel.TabIndex = 178;
            mAKHLabel.Text = "Mã KH";
            // 
            // nGAYTAOLabel
            // 
            nGAYTAOLabel.AutoSize = true;
            nGAYTAOLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYTAOLabel.Location = new System.Drawing.Point(3, 171);
            nGAYTAOLabel.Name = "nGAYTAOLabel";
            nGAYTAOLabel.Size = new System.Drawing.Size(86, 22);
            nGAYTAOLabel.TabIndex = 180;
            nGAYTAOLabel.Text = "Ngày Tạo";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.guna2GroupBox1);
            this.groupControl1.Controls.Add(this.guna2Panel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1409, 655);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Hóa đơn";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.nHANVIENGridControl);
            this.guna2GroupBox1.Controls.Add(this.panel1);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(2, 313);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1405, 340);
            this.guna2GroupBox1.TabIndex = 173;
            this.guna2GroupBox1.Text = "Chi tiết ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(3, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 21);
            label4.TabIndex = 187;
            label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(3, 80);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(82, 21);
            label3.TabIndex = 184;
            label3.Text = "Mã Phòng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(3, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 21);
            label2.TabIndex = 182;
            label2.Text = "Mã DV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(3, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 21);
            label1.TabIndex = 181;
            label1.Text = "Mã HD";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(212, 117);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(285, 27);
            this.txtTong.TabIndex = 188;
            // 
            // cbbMaHd
            // 
            this.cbbMaHd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaHd.FormattingEnabled = true;
            this.cbbMaHd.Location = new System.Drawing.Point(212, 83);
            this.cbbMaHd.Name = "cbbMaHd";
            this.cbbMaHd.Size = new System.Drawing.Size(285, 28);
            this.cbbMaHd.TabIndex = 186;
            // 
            // cbbMaDV
            // 
            this.cbbMaDV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaDV.FormattingEnabled = true;
            this.cbbMaDV.Location = new System.Drawing.Point(212, 50);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(285, 28);
            this.cbbMaDV.TabIndex = 183;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(212, 19);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(285, 28);
            this.cbbMaPhong.TabIndex = 185;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.btn_xoa);
            this.panel1.Controls.Add(this.btn_capnhat);
            this.panel1.Controls.Add(this.cbbMaHd);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(this.cbbMaPhong);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(this.cbbMaDV);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.txtTong);
            this.panel1.Controls.Add(label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 300);
            this.panel1.TabIndex = 189;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(58, 171);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(127, 63);
            this.btn_them.TabIndex = 191;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(370, 172);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(127, 62);
            this.btn_xoa.TabIndex = 190;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_capnhat.Location = new System.Drawing.Point(215, 172);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(127, 62);
            this.btn_capnhat.TabIndex = 189;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QLHomeStay_App.Properties.Resources.checked4;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::QLHomeStay_App.Properties.Resources.remove1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::QLHomeStay_App.Properties.Resources.refresh2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // nGAYTAODateEdit
            // 
            this.nGAYTAODateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "NGAYTAO", true));
            this.nGAYTAODateEdit.EditValue = null;
            this.nGAYTAODateEdit.Location = new System.Drawing.Point(211, 174);
            this.nGAYTAODateEdit.Name = "nGAYTAODateEdit";
            this.nGAYTAODateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTAODateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYTAODateEdit.Size = new System.Drawing.Size(285, 22);
            this.nGAYTAODateEdit.TabIndex = 181;
            // 
            // mAHDSpinEdit1
            // 
            this.mAHDSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.hOADONBindingSource, "MAHD", true));
            this.mAHDSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mAHDSpinEdit1.Location = new System.Drawing.Point(211, 58);
            this.mAHDSpinEdit1.Name = "mAHDSpinEdit1";
            this.mAHDSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mAHDSpinEdit1.Size = new System.Drawing.Size(285, 24);
            this.mAHDSpinEdit1.TabIndex = 177;
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "FK_CTHD_HD";
            this.cTHDBindingSource.DataSource = this.hOADONBindingSource;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.cTHDBindingSource;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(746, 40);
            this.nHANVIENGridControl.MainView = this.gridView1;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(659, 300);
            this.nHANVIENGridControl.TabIndex = 190;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMADV,
            this.colMAHD,
            this.colMAPHONG,
            this.colTONGTIENTHANHTOAN,
            this.colGIAMGIA,
            this.colSLDICHVU});
            this.gridView1.GridControl = this.nHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMADV
            // 
            this.colMADV.FieldName = "MADV";
            this.colMADV.MinWidth = 25;
            this.colMADV.Name = "colMADV";
            this.colMADV.Visible = true;
            this.colMADV.VisibleIndex = 0;
            this.colMADV.Width = 94;
            // 
            // colMAHD
            // 
            this.colMAHD.FieldName = "MAHD";
            this.colMAHD.MinWidth = 25;
            this.colMAHD.Name = "colMAHD";
            this.colMAHD.Visible = true;
            this.colMAHD.VisibleIndex = 1;
            this.colMAHD.Width = 94;
            // 
            // colMAPHONG
            // 
            this.colMAPHONG.FieldName = "MAPHONG";
            this.colMAPHONG.MinWidth = 25;
            this.colMAPHONG.Name = "colMAPHONG";
            this.colMAPHONG.Visible = true;
            this.colMAPHONG.VisibleIndex = 2;
            this.colMAPHONG.Width = 94;
            // 
            // colTONGTIENTHANHTOAN
            // 
            this.colTONGTIENTHANHTOAN.FieldName = "TONGTIENTHANHTOAN";
            this.colTONGTIENTHANHTOAN.MinWidth = 25;
            this.colTONGTIENTHANHTOAN.Name = "colTONGTIENTHANHTOAN";
            this.colTONGTIENTHANHTOAN.Visible = true;
            this.colTONGTIENTHANHTOAN.VisibleIndex = 3;
            this.colTONGTIENTHANHTOAN.Width = 94;
            // 
            // colGIAMGIA
            // 
            this.colGIAMGIA.FieldName = "GIAMGIA";
            this.colGIAMGIA.MinWidth = 25;
            this.colGIAMGIA.Name = "colGIAMGIA";
            this.colGIAMGIA.Visible = true;
            this.colGIAMGIA.VisibleIndex = 4;
            this.colGIAMGIA.Width = 94;
            // 
            // colSLDICHVU
            // 
            this.colSLDICHVU.FieldName = "SLDICHVU";
            this.colSLDICHVU.MinWidth = 25;
            this.colSLDICHVU.Name = "colSLDICHVU";
            this.colSLDICHVU.Visible = true;
            this.colSLDICHVU.VisibleIndex = 5;
            this.colSLDICHVU.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hOADONBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(746, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(659, 285);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAHD1,
            this.colMAKH,
            this.colNGAYTAO});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colMAHD1
            // 
            this.colMAHD1.FieldName = "MAHD";
            this.colMAHD1.MinWidth = 25;
            this.colMAHD1.Name = "colMAHD1";
            this.colMAHD1.Visible = true;
            this.colMAHD1.VisibleIndex = 0;
            this.colMAHD1.Width = 94;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.MinWidth = 25;
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 1;
            this.colMAKH.Width = 94;
            // 
            // colNGAYTAO
            // 
            this.colNGAYTAO.FieldName = "NGAYTAO";
            this.colNGAYTAO.MinWidth = 25;
            this.colNGAYTAO.Name = "colNGAYTAO";
            this.colNGAYTAO.Visible = true;
            this.colNGAYTAO.VisibleIndex = 2;
            this.colNGAYTAO.Width = 94;
            // 
            // frmQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 655);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmQLHD";
            this.Text = "QUẢN LÝ HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmQLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_KH qL_KH;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QL_KHTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private QL_KHTableAdapters.TableAdapterManager tableAdapterManager;
        private QL_KHTableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.DateEdit nGAYTAODateEdit;
        private System.Windows.Forms.ComboBox mAKHComboBox;
        private DevExpress.XtraEditors.SpinEdit mAHDSpinEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbMaHd;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_capnhat;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMADV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn colTONGTIENTHANHTOAN;
        private DevExpress.XtraGrid.Columns.GridColumn colGIAMGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colSLDICHVU;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAHD1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTAO;
    }
}

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
            this.txtTong = new System.Windows.Forms.TextBox();
            this.cbbMaHd = new System.Windows.Forms.ComboBox();
            this.cbbMaPhong = new System.Windows.Forms.ComboBox();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAHDLabel1
            // 
            mAHDLabel1.AutoSize = true;
            mAHDLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAHDLabel1.Location = new System.Drawing.Point(3, 35);
            mAHDLabel1.Name = "mAHDLabel1";
            mAHDLabel1.Size = new System.Drawing.Size(60, 21);
            mAHDLabel1.TabIndex = 0;
            mAHDLabel1.Text = "Mã HD";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHLabel.Location = new System.Drawing.Point(3, 73);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(59, 21);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "Mã DV";
            // 
            // nGAYTAOLabel
            // 
            nGAYTAOLabel.AutoSize = true;
            nGAYTAOLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYTAOLabel.Location = new System.Drawing.Point(3, 109);
            nGAYTAOLabel.Name = "nGAYTAOLabel";
            nGAYTAOLabel.Size = new System.Drawing.Size(82, 21);
            nGAYTAOLabel.TabIndex = 4;
            nGAYTAOLabel.Text = "Mã Phòng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 146);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 21);
            label1.TabIndex = 168;
            label1.Text = "Tổng tiền";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1418, 256);
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
            this.cbbMaDV.Location = new System.Drawing.Point(303, 76);
            this.cbbMaDV.Name = "cbbMaDV";
            this.cbbMaDV.Size = new System.Drawing.Size(120, 24);
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
            this.groupControl1.Controls.Add(this.panel1);
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1422, 486);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Chi tiết Hóa đơn";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(303, 112);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(120, 23);
            this.txtTong.TabIndex = 169;
            // 
            // cbbMaHd
            // 
            this.cbbMaHd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaHd.FormattingEnabled = true;
            this.cbbMaHd.Location = new System.Drawing.Point(303, 38);
            this.cbbMaHd.Name = "cbbMaHd";
            this.cbbMaHd.Size = new System.Drawing.Size(120, 24);
            this.cbbMaHd.TabIndex = 167;
            // 
            // cbbMaPhong
            // 
            this.cbbMaPhong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.cbbMaPhong.FormattingEnabled = true;
            this.cbbMaPhong.Location = new System.Drawing.Point(303, 149);
            this.cbbMaPhong.Name = "cbbMaPhong";
            this.cbbMaPhong.Size = new System.Drawing.Size(120, 24);
            this.cbbMaPhong.TabIndex = 166;
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "FK_CTHD_HD";
            this.cTHDBindingSource.DataSource = this.hOADONBindingSource;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.18898F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.81102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(mAHDLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(mAKHLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(nGAYTAOLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbbMaHd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbMaDV, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTong, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbbMaPhong, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1418, 200);
            this.tableLayoutPanel1.TabIndex = 170;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 256);
            this.panel1.TabIndex = 171;
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
            this.toolStrip1.Size = new System.Drawing.Size(1422, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QLHomeStay_App.Properties.Resources.checked4;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::QLHomeStay_App.Properties.Resources.remove1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::QLHomeStay_App.Properties.Resources.refresh2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // frmCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 486);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmCTHD";
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QL_KH qL_KH;
        private System.Windows.Forms.ComboBox cbbMaDV;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private QL_KHTableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private QL_KHTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private QL_KHTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbbMaHd;
        private System.Windows.Forms.ComboBox cbbMaPhong;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}
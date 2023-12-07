namespace QLHomeStay_App.GUI
{
    partial class frmQLKH
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label gIOITINHLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label qUEQUANLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label cCCDLabel;
            System.Windows.Forms.Label mATKLabel;
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.kHACHHANGGridControl = new DevExpress.XtraGrid.GridControl();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_KH = new QLHomeStay_App.QL_KH();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mAKHTextBox = new System.Windows.Forms.TextBox();
            this.hOTENTextBox = new System.Windows.Forms.TextBox();
            this.gIOITINHTextBox = new System.Windows.Forms.TextBox();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.qUEQUANTextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.cCCDTextBox = new System.Windows.Forms.TextBox();
            this.mATKComboBox = new System.Windows.Forms.ComboBox();
            this.btn_tk = new System.Windows.Forms.Button();
            this.kHACHHANGTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager();
            this.kHACHHANGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.kHACHHANGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            mAKHLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            gIOITINHLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            qUEQUANLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            cCCDLabel = new System.Windows.Forms.Label();
            mATKLabel = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingNavigator)).BeginInit();
            this.kHACHHANGBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(114, 103);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(70, 24);
            mAKHLabel.TabIndex = 165;
            mAKHLabel.Text = "MAKH:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(114, 137);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(83, 24);
            hOTENLabel.TabIndex = 167;
            hOTENLabel.Text = "HOTEN:";
            // 
            // gIOITINHLabel
            // 
            gIOITINHLabel.AutoSize = true;
            gIOITINHLabel.Location = new System.Drawing.Point(114, 171);
            gIOITINHLabel.Name = "gIOITINHLabel";
            gIOITINHLabel.Size = new System.Drawing.Size(96, 24);
            gIOITINHLabel.TabIndex = 169;
            gIOITINHLabel.Text = "GIOITINH:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(114, 202);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(112, 24);
            nGAYSINHLabel.TabIndex = 171;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // qUEQUANLabel
            // 
            qUEQUANLabel.AutoSize = true;
            qUEQUANLabel.Location = new System.Drawing.Point(114, 235);
            qUEQUANLabel.Name = "qUEQUANLabel";
            qUEQUANLabel.Size = new System.Drawing.Size(111, 24);
            qUEQUANLabel.TabIndex = 173;
            qUEQUANLabel.Text = "QUEQUAN:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(114, 269);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(52, 24);
            sDTLabel.TabIndex = 175;
            sDTLabel.Text = "SDT:";
            // 
            // cCCDLabel
            // 
            cCCDLabel.AutoSize = true;
            cCCDLabel.Location = new System.Drawing.Point(114, 303);
            cCCDLabel.Name = "cCCDLabel";
            cCCDLabel.Size = new System.Drawing.Size(67, 24);
            cCCDLabel.TabIndex = 177;
            cCCDLabel.Text = "CCCD:";
            // 
            // mATKLabel
            // 
            mATKLabel.AutoSize = true;
            mATKLabel.Location = new System.Drawing.Point(114, 337);
            mATKLabel.Name = "mATKLabel";
            mATKLabel.Size = new System.Drawing.Size(68, 24);
            mATKLabel.TabIndex = 179;
            mATKLabel.Text = "MATK:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = global::QLHomeStay_App.Properties.Resources.search1;
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(476, 34);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(60, 48);
            this.guna2Button1.TabIndex = 79;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.kHACHHANGGridControl);
            this.guna2Panel1.Controls.Add(this.groupBox2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1343, 713);
            this.guna2Panel1.TabIndex = 1;
            // 
            // kHACHHANGGridControl
            // 
            this.kHACHHANGGridControl.DataSource = this.kHACHHANGBindingSource;
            this.kHACHHANGGridControl.Location = new System.Drawing.Point(572, 47);
            this.kHACHHANGGridControl.MainView = this.gridView1;
            this.kHACHHANGGridControl.Name = "kHACHHANGGridControl";
            this.kHACHHANGGridControl.Size = new System.Drawing.Size(768, 355);
            this.kHACHHANGGridControl.TabIndex = 64;
            this.kHACHHANGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qL_KH;
            // 
            // qL_KH
            // 
            this.qL_KH.DataSetName = "QL_KH";
            this.qL_KH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.kHACHHANGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(mAKHLabel);
            this.groupBox2.Controls.Add(this.mAKHTextBox);
            this.groupBox2.Controls.Add(hOTENLabel);
            this.groupBox2.Controls.Add(this.hOTENTextBox);
            this.groupBox2.Controls.Add(gIOITINHLabel);
            this.groupBox2.Controls.Add(this.gIOITINHTextBox);
            this.groupBox2.Controls.Add(nGAYSINHLabel);
            this.groupBox2.Controls.Add(this.nGAYSINHDateEdit);
            this.groupBox2.Controls.Add(qUEQUANLabel);
            this.groupBox2.Controls.Add(this.qUEQUANTextBox);
            this.groupBox2.Controls.Add(sDTLabel);
            this.groupBox2.Controls.Add(this.sDTTextBox);
            this.groupBox2.Controls.Add(cCCDLabel);
            this.groupBox2.Controls.Add(this.cCCDTextBox);
            this.groupBox2.Controls.Add(mATKLabel);
            this.groupBox2.Controls.Add(this.mATKComboBox);
            this.groupBox2.Controls.Add(this.btn_tk);
            this.groupBox2.Controls.Add(this.guna2Button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 713);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // mAKHTextBox
            // 
            this.mAKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MAKH", true));
            this.mAKHTextBox.Location = new System.Drawing.Point(232, 100);
            this.mAKHTextBox.Name = "mAKHTextBox";
            this.mAKHTextBox.Size = new System.Drawing.Size(125, 28);
            this.mAKHTextBox.TabIndex = 166;
            // 
            // hOTENTextBox
            // 
            this.hOTENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "HOTEN", true));
            this.hOTENTextBox.Location = new System.Drawing.Point(232, 134);
            this.hOTENTextBox.Name = "hOTENTextBox";
            this.hOTENTextBox.Size = new System.Drawing.Size(125, 28);
            this.hOTENTextBox.TabIndex = 168;
            // 
            // gIOITINHTextBox
            // 
            this.gIOITINHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "GIOITINH", true));
            this.gIOITINHTextBox.Location = new System.Drawing.Point(232, 168);
            this.gIOITINHTextBox.Name = "gIOITINHTextBox";
            this.gIOITINHTextBox.Size = new System.Drawing.Size(125, 28);
            this.gIOITINHTextBox.TabIndex = 170;
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.kHACHHANGBindingSource, "NGAYSINH", true));
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(232, 199);
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(125, 22);
            this.nGAYSINHDateEdit.TabIndex = 172;
            // 
            // qUEQUANTextBox
            // 
            this.qUEQUANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "QUEQUAN", true));
            this.qUEQUANTextBox.Location = new System.Drawing.Point(232, 232);
            this.qUEQUANTextBox.Name = "qUEQUANTextBox";
            this.qUEQUANTextBox.Size = new System.Drawing.Size(125, 28);
            this.qUEQUANTextBox.TabIndex = 174;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(232, 266);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(125, 28);
            this.sDTTextBox.TabIndex = 176;
            // 
            // cCCDTextBox
            // 
            this.cCCDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "CCCD", true));
            this.cCCDTextBox.Location = new System.Drawing.Point(232, 300);
            this.cCCDTextBox.Name = "cCCDTextBox";
            this.cCCDTextBox.Size = new System.Drawing.Size(125, 28);
            this.cCCDTextBox.TabIndex = 178;
            // 
            // mATKComboBox
            // 
            this.mATKComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MATK", true));
            this.mATKComboBox.FormattingEnabled = true;
            this.mATKComboBox.Location = new System.Drawing.Point(232, 334);
            this.mATKComboBox.Name = "mATKComboBox";
            this.mATKComboBox.Size = new System.Drawing.Size(125, 30);
            this.mATKComboBox.TabIndex = 180;
            // 
            // btn_tk
            // 
            this.btn_tk.Location = new System.Drawing.Point(402, 337);
            this.btn_tk.Name = "btn_tk";
            this.btn_tk.Size = new System.Drawing.Size(47, 30);
            this.btn_tk.TabIndex = 78;
            this.btn_tk.Text = "+";
            this.btn_tk.UseVisualStyleBackColor = true;
            this.btn_tk.Click += new System.EventHandler(this.btn_tk_Click);
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDichVuTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = null;
            this.tableAdapterManager.CTKHUYENMAITableAdapter = null;
            this.tableAdapterManager.DANHGIATableAdapter = null;
            this.tableAdapterManager.DVuTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KHUTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kHACHHANGBindingNavigator
            // 
            this.kHACHHANGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kHACHHANGBindingNavigator.BindingSource = this.kHACHHANGBindingSource;
            this.kHACHHANGBindingNavigator.CountItem = null;
            this.kHACHHANGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kHACHHANGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kHACHHANGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kHACHHANGBindingNavigatorSaveItem});
            this.kHACHHANGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kHACHHANGBindingNavigator.MoveFirstItem = null;
            this.kHACHHANGBindingNavigator.MoveLastItem = null;
            this.kHACHHANGBindingNavigator.MoveNextItem = null;
            this.kHACHHANGBindingNavigator.MovePreviousItem = null;
            this.kHACHHANGBindingNavigator.Name = "kHACHHANGBindingNavigator";
            this.kHACHHANGBindingNavigator.PositionItem = null;
            this.kHACHHANGBindingNavigator.Size = new System.Drawing.Size(1343, 27);
            this.kHACHHANGBindingNavigator.TabIndex = 2;
            this.kHACHHANGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::QLHomeStay_App.Properties.Resources.plus;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::QLHomeStay_App.Properties.Resources.trash_bin;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // kHACHHANGBindingNavigatorSaveItem
            // 
            this.kHACHHANGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kHACHHANGBindingNavigatorSaveItem.Image = global::QLHomeStay_App.Properties.Resources.checked1;
            this.kHACHHANGBindingNavigatorSaveItem.Name = "kHACHHANGBindingNavigatorSaveItem";
            this.kHACHHANGBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.kHACHHANGBindingNavigatorSaveItem.Text = "Save Data";
            this.kHACHHANGBindingNavigatorSaveItem.Click += new System.EventHandler(this.kHACHHANGBindingNavigatorSaveItem_Click);
            // 
            // frmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 713);
            this.Controls.Add(this.kHACHHANGBindingNavigator);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmQLKH";
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmQLKH_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingNavigator)).EndInit();
            this.kHACHHANGBindingNavigator.ResumeLayout(false);
            this.kHACHHANGBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_tk;
        private QL_KH qL_KH;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private QL_KHTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private QL_KHTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kHACHHANGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kHACHHANGBindingNavigatorSaveItem;
        private DevExpress.XtraGrid.GridControl kHACHHANGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox mAKHTextBox;
        private System.Windows.Forms.TextBox hOTENTextBox;
        private System.Windows.Forms.TextBox gIOITINHTextBox;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private System.Windows.Forms.TextBox qUEQUANTextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox cCCDTextBox;
        private System.Windows.Forms.ComboBox mATKComboBox;
    }
}
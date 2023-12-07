
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
            System.Windows.Forms.Label mADVLabel;
            System.Windows.Forms.Label mAHDLabel;
            System.Windows.Forms.Label mAPHONGLabel;
            System.Windows.Forms.Label tONGTIENTHANHTOANLabel;
            System.Windows.Forms.Label gIAMGIALabel;
            System.Windows.Forms.Label sLDICHVULabel;
            System.Windows.Forms.Label mAHDLabel1;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label nGAYTAOLabel;
            this.qL_KH = new QLHomeStay_App.QL_KH();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager();
            this.hOADONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.hOADONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHDTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.CTHDTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.mADVSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAHDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAPHONGComboBox = new System.Windows.Forms.ComboBox();
            this.tONGTIENTHANHTOANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.gIAMGIASpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sLDICHVUSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cTHDGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mAHDSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.mAKHComboBox = new System.Windows.Forms.ComboBox();
            this.nGAYTAODateEdit = new DevExpress.XtraEditors.DateEdit();
            this.hOADONGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            mADVLabel = new System.Windows.Forms.Label();
            mAHDLabel = new System.Windows.Forms.Label();
            mAPHONGLabel = new System.Windows.Forms.Label();
            tONGTIENTHANHTOANLabel = new System.Windows.Forms.Label();
            gIAMGIALabel = new System.Windows.Forms.Label();
            sLDICHVULabel = new System.Windows.Forms.Label();
            mAHDLabel1 = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            nGAYTAOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).BeginInit();
            this.hOADONBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mADVSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGTIENTHANHTOANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAMGIASpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLDICHVUSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONGridControl)).BeginInit();
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
            // hOADONBindingNavigator
            // 
            this.hOADONBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hOADONBindingNavigator.BindingSource = this.hOADONBindingSource;
            this.hOADONBindingNavigator.CountItem = null;
            this.hOADONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hOADONBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hOADONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hOADONBindingNavigatorSaveItem});
            this.hOADONBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hOADONBindingNavigator.MoveFirstItem = null;
            this.hOADONBindingNavigator.MoveLastItem = null;
            this.hOADONBindingNavigator.MoveNextItem = null;
            this.hOADONBindingNavigator.MovePreviousItem = null;
            this.hOADONBindingNavigator.Name = "hOADONBindingNavigator";
            this.hOADONBindingNavigator.PositionItem = null;
            this.hOADONBindingNavigator.Size = new System.Drawing.Size(1451, 27);
            this.hOADONBindingNavigator.TabIndex = 0;
            this.hOADONBindingNavigator.Text = "bindingNavigator1";
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
            // hOADONBindingNavigatorSaveItem
            // 
            this.hOADONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hOADONBindingNavigatorSaveItem.Image = global::QLHomeStay_App.Properties.Resources.checked2;
            this.hOADONBindingNavigatorSaveItem.Name = "hOADONBindingNavigatorSaveItem";
            this.hOADONBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.hOADONBindingNavigatorSaveItem.Text = "Save Data";
            this.hOADONBindingNavigatorSaveItem.Click += new System.EventHandler(this.hOADONBindingNavigatorSaveItem_Click);
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "FK_CTHD_HD";
            this.cTHDBindingSource.DataSource = this.hOADONBindingSource;
            // 
            // cTHDTableAdapter
            // 
            this.cTHDTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.hOADONGridControl);
            this.groupControl1.Controls.Add(mAHDLabel1);
            this.groupControl1.Controls.Add(this.mAHDSpinEdit1);
            this.groupControl1.Controls.Add(mAKHLabel);
            this.groupControl1.Controls.Add(this.mAKHComboBox);
            this.groupControl1.Controls.Add(nGAYTAOLabel);
            this.groupControl1.Controls.Add(this.nGAYTAODateEdit);
            this.groupControl1.Location = new System.Drawing.Point(31, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(607, 480);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Hóa đơn";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cTHDGridControl);
            this.groupControl2.Controls.Add(mADVLabel);
            this.groupControl2.Controls.Add(this.mADVSpinEdit);
            this.groupControl2.Controls.Add(mAHDLabel);
            this.groupControl2.Controls.Add(this.mAHDSpinEdit);
            this.groupControl2.Controls.Add(mAPHONGLabel);
            this.groupControl2.Controls.Add(this.mAPHONGComboBox);
            this.groupControl2.Controls.Add(tONGTIENTHANHTOANLabel);
            this.groupControl2.Controls.Add(this.tONGTIENTHANHTOANSpinEdit);
            this.groupControl2.Controls.Add(gIAMGIALabel);
            this.groupControl2.Controls.Add(this.gIAMGIASpinEdit);
            this.groupControl2.Controls.Add(sLDICHVULabel);
            this.groupControl2.Controls.Add(this.sLDICHVUSpinEdit);
            this.groupControl2.Location = new System.Drawing.Point(707, 42);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(667, 534);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chi tiết Hóa đơn";
            // 
            // mADVLabel
            // 
            mADVLabel.AutoSize = true;
            mADVLabel.Location = new System.Drawing.Point(35, 52);
            mADVLabel.Name = "mADVLabel";
            mADVLabel.Size = new System.Drawing.Size(49, 17);
            mADVLabel.TabIndex = 0;
            mADVLabel.Text = "MADV:";
            // 
            // mADVSpinEdit
            // 
            this.mADVSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "MADV", true));
            this.mADVSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mADVSpinEdit.Location = new System.Drawing.Point(197, 49);
            this.mADVSpinEdit.Name = "mADVSpinEdit";
            this.mADVSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mADVSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.mADVSpinEdit.TabIndex = 1;
            // 
            // mAHDLabel
            // 
            mAHDLabel.AutoSize = true;
            mAHDLabel.Location = new System.Drawing.Point(35, 82);
            mAHDLabel.Name = "mAHDLabel";
            mAHDLabel.Size = new System.Drawing.Size(50, 17);
            mAHDLabel.TabIndex = 2;
            mAHDLabel.Text = "MAHD:";
            // 
            // mAHDSpinEdit
            // 
            this.mAHDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "MAHD", true));
            this.mAHDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mAHDSpinEdit.Location = new System.Drawing.Point(197, 79);
            this.mAHDSpinEdit.Name = "mAHDSpinEdit";
            this.mAHDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mAHDSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.mAHDSpinEdit.TabIndex = 3;
            // 
            // mAPHONGLabel
            // 
            mAPHONGLabel.AutoSize = true;
            mAPHONGLabel.Location = new System.Drawing.Point(35, 115);
            mAPHONGLabel.Name = "mAPHONGLabel";
            mAPHONGLabel.Size = new System.Drawing.Size(76, 17);
            mAPHONGLabel.TabIndex = 4;
            mAPHONGLabel.Text = "MAPHONG:";
            // 
            // mAPHONGComboBox
            // 
            this.mAPHONGComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTHDBindingSource, "MAPHONG", true));
            this.mAPHONGComboBox.FormattingEnabled = true;
            this.mAPHONGComboBox.Location = new System.Drawing.Point(197, 112);
            this.mAPHONGComboBox.Name = "mAPHONGComboBox";
            this.mAPHONGComboBox.Size = new System.Drawing.Size(125, 24);
            this.mAPHONGComboBox.TabIndex = 5;
            // 
            // tONGTIENTHANHTOANLabel
            // 
            tONGTIENTHANHTOANLabel.AutoSize = true;
            tONGTIENTHANHTOANLabel.Location = new System.Drawing.Point(346, 56);
            tONGTIENTHANHTOANLabel.Name = "tONGTIENTHANHTOANLabel";
            tONGTIENTHANHTOANLabel.Size = new System.Drawing.Size(156, 17);
            tONGTIENTHANHTOANLabel.TabIndex = 6;
            tONGTIENTHANHTOANLabel.Text = "TONGTIENTHANHTOAN:";
            // 
            // tONGTIENTHANHTOANSpinEdit
            // 
            this.tONGTIENTHANHTOANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "TONGTIENTHANHTOAN", true));
            this.tONGTIENTHANHTOANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tONGTIENTHANHTOANSpinEdit.Location = new System.Drawing.Point(508, 53);
            this.tONGTIENTHANHTOANSpinEdit.Name = "tONGTIENTHANHTOANSpinEdit";
            this.tONGTIENTHANHTOANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tONGTIENTHANHTOANSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.tONGTIENTHANHTOANSpinEdit.TabIndex = 7;
            // 
            // gIAMGIALabel
            // 
            gIAMGIALabel.AutoSize = true;
            gIAMGIALabel.Location = new System.Drawing.Point(346, 86);
            gIAMGIALabel.Name = "gIAMGIALabel";
            gIAMGIALabel.Size = new System.Drawing.Size(65, 17);
            gIAMGIALabel.TabIndex = 8;
            gIAMGIALabel.Text = "GIAMGIA:";
            // 
            // gIAMGIASpinEdit
            // 
            this.gIAMGIASpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "GIAMGIA", true));
            this.gIAMGIASpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gIAMGIASpinEdit.Location = new System.Drawing.Point(508, 83);
            this.gIAMGIASpinEdit.Name = "gIAMGIASpinEdit";
            this.gIAMGIASpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gIAMGIASpinEdit.Size = new System.Drawing.Size(125, 24);
            this.gIAMGIASpinEdit.TabIndex = 9;
            // 
            // sLDICHVULabel
            // 
            sLDICHVULabel.AutoSize = true;
            sLDICHVULabel.Location = new System.Drawing.Point(346, 116);
            sLDICHVULabel.Name = "sLDICHVULabel";
            sLDICHVULabel.Size = new System.Drawing.Size(77, 17);
            sLDICHVULabel.TabIndex = 10;
            sLDICHVULabel.Text = "SLDICHVU:";
            // 
            // sLDICHVUSpinEdit
            // 
            this.sLDICHVUSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "SLDICHVU", true));
            this.sLDICHVUSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sLDICHVUSpinEdit.Location = new System.Drawing.Point(508, 113);
            this.sLDICHVUSpinEdit.Name = "sLDICHVUSpinEdit";
            this.sLDICHVUSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sLDICHVUSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.sLDICHVUSpinEdit.TabIndex = 11;
            // 
            // cTHDGridControl
            // 
            this.cTHDGridControl.DataSource = this.cTHDBindingSource;
            this.cTHDGridControl.Location = new System.Drawing.Point(48, 201);
            this.cTHDGridControl.MainView = this.gridView1;
            this.cTHDGridControl.Name = "cTHDGridControl";
            this.cTHDGridControl.Size = new System.Drawing.Size(603, 220);
            this.cTHDGridControl.TabIndex = 12;
            this.cTHDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.cTHDGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // mAHDLabel1
            // 
            mAHDLabel1.AutoSize = true;
            mAHDLabel1.Location = new System.Drawing.Point(73, 66);
            mAHDLabel1.Name = "mAHDLabel1";
            mAHDLabel1.Size = new System.Drawing.Size(50, 17);
            mAHDLabel1.TabIndex = 0;
            mAHDLabel1.Text = "MAHD:";
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
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(73, 99);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(48, 17);
            mAKHLabel.TabIndex = 2;
            mAKHLabel.Text = "MAKH:";
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
            // nGAYTAOLabel
            // 
            nGAYTAOLabel.AutoSize = true;
            nGAYTAOLabel.Location = new System.Drawing.Point(73, 127);
            nGAYTAOLabel.Name = "nGAYTAOLabel";
            nGAYTAOLabel.Size = new System.Drawing.Size(73, 17);
            nGAYTAOLabel.TabIndex = 4;
            nGAYTAOLabel.Text = "NGAYTAO:";
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
            // hOADONGridControl
            // 
            this.hOADONGridControl.DataSource = this.hOADONBindingSource;
            this.hOADONGridControl.Location = new System.Drawing.Point(5, 240);
            this.hOADONGridControl.MainView = this.gridView2;
            this.hOADONGridControl.Name = "hOADONGridControl";
            this.hOADONGridControl.Size = new System.Drawing.Size(584, 220);
            this.hOADONGridControl.TabIndex = 6;
            this.hOADONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.hOADONGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // frmQLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 583);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.hOADONBindingNavigator);
            this.Name = "frmQLHD";
            this.Text = "frmQLHD";
            this.Load += new System.EventHandler(this.frmQLHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).EndInit();
            this.hOADONBindingNavigator.ResumeLayout(false);
            this.hOADONBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mADVSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGTIENTHANHTOANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAMGIASpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sLDICHVUSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYTAODateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_KH qL_KH;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QL_KHTableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private QL_KHTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hOADONBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton hOADONBindingNavigatorSaveItem;
        private QL_KHTableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl hOADONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SpinEdit mAHDSpinEdit1;
        private System.Windows.Forms.ComboBox mAKHComboBox;
        private DevExpress.XtraEditors.DateEdit nGAYTAODateEdit;
        private DevExpress.XtraGrid.GridControl cTHDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SpinEdit mADVSpinEdit;
        private DevExpress.XtraEditors.SpinEdit mAHDSpinEdit;
        private System.Windows.Forms.ComboBox mAPHONGComboBox;
        private DevExpress.XtraEditors.SpinEdit tONGTIENTHANHTOANSpinEdit;
        private DevExpress.XtraEditors.SpinEdit gIAMGIASpinEdit;
        private DevExpress.XtraEditors.SpinEdit sLDICHVUSpinEdit;
    }
}
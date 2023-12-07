
namespace QLHomeStay_App.GUI
{
    partial class CTHD
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
            this.qL_KH = new QLHomeStay_App.QL_KH();
            this.cTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cTHDTableAdapter = new QLHomeStay_App.QL_KHTableAdapters.CTHDTableAdapter();
            this.tableAdapterManager = new QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager();
            this.cTHDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cTHDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mADVSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAHDSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAPHONGComboBox = new System.Windows.Forms.ComboBox();
            this.tONGTIENTHANHTOANSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.cTHDGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            mADVLabel = new System.Windows.Forms.Label();
            mAHDLabel = new System.Windows.Forms.Label();
            mAPHONGLabel = new System.Windows.Forms.Label();
            tONGTIENTHANHTOANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingNavigator)).BeginInit();
            this.cTHDBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mADVSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGTIENTHANHTOANSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // qL_KH
            // 
            this.qL_KH.DataSetName = "QL_KH";
            this.qL_KH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cTHDBindingSource
            // 
            this.cTHDBindingSource.DataMember = "CTHD";
            this.cTHDBindingSource.DataSource = this.qL_KH;
            // 
            // cTHDTableAdapter
            // 
            this.cTHDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDichVuTableAdapter = null;
            this.tableAdapterManager.CTHDTableAdapter = this.cTHDTableAdapter;
            this.tableAdapterManager.CTKHUYENMAITableAdapter = null;
            this.tableAdapterManager.DANHGIATableAdapter = null;
            this.tableAdapterManager.DVuTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUTableAdapter = null;
            this.tableAdapterManager.KHUYENMAITableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLHomeStay_App.QL_KHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cTHDBindingNavigator
            // 
            this.cTHDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cTHDBindingNavigator.BindingSource = this.cTHDBindingSource;
            this.cTHDBindingNavigator.CountItem = null;
            this.cTHDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cTHDBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cTHDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cTHDBindingNavigatorSaveItem});
            this.cTHDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cTHDBindingNavigator.MoveFirstItem = null;
            this.cTHDBindingNavigator.MoveLastItem = null;
            this.cTHDBindingNavigator.MoveNextItem = null;
            this.cTHDBindingNavigator.MovePreviousItem = null;
            this.cTHDBindingNavigator.Name = "cTHDBindingNavigator";
            this.cTHDBindingNavigator.PositionItem = null;
            this.cTHDBindingNavigator.Size = new System.Drawing.Size(955, 27);
            this.cTHDBindingNavigator.TabIndex = 0;
            this.cTHDBindingNavigator.Text = "bindingNavigator1";
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
            // cTHDBindingNavigatorSaveItem
            // 
            this.cTHDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cTHDBindingNavigatorSaveItem.Image = global::QLHomeStay_App.Properties.Resources.checked2;
            this.cTHDBindingNavigatorSaveItem.Name = "cTHDBindingNavigatorSaveItem";
            this.cTHDBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cTHDBindingNavigatorSaveItem.Text = "Save Data";
            this.cTHDBindingNavigatorSaveItem.Click += new System.EventHandler(this.cTHDBindingNavigatorSaveItem_Click);
            // 
            // mADVLabel
            // 
            mADVLabel.AutoSize = true;
            mADVLabel.Location = new System.Drawing.Point(128, 110);
            mADVLabel.Name = "mADVLabel";
            mADVLabel.Size = new System.Drawing.Size(50, 17);
            mADVLabel.TabIndex = 1;
            mADVLabel.Text = "Mã DV";
            // 
            // mADVSpinEdit
            // 
            this.mADVSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "MADV", true));
            this.mADVSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mADVSpinEdit.Location = new System.Drawing.Point(250, 106);
            this.mADVSpinEdit.Name = "mADVSpinEdit";
            this.mADVSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mADVSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.mADVSpinEdit.TabIndex = 2;
            // 
            // mAHDLabel
            // 
            mAHDLabel.AutoSize = true;
            mAHDLabel.Location = new System.Drawing.Point(127, 76);
            mAHDLabel.Name = "mAHDLabel";
            mAHDLabel.Size = new System.Drawing.Size(51, 17);
            mAHDLabel.TabIndex = 3;
            mAHDLabel.Text = "Mã HD";
            // 
            // mAHDSpinEdit
            // 
            this.mAHDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "MAHD", true));
            this.mAHDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mAHDSpinEdit.Location = new System.Drawing.Point(249, 72);
            this.mAHDSpinEdit.Name = "mAHDSpinEdit";
            this.mAHDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mAHDSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.mAHDSpinEdit.TabIndex = 4;
            // 
            // mAPHONGLabel
            // 
            mAPHONGLabel.AutoSize = true;
            mAPHONGLabel.Location = new System.Drawing.Point(127, 140);
            mAPHONGLabel.Name = "mAPHONGLabel";
            mAPHONGLabel.Size = new System.Drawing.Size(72, 17);
            mAPHONGLabel.TabIndex = 5;
            mAPHONGLabel.Text = "Mã Phòng";
            // 
            // mAPHONGComboBox
            // 
            this.mAPHONGComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cTHDBindingSource, "MAPHONG", true));
            this.mAPHONGComboBox.FormattingEnabled = true;
            this.mAPHONGComboBox.Location = new System.Drawing.Point(249, 136);
            this.mAPHONGComboBox.Name = "mAPHONGComboBox";
            this.mAPHONGComboBox.Size = new System.Drawing.Size(125, 24);
            this.mAPHONGComboBox.TabIndex = 6;
            // 
            // tONGTIENTHANHTOANLabel
            // 
            tONGTIENTHANHTOANLabel.AutoSize = true;
            tONGTIENTHANHTOANLabel.Location = new System.Drawing.Point(127, 168);
            tONGTIENTHANHTOANLabel.Name = "tONGTIENTHANHTOANLabel";
            tONGTIENTHANHTOANLabel.Size = new System.Drawing.Size(73, 17);
            tONGTIENTHANHTOANLabel.TabIndex = 7;
            tONGTIENTHANHTOANLabel.Text = "Tổng Tiền";
            // 
            // tONGTIENTHANHTOANSpinEdit
            // 
            this.tONGTIENTHANHTOANSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTHDBindingSource, "TONGTIENTHANHTOAN", true));
            this.tONGTIENTHANHTOANSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tONGTIENTHANHTOANSpinEdit.Location = new System.Drawing.Point(249, 164);
            this.tONGTIENTHANHTOANSpinEdit.Name = "tONGTIENTHANHTOANSpinEdit";
            this.tONGTIENTHANHTOANSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tONGTIENTHANHTOANSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.tONGTIENTHANHTOANSpinEdit.TabIndex = 8;
            // 
            // cTHDGridControl
            // 
            this.cTHDGridControl.DataSource = this.cTHDBindingSource;
            this.cTHDGridControl.Location = new System.Drawing.Point(74, 218);
            this.cTHDGridControl.MainView = this.gridView1;
            this.cTHDGridControl.Name = "cTHDGridControl";
            this.cTHDGridControl.Size = new System.Drawing.Size(815, 220);
            this.cTHDGridControl.TabIndex = 9;
            this.cTHDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.cTHDGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 568);
            this.Controls.Add(this.cTHDGridControl);
            this.Controls.Add(mADVLabel);
            this.Controls.Add(this.mADVSpinEdit);
            this.Controls.Add(mAHDLabel);
            this.Controls.Add(this.mAHDSpinEdit);
            this.Controls.Add(mAPHONGLabel);
            this.Controls.Add(this.mAPHONGComboBox);
            this.Controls.Add(tONGTIENTHANHTOANLabel);
            this.Controls.Add(this.tONGTIENTHANHTOANSpinEdit);
            this.Controls.Add(this.cTHDBindingNavigator);
            this.Name = "CTHD";
            this.Text = "CTHD";
            this.Load += new System.EventHandler(this.CTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDBindingNavigator)).EndInit();
            this.cTHDBindingNavigator.ResumeLayout(false);
            this.cTHDBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mADVSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAHDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tONGTIENTHANHTOANSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QL_KH qL_KH;
        private System.Windows.Forms.BindingSource cTHDBindingSource;
        private QL_KHTableAdapters.CTHDTableAdapter cTHDTableAdapter;
        private QL_KHTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cTHDBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton cTHDBindingNavigatorSaveItem;
        private DevExpress.XtraEditors.SpinEdit mADVSpinEdit;
        private DevExpress.XtraEditors.SpinEdit mAHDSpinEdit;
        private System.Windows.Forms.ComboBox mAPHONGComboBox;
        private DevExpress.XtraEditors.SpinEdit tONGTIENTHANHTOANSpinEdit;
        private DevExpress.XtraGrid.GridControl cTHDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
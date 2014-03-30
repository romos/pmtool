namespace pmt
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenuItem_NewPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.rBACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Tables = new System.Windows.Forms.Label();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.bindingSource_Tables = new System.Windows.Forms.BindingSource(this.components);
            this.rbacDataSet = new pmt.rbacDataSet();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.permissionPerObjectTableAdapter1 = new pmt.rbacDataSetTableAdapters.PermissionPerObjectTableAdapter();
            this.userTableAdapter = new pmt.rbacDataSetTableAdapters.UserTableAdapter();
            this.dataGV_Tables = new System.Windows.Forms.DataGridView();
            this.bindingNavigator_Tables = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.roleTableAdapter1 = new pmt.rbacDataSetTableAdapters.RoleTableAdapter();
            this.tableAdapterManager1 = new pmt.rbacDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_rmPolicy = new System.Windows.Forms.Button();
            this.btn_setCardinality = new System.Windows.Forms.Button();
            this.btn_addPolicy = new System.Windows.Forms.Button();
            this.btn_rmDSOD = new System.Windows.Forms.Button();
            this.btn_addDSOD = new System.Windows.Forms.Button();
            this.btn_rmSSOD = new System.Windows.Forms.Button();
            this.btn_addSSOD = new System.Windows.Forms.Button();
            this.btn_rmInheritance = new System.Windows.Forms.Button();
            this.btn_addInheritance = new System.Windows.Forms.Button();
            this.btn_rmAssignment = new System.Windows.Forms.Button();
            this.btn_addAssignment = new System.Windows.Forms.Button();
            this.btn_rmRole = new System.Windows.Forms.Button();
            this.btn_addRole = new System.Windows.Forms.Button();
            this.btn_rmUser = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbacDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Tables)).BeginInit();
            this.bindingNavigator_Tables.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem_NewPolicy,
            this.TSMenuItem_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMenuItem_NewPolicy
            // 
            this.TSMenuItem_NewPolicy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rBACToolStripMenuItem,
            this.mACToolStripMenuItem,
            this.dACToolStripMenuItem});
            this.TSMenuItem_NewPolicy.Enabled = false;
            this.TSMenuItem_NewPolicy.Name = "TSMenuItem_NewPolicy";
            this.TSMenuItem_NewPolicy.Size = new System.Drawing.Size(78, 20);
            this.TSMenuItem_NewPolicy.Text = "New Policy";
            // 
            // rBACToolStripMenuItem
            // 
            this.rBACToolStripMenuItem.Name = "rBACToolStripMenuItem";
            this.rBACToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.rBACToolStripMenuItem.Text = "RBAC";
            // 
            // mACToolStripMenuItem
            // 
            this.mACToolStripMenuItem.Enabled = false;
            this.mACToolStripMenuItem.Name = "mACToolStripMenuItem";
            this.mACToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.mACToolStripMenuItem.Text = "MAC";
            // 
            // dACToolStripMenuItem
            // 
            this.dACToolStripMenuItem.Enabled = false;
            this.dACToolStripMenuItem.Name = "dACToolStripMenuItem";
            this.dACToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.dACToolStripMenuItem.Text = "DAC";
            // 
            // TSMenuItem_about
            // 
            this.TSMenuItem_about.Name = "TSMenuItem_about";
            this.TSMenuItem_about.Size = new System.Drawing.Size(52, 20);
            this.TSMenuItem_about.Text = "About";
            this.TSMenuItem_about.Click += new System.EventHandler(this.TSMenuItem_about_Click);
            // 
            // label_Tables
            // 
            this.label_Tables.AutoSize = true;
            this.label_Tables.Location = new System.Drawing.Point(6, 27);
            this.label_Tables.Name = "label_Tables";
            this.label_Tables.Size = new System.Drawing.Size(103, 13);
            this.label_Tables.TabIndex = 3;
            this.label_Tables.Text = "Выберите таблицу:";
            // 
            // cb_Tables
            // 
            this.cb_Tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tables.FormattingEnabled = true;
            this.cb_Tables.Items.AddRange(new object[] {
            "Action",
            "ActiveRole",
            "AuthUserRole",
            "DynamicSOD",
            "Object",
            "Permission",
            "PermissionPerObject",
            "Policy",
            "Role",
            "RoleHierarchy",
            "RolePermission",
            "Session",
            "StaticSOD",
            "User"});
            this.cb_Tables.Location = new System.Drawing.Point(115, 24);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(147, 21);
            this.cb_Tables.TabIndex = 4;
            this.cb_Tables.SelectedIndexChanged += new System.EventHandler(this.cb_Tables_SelectedIndexChanged);
            // 
            // bindingSource_Tables
            // 
            this.bindingSource_Tables.AllowNew = true;
            // 
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(323, 59);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(142, 25);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "SubmitChanges";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // permissionPerObjectTableAdapter1
            // 
            this.permissionPerObjectTableAdapter1.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // dataGV_Tables
            // 
            this.dataGV_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Tables.Location = new System.Drawing.Point(4, 87);
            this.dataGV_Tables.Name = "dataGV_Tables";
            this.dataGV_Tables.Size = new System.Drawing.Size(461, 343);
            this.dataGV_Tables.TabIndex = 5;
            // 
            // bindingNavigator_Tables
            // 
            this.bindingNavigator_Tables.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator_Tables.BindingSource = this.bindingSource_Tables;
            this.bindingNavigator_Tables.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_Tables.CountItemFormat = "из {0}";
            this.bindingNavigator_Tables.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator_Tables.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator_Tables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator_Tables.Location = new System.Drawing.Point(6, 59);
            this.bindingNavigator_Tables.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_Tables.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_Tables.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_Tables.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_Tables.Name = "bindingNavigator_Tables";
            this.bindingNavigator_Tables.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_Tables.Size = new System.Drawing.Size(256, 25);
            this.bindingNavigator_Tables.TabIndex = 13;
            this.bindingNavigator_Tables.Text = "bindingNavigator_Tables";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // roleTableAdapter1
            // 
            this.roleTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ActionTableAdapter = null;
            this.tableAdapterManager1.ActiveRoleTableAdapter = null;
            this.tableAdapterManager1.AuthUserRoleTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DynamicSODTableAdapter = null;
            this.tableAdapterManager1.ObjectTableAdapter = null;
            this.tableAdapterManager1.PermissionPerObjectTableAdapter = this.permissionPerObjectTableAdapter1;
            this.tableAdapterManager1.PermissionTableAdapter = null;
            this.tableAdapterManager1.PolicyTableAdapter = null;
            this.tableAdapterManager1.RoleHierarchyTableAdapter = null;
            this.tableAdapterManager1.RolePermissionTableAdapter = null;
            this.tableAdapterManager1.RoleTableAdapter = this.roleTableAdapter1;
            this.tableAdapterManager1.SessionTableAdapter = null;
            this.tableAdapterManager1.StaticSODTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = pmt.rbacDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UserTableAdapter = this.userTableAdapter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.bindingNavigator_Tables);
            this.groupBox1.Controls.Add(this.dataGV_Tables);
            this.groupBox1.Controls.Add(this.btn_Submit);
            this.groupBox1.Controls.Add(this.label_Tables);
            this.groupBox1.Controls.Add(this.cb_Tables);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 436);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btn_rmPolicy);
            this.groupBox2.Controls.Add(this.btn_setCardinality);
            this.groupBox2.Controls.Add(this.btn_addPolicy);
            this.groupBox2.Controls.Add(this.btn_rmDSOD);
            this.groupBox2.Controls.Add(this.btn_addDSOD);
            this.groupBox2.Controls.Add(this.btn_rmSSOD);
            this.groupBox2.Controls.Add(this.btn_addSSOD);
            this.groupBox2.Controls.Add(this.btn_rmInheritance);
            this.groupBox2.Controls.Add(this.btn_addInheritance);
            this.groupBox2.Controls.Add(this.btn_rmAssignment);
            this.groupBox2.Controls.Add(this.btn_addAssignment);
            this.groupBox2.Controls.Add(this.btn_rmRole);
            this.groupBox2.Controls.Add(this.btn_addRole);
            this.groupBox2.Controls.Add(this.btn_rmUser);
            this.groupBox2.Controls.Add(this.btn_addUser);
            this.groupBox2.Location = new System.Drawing.Point(497, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 436);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functionality";
            // 
            // btn_rmPolicy
            // 
            this.btn_rmPolicy.Location = new System.Drawing.Point(23, 399);
            this.btn_rmPolicy.Name = "btn_rmPolicy";
            this.btn_rmPolicy.Size = new System.Drawing.Size(140, 21);
            this.btn_rmPolicy.TabIndex = 14;
            this.btn_rmPolicy.Text = "rmPolicy";
            this.btn_rmPolicy.UseVisualStyleBackColor = true;
            this.btn_rmPolicy.Click += new System.EventHandler(this.btn_rmPolicy_Click);
            // 
            // btn_setCardinality
            // 
            this.btn_setCardinality.Location = new System.Drawing.Point(23, 344);
            this.btn_setCardinality.Name = "btn_setCardinality";
            this.btn_setCardinality.Size = new System.Drawing.Size(140, 21);
            this.btn_setCardinality.TabIndex = 12;
            this.btn_setCardinality.Text = "setCardinality";
            this.btn_setCardinality.UseVisualStyleBackColor = true;
            this.btn_setCardinality.Click += new System.EventHandler(this.btn_setCardinality_Click);
            // 
            // btn_addPolicy
            // 
            this.btn_addPolicy.Location = new System.Drawing.Point(23, 371);
            this.btn_addPolicy.Name = "btn_addPolicy";
            this.btn_addPolicy.Size = new System.Drawing.Size(140, 21);
            this.btn_addPolicy.TabIndex = 13;
            this.btn_addPolicy.Text = "addPolicy";
            this.btn_addPolicy.UseVisualStyleBackColor = true;
            this.btn_addPolicy.Click += new System.EventHandler(this.btn_addPolicy_Click);
            // 
            // btn_rmDSOD
            // 
            this.btn_rmDSOD.Location = new System.Drawing.Point(23, 317);
            this.btn_rmDSOD.Name = "btn_rmDSOD";
            this.btn_rmDSOD.Size = new System.Drawing.Size(140, 21);
            this.btn_rmDSOD.TabIndex = 11;
            this.btn_rmDSOD.Text = "rmDSOD";
            this.btn_rmDSOD.UseVisualStyleBackColor = true;
            this.btn_rmDSOD.Click += new System.EventHandler(this.btn_rmDSOD_Click);
            // 
            // btn_addDSOD
            // 
            this.btn_addDSOD.Location = new System.Drawing.Point(23, 290);
            this.btn_addDSOD.Name = "btn_addDSOD";
            this.btn_addDSOD.Size = new System.Drawing.Size(140, 21);
            this.btn_addDSOD.TabIndex = 10;
            this.btn_addDSOD.Text = "addDSOD";
            this.btn_addDSOD.UseVisualStyleBackColor = true;
            this.btn_addDSOD.Click += new System.EventHandler(this.btn_addDSOD_Click);
            // 
            // btn_rmSSOD
            // 
            this.btn_rmSSOD.Location = new System.Drawing.Point(23, 263);
            this.btn_rmSSOD.Name = "btn_rmSSOD";
            this.btn_rmSSOD.Size = new System.Drawing.Size(140, 21);
            this.btn_rmSSOD.TabIndex = 9;
            this.btn_rmSSOD.Text = "rmSSOD";
            this.btn_rmSSOD.UseVisualStyleBackColor = true;
            this.btn_rmSSOD.Click += new System.EventHandler(this.btn_rmSSOD_Click);
            // 
            // btn_addSSOD
            // 
            this.btn_addSSOD.Location = new System.Drawing.Point(23, 236);
            this.btn_addSSOD.Name = "btn_addSSOD";
            this.btn_addSSOD.Size = new System.Drawing.Size(140, 21);
            this.btn_addSSOD.TabIndex = 8;
            this.btn_addSSOD.Text = "addSSOD";
            this.btn_addSSOD.UseVisualStyleBackColor = true;
            this.btn_addSSOD.Click += new System.EventHandler(this.btn_addSSOD_Click);
            // 
            // btn_rmInheritance
            // 
            this.btn_rmInheritance.Location = new System.Drawing.Point(23, 209);
            this.btn_rmInheritance.Name = "btn_rmInheritance";
            this.btn_rmInheritance.Size = new System.Drawing.Size(140, 21);
            this.btn_rmInheritance.TabIndex = 7;
            this.btn_rmInheritance.Text = "rmInheritance";
            this.btn_rmInheritance.UseVisualStyleBackColor = true;
            this.btn_rmInheritance.Click += new System.EventHandler(this.btn_rmInheritance_Click);
            // 
            // btn_addInheritance
            // 
            this.btn_addInheritance.Location = new System.Drawing.Point(23, 182);
            this.btn_addInheritance.Name = "btn_addInheritance";
            this.btn_addInheritance.Size = new System.Drawing.Size(140, 21);
            this.btn_addInheritance.TabIndex = 6;
            this.btn_addInheritance.Text = "addInheritance";
            this.btn_addInheritance.UseVisualStyleBackColor = true;
            this.btn_addInheritance.Click += new System.EventHandler(this.btn_addInheritance_Click);
            // 
            // btn_rmAssignment
            // 
            this.btn_rmAssignment.Location = new System.Drawing.Point(23, 155);
            this.btn_rmAssignment.Name = "btn_rmAssignment";
            this.btn_rmAssignment.Size = new System.Drawing.Size(140, 21);
            this.btn_rmAssignment.TabIndex = 5;
            this.btn_rmAssignment.Text = "rmAssignment";
            this.btn_rmAssignment.UseVisualStyleBackColor = true;
            this.btn_rmAssignment.Click += new System.EventHandler(this.btn_rmAssignment_Click);
            // 
            // btn_addAssignment
            // 
            this.btn_addAssignment.Location = new System.Drawing.Point(23, 128);
            this.btn_addAssignment.Name = "btn_addAssignment";
            this.btn_addAssignment.Size = new System.Drawing.Size(140, 21);
            this.btn_addAssignment.TabIndex = 4;
            this.btn_addAssignment.Text = "addAssignment";
            this.btn_addAssignment.UseVisualStyleBackColor = true;
            this.btn_addAssignment.Click += new System.EventHandler(this.btn_addAssignment_Click);
            // 
            // btn_rmRole
            // 
            this.btn_rmRole.Location = new System.Drawing.Point(23, 101);
            this.btn_rmRole.Name = "btn_rmRole";
            this.btn_rmRole.Size = new System.Drawing.Size(140, 21);
            this.btn_rmRole.TabIndex = 3;
            this.btn_rmRole.Text = "rmRole";
            this.btn_rmRole.UseVisualStyleBackColor = true;
            this.btn_rmRole.Click += new System.EventHandler(this.btn_rmRole_Click);
            // 
            // btn_addRole
            // 
            this.btn_addRole.Location = new System.Drawing.Point(23, 74);
            this.btn_addRole.Name = "btn_addRole";
            this.btn_addRole.Size = new System.Drawing.Size(140, 21);
            this.btn_addRole.TabIndex = 2;
            this.btn_addRole.Text = "addRole";
            this.btn_addRole.UseVisualStyleBackColor = true;
            this.btn_addRole.Click += new System.EventHandler(this.btn_addRole_Click);
            // 
            // btn_rmUser
            // 
            this.btn_rmUser.Location = new System.Drawing.Point(23, 47);
            this.btn_rmUser.Name = "btn_rmUser";
            this.btn_rmUser.Size = new System.Drawing.Size(140, 21);
            this.btn_rmUser.TabIndex = 1;
            this.btn_rmUser.Text = "rmUser";
            this.btn_rmUser.UseVisualStyleBackColor = true;
            this.btn_rmUser.Click += new System.EventHandler(this.btn_rmUser_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(23, 20);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(140, 21);
            this.btn_addUser.TabIndex = 0;
            this.btn_addUser.Text = "addUser";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(688, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 436);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MS Visio";
            // 
            // rbacDataSetBindingSource
            // 
            this.rbacDataSetBindingSource.DataSource = this.rbacDataSet;
            this.rbacDataSetBindingSource.Position = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Tables)).EndInit();
            this.bindingNavigator_Tables.ResumeLayout(false);
            this.bindingNavigator_Tables.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_about;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_NewPolicy;
        private System.Windows.Forms.ToolStripMenuItem rBACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dACToolStripMenuItem;
        private System.Windows.Forms.Label label_Tables;
        private System.Windows.Forms.ComboBox cb_Tables;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource bindingSource_Tables;
        private System.Windows.Forms.Button btn_Submit;
        private rbacDataSetTableAdapters.PermissionPerObjectTableAdapter permissionPerObjectTableAdapter1;
        private rbacDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridView dataGV_Tables;
        private System.Windows.Forms.BindingNavigator bindingNavigator_Tables;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private rbacDataSetTableAdapters.RoleTableAdapter roleTableAdapter1;
        private rbacDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_setCardinality;
        private System.Windows.Forms.Button btn_rmDSOD;
        private System.Windows.Forms.Button btn_addDSOD;
        private System.Windows.Forms.Button btn_rmSSOD;
        private System.Windows.Forms.Button btn_addSSOD;
        private System.Windows.Forms.Button btn_rmInheritance;
        private System.Windows.Forms.Button btn_addInheritance;
        private System.Windows.Forms.Button btn_rmAssignment;
        private System.Windows.Forms.Button btn_addAssignment;
        private System.Windows.Forms.Button btn_rmRole;
        private System.Windows.Forms.Button btn_addRole;
        private System.Windows.Forms.Button btn_rmUser;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Button btn_rmPolicy;
        private System.Windows.Forms.Button btn_addPolicy;
        private System.Windows.Forms.BindingSource rbacDataSetBindingSource;



    }
}


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
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_NewPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.rBACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Tables = new System.Windows.Forms.Label();
            this.cb_Tables = new System.Windows.Forms.ComboBox();
            this.rbacDataSet = new pmt.rbacDataSet();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.permissionPerObjectTableAdapter1 = new pmt.rbacDataSetTableAdapters.PermissionPerObjectTableAdapter();
            this.userTableAdapter = new pmt.rbacDataSetTableAdapters.UserTableAdapter();
            this.dataGV_Tables = new System.Windows.Forms.DataGridView();
            this.bindingNavigator_Tables = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSource_Tables = new System.Windows.Forms.BindingSource(this.components);
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
            this.btn_DrawURP = new System.Windows.Forms.Button();
            this.btn_DeletePage = new System.Windows.Forms.Button();
            this.btn_ClearPage = new System.Windows.Forms.Button();
            this.btn_DrawUserTable = new System.Windows.Forms.Button();
            this.btn_rmRolePerm = new System.Windows.Forms.Button();
            this.btn_addRolePerm = new System.Windows.Forms.Button();
            this.btn_rmPermission = new System.Windows.Forms.Button();
            this.btn_addPermission = new System.Windows.Forms.Button();
            this.btn_rmObject = new System.Windows.Forms.Button();
            this.btn_rmAction = new System.Windows.Forms.Button();
            this.btn_addObject = new System.Windows.Forms.Button();
            this.btn_addAction = new System.Windows.Forms.Button();
            this.btn_addPolicy = new System.Windows.Forms.Button();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_rmRole = new System.Windows.Forms.Button();
            this.btn_rmAssignment = new System.Windows.Forms.Button();
            this.btn_addRole = new System.Windows.Forms.Button();
            this.btn_rmPolicy = new System.Windows.Forms.Button();
            this.btn_setCardinality = new System.Windows.Forms.Button();
            this.btn_rmDSOD = new System.Windows.Forms.Button();
            this.btn_addDSOD = new System.Windows.Forms.Button();
            this.btn_rmSSOD = new System.Windows.Forms.Button();
            this.btn_addSSOD = new System.Windows.Forms.Button();
            this.btn_rmInheritance = new System.Windows.Forms.Button();
            this.btn_addInheritance = new System.Windows.Forms.Button();
            this.btn_addAssignment = new System.Windows.Forms.Button();
            this.btn_rmUser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axDrawingControl1 = new AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl();
            this.rbacDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Tables)).BeginInit();
            this.bindingNavigator_Tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Tables)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axDrawingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.TSMenuItem_NewPolicy,
            this.TSMenuItem_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exportToolStripMenuItem.Text = "Export to XML";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importToolStripMenuItem.Text = "Import from XML";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
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
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(284, 59);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(142, 25);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.TabStop = false;
            this.btn_Submit.Text = "SubmitChanges";
            this.toolTip1.SetToolTip(this.btn_Submit, "Применить изменения (temporary disabled)");
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
            this.dataGV_Tables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGV_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Tables.Location = new System.Drawing.Point(4, 87);
            this.dataGV_Tables.Name = "dataGV_Tables";
            this.dataGV_Tables.ReadOnly = true;
            this.dataGV_Tables.Size = new System.Drawing.Size(422, 485);
            this.dataGV_Tables.TabIndex = 5;
            this.dataGV_Tables.TabStop = false;
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
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.ToolTipText = "Добавить (temporary disabled)";
            // 
            // bindingSource_Tables
            // 
            this.bindingSource_Tables.AllowNew = true;
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
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.ToolTipText = "Удалить (temporary disabled)";
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
            this.groupBox1.Size = new System.Drawing.Size(433, 578);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tables";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btn_DrawURP);
            this.groupBox2.Controls.Add(this.btn_DeletePage);
            this.groupBox2.Controls.Add(this.btn_ClearPage);
            this.groupBox2.Controls.Add(this.btn_DrawUserTable);
            this.groupBox2.Controls.Add(this.btn_rmRolePerm);
            this.groupBox2.Controls.Add(this.btn_addRolePerm);
            this.groupBox2.Controls.Add(this.btn_rmPermission);
            this.groupBox2.Controls.Add(this.btn_addPermission);
            this.groupBox2.Controls.Add(this.btn_rmObject);
            this.groupBox2.Controls.Add(this.btn_rmAction);
            this.groupBox2.Controls.Add(this.btn_addObject);
            this.groupBox2.Controls.Add(this.btn_addAction);
            this.groupBox2.Controls.Add(this.btn_addPolicy);
            this.groupBox2.Controls.Add(this.btn_addUser);
            this.groupBox2.Controls.Add(this.btn_rmRole);
            this.groupBox2.Controls.Add(this.btn_rmAssignment);
            this.groupBox2.Controls.Add(this.btn_addRole);
            this.groupBox2.Controls.Add(this.btn_rmPolicy);
            this.groupBox2.Controls.Add(this.btn_setCardinality);
            this.groupBox2.Controls.Add(this.btn_rmDSOD);
            this.groupBox2.Controls.Add(this.btn_addDSOD);
            this.groupBox2.Controls.Add(this.btn_rmSSOD);
            this.groupBox2.Controls.Add(this.btn_addSSOD);
            this.groupBox2.Controls.Add(this.btn_rmInheritance);
            this.groupBox2.Controls.Add(this.btn_addInheritance);
            this.groupBox2.Controls.Add(this.btn_addAssignment);
            this.groupBox2.Controls.Add(this.btn_rmUser);
            this.groupBox2.Location = new System.Drawing.Point(451, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 578);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functionality";
            // 
            // btn_DrawURP
            // 
            this.btn_DrawURP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DrawURP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DrawURP.Location = new System.Drawing.Point(6, 392);
            this.btn_DrawURP.Name = "btn_DrawURP";
            this.btn_DrawURP.Size = new System.Drawing.Size(198, 36);
            this.btn_DrawURP.TabIndex = 26;
            this.btn_DrawURP.Text = "Draw User-Role-Permission";
            this.btn_DrawURP.UseVisualStyleBackColor = false;
            this.btn_DrawURP.Click += new System.EventHandler(this.btn_DrawURP_Click);
            // 
            // btn_DeletePage
            // 
            this.btn_DeletePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DeletePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_DeletePage.Location = new System.Drawing.Point(108, 434);
            this.btn_DeletePage.Name = "btn_DeletePage";
            this.btn_DeletePage.Size = new System.Drawing.Size(96, 36);
            this.btn_DeletePage.TabIndex = 28;
            this.btn_DeletePage.Text = "DeletePage";
            this.btn_DeletePage.UseVisualStyleBackColor = false;
            this.btn_DeletePage.Click += new System.EventHandler(this.btn_DeletePage_Click);
            // 
            // btn_ClearPage
            // 
            this.btn_ClearPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ClearPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ClearPage.Location = new System.Drawing.Point(6, 434);
            this.btn_ClearPage.Name = "btn_ClearPage";
            this.btn_ClearPage.Size = new System.Drawing.Size(96, 36);
            this.btn_ClearPage.TabIndex = 27;
            this.btn_ClearPage.Text = "ClearPage";
            this.btn_ClearPage.UseVisualStyleBackColor = false;
            this.btn_ClearPage.Click += new System.EventHandler(this.btn_ClearPage_Click);
            // 
            // btn_DrawUserTable
            // 
            this.btn_DrawUserTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_DrawUserTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_DrawUserTable.Location = new System.Drawing.Point(6, 355);
            this.btn_DrawUserTable.Name = "btn_DrawUserTable";
            this.btn_DrawUserTable.Size = new System.Drawing.Size(198, 36);
            this.btn_DrawUserTable.TabIndex = 25;
            this.btn_DrawUserTable.Text = "Draw User Table";
            this.btn_DrawUserTable.UseVisualStyleBackColor = false;
            this.btn_DrawUserTable.Click += new System.EventHandler(this.btn_DrawUserTable_Click);
            // 
            // btn_rmRolePerm
            // 
            this.btn_rmRolePerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmRolePerm.Location = new System.Drawing.Point(108, 308);
            this.btn_rmRolePerm.Name = "btn_rmRolePerm";
            this.btn_rmRolePerm.Size = new System.Drawing.Size(96, 36);
            this.btn_rmRolePerm.TabIndex = 24;
            this.btn_rmRolePerm.Text = "Remove Role-Permission";
            this.btn_rmRolePerm.UseVisualStyleBackColor = false;
            this.btn_rmRolePerm.Click += new System.EventHandler(this.btn_rmRolePerm_Click);
            // 
            // btn_addRolePerm
            // 
            this.btn_addRolePerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addRolePerm.Location = new System.Drawing.Point(6, 309);
            this.btn_addRolePerm.Name = "btn_addRolePerm";
            this.btn_addRolePerm.Size = new System.Drawing.Size(96, 36);
            this.btn_addRolePerm.TabIndex = 23;
            this.btn_addRolePerm.Text = "Add Role-Permission";
            this.btn_addRolePerm.UseVisualStyleBackColor = false;
            this.btn_addRolePerm.Click += new System.EventHandler(this.btn_addRolePerm_Click);
            // 
            // btn_rmPermission
            // 
            this.btn_rmPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmPermission.Location = new System.Drawing.Point(108, 266);
            this.btn_rmPermission.Name = "btn_rmPermission";
            this.btn_rmPermission.Size = new System.Drawing.Size(96, 36);
            this.btn_rmPermission.TabIndex = 22;
            this.btn_rmPermission.Text = "Remove Permission";
            this.btn_rmPermission.UseVisualStyleBackColor = false;
            this.btn_rmPermission.Click += new System.EventHandler(this.btn_rmPermission_Click);
            // 
            // btn_addPermission
            // 
            this.btn_addPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addPermission.Location = new System.Drawing.Point(6, 267);
            this.btn_addPermission.Name = "btn_addPermission";
            this.btn_addPermission.Size = new System.Drawing.Size(96, 36);
            this.btn_addPermission.TabIndex = 21;
            this.btn_addPermission.Text = "Add Permission";
            this.btn_addPermission.UseVisualStyleBackColor = false;
            this.btn_addPermission.Click += new System.EventHandler(this.btn_addPermission_Click);
            // 
            // btn_rmObject
            // 
            this.btn_rmObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmObject.Location = new System.Drawing.Point(108, 224);
            this.btn_rmObject.Name = "btn_rmObject";
            this.btn_rmObject.Size = new System.Drawing.Size(96, 36);
            this.btn_rmObject.TabIndex = 20;
            this.btn_rmObject.Text = "Remove Object";
            this.btn_rmObject.UseVisualStyleBackColor = false;
            this.btn_rmObject.Click += new System.EventHandler(this.btn_rmObject_Click);
            // 
            // btn_rmAction
            // 
            this.btn_rmAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmAction.Location = new System.Drawing.Point(108, 182);
            this.btn_rmAction.Name = "btn_rmAction";
            this.btn_rmAction.Size = new System.Drawing.Size(96, 36);
            this.btn_rmAction.TabIndex = 18;
            this.btn_rmAction.Text = "Remove Action";
            this.btn_rmAction.UseVisualStyleBackColor = false;
            this.btn_rmAction.Click += new System.EventHandler(this.btn_rmAction_Click);
            // 
            // btn_addObject
            // 
            this.btn_addObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addObject.Location = new System.Drawing.Point(6, 225);
            this.btn_addObject.Name = "btn_addObject";
            this.btn_addObject.Size = new System.Drawing.Size(96, 36);
            this.btn_addObject.TabIndex = 19;
            this.btn_addObject.Text = "Add Object";
            this.btn_addObject.UseVisualStyleBackColor = false;
            this.btn_addObject.Click += new System.EventHandler(this.btn_addObject_Click);
            // 
            // btn_addAction
            // 
            this.btn_addAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addAction.Location = new System.Drawing.Point(6, 183);
            this.btn_addAction.Name = "btn_addAction";
            this.btn_addAction.Size = new System.Drawing.Size(96, 36);
            this.btn_addAction.TabIndex = 17;
            this.btn_addAction.Text = "Add Action";
            this.btn_addAction.UseVisualStyleBackColor = false;
            this.btn_addAction.Click += new System.EventHandler(this.btn_addAction_Click);
            // 
            // btn_addPolicy
            // 
            this.btn_addPolicy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addPolicy.Location = new System.Drawing.Point(6, 143);
            this.btn_addPolicy.Name = "btn_addPolicy";
            this.btn_addPolicy.Size = new System.Drawing.Size(96, 36);
            this.btn_addPolicy.TabIndex = 15;
            this.btn_addPolicy.Text = "Add Policy";
            this.btn_addPolicy.UseVisualStyleBackColor = false;
            this.btn_addPolicy.Click += new System.EventHandler(this.btn_addPolicy_Click);
            // 
            // btn_addUser
            // 
            this.btn_addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addUser.Location = new System.Drawing.Point(6, 17);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(96, 36);
            this.btn_addUser.TabIndex = 0;
            this.btn_addUser.Text = "Add User";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_rmRole
            // 
            this.btn_rmRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmRole.Location = new System.Drawing.Point(108, 58);
            this.btn_rmRole.Name = "btn_rmRole";
            this.btn_rmRole.Size = new System.Drawing.Size(96, 36);
            this.btn_rmRole.TabIndex = 3;
            this.btn_rmRole.Text = "Remove Role";
            this.btn_rmRole.UseVisualStyleBackColor = false;
            this.btn_rmRole.Click += new System.EventHandler(this.btn_rmRole_Click);
            // 
            // btn_rmAssignment
            // 
            this.btn_rmAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmAssignment.Location = new System.Drawing.Point(108, 100);
            this.btn_rmAssignment.Name = "btn_rmAssignment";
            this.btn_rmAssignment.Size = new System.Drawing.Size(96, 36);
            this.btn_rmAssignment.TabIndex = 5;
            this.btn_rmAssignment.Text = "Remove Assignment";
            this.btn_rmAssignment.UseVisualStyleBackColor = false;
            this.btn_rmAssignment.Click += new System.EventHandler(this.btn_rmAssignment_Click);
            // 
            // btn_addRole
            // 
            this.btn_addRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addRole.Location = new System.Drawing.Point(6, 59);
            this.btn_addRole.Name = "btn_addRole";
            this.btn_addRole.Size = new System.Drawing.Size(96, 36);
            this.btn_addRole.TabIndex = 2;
            this.btn_addRole.Text = "Add Role";
            this.btn_addRole.UseVisualStyleBackColor = false;
            this.btn_addRole.Click += new System.EventHandler(this.btn_addRole_Click);
            // 
            // btn_rmPolicy
            // 
            this.btn_rmPolicy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmPolicy.Location = new System.Drawing.Point(108, 142);
            this.btn_rmPolicy.Name = "btn_rmPolicy";
            this.btn_rmPolicy.Size = new System.Drawing.Size(96, 36);
            this.btn_rmPolicy.TabIndex = 16;
            this.btn_rmPolicy.Text = "Remove Policy";
            this.toolTip1.SetToolTip(this.btn_rmPolicy, "TODO:\r\nЗапилить каскадное удаление по всем Юзерам, Ролям, Пермишнам");
            this.btn_rmPolicy.UseVisualStyleBackColor = false;
            this.btn_rmPolicy.Click += new System.EventHandler(this.btn_rmPolicy_Click);
            // 
            // btn_setCardinality
            // 
            this.btn_setCardinality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_setCardinality.Enabled = false;
            this.btn_setCardinality.Location = new System.Drawing.Point(6, 551);
            this.btn_setCardinality.Name = "btn_setCardinality";
            this.btn_setCardinality.Size = new System.Drawing.Size(198, 21);
            this.btn_setCardinality.TabIndex = 12;
            this.btn_setCardinality.Text = "setCardinality";
            this.toolTip1.SetToolTip(this.btn_setCardinality, "Temporary disabled");
            this.btn_setCardinality.UseVisualStyleBackColor = true;
            // 
            // btn_rmDSOD
            // 
            this.btn_rmDSOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_rmDSOD.Enabled = false;
            this.btn_rmDSOD.Location = new System.Drawing.Point(108, 530);
            this.btn_rmDSOD.Name = "btn_rmDSOD";
            this.btn_rmDSOD.Size = new System.Drawing.Size(96, 21);
            this.btn_rmDSOD.TabIndex = 11;
            this.btn_rmDSOD.Text = "rmDSOD";
            this.toolTip1.SetToolTip(this.btn_rmDSOD, "Temporary disabled");
            this.btn_rmDSOD.UseVisualStyleBackColor = true;
            // 
            // btn_addDSOD
            // 
            this.btn_addDSOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addDSOD.Enabled = false;
            this.btn_addDSOD.Location = new System.Drawing.Point(6, 530);
            this.btn_addDSOD.Name = "btn_addDSOD";
            this.btn_addDSOD.Size = new System.Drawing.Size(96, 21);
            this.btn_addDSOD.TabIndex = 10;
            this.btn_addDSOD.Text = "addDSOD";
            this.toolTip1.SetToolTip(this.btn_addDSOD, "Temporary disabled");
            this.btn_addDSOD.UseVisualStyleBackColor = true;
            // 
            // btn_rmSSOD
            // 
            this.btn_rmSSOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_rmSSOD.Enabled = false;
            this.btn_rmSSOD.Location = new System.Drawing.Point(108, 509);
            this.btn_rmSSOD.Name = "btn_rmSSOD";
            this.btn_rmSSOD.Size = new System.Drawing.Size(96, 21);
            this.btn_rmSSOD.TabIndex = 9;
            this.btn_rmSSOD.Text = "rmSSOD";
            this.toolTip1.SetToolTip(this.btn_rmSSOD, "Temporary disabled");
            this.btn_rmSSOD.UseVisualStyleBackColor = true;
            // 
            // btn_addSSOD
            // 
            this.btn_addSSOD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addSSOD.Enabled = false;
            this.btn_addSSOD.Location = new System.Drawing.Point(6, 509);
            this.btn_addSSOD.Name = "btn_addSSOD";
            this.btn_addSSOD.Size = new System.Drawing.Size(96, 21);
            this.btn_addSSOD.TabIndex = 8;
            this.btn_addSSOD.Text = "addSSOD";
            this.toolTip1.SetToolTip(this.btn_addSSOD, "Temporary disabled");
            this.btn_addSSOD.UseVisualStyleBackColor = true;
            // 
            // btn_rmInheritance
            // 
            this.btn_rmInheritance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_rmInheritance.Enabled = false;
            this.btn_rmInheritance.Location = new System.Drawing.Point(108, 488);
            this.btn_rmInheritance.Name = "btn_rmInheritance";
            this.btn_rmInheritance.Size = new System.Drawing.Size(96, 21);
            this.btn_rmInheritance.TabIndex = 7;
            this.btn_rmInheritance.Text = "rmInheritance";
            this.toolTip1.SetToolTip(this.btn_rmInheritance, "Temporary disabled");
            this.btn_rmInheritance.UseVisualStyleBackColor = true;
            // 
            // btn_addInheritance
            // 
            this.btn_addInheritance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addInheritance.Enabled = false;
            this.btn_addInheritance.Location = new System.Drawing.Point(6, 488);
            this.btn_addInheritance.Name = "btn_addInheritance";
            this.btn_addInheritance.Size = new System.Drawing.Size(96, 21);
            this.btn_addInheritance.TabIndex = 6;
            this.btn_addInheritance.Text = "addInheritance";
            this.toolTip1.SetToolTip(this.btn_addInheritance, "Temporary disabled");
            this.btn_addInheritance.UseVisualStyleBackColor = true;
            // 
            // btn_addAssignment
            // 
            this.btn_addAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addAssignment.Location = new System.Drawing.Point(6, 101);
            this.btn_addAssignment.Name = "btn_addAssignment";
            this.btn_addAssignment.Size = new System.Drawing.Size(96, 36);
            this.btn_addAssignment.TabIndex = 4;
            this.btn_addAssignment.Text = "Add Assignment";
            this.btn_addAssignment.UseVisualStyleBackColor = false;
            this.btn_addAssignment.Click += new System.EventHandler(this.btn_addAssignment_Click);
            // 
            // btn_rmUser
            // 
            this.btn_rmUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_rmUser.Location = new System.Drawing.Point(108, 16);
            this.btn_rmUser.Name = "btn_rmUser";
            this.btn_rmUser.Size = new System.Drawing.Size(96, 36);
            this.btn_rmUser.TabIndex = 1;
            this.btn_rmUser.Text = "Remove User";
            this.btn_rmUser.UseVisualStyleBackColor = false;
            this.btn_rmUser.Click += new System.EventHandler(this.btn_rmUser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.axDrawingControl1);
            this.groupBox3.Location = new System.Drawing.Point(667, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 578);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MS Visio";
            // 
            // axDrawingControl1
            // 
            this.axDrawingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axDrawingControl1.Enabled = true;
            this.axDrawingControl1.Location = new System.Drawing.Point(3, 16);
            this.axDrawingControl1.Name = "axDrawingControl1";
            this.axDrawingControl1.Size = new System.Drawing.Size(512, 559);
            this.axDrawingControl1.TabIndex = 0;
            // 
            // rbacDataSetBindingSource
            // 
            this.rbacDataSetBindingSource.DataSource = this.rbacDataSet;
            this.rbacDataSetBindingSource.Position = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.FileName = "exportRBAC.xml";
            this.saveFileDialog1.Filter = "XML-files|*.xml|All files|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "XML-files|*.xml|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 617);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1213, 655);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Tables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Tables)).EndInit();
            this.bindingNavigator_Tables.ResumeLayout(false);
            this.bindingNavigator_Tables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Tables)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axDrawingControl1)).EndInit();
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
        private System.Windows.Forms.BindingSource rbacDataSetBindingSource;
        private System.Windows.Forms.Button btn_addPolicy;
        private System.Windows.Forms.Button btn_rmPolicy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_rmObject;
        private System.Windows.Forms.Button btn_rmAction;
        private System.Windows.Forms.Button btn_addObject;
        private System.Windows.Forms.Button btn_addAction;
        private System.Windows.Forms.Button btn_rmPermission;
        private System.Windows.Forms.Button btn_addPermission;
        private System.Windows.Forms.Button btn_rmRolePerm;
        private System.Windows.Forms.Button btn_addRolePerm;
        private AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl axDrawingControl1;
        private System.Windows.Forms.Button btn_DrawUserTable;
        private System.Windows.Forms.Button btn_DeletePage;
        private System.Windows.Forms.Button btn_ClearPage;
        private System.Windows.Forms.Button btn_DrawURP;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;



    }
}


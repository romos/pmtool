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
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_role = new System.Windows.Forms.Button();
            this.btn_authUR = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_policy = new System.Windows.Forms.Button();
            this.permissionPerObjectTableAdapter1 = new pmt.rbacDataSetTableAdapters.PermissionPerObjectTableAdapter();
            this.userTableAdapter = new pmt.rbacDataSetTableAdapters.UserTableAdapter();
            this.dataGV_Tables = new System.Windows.Forms.DataGridView();
            this.bindingNavigator_Tables = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Tables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator_Tables)).BeginInit();
            this.bindingNavigator_Tables.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
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
            this.label_Tables.Location = new System.Drawing.Point(12, 39);
            this.label_Tables.Name = "label_Tables";
            this.label_Tables.Size = new System.Drawing.Size(103, 13);
            this.label_Tables.TabIndex = 3;
            this.label_Tables.Text = "Выберите таблицу:";
            // 
            // cb_Tables
            // 
            this.cb_Tables.DisplayMember = "ва";
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
            this.cb_Tables.Location = new System.Drawing.Point(121, 36);
            this.cb_Tables.Name = "cb_Tables";
            this.cb_Tables.Size = new System.Drawing.Size(137, 21);
            this.cb_Tables.TabIndex = 4;
            this.cb_Tables.SelectedIndexChanged += new System.EventHandler(this.cb_Tables_SelectedIndexChanged);
            // 
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_user
            // 
            this.btn_user.Location = new System.Drawing.Point(316, 85);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(80, 23);
            this.btn_user.TabIndex = 7;
            this.btn_user.Text = "user";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_role
            // 
            this.btn_role.Location = new System.Drawing.Point(397, 85);
            this.btn_role.Name = "btn_role";
            this.btn_role.Size = new System.Drawing.Size(80, 23);
            this.btn_role.TabIndex = 8;
            this.btn_role.Text = "role";
            this.btn_role.UseVisualStyleBackColor = true;
            this.btn_role.Click += new System.EventHandler(this.btn_role_Click);
            // 
            // btn_authUR
            // 
            this.btn_authUR.Location = new System.Drawing.Point(559, 85);
            this.btn_authUR.Name = "btn_authUR";
            this.btn_authUR.Size = new System.Drawing.Size(80, 23);
            this.btn_authUR.TabIndex = 10;
            this.btn_authUR.Text = "authUserRole";
            this.btn_authUR.UseVisualStyleBackColor = true;
            this.btn_authUR.Click += new System.EventHandler(this.btn_authUR_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(483, 27);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(156, 40);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "SubmitChanges";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_policy
            // 
            this.btn_policy.Location = new System.Drawing.Point(478, 85);
            this.btn_policy.Name = "btn_policy";
            this.btn_policy.Size = new System.Drawing.Size(80, 23);
            this.btn_policy.TabIndex = 12;
            this.btn_policy.Text = "Policy";
            this.btn_policy.UseVisualStyleBackColor = true;
            this.btn_policy.Click += new System.EventHandler(this.btn_Policy_Click);
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
            this.dataGV_Tables.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGV_Tables.Location = new System.Drawing.Point(0, 136);
            this.dataGV_Tables.Name = "dataGV_Tables";
            this.dataGV_Tables.Size = new System.Drawing.Size(651, 342);
            this.dataGV_Tables.TabIndex = 5;
            // 
            // bindingNavigator_Tables
            // 
            this.bindingNavigator_Tables.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator_Tables.BindingSource = this.bindingSource_Tables;
            this.bindingNavigator_Tables.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator_Tables.CountItemFormat = "из {0}";
            this.bindingNavigator_Tables.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator_Tables.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.bindingNavigator_Tables.Location = new System.Drawing.Point(0, 111);
            this.bindingNavigator_Tables.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator_Tables.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator_Tables.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator_Tables.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator_Tables.Name = "bindingNavigator_Tables";
            this.bindingNavigator_Tables.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator_Tables.Size = new System.Drawing.Size(651, 25);
            this.bindingNavigator_Tables.TabIndex = 13;
            this.bindingNavigator_Tables.Text = "bindingNavigator_Tables";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 478);
            this.Controls.Add(this.bindingNavigator_Tables);
            this.Controls.Add(this.btn_policy);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.btn_authUR);
            this.Controls.Add(this.btn_role);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.dataGV_Tables);
            this.Controls.Add(this.cb_Tables);
            this.Controls.Add(this.label_Tables);
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
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_role;
        private System.Windows.Forms.Button btn_authUR;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_policy;
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



    }
}


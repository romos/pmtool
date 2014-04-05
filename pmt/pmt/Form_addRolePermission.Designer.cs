namespace pmt
{
    partial class Form_addRolePermission
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
            this.l_RoleName = new System.Windows.Forms.Label();
            this.l_PermName = new System.Windows.Forms.Label();
            this.cb_Permission = new System.Windows.Forms.ComboBox();
            this.btn_addRolePermission_Save = new System.Windows.Forms.Button();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.l_Policy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbacDataSet = new pmt.rbacDataSet();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            this.fKRolePolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new pmt.rbacDataSetTableAdapters.RoleTableAdapter();
            this.fKPermissionPolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissionTableAdapter = new pmt.rbacDataSetTableAdapters.PermissionTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRolePolicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPermissionPolicyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // l_RoleName
            // 
            this.l_RoleName.AutoSize = true;
            this.l_RoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_RoleName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.l_RoleName.Location = new System.Drawing.Point(2, 31);
            this.l_RoleName.Name = "l_RoleName";
            this.l_RoleName.Size = new System.Drawing.Size(60, 13);
            this.l_RoleName.TabIndex = 0;
            this.l_RoleName.Text = "Role Name";
            // 
            // l_PermName
            // 
            this.l_PermName.AutoSize = true;
            this.l_PermName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_PermName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.l_PermName.Location = new System.Drawing.Point(5, 58);
            this.l_PermName.Name = "l_PermName";
            this.l_PermName.Size = new System.Drawing.Size(57, 13);
            this.l_PermName.TabIndex = 4;
            this.l_PermName.Text = "Permission";
            // 
            // cb_Permission
            // 
            this.cb_Permission.DataSource = this.fKPermissionPolicyBindingSource;
            this.cb_Permission.DisplayMember = "Name";
            this.cb_Permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Permission.FormattingEnabled = true;
            this.cb_Permission.Location = new System.Drawing.Point(66, 55);
            this.cb_Permission.Name = "cb_Permission";
            this.cb_Permission.Size = new System.Drawing.Size(100, 21);
            this.cb_Permission.TabIndex = 5;
            this.cb_Permission.ValueMember = "Id";
            // 
            // btn_addRolePermission_Save
            // 
            this.btn_addRolePermission_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addRolePermission_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addRolePermission_Save.Location = new System.Drawing.Point(193, 33);
            this.btn_addRolePermission_Save.Name = "btn_addRolePermission_Save";
            this.btn_addRolePermission_Save.Size = new System.Drawing.Size(108, 38);
            this.btn_addRolePermission_Save.TabIndex = 6;
            this.btn_addRolePermission_Save.Text = "Assign Permission to Role";
            this.btn_addRolePermission_Save.UseVisualStyleBackColor = true;
            this.btn_addRolePermission_Save.Click += new System.EventHandler(this.btn_addRolePermission_Save_Click);
            // 
            // cb_Role
            // 
            this.cb_Role.DataSource = this.fKRolePolicyBindingSource;
            this.cb_Role.DisplayMember = "Name";
            this.cb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(66, 28);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(100, 21);
            this.cb_Role.TabIndex = 7;
            this.cb_Role.ValueMember = "Id";
            // 
            // cb_Policy
            // 
            this.cb_Policy.DataSource = this.policyBindingSource;
            this.cb_Policy.DisplayMember = "Name";
            this.cb_Policy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Policy.FormattingEnabled = true;
            this.cb_Policy.Location = new System.Drawing.Point(70, 6);
            this.cb_Policy.Name = "cb_Policy";
            this.cb_Policy.Size = new System.Drawing.Size(100, 21);
            this.cb_Policy.TabIndex = 9;
            this.cb_Policy.ValueMember = "Id";
            // 
            // l_Policy
            // 
            this.l_Policy.AutoSize = true;
            this.l_Policy.Location = new System.Drawing.Point(31, 9);
            this.l_Policy.Name = "l_Policy";
            this.l_Policy.Size = new System.Drawing.Size(35, 13);
            this.l_Policy.TabIndex = 8;
            this.l_Policy.Text = "Policy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_PermName);
            this.groupBox1.Controls.Add(this.cb_Permission);
            this.groupBox1.Controls.Add(this.btn_addRolePermission_Save);
            this.groupBox1.Controls.Add(this.l_RoleName);
            this.groupBox1.Controls.Add(this.cb_Role);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(4, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role-Permission Assignment within the policy";
            // 
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // policyBindingSource
            // 
            this.policyBindingSource.DataMember = "Policy";
            this.policyBindingSource.DataSource = this.rbacDataSet;
            // 
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // fKRolePolicyBindingSource
            // 
            this.fKRolePolicyBindingSource.DataMember = "FK_Role_Policy";
            this.fKRolePolicyBindingSource.DataSource = this.policyBindingSource;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // fKPermissionPolicyBindingSource
            // 
            this.fKPermissionPolicyBindingSource.DataMember = "FK_Permission_Policy";
            this.fKPermissionPolicyBindingSource.DataSource = this.policyBindingSource;
            // 
            // permissionTableAdapter
            // 
            this.permissionTableAdapter.ClearBeforeFill = true;
            // 
            // Form_addRolePermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 128);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.l_Policy);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_addRolePermission";
            this.Text = "Form_addRolePermission";
            this.Load += new System.EventHandler(this.Form_addRolePermission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKRolePolicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPermissionPolicyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_RoleName;
        private System.Windows.Forms.Label l_PermName;
        private System.Windows.Forms.ComboBox cb_Permission;
        private System.Windows.Forms.Button btn_addRolePermission_Save;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.ComboBox cb_Policy;
        private System.Windows.Forms.Label l_Policy;
        private System.Windows.Forms.GroupBox groupBox1;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
        private System.Windows.Forms.BindingSource fKRolePolicyBindingSource;
        private rbacDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.BindingSource fKPermissionPolicyBindingSource;
        private rbacDataSetTableAdapters.PermissionTableAdapter permissionTableAdapter;
    }
}
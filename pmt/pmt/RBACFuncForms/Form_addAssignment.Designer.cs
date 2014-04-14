namespace pmt
{
    partial class Form_addAssignment
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
            this.l_UserName = new System.Windows.Forms.Label();
            this.l_RoleName = new System.Windows.Forms.Label();
            this.cb_Role = new System.Windows.Forms.ComboBox();
            this.fKRolePolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbacDataSet = new pmt.rbacDataSet();
            this.btn_addAssignment_Save = new System.Windows.Forms.Button();
            this.cb_User = new System.Windows.Forms.ComboBox();
            this.fKUserPolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.l_Policy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            this.userTableAdapter = new pmt.rbacDataSetTableAdapters.UserTableAdapter();
            this.roleTableAdapter = new pmt.rbacDataSetTableAdapters.RoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fKRolePolicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserPolicyBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_UserName
            // 
            this.l_UserName.AutoSize = true;
            this.l_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_UserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.l_UserName.Location = new System.Drawing.Point(2, 31);
            this.l_UserName.Name = "l_UserName";
            this.l_UserName.Size = new System.Drawing.Size(60, 13);
            this.l_UserName.TabIndex = 0;
            this.l_UserName.Text = "User Name";
            // 
            // l_RoleName
            // 
            this.l_RoleName.AutoSize = true;
            this.l_RoleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_RoleName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.l_RoleName.Location = new System.Drawing.Point(33, 58);
            this.l_RoleName.Name = "l_RoleName";
            this.l_RoleName.Size = new System.Drawing.Size(29, 13);
            this.l_RoleName.TabIndex = 4;
            this.l_RoleName.Text = "Role";
            // 
            // cb_Role
            // 
            this.cb_Role.DataSource = this.fKRolePolicyBindingSource;
            this.cb_Role.DisplayMember = "Name";
            this.cb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Role.FormattingEnabled = true;
            this.cb_Role.Location = new System.Drawing.Point(66, 55);
            this.cb_Role.Name = "cb_Role";
            this.cb_Role.Size = new System.Drawing.Size(100, 21);
            this.cb_Role.TabIndex = 5;
            this.cb_Role.ValueMember = "Id";
            // 
            // fKRolePolicyBindingSource
            // 
            this.fKRolePolicyBindingSource.DataMember = "FK_Role_Policy";
            this.fKRolePolicyBindingSource.DataSource = this.policyBindingSource;
            // 
            // policyBindingSource
            // 
            this.policyBindingSource.DataMember = "Policy";
            this.policyBindingSource.DataSource = this.rbacDataSet;
            // 
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_addAssignment_Save
            // 
            this.btn_addAssignment_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_addAssignment_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_addAssignment_Save.Location = new System.Drawing.Point(193, 33);
            this.btn_addAssignment_Save.Name = "btn_addAssignment_Save";
            this.btn_addAssignment_Save.Size = new System.Drawing.Size(108, 38);
            this.btn_addAssignment_Save.TabIndex = 6;
            this.btn_addAssignment_Save.Text = "Assign Role to User";
            this.btn_addAssignment_Save.UseVisualStyleBackColor = true;
            this.btn_addAssignment_Save.Click += new System.EventHandler(this.btn_addAssignment_Save_Click);
            // 
            // cb_User
            // 
            this.cb_User.DataSource = this.fKUserPolicyBindingSource;
            this.cb_User.DisplayMember = "Name";
            this.cb_User.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_User.FormattingEnabled = true;
            this.cb_User.Location = new System.Drawing.Point(66, 28);
            this.cb_User.Name = "cb_User";
            this.cb_User.Size = new System.Drawing.Size(100, 21);
            this.cb_User.TabIndex = 7;
            this.cb_User.ValueMember = "Id";
            // 
            // fKUserPolicyBindingSource
            // 
            this.fKUserPolicyBindingSource.DataMember = "FK_User_Policy";
            this.fKUserPolicyBindingSource.DataSource = this.policyBindingSource;
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
            this.groupBox1.Controls.Add(this.l_RoleName);
            this.groupBox1.Controls.Add(this.cb_Role);
            this.groupBox1.Controls.Add(this.btn_addAssignment_Save);
            this.groupBox1.Controls.Add(this.l_UserName);
            this.groupBox1.Controls.Add(this.cb_User);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(4, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User-Role Assignment within the policy";
            // 
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // Form_addAssignment
            // 
            this.AcceptButton = this.btn_addAssignment_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 128);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.l_Policy);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_addAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_addAssignment";
            this.Load += new System.EventHandler(this.Form_addAssignment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_addAssignment_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fKRolePolicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserPolicyBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_UserName;
        private System.Windows.Forms.Label l_RoleName;
        private System.Windows.Forms.ComboBox cb_Role;
        private System.Windows.Forms.Button btn_addAssignment_Save;
        private System.Windows.Forms.ComboBox cb_User;
        private System.Windows.Forms.ComboBox cb_Policy;
        private System.Windows.Forms.Label l_Policy;
        private System.Windows.Forms.GroupBox groupBox1;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
        private System.Windows.Forms.BindingSource fKUserPolicyBindingSource;
        private rbacDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource fKRolePolicyBindingSource;
        private rbacDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
    }
}
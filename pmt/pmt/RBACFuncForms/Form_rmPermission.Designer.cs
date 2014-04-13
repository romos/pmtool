namespace pmt
{
    partial class Form_rmPermission
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
            this.l_Name = new System.Windows.Forms.Label();
            this.l_Object = new System.Windows.Forms.Label();
            this.cb_Object = new System.Windows.Forms.ComboBox();
            this.btn_rmPermission_Save = new System.Windows.Forms.Button();
            this.cb_Action = new System.Windows.Forms.ComboBox();
            this.l_Action = new System.Windows.Forms.Label();
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.l_Policy = new System.Windows.Forms.Label();
            this.cb_Permission = new System.Windows.Forms.ComboBox();
            this.rbacDataSet = new pmt.rbacDataSet();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            this.fKPermissionPolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissionTableAdapter = new pmt.rbacDataSetTableAdapters.PermissionTableAdapter();
            this.fKPermissionPerObjectPermissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissionPerObjectTableAdapter = new pmt.rbacDataSetTableAdapters.PermissionPerObjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPermissionPolicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPermissionPerObjectPermissionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(5, 15);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(69, 13);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Permission Id";
            // 
            // l_Object
            // 
            this.l_Object.AutoSize = true;
            this.l_Object.Location = new System.Drawing.Point(24, 68);
            this.l_Object.Name = "l_Object";
            this.l_Object.Size = new System.Drawing.Size(50, 13);
            this.l_Object.TabIndex = 4;
            this.l_Object.Text = "Object Id";
            // 
            // cb_Object
            // 
            this.cb_Object.DataSource = this.fKPermissionPerObjectPermissionBindingSource;
            this.cb_Object.DisplayMember = "Object_Id";
            this.cb_Object.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Object.FormattingEnabled = true;
            this.cb_Object.Location = new System.Drawing.Point(80, 65);
            this.cb_Object.Name = "cb_Object";
            this.cb_Object.Size = new System.Drawing.Size(100, 21);
            this.cb_Object.TabIndex = 3;
            this.cb_Object.ValueMember = "Object_Id";
            // 
            // btn_rmPermission_Save
            // 
            this.btn_rmPermission_Save.Location = new System.Drawing.Point(194, 43);
            this.btn_rmPermission_Save.Name = "btn_rmPermission_Save";
            this.btn_rmPermission_Save.Size = new System.Drawing.Size(100, 38);
            this.btn_rmPermission_Save.TabIndex = 5;
            this.btn_rmPermission_Save.Text = "Remove Permission";
            this.btn_rmPermission_Save.UseVisualStyleBackColor = true;
            this.btn_rmPermission_Save.Click += new System.EventHandler(this.btn_rmPermission_Save_Click);
            // 
            // cb_Action
            // 
            this.cb_Action.DataSource = this.fKPermissionPerObjectPermissionBindingSource;
            this.cb_Action.DisplayMember = "Action_Id";
            this.cb_Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Action.FormattingEnabled = true;
            this.cb_Action.Location = new System.Drawing.Point(80, 38);
            this.cb_Action.Name = "cb_Action";
            this.cb_Action.Size = new System.Drawing.Size(100, 21);
            this.cb_Action.TabIndex = 2;
            this.cb_Action.ValueMember = "Action_Id";
            // 
            // l_Action
            // 
            this.l_Action.AutoSize = true;
            this.l_Action.Location = new System.Drawing.Point(25, 41);
            this.l_Action.Name = "l_Action";
            this.l_Action.Size = new System.Drawing.Size(49, 13);
            this.l_Action.TabIndex = 7;
            this.l_Action.Text = "Action Id";
            // 
            // cb_Policy
            // 
            this.cb_Policy.DataSource = this.policyBindingSource;
            this.cb_Policy.DisplayMember = "Name";
            this.cb_Policy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Policy.FormattingEnabled = true;
            this.cb_Policy.Location = new System.Drawing.Point(80, 92);
            this.cb_Policy.Name = "cb_Policy";
            this.cb_Policy.Size = new System.Drawing.Size(100, 21);
            this.cb_Policy.TabIndex = 4;
            this.cb_Policy.ValueMember = "Id";
            // 
            // l_Policy
            // 
            this.l_Policy.AutoSize = true;
            this.l_Policy.Location = new System.Drawing.Point(39, 95);
            this.l_Policy.Name = "l_Policy";
            this.l_Policy.Size = new System.Drawing.Size(35, 13);
            this.l_Policy.TabIndex = 9;
            this.l_Policy.Text = "Policy";
            // 
            // cb_Permission
            // 
            this.cb_Permission.DataSource = this.fKPermissionPolicyBindingSource;
            this.cb_Permission.DisplayMember = "Id";
            this.cb_Permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Permission.FormattingEnabled = true;
            this.cb_Permission.Location = new System.Drawing.Point(80, 12);
            this.cb_Permission.Name = "cb_Permission";
            this.cb_Permission.Size = new System.Drawing.Size(100, 21);
            this.cb_Permission.TabIndex = 10;
            this.cb_Permission.ValueMember = "Id";
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
            // fKPermissionPolicyBindingSource
            // 
            this.fKPermissionPolicyBindingSource.DataMember = "FK_Permission_Policy";
            this.fKPermissionPolicyBindingSource.DataSource = this.policyBindingSource;
            // 
            // permissionTableAdapter
            // 
            this.permissionTableAdapter.ClearBeforeFill = true;
            // 
            // fKPermissionPerObjectPermissionBindingSource
            // 
            this.fKPermissionPerObjectPermissionBindingSource.DataMember = "FK_PermissionPerObject_Permission";
            this.fKPermissionPerObjectPermissionBindingSource.DataSource = this.fKPermissionPolicyBindingSource;
            // 
            // permissionPerObjectTableAdapter
            // 
            this.permissionPerObjectTableAdapter.ClearBeforeFill = true;
            // 
            // Form_rmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 121);
            this.Controls.Add(this.cb_Permission);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.l_Policy);
            this.Controls.Add(this.cb_Action);
            this.Controls.Add(this.l_Action);
            this.Controls.Add(this.btn_rmPermission_Save);
            this.Controls.Add(this.cb_Object);
            this.Controls.Add(this.l_Object);
            this.Controls.Add(this.l_Name);
            this.Name = "Form_rmPermission";
            this.Text = "Form_rmPermission";
            this.Load += new System.EventHandler(this.Form_rmPermission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPermissionPolicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPermissionPerObjectPermissionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label l_Object;
        private System.Windows.Forms.ComboBox cb_Object;
        private System.Windows.Forms.Button btn_rmPermission_Save;
        private System.Windows.Forms.ComboBox cb_Action;
        private System.Windows.Forms.Label l_Action;
        private System.Windows.Forms.ComboBox cb_Policy;
        private System.Windows.Forms.Label l_Policy;
        private System.Windows.Forms.ComboBox cb_Permission;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
        private System.Windows.Forms.BindingSource fKPermissionPolicyBindingSource;
        private rbacDataSetTableAdapters.PermissionTableAdapter permissionTableAdapter;
        private System.Windows.Forms.BindingSource fKPermissionPerObjectPermissionBindingSource;
        private rbacDataSetTableAdapters.PermissionPerObjectTableAdapter permissionPerObjectTableAdapter;
    }
}
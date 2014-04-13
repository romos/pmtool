namespace pmt
{
    partial class Form_rmUser
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
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.fKUserPolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbacDataSet = new pmt.rbacDataSet();
            this.l_Password = new System.Windows.Forms.Label();
            this.l_Policy = new System.Windows.Forms.Label();
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.btn_rmUser_Save = new System.Windows.Forms.Button();
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new pmt.rbacDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fKUserPolicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(29, 15);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(35, 13);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Name";
            // 
            // tb_Password
            // 
            this.tb_Password.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKUserPolicyBindingSource, "Password", true));
            this.tb_Password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKUserPolicyBindingSource, "Password", true));
            this.tb_Password.Enabled = false;
            this.tb_Password.Location = new System.Drawing.Point(70, 38);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(100, 20);
            this.tb_Password.TabIndex = 3;
            // 
            // fKUserPolicyBindingSource
            // 
            this.fKUserPolicyBindingSource.DataMember = "FK_User_Policy";
            this.fKUserPolicyBindingSource.DataSource = this.policyBindingSource;
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
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Location = new System.Drawing.Point(11, 41);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(53, 13);
            this.l_Password.TabIndex = 2;
            this.l_Password.Text = "Password";
            // 
            // l_Policy
            // 
            this.l_Policy.AutoSize = true;
            this.l_Policy.Location = new System.Drawing.Point(29, 68);
            this.l_Policy.Name = "l_Policy";
            this.l_Policy.Size = new System.Drawing.Size(35, 13);
            this.l_Policy.TabIndex = 4;
            this.l_Policy.Text = "Policy";
            // 
            // cb_Policy
            // 
            this.cb_Policy.DataSource = this.policyBindingSource;
            this.cb_Policy.DisplayMember = "Name";
            this.cb_Policy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Policy.FormattingEnabled = true;
            this.cb_Policy.Location = new System.Drawing.Point(70, 68);
            this.cb_Policy.Name = "cb_Policy";
            this.cb_Policy.Size = new System.Drawing.Size(100, 21);
            this.cb_Policy.TabIndex = 5;
            this.cb_Policy.ValueMember = "Id";
            // 
            // btn_rmUser_Save
            // 
            this.btn_rmUser_Save.Location = new System.Drawing.Point(194, 28);
            this.btn_rmUser_Save.Name = "btn_rmUser_Save";
            this.btn_rmUser_Save.Size = new System.Drawing.Size(100, 38);
            this.btn_rmUser_Save.TabIndex = 6;
            this.btn_rmUser_Save.Text = "Remove user";
            this.btn_rmUser_Save.UseVisualStyleBackColor = true;
            this.btn_rmUser_Save.Click += new System.EventHandler(this.btn_rmUser_Save_Click);
            // 
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // cb_Name
            // 
            this.cb_Name.DataSource = this.fKUserPolicyBindingSource;
            this.cb_Name.DisplayMember = "Name";
            this.cb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(70, 11);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(100, 21);
            this.cb_Name.TabIndex = 7;
            this.cb_Name.ValueMember = "Id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.rbacDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // Form_rmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 100);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.btn_rmUser_Save);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.l_Policy);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_Name);
            this.Name = "Form_rmUser";
            this.Text = "Form_rmUser";
            this.Load += new System.EventHandler(this.Form_rmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKUserPolicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.Label l_Policy;
        private System.Windows.Forms.ComboBox cb_Policy;
        private System.Windows.Forms.Button btn_rmUser_Save;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSet rbacDataSet;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.BindingSource userBindingSource;
        private rbacDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource fKUserPolicyBindingSource;
    }
}
namespace pmt
{
    partial class Form_rmRole
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
            this.tb_Cardinality = new System.Windows.Forms.TextBox();
            this.fKRolePolicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbacDataSet = new pmt.rbacDataSet();
            this.l_Cardinality = new System.Windows.Forms.Label();
            this.l_Policy = new System.Windows.Forms.Label();
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.btn_rmRole_Save = new System.Windows.Forms.Button();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTableAdapter = new pmt.rbacDataSetTableAdapters.RoleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fKRolePolicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
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
            // tb_Cardinality
            // 
            this.tb_Cardinality.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKRolePolicyBindingSource, "Cardinality", true));
            this.tb_Cardinality.Enabled = false;
            this.tb_Cardinality.Location = new System.Drawing.Point(70, 38);
            this.tb_Cardinality.Name = "tb_Cardinality";
            this.tb_Cardinality.Size = new System.Drawing.Size(100, 20);
            this.tb_Cardinality.TabIndex = 3;
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
            // l_Cardinality
            // 
            this.l_Cardinality.AutoSize = true;
            this.l_Cardinality.Location = new System.Drawing.Point(11, 41);
            this.l_Cardinality.Name = "l_Cardinality";
            this.l_Cardinality.Size = new System.Drawing.Size(55, 13);
            this.l_Cardinality.TabIndex = 2;
            this.l_Cardinality.Text = "Cardinality";
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
            // btn_rmRole_Save
            // 
            this.btn_rmRole_Save.Location = new System.Drawing.Point(194, 28);
            this.btn_rmRole_Save.Name = "btn_rmRole_Save";
            this.btn_rmRole_Save.Size = new System.Drawing.Size(100, 38);
            this.btn_rmRole_Save.TabIndex = 6;
            this.btn_rmRole_Save.Text = "Remove role";
            this.btn_rmRole_Save.UseVisualStyleBackColor = true;
            this.btn_rmRole_Save.Click += new System.EventHandler(this.btn_rmRole_Save_Click);
            // 
            // cb_Name
            // 
            this.cb_Name.DataSource = this.fKRolePolicyBindingSource;
            this.cb_Name.DisplayMember = "Name";
            this.cb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(70, 11);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(100, 21);
            this.cb_Name.TabIndex = 7;
            this.cb_Name.ValueMember = "Id";
            // 
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.rbacDataSet;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // Form_rmRole
            // 
            this.AcceptButton = this.btn_rmRole_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 100);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.btn_rmRole_Save);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.l_Policy);
            this.Controls.Add(this.tb_Cardinality);
            this.Controls.Add(this.l_Cardinality);
            this.Controls.Add(this.l_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_rmRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_rmRole";
            this.Load += new System.EventHandler(this.Form_rmRole_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_rmRole_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.fKRolePolicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_Cardinality;
        private System.Windows.Forms.Label l_Cardinality;
        private System.Windows.Forms.Label l_Policy;
        private System.Windows.Forms.ComboBox cb_Policy;
        private System.Windows.Forms.Button btn_rmRole_Save;
        private System.Windows.Forms.ComboBox cb_Name;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private rbacDataSetTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.BindingSource fKRolePolicyBindingSource;
    }
}
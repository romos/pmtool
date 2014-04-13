namespace pmt
{
    partial class Form_addRole
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Cardinality = new System.Windows.Forms.TextBox();
            this.l_Cardinality = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbacDataSet = new pmt.rbacDataSet();
            this.btn_addRole_Save = new System.Windows.Forms.Button();
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
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
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(70, 12);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Cardinality
            // 
            this.tb_Cardinality.Location = new System.Drawing.Point(70, 38);
            this.tb_Cardinality.Name = "tb_Cardinality";
            this.tb_Cardinality.Size = new System.Drawing.Size(100, 20);
            this.tb_Cardinality.TabIndex = 3;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Policy";
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
            // btn_addRole_Save
            // 
            this.btn_addRole_Save.Location = new System.Drawing.Point(194, 28);
            this.btn_addRole_Save.Name = "btn_addRole_Save";
            this.btn_addRole_Save.Size = new System.Drawing.Size(100, 38);
            this.btn_addRole_Save.TabIndex = 6;
            this.btn_addRole_Save.Text = "Add role";
            this.btn_addRole_Save.UseVisualStyleBackColor = true;
            this.btn_addRole_Save.Click += new System.EventHandler(this.btn_addRole_Save_Click);
            // 
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // Form_addRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 100);
            this.Controls.Add(this.btn_addRole_Save);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Cardinality);
            this.Controls.Add(this.l_Cardinality);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.l_Name);
            this.Name = "Form_addRole";
            this.Text = "Form_addRole";
            this.Load += new System.EventHandler(this.Form_addRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Cardinality;
        private System.Windows.Forms.Label l_Cardinality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Policy;
        private System.Windows.Forms.Button btn_addRole_Save;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSet rbacDataSet;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
    }
}
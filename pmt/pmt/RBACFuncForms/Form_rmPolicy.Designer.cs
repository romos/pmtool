namespace pmt
{
    partial class Form_rmPolicy
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
            this.btn_rmPolicy_Save = new System.Windows.Forms.Button();
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbacDataSet = new pmt.rbacDataSet();
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(12, 27);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(66, 13);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Policy Name";
            // 
            // btn_rmPolicy_Save
            // 
            this.btn_rmPolicy_Save.Location = new System.Drawing.Point(194, 12);
            this.btn_rmPolicy_Save.Name = "btn_rmPolicy_Save";
            this.btn_rmPolicy_Save.Size = new System.Drawing.Size(100, 42);
            this.btn_rmPolicy_Save.TabIndex = 6;
            this.btn_rmPolicy_Save.Text = "Remove Policy";
            this.btn_rmPolicy_Save.UseVisualStyleBackColor = true;
            this.btn_rmPolicy_Save.Click += new System.EventHandler(this.btn_rmPolicy_Save_Click);
            // 
            // cb_Policy
            // 
            this.cb_Policy.DataSource = this.policyBindingSource;
            this.cb_Policy.DisplayMember = "Name";
            this.cb_Policy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Policy.FormattingEnabled = true;
            this.cb_Policy.Location = new System.Drawing.Point(81, 24);
            this.cb_Policy.Name = "cb_Policy";
            this.cb_Policy.Size = new System.Drawing.Size(102, 21);
            this.cb_Policy.TabIndex = 7;
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
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // Form_rmPolicy
            // 
            this.AcceptButton = this.btn_rmPolicy_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 66);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.btn_rmPolicy_Save);
            this.Controls.Add(this.l_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_rmPolicy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_rmPolicy";
            this.Load += new System.EventHandler(this.Form_rmPolicy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_rmPolicy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Button btn_rmPolicy_Save;
        private System.Windows.Forms.ComboBox cb_Policy;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
    }
}
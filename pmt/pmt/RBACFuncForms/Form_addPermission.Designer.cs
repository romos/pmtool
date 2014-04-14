namespace pmt
{
    partial class Form_addPermission
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
            this.l_Object = new System.Windows.Forms.Label();
            this.cb_Object = new System.Windows.Forms.ComboBox();
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbacDataSet = new pmt.rbacDataSet();
            this.btn_addPermission_Save = new System.Windows.Forms.Button();
            this.cb_Action = new System.Windows.Forms.ComboBox();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l_Action = new System.Windows.Forms.Label();
            this.cb_Policy = new System.Windows.Forms.ComboBox();
            this.policyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.l_Policy = new System.Windows.Forms.Label();
            this.actionTableAdapter = new pmt.rbacDataSetTableAdapters.ActionTableAdapter();
            this.objectTableAdapter = new pmt.rbacDataSetTableAdapters.ObjectTableAdapter();
            this.policyTableAdapter = new pmt.rbacDataSetTableAdapters.PolicyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).BeginInit();
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
            // l_Object
            // 
            this.l_Object.AutoSize = true;
            this.l_Object.Location = new System.Drawing.Point(29, 68);
            this.l_Object.Name = "l_Object";
            this.l_Object.Size = new System.Drawing.Size(38, 13);
            this.l_Object.TabIndex = 4;
            this.l_Object.Text = "Object";
            // 
            // cb_Object
            // 
            this.cb_Object.DataSource = this.objectBindingSource;
            this.cb_Object.DisplayMember = "Name";
            this.cb_Object.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Object.FormattingEnabled = true;
            this.cb_Object.Location = new System.Drawing.Point(70, 65);
            this.cb_Object.Name = "cb_Object";
            this.cb_Object.Size = new System.Drawing.Size(100, 21);
            this.cb_Object.TabIndex = 3;
            this.cb_Object.ValueMember = "Id";
            // 
            // objectBindingSource
            // 
            this.objectBindingSource.DataMember = "Object";
            this.objectBindingSource.DataSource = this.rbacDataSet;
            // 
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_addPermission_Save
            // 
            this.btn_addPermission_Save.Location = new System.Drawing.Point(194, 43);
            this.btn_addPermission_Save.Name = "btn_addPermission_Save";
            this.btn_addPermission_Save.Size = new System.Drawing.Size(100, 38);
            this.btn_addPermission_Save.TabIndex = 5;
            this.btn_addPermission_Save.Text = "Add/Update Permission";
            this.btn_addPermission_Save.UseVisualStyleBackColor = true;
            this.btn_addPermission_Save.Click += new System.EventHandler(this.btn_addPermission_Save_Click);
            // 
            // cb_Action
            // 
            this.cb_Action.DataSource = this.actionBindingSource;
            this.cb_Action.DisplayMember = "Name";
            this.cb_Action.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Action.FormattingEnabled = true;
            this.cb_Action.Location = new System.Drawing.Point(70, 38);
            this.cb_Action.Name = "cb_Action";
            this.cb_Action.Size = new System.Drawing.Size(100, 21);
            this.cb_Action.TabIndex = 2;
            this.cb_Action.ValueMember = "Id";
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataMember = "Action";
            this.actionBindingSource.DataSource = this.rbacDataSet;
            // 
            // l_Action
            // 
            this.l_Action.AutoSize = true;
            this.l_Action.Location = new System.Drawing.Point(29, 41);
            this.l_Action.Name = "l_Action";
            this.l_Action.Size = new System.Drawing.Size(37, 13);
            this.l_Action.TabIndex = 7;
            this.l_Action.Text = "Action";
            // 
            // cb_Policy
            // 
            this.cb_Policy.DataSource = this.policyBindingSource;
            this.cb_Policy.DisplayMember = "Name";
            this.cb_Policy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Policy.FormattingEnabled = true;
            this.cb_Policy.Location = new System.Drawing.Point(70, 92);
            this.cb_Policy.Name = "cb_Policy";
            this.cb_Policy.Size = new System.Drawing.Size(100, 21);
            this.cb_Policy.TabIndex = 4;
            this.cb_Policy.ValueMember = "Id";
            // 
            // policyBindingSource
            // 
            this.policyBindingSource.DataMember = "Policy";
            this.policyBindingSource.DataSource = this.rbacDataSet;
            // 
            // l_Policy
            // 
            this.l_Policy.AutoSize = true;
            this.l_Policy.Location = new System.Drawing.Point(29, 95);
            this.l_Policy.Name = "l_Policy";
            this.l_Policy.Size = new System.Drawing.Size(35, 13);
            this.l_Policy.TabIndex = 9;
            this.l_Policy.Text = "Policy";
            // 
            // actionTableAdapter
            // 
            this.actionTableAdapter.ClearBeforeFill = true;
            // 
            // objectTableAdapter
            // 
            this.objectTableAdapter.ClearBeforeFill = true;
            // 
            // policyTableAdapter
            // 
            this.policyTableAdapter.ClearBeforeFill = true;
            // 
            // Form_addPermission
            // 
            this.AcceptButton = this.btn_addPermission_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 121);
            this.Controls.Add(this.cb_Policy);
            this.Controls.Add(this.l_Policy);
            this.Controls.Add(this.cb_Action);
            this.Controls.Add(this.l_Action);
            this.Controls.Add(this.btn_addPermission_Save);
            this.Controls.Add(this.cb_Object);
            this.Controls.Add(this.l_Object);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.l_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_addPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_addPermission";
            this.Load += new System.EventHandler(this.Form_addPermission_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_addPermission_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label l_Object;
        private System.Windows.Forms.ComboBox cb_Object;
        private System.Windows.Forms.Button btn_addPermission_Save;
        private System.Windows.Forms.ComboBox cb_Action;
        private System.Windows.Forms.Label l_Action;
        private System.Windows.Forms.ComboBox cb_Policy;
        private System.Windows.Forms.Label l_Policy;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource actionBindingSource;
        private rbacDataSetTableAdapters.ActionTableAdapter actionTableAdapter;
        private System.Windows.Forms.BindingSource objectBindingSource;
        private rbacDataSetTableAdapters.ObjectTableAdapter objectTableAdapter;
        private System.Windows.Forms.BindingSource policyBindingSource;
        private rbacDataSetTableAdapters.PolicyTableAdapter policyTableAdapter;
    }
}
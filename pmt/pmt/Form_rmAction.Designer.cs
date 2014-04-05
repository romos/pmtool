namespace pmt
{
    partial class Form_rmAction
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
            this.btn_rmAction_Save = new System.Windows.Forms.Button();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.rbacDataSet = new pmt.rbacDataSet();
            this.actionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actionTableAdapter = new pmt.rbacDataSetTableAdapters.ActionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(29, 24);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(37, 13);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Action";
            // 
            // btn_rmAction_Save
            // 
            this.btn_rmAction_Save.Location = new System.Drawing.Point(194, 11);
            this.btn_rmAction_Save.Name = "btn_rmAction_Save";
            this.btn_rmAction_Save.Size = new System.Drawing.Size(100, 38);
            this.btn_rmAction_Save.TabIndex = 6;
            this.btn_rmAction_Save.Text = "Remove action";
            this.btn_rmAction_Save.UseVisualStyleBackColor = true;
            this.btn_rmAction_Save.Click += new System.EventHandler(this.btn_rmAction_Save_Click);
            // 
            // cb_Name
            // 
            this.cb_Name.DataSource = this.actionBindingSource;
            this.cb_Name.DisplayMember = "Name";
            this.cb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(70, 20);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(100, 21);
            this.cb_Name.TabIndex = 7;
            this.cb_Name.ValueMember = "Id";
            // 
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actionBindingSource
            // 
            this.actionBindingSource.DataMember = "Action";
            this.actionBindingSource.DataSource = this.rbacDataSet;
            // 
            // actionTableAdapter
            // 
            this.actionTableAdapter.ClearBeforeFill = true;
            // 
            // Form_rmAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 61);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.btn_rmAction_Save);
            this.Controls.Add(this.l_Name);
            this.Name = "Form_rmAction";
            this.Text = "Form_rmAction";
            this.Load += new System.EventHandler(this.Form_rmAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Button btn_rmAction_Save;
        private System.Windows.Forms.ComboBox cb_Name;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource actionBindingSource;
        private rbacDataSetTableAdapters.ActionTableAdapter actionTableAdapter;
    }
}
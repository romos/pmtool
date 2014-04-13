namespace pmt
{
    partial class Form_rmObject
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
            this.btn_rmObject_Save = new System.Windows.Forms.Button();
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.rbacDataSet = new pmt.rbacDataSet();
            this.objectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.objectTableAdapter = new pmt.rbacDataSetTableAdapters.ObjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(12, 25);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(69, 13);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Object Name";
            // 
            // btn_rmObject_Save
            // 
            this.btn_rmObject_Save.Location = new System.Drawing.Point(198, 13);
            this.btn_rmObject_Save.Name = "btn_rmObject_Save";
            this.btn_rmObject_Save.Size = new System.Drawing.Size(100, 38);
            this.btn_rmObject_Save.TabIndex = 6;
            this.btn_rmObject_Save.Text = "Remove object";
            this.btn_rmObject_Save.UseVisualStyleBackColor = true;
            this.btn_rmObject_Save.Click += new System.EventHandler(this.btn_rmObject_Save_Click);
            // 
            // cb_Name
            // 
            this.cb_Name.DataSource = this.objectBindingSource;
            this.cb_Name.DisplayMember = "Name";
            this.cb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Location = new System.Drawing.Point(87, 22);
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
            // objectBindingSource
            // 
            this.objectBindingSource.DataMember = "Object";
            this.objectBindingSource.DataSource = this.rbacDataSet;
            // 
            // objectTableAdapter
            // 
            this.objectTableAdapter.ClearBeforeFill = true;
            // 
            // Form_rmObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 65);
            this.Controls.Add(this.cb_Name);
            this.Controls.Add(this.btn_rmObject_Save);
            this.Controls.Add(this.l_Name);
            this.Name = "Form_rmObject";
            this.Text = "Form_rmObject";
            this.Load += new System.EventHandler(this.Form_rmObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Button btn_rmObject_Save;
        private System.Windows.Forms.ComboBox cb_Name;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.BindingSource objectBindingSource;
        private rbacDataSetTableAdapters.ObjectTableAdapter objectTableAdapter;
    }
}
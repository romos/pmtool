namespace pmt
{
    partial class Form_addAction
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
            this.l_Name = new System.Windows.Forms.Label();
            this.btn_addAction_Save = new System.Windows.Forms.Button();
            this.rbacDataSet = new pmt.rbacDataSet();
            this.tb_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(28, 27);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(37, 13);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Action";
            this.l_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_addAction_Save
            // 
            this.btn_addAction_Save.Location = new System.Drawing.Point(197, 12);
            this.btn_addAction_Save.Name = "btn_addAction_Save";
            this.btn_addAction_Save.Size = new System.Drawing.Size(100, 42);
            this.btn_addAction_Save.TabIndex = 6;
            this.btn_addAction_Save.Text = "Add Action";
            this.btn_addAction_Save.UseVisualStyleBackColor = true;
            this.btn_addAction_Save.Click += new System.EventHandler(this.btn_addAction_Save_Click);
            // 
            // rbacDataSet
            // 
            this.rbacDataSet.DataSetName = "rbacDataSet";
            this.rbacDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(71, 24);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(98, 20);
            this.tb_Name.TabIndex = 7;
            // 
            // Form_addAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 69);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_addAction_Save);
            this.Controls.Add(this.l_Name);
            this.Name = "Form_addAction";
            this.Text = "Form_addAction";
            this.Load += new System.EventHandler(this.Form_addAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbacDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Button btn_addAction_Save;
        private rbacDataSet rbacDataSet;
        private System.Windows.Forms.TextBox tb_Name;
    }
}
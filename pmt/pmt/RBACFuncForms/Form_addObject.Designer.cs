namespace pmt
{
    partial class Form_addObject
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_addObject_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(29, 27);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(38, 13);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Object";
            this.l_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(73, 24);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // btn_addObject_Save
            // 
            this.btn_addObject_Save.Location = new System.Drawing.Point(200, 12);
            this.btn_addObject_Save.Name = "btn_addObject_Save";
            this.btn_addObject_Save.Size = new System.Drawing.Size(100, 42);
            this.btn_addObject_Save.TabIndex = 6;
            this.btn_addObject_Save.Text = "Add Object";
            this.btn_addObject_Save.UseVisualStyleBackColor = true;
            this.btn_addObject_Save.Click += new System.EventHandler(this.btn_addObject_Save_Click);
            // 
            // Form_addObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 74);
            this.Controls.Add(this.btn_addObject_Save);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.l_Name);
            this.Name = "Form_addObject";
            this.Text = "Form_addObject";
            this.Load += new System.EventHandler(this.Form_addObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_addObject_Save;
    }
}
namespace pmt
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMenuItem_about = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rBACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMenuItem_NewPolicy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMenuItem_NewPolicy,
            this.TSMenuItem_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMenuItem_about
            // 
            this.TSMenuItem_about.Name = "TSMenuItem_about";
            this.TSMenuItem_about.Size = new System.Drawing.Size(52, 20);
            this.TSMenuItem_about.Text = "About";
            this.TSMenuItem_about.Click += new System.EventHandler(this.TSMenuItem_about_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 425);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(693, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(693, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rBACToolStripMenuItem
            // 
            this.rBACToolStripMenuItem.Name = "rBACToolStripMenuItem";
            this.rBACToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rBACToolStripMenuItem.Text = "RBAC";
            // 
            // mACToolStripMenuItem
            // 
            this.mACToolStripMenuItem.Enabled = false;
            this.mACToolStripMenuItem.Name = "mACToolStripMenuItem";
            this.mACToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mACToolStripMenuItem.Text = "MAC";
            // 
            // dACToolStripMenuItem
            // 
            this.dACToolStripMenuItem.Enabled = false;
            this.dACToolStripMenuItem.Name = "dACToolStripMenuItem";
            this.dACToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dACToolStripMenuItem.Text = "DAC";
            // 
            // TSMenuItem_NewPolicy
            // 
            this.TSMenuItem_NewPolicy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rBACToolStripMenuItem,
            this.mACToolStripMenuItem,
            this.dACToolStripMenuItem});
            this.TSMenuItem_NewPolicy.Enabled = false;
            this.TSMenuItem_NewPolicy.Name = "TSMenuItem_NewPolicy";
            this.TSMenuItem_NewPolicy.Size = new System.Drawing.Size(78, 20);
            this.TSMenuItem_NewPolicy.Text = "New Policy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_about;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem TSMenuItem_NewPolicy;
        private System.Windows.Forms.ToolStripMenuItem rBACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dACToolStripMenuItem;



    }
}


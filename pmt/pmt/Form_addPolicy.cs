﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmt
{
    public partial class Form_addPolicy : Form
    {
        private MainForm mainForm;

        public Form_addPolicy()
        {
            InitializeComponent();
        }
        public Form_addPolicy(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addPolicy_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (tb_Name.Text != "")
            {
                Policy p = new Policy
                {
                    Name = tb_Name.Text,
                };

                status = RBACManager.AddPolicy(p, mainForm.db);
                if (status == Program.ExitCode.Error)
                {
                    MessageBox.Show(this,
                                    "Error while Submiting results in the DataBase!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }
                if (status == Program.ExitCode.Success)
                {
                    MessageBox.Show(this,
                                    "Политика добавлена!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                if (status == Program.ExitCode.ElementExists)
                {
                    MessageBox.Show(this,
                                    "Такая политика уже существует!",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show(this,
                            "Вы не заполнили поле 'Policy Name'!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
        }
        private void Form_addPolicy_Load(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class Form_rmRole : Form
    {
        private MainForm mainForm;

        public Form_rmRole()
        {
            InitializeComponent();
        }
        public Form_rmRole(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void tb_Pwd_UpdateValue()
        {
            tb_Cardinality.Text = ((DataRowView)cb_Name.SelectedItem)["Password"].ToString();
        }

        private void btn_rmRole_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (MessageBox.Show(this,
                            "Удалить роль?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            //удалить роль после подтверждения:
            Role r = new Role
            {
                Id = Convert.ToInt32(cb_Name.SelectedValue),
                Name = cb_Name.Text,
                Cardinality = Convert.ToInt32(tb_Cardinality.Text),
                Policy_Id = Convert.ToInt32(cb_Policy.SelectedValue)
            };

            status = RBACManager.RmRole(r, mainForm.db);

            if (status == Program.ExitCode.Success)
            {
                MessageBox.Show(this,
                            "Роль удалена!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (status == Program.ExitCode.Error)
            {
                MessageBox.Show(this,
                            "Error while submitting deletion to the DataBase",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
        }

        private void Form_rmRole_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.rbacDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

        private void Form_rmRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}

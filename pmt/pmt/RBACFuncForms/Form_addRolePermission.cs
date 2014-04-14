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
    public partial class Form_addRolePermission : Form
    {
        private MainForm mainForm;

        public Form_addRolePermission()
        {
            InitializeComponent();
        }
        public Form_addRolePermission(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addRolePermission_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            //Создать RolePermission:
            RolePermission rp = new RolePermission
            {
                Role_Id = Convert.ToInt32(cb_Role.SelectedValue),
                Permission_Id = Convert.ToInt32(cb_Permission.SelectedValue),
            };

            status = RBACManager.AddRolePermission(rp, mainForm.db);

            if (status == Program.ExitCode.Success)
            {
                MessageBox.Show(this,
                            "Permission успешно авторизован для роли!",
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
            if (status == Program.ExitCode.ElementExists)
            {
                MessageBox.Show(this,
                            "Выбранный permission уже авторизован для выбранной роли!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
        }

        private void Form_addRolePermission_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Permission". При необходимости она может быть перемещена или удалена.
            this.permissionTableAdapter.Fill(this.rbacDataSet.Permission);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.rbacDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

        private void Form_addRolePermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

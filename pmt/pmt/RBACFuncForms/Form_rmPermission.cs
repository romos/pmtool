using System;
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
    public partial class Form_rmPermission : Form
    {
        private MainForm mainForm;

        public Form_rmPermission()
        {
            InitializeComponent();
        }
        public Form_rmPermission(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_rmPermission_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (cb_Action.Text == "" || cb_Object.Text == "")
            {
                MessageBox.Show(this,
                            "Выберите Операцию и Объект!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            //Создать PermissionPerObject:
            PermissionPerObject ppo = new PermissionPerObject
            {                
                Action_Id = Convert.ToInt32(cb_Action.SelectedValue),
                Object_Id = Convert.ToInt32(cb_Object.SelectedValue),
                Permission_Id = Convert.ToInt32(cb_Permission.SelectedValue),
            };

            status = RBACManager.RmPermissionPerObject(ppo, mainForm.db);

            if (status == Program.ExitCode.Success)
            {
                MessageBox.Show(this,
                            "Permission c выбранными Action и Object успешно удален!",
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
            if (status == Program.ExitCode.ElementDoesNotExists)
            {
                MessageBox.Show(this,
                            "Выбранной тройки Permission-Action-Object не существует!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
        }
        private void Form_rmPermission_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.PermissionPerObject". При необходимости она может быть перемещена или удалена.
            this.permissionPerObjectTableAdapter.Fill(this.rbacDataSet.PermissionPerObject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Permission". При необходимости она может быть перемещена или удалена.
            this.permissionTableAdapter.Fill(this.rbacDataSet.Permission);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

        private void Form_rmPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class Form_addPermission : Form
    {
        private MainForm mainForm;

        public Form_addPermission()
        {
            InitializeComponent();
        }
        public Form_addPermission(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addPermission_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (tb_Name.Text != "")
            {
                Permission p = new Permission
                {
                    Name = tb_Name.Text,
                    Policy_Id = Convert.ToInt32(cb_Policy.SelectedValue)
                };

                status = RBACManager.AddPermission(p,
                                    mainForm.db.Action.Single(a => a.Id == Convert.ToInt32(cb_Action.SelectedValue)),
                                    mainForm.db.Object.Single(o => o.Id == Convert.ToInt32(cb_Object.SelectedValue)),
                                    mainForm.db);
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
                                    "Permission добавлен!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                if (status == Program.ExitCode.ElementExists)
                {
                    MessageBox.Show(this,
                                    "Permission с такими параметрами уже существует!",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show(this,
                            "Вы не заполнили поле'Name'!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
        private void Form_addPermission_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Object". При необходимости она может быть перемещена или удалена.
            this.objectTableAdapter.Fill(this.rbacDataSet.Object);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Action". При необходимости она может быть перемещена или удалена.
            this.actionTableAdapter.Fill(this.rbacDataSet.Action);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

        private void Form_addPermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

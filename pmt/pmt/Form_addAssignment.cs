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
    public partial class Form_addAssignment : Form
    {
        private MainForm mainForm;

        public Form_addAssignment()
        {
            InitializeComponent();
        }
        public Form_addAssignment(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addAssignment_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            //Создать Assignment:
            AuthUserRole assgnUR = new AuthUserRole
            {
                User_Id = Convert.ToInt32(cb_User.SelectedValue),
                Role_Id = Convert.ToInt32(cb_Role.SelectedValue),
            };

            status = RBACManager.AddAssignment(assgnUR, mainForm.db);

            if (status == Program.ExitCode.Success)
            {
                MessageBox.Show(this,
                            "Роль успешно авторизована для пользователя!",
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
                            "Выбранная роль уже авторизована для выбранного пользователя!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
        }

        private void Form_addAssignment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.rbacDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.rbacDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }
    }
}

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
    public partial class Form_rmAssignment : Form
    {
        private MainForm mainForm;

        public Form_rmAssignment()
        {
            InitializeComponent();
        }
        public Form_rmAssignment(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_rmAssignment_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (cb_Role.Text == "")
            {
                MessageBox.Show(this,
                            "Выберите пользователя и роль, которую хотите удалить!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            //Создать Assignment:
            AuthUserRole assgnUR = new AuthUserRole
            {
                User_Id = Convert.ToInt32(cb_User.SelectedValue),
                Role_Id = Convert.ToInt32(cb_Role.SelectedValue),
            };

            status = RBACManager.RmAssignment(assgnUR, mainForm.db);

            if (status == Program.ExitCode.Success)
            {
                MessageBox.Show(this,
                            "Роль успешно удалена!",
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
                            "Пользователь не авторизован для указанной роли!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
        }

        private void Form_rmAssignment_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.AuthUserRole". При необходимости она может быть перемещена или удалена.
            this.authUserRoleTableAdapter.Fill(this.rbacDataSet.AuthUserRole);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.rbacDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }
        
        private void cb_Policy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RenewCB_UR();
        } 
        //// Manually load into comboBoxes Names (NOT IDs) of Users and Roles (only existing in AuthUserRole table)
        private void RenewCB_UR()
        {
            //выбрали Юзеров с именами из AuthUserRole только в рамках указанной Policy.
            var queryUser = from temp in mainForm.db.AuthUserRole
                        .Join(mainForm.db.User, aur => aur.User_Id, u => u.Id, (aur, u) => new { authUR = aur, user = u })
                            where (temp.user.Policy_Id == Convert.ToInt32(cb_Policy.SelectedValue))
                            select new { uid = temp.authUR.User_Id, uname = temp.user.Name };
            //Избавились от повторных вхождений (uid,uname)
            queryUser = queryUser.Distinct();

            cb_User.DataSource = queryUser;
            cb_User.ValueMember = "uid";
            cb_User.DisplayMember = "uname";
            cb_User.SelectedValue = queryUser.First().uid;


            //выбрали Роли для выбранных Юзеров из AuthUserRole
            var queryRole = from temp in mainForm.db.AuthUserRole
                            .Join(mainForm.db.Role, aur => aur.Role_Id, r => r.Id, (aur, r) => new { authUR = aur, role = r })
                            where temp.authUR.Role_Id == Convert.ToInt32(cb_User.SelectedValue)
                            select new { rid = temp.authUR.Role_Id, rname = temp.role.Name };
            //Избавились от повторных вхождений (rid,rname)
            queryRole = queryRole.Distinct();

            cb_Role.DataSource = queryRole;
            cb_Role.ValueMember = "rid";
            cb_Role.DisplayMember = "rname";
        }
    }
}

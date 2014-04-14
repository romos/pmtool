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
    public partial class Form_rmRolePermission : Form
    {
        private MainForm mainForm;

        public Form_rmRolePermission()
        {
            InitializeComponent();
        }
        public Form_rmRolePermission(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_rmRolePermission_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status = Program.ExitCode.Success;

            if (cb_Permission.Text == "")
            {
                MessageBox.Show(this,
                            "Выберите Роль и Permission, которые хотите удалить!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
            //Создать RolePermission:
            RolePermission rp = new RolePermission
            {
                Role_Id = Convert.ToInt32(cb_Role.SelectedValue),
                Permission_Id = Convert.ToInt32(cb_Permission.SelectedValue),
            };

            status = RBACManager.RmRolePermission(rp, mainForm.db);

            if (status == Program.ExitCode.Success)
            {
                MessageBox.Show(this,
                            "Permission успешно удален!",
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
                            "Permission не авторизован для указанной роли!",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return;
            }
        }

        private void Form_rmRolePermission_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.RolePermission". При необходимости она может быть перемещена или удалена.
            this.rolePermissionTableAdapter.Fill(this.rbacDataSet.RolePermission);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.rbacDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.RolePermission". При необходимости она может быть перемещена или удалена.
            this.rolePermissionTableAdapter.Fill(this.rbacDataSet.RolePermission);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.rbacDataSet.Role);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }
        
        private void cb_Policy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //RenewCB_UR();
        } 
        //// Manually load into comboBoxes Names (NOT IDs) of Users and Roles (only existing in AuthUserRole table)
        private void RenewCB_RP()
        {
            //выбрали Роли с именами из RolePermission только в рамках указанной Policy.
            var queryRole = from temp in mainForm.db.RolePermission
                        .Join(mainForm.db.Role, rp => rp.Role_Id, r => r.Id, (rp, r) => new { roleperm = rp, role = r })
                            where (temp.role.Policy_Id == Convert.ToInt32(cb_Policy.SelectedValue))
                            select new { rid = temp.roleperm.Role_Id, rname = temp.role.Name };
            //Избавились от повторных вхождений (rid,rname)
            queryRole = queryRole.Distinct();

            cb_Permission.DataSource = queryRole;
            cb_Permission.ValueMember = "rid";
            cb_Permission.DisplayMember = "rname";
            cb_Permission.SelectedValue = queryRole.First().rid;


            //выбрали Роли для выбранных Ролей из RolePermission
            var queryPerm = from temp in mainForm.db.RolePermission
                            .Join(mainForm.db.Permission, rp => rp.Permission_Id, p => p.Id, (rp, p) => new { roleperm = rp, perm = p })
                            where temp.roleperm.Permission_Id == Convert.ToInt32(cb_Permission.SelectedValue)
                            select new { pid = temp.roleperm.Permission_Id, pname = temp.perm.Name };
            //Избавились от повторных вхождений (pid,pname)
            queryPerm = queryPerm.Distinct();

            cb_Permission.DataSource = queryPerm;
            cb_Permission.ValueMember = "pid";
            cb_Permission.DisplayMember = "pname";
        }

        private void Form_rmRolePermission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

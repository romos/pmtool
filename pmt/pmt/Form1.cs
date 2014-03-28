using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmt
{
    public partial class MainForm : Form
    {
        rbacLINQ2SQLDataContext db;

        public MainForm()
        {
            InitializeComponent();
            db = new rbacLINQ2SQLDataContext();

            //Create bindings to rbacDataSet (local in-memory copy for rbac.mdf, IMHO)
            bindingSource_Tables.DataSource = null;
            bindingNavigator_Tables.BindingSource = bindingSource_Tables;
            dataGV_Tables.DataSource = bindingSource_Tables;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //var users = from user in db.User
            //            where user.Policy_Id == 1
            //            select user;

            //MessageBox.Show(String.Format("Id = {0}\nName = {1}\nPassword = {2}\nPolicy_Id = {3}",
            //                                users.First().Id,
            //                                users.First().Name,
            //                                users.First().Password,
            //                                users.First().Policy_Id),
            //                                "DataItem");
            //User u = new User
            //{
            //    Id = 2,
            //    Name = "Roman",
            //    Password = "r0m4n",
            //    Policy_Id = 1
            //};
            //db.User.InsertOnSubmit(u);
            //try
            //{
            //    db.SubmitChanges();
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.ToString());
            //}
            //users = from user in db.User
            //        select user;
            //MessageBox.Show(String.Format("Id = {0}\nName = {1}\nPassword = {2}\nPolicy_Id = {3}",
            //                                users.Last().Id,
            //                                users.Last().Name,
            //                                users.Last().Password,
            //                                users.Last().Policy_Id),
            //                                "DataItem");
        }

        private void TSMenuItem_about_Click(object sender, EventArgs e)
        {
            new AboutPmtool().ShowDialog();
        }

        private void cb_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cb_Tables.SelectionLength != 0)
            //{
            //    string table = cb_Tables.SelectedText;
            //    switch (table)
            //    {
            //        case "Action":
            //            bindingSource_Tables.DataSource = rbacDataSet.Action;
            //            break;
            //        case "ActiveRole":
            //            bindingSource_Tables.DataSource = rbacDataSet.ActiveRole;
            //            break;
            //        case "AuthUserRole":
            //            bindingSource_Tables.DataSource = db.AuthUserRole;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "DynamicSOD":
            //            bindingSource_Tables.DataSource = db.DynamicSOD;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "Object":
            //            bindingSource_Tables.DataSource = db.Object;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "Permission":
            //            bindingSource_Tables.DataSource = db.Permission;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "PermissionPerObject":
            //            bindingSource_Tables.DataSource = db.PermissionPerObject;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "Policy":
            //            bindingSource_Tables.DataSource = db.Policy;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "Role":
            //            bindingSource_Tables.DataSource = db.Role;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "RoleHierarchy":
            //            bindingSource_Tables.DataSource = db.RoleHierarchy;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "RolePermission":
            //            bindingSource_Tables.DataSource = db.RolePermission;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "Session":
            //            bindingSource_Tables.DataSource = db.Session;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "StaticSOD":
            //            bindingSource_Tables.DataSource = db.StaticSOD;
            //            dataGV_Tables.Refresh();
            //            break;
            //        case "User":
            //            bindingSource_Tables.DataSource = db.User;
            //            dataGV_Tables.Refresh();
            //            break;
            //    }
            //}
            //else
            //{
            //    return;
            //}
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            bindingSource_Tables.DataSource = db.User;
            dataGV_Tables.Columns["Policy"].Visible = false;
        }

        private void btn_role_Click(object sender, EventArgs e)
        {
            bindingSource_Tables.DataSource = db.Role;
            dataGV_Tables.Columns["Policy"].Visible = false;
        }

        private void btn_policy_Click(object sender, EventArgs e)
        {
            bindingSource_Tables.DataSource = db.Policy;
        }

        private void btn_authUR_Click(object sender, EventArgs e)
        {
            bindingSource_Tables.DataSource = db.AuthUserRole;
            dataGV_Tables.Columns["Role"].Visible = false;
            dataGV_Tables.Columns["User"].Visible = false;
        }
    }
}

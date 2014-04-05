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
    public partial class MainForm : Form
    {
        public rbacLINQ2SQLDataContext db;

        public MainForm()
        {
            InitializeComponent();

            //Create LINQ classes for database
            db = new rbacLINQ2SQLDataContext();
            //Create bindings to rbacDataSet (local in-memory copy for rbac.mdf, IMHO)
            dataGV_Tables.DataSource = bindingSource_Tables;

            /////combobox_Tables initialization with Table names in <dbo.Table_name> format
            //var q = from t in db.Mapping.GetTables()
            //        select t.TableName;
            //cb_Tables.Items.AddRange(q.ToArray());

            /////testing auto-generated forms for tables
            //new Form1().Show();
            /////1. testing TableAdapterManager for the Role-table edit procedure
            //roleTableAdapter1.Fill(rbacDataSet.Role);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        //
        //Renew dataGV_Tables bindings for correct visualizing
        //
        private void RenewDataGV_Tables(string table_name)
        {
            switch (table_name)
            {
                case "Action":
                    bindingSource_Tables.DataSource = db.Action.GetNewBindingList();
                    break;
                case "ActiveRole":
                    bindingSource_Tables.DataSource = db.ActiveRole.GetNewBindingList();
                    dataGV_Tables.Sort(dataGV_Tables.Columns["Session_Id"], ListSortDirection.Ascending);
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["Session"].Visible = false;
                    break;
                case "AuthUserRole":
                    bindingSource_Tables.DataSource = db.AuthUserRole.GetNewBindingList();
                    dataGV_Tables.Sort(dataGV_Tables.Columns["User_Id"], ListSortDirection.Ascending);
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["User"].Visible = false;
                    break;
                case "DynamicSOD":
                    bindingSource_Tables.DataSource = db.DynamicSOD.GetNewBindingList();
                    dataGV_Tables.Sort(dataGV_Tables.Columns["Role_Id"], ListSortDirection.Ascending);
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["Role1"].Visible = false;
                    break;
                case "Object":
                    bindingSource_Tables.DataSource = db.Object.GetNewBindingList();
                    break;
                case "Permission":
                    bindingSource_Tables.DataSource = db.Permission.GetNewBindingList();
                    dataGV_Tables.Columns["Policy"].Visible = false;
                    break;
                case "PermissionPerObject":
                    bindingSource_Tables.DataSource = db.PermissionPerObject.GetNewBindingList();
                    dataGV_Tables.Sort(dataGV_Tables.Columns["Permission_Id"], ListSortDirection.Ascending);
                    dataGV_Tables.Columns["Permission_Id"].DisplayIndex = 0;
                    dataGV_Tables.Columns["Action_Id"].DisplayIndex = 1;
                    dataGV_Tables.Columns["Object_Id"].DisplayIndex = 2;
                    dataGV_Tables.Columns["Action"].Visible = false;
                    dataGV_Tables.Columns["Object"].Visible = false;
                    dataGV_Tables.Columns["Permission"].Visible = false;
                    break;
                case "Policy":
                    bindingSource_Tables.DataSource = db.Policy.GetNewBindingList();
                    dataGV_Tables.Columns["Id"].ReadOnly = true;
                    break;
                case "Role":
                    /////1. 'DataSet' way to change database.
                    /////Use with tableAdapterManager1 (see below on Submit Button click)
                    //bindingSource_Tables.DataSource = rbacDataSet.Role;

                    bindingSource_Tables.DataSource = db.Role.GetNewBindingList();
                    dataGV_Tables.Columns["Id"].ReadOnly = true;
                    dataGV_Tables.Columns["Policy"].Visible = false;
                    break;
                case "RoleHierarchy":
                    bindingSource_Tables.DataSource = db.RoleHierarchy.GetNewBindingList();
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["Role1"].Visible = false;
                    break;
                case "RolePermission":
                    bindingSource_Tables.DataSource = db.RolePermission.GetNewBindingList();
                    dataGV_Tables.Sort(dataGV_Tables.Columns["Role_Id"], ListSortDirection.Ascending);
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["Permission"].Visible = false;
                    break;
                case "Session":
                    bindingSource_Tables.DataSource = db.Session.GetNewBindingList();
                    dataGV_Tables.Columns["User"].Visible = false;
                    break;
                case "StaticSOD":
                    bindingSource_Tables.DataSource = db.StaticSOD.GetNewBindingList();
                    dataGV_Tables.Sort(dataGV_Tables.Columns["Role_Id"], ListSortDirection.Ascending);
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["Role1"].Visible = false;
                    break;
                case "User":
                    bindingSource_Tables.DataSource = db.User.GetNewBindingList();
                    dataGV_Tables.Columns["Id"].ReadOnly = true;
                    dataGV_Tables.Columns["Policy"].Visible = false;
                    break;
            }
        }
        
        //
        //dataGridView representation test for different tables
        //
        private void cb_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = cb_Tables.Text;

            /////?! WTF ?! DON'T CHANGE NEXT LINE
            bindingSource_Tables.DataSource = null;
            
            RenewDataGV_Tables(table);
        }
        
        //
        //Submit changes to dataGridView
        //
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //[Submit nothing] Prevent Submit windows appearance, when no change done
            if (db.GetChangeSet().Updates.Count == 0 && db.GetChangeSet().Deletes.Count == 0 && db.GetChangeSet().Inserts.Count == 0)
            {
                return;
            }

            try
            {
                db.SubmitChanges();
                MessageBox.Show(this,
                        "Submited",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show(this,
                    exc.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            /////1. to use with rbacDataSet.Role in "Role"-case:
            //tableAdapterManager1.UpdateAll(rbacDataSet);
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            new Form_addUser(this).ShowDialog();
            cb_Tables.Text = "User";
            RenewDataGV_Tables("User");
            /*
            /////Не сработало для обновления dataGV_Tables.
            //
            //db.Refresh(RefreshMode.OverwriteCurrentValues);
            //bindingSource_Tables.ResetBindings(false);
            //
            //this.BindingContext[dataGV_Tables.DataSource].EndCurrentEdit();
            //dataGV_Tables.EndEdit();
            //dataGV_Tables.Refresh();
            //
            /////Делает пустым dataGV:
            //bindingSource_Tables.DataSource = null;
            */
        }
        private void btn_rmUser_Click(object sender, EventArgs e)
        {
            new Form_rmUser(this).ShowDialog();
            cb_Tables.Text = "User";
            RenewDataGV_Tables("User");
        }

        private void btn_addRole_Click(object sender, EventArgs e)
        {
            new Form_addRole(this).ShowDialog();
            cb_Tables.Text = "Role";
            RenewDataGV_Tables("Role");
        }
        private void btn_rmRole_Click(object sender, EventArgs e)
        {
            new Form_rmRole(this).ShowDialog();
            cb_Tables.Text = "Role";
            RenewDataGV_Tables("Role");
        }

        private void btn_addAssignment_Click(object sender, EventArgs e)
        {
            new Form_addAssignment(this).ShowDialog();
            cb_Tables.Text = "AuthUserRole";
            RenewDataGV_Tables("AuthUserRole");
        }
        private void btn_rmAssignment_Click(object sender, EventArgs e)
        {
            new Form_rmAssignment(this).ShowDialog();
            cb_Tables.Text = "AuthUserRole";
            RenewDataGV_Tables("AuthUserRole");
        }

        private void btn_addPolicy_Click(object sender, EventArgs e)
        {
            new Form_addPolicy(this).ShowDialog();
            cb_Tables.Text = "Policy";
            RenewDataGV_Tables("Policy");
        }
        private void btn_rmPolicy_Click(object sender, EventArgs e)
        {
            new Form_rmPolicy(this).ShowDialog();
            cb_Tables.Text = "Policy";
            RenewDataGV_Tables("Policy");
        }

        private void btn_addAction_Click(object sender, EventArgs e)
        {
            new Form_addAction(this).ShowDialog();
            cb_Tables.Text = "Action";
            RenewDataGV_Tables("Action");
        }
        private void btn_rmAction_Click(object sender, EventArgs e)
        {

        }

        private void btn_addObject_Click(object sender, EventArgs e)
        {
            new Form_addObject(this).ShowDialog();
            cb_Tables.Text = "Object";
            RenewDataGV_Tables("Object");
        }
        private void btn_rmObject_Click(object sender, EventArgs e)
        {

        }

        private void btn_addPermission_Click(object sender, EventArgs e)
        {
            new Form_addPermission(this).ShowDialog();
            cb_Tables.Text = "RolePermission";
            RenewDataGV_Tables("RolePermission");
        }
        private void btn_rmPermission_Click(object sender, EventArgs e)
        {
            new Form_rmPermission(this).ShowDialog();
            cb_Tables.Text = "RolePermission";
            RenewDataGV_Tables("RolePermission");
        }

        private void btn_addRolePerm_Click(object sender, EventArgs e)
        {
            new Form_addRolePermission(this).ShowDialog();
            cb_Tables.Text = "RolePermission";
            RenewDataGV_Tables("RolePermission");
        }
        private void btn_rmRolePerm_Click(object sender, EventArgs e)
        {
            new Form_rmRolePermission(this).ShowDialog();
            cb_Tables.Text = "RolePermission";
            RenewDataGV_Tables("RolePermission");
        }


        //
        //AboutBox About Program
        //
        private void TSMenuItem_about_Click(object sender, EventArgs e)
        {
            new AboutPmtool().ShowDialog();
        }
    }
}

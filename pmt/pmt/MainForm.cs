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
        

        /////AboutBox About Program
        private void TSMenuItem_about_Click(object sender, EventArgs e)
        {
            new AboutPmtool().ShowDialog();
        }


        /////dataGridView representation test for different tables
        private void cb_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = cb_Tables.Text;

            /////?! WTF ?! DON'T CHANGE NEXT LINE
            bindingSource_Tables.DataSource = null;

            switch (table)
            {
                case "Action":
                    bindingSource_Tables.DataSource = db.Action.GetNewBindingList();
                    break;
                case "ActiveRole":
                    bindingSource_Tables.DataSource = db.ActiveRole.GetNewBindingList();
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["Session"].Visible = false;
                    break;
                case "AuthUserRole":
                    bindingSource_Tables.DataSource = db.AuthUserRole.GetNewBindingList();
                    dataGV_Tables.Sort(dataGV_Tables.Columns["User_Id"],ListSortDirection.Ascending);
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["User"].Visible = false;
                    break;
                case "DynamicSOD":
                    bindingSource_Tables.DataSource = db.DynamicSOD.GetNewBindingList();
                    break;
                case "Object":
                    bindingSource_Tables.DataSource = db.Object.GetNewBindingList();
                    break;
                case "Permission":
                    bindingSource_Tables.DataSource = db.Permission.GetNewBindingList();
                    break;
                case "PermissionPerObject":
                    bindingSource_Tables.DataSource = db.PermissionPerObject.GetNewBindingList();
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
                    break;
                case "RolePermission":
                    bindingSource_Tables.DataSource = db.RolePermission.GetNewBindingList();
                    break;
                case "Session":
                    bindingSource_Tables.DataSource = db.Session.GetNewBindingList();
                    dataGV_Tables.Columns["User"].Visible = false;
                    break;
                case "StaticSOD":
                    bindingSource_Tables.DataSource = db.StaticSOD.GetNewBindingList();
                    break;
                case "User":
                    bindingSource_Tables.DataSource = db.User.GetNewBindingList();
                    dataGV_Tables.Columns["Id"].ReadOnly = true;
                    dataGV_Tables.Columns["Policy"].Visible = false;
                    break;
            }
        }
        /////Submit changes to dataGridView
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
            bindingSource_Tables.DataSource = db.User.GetNewBindingList();

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
            bindingSource_Tables.DataSource = db.User.GetNewBindingList();
        }
        private void btn_addRole_Click(object sender, EventArgs e)
        {
            new Form_addRole(this).ShowDialog();
            cb_Tables.Text = "Role";
            bindingSource_Tables.DataSource = db.Role.GetNewBindingList();
        }

        private void btn_rmRole_Click(object sender, EventArgs e)
        {

        }

        private void btn_addAssignment_Click(object sender, EventArgs e)
        {

        }

        private void btn_addInheritance_Click(object sender, EventArgs e)
        {

        }

        private void btn_rmAssignment_Click(object sender, EventArgs e)
        {

        }

        private void btn_rmInheritance_Click(object sender, EventArgs e)
        {

        }

        private void btn_addSSOD_Click(object sender, EventArgs e)
        {

        }

        private void btn_rmSSOD_Click(object sender, EventArgs e)
        {

        }

        private void btn_setCardinality_Click(object sender, EventArgs e)
        {

        }

        private void btn_rmDSOD_Click(object sender, EventArgs e)
        {

        }

        private void btn_addDSOD_Click(object sender, EventArgs e)
        {

        }

        private void btn_addPolicy_Click(object sender, EventArgs e)
        {

        }

        private void btn_rmPolicy_Click(object sender, EventArgs e)
        {

        }
    }
}

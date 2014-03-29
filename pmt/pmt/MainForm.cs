﻿using System;
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

            //Create LINQ classes for database
            db = new rbacLINQ2SQLDataContext();
            
            //Create bindings to rbacDataSet (local in-memory copy for rbac.mdf, IMHO)
            dataGV_Tables.DataSource = bindingSource_Tables;

            /////testing auto-generated forms for tables
            //new Form1().Show();
            /////1. testing TableAdapterManager for the Role-table edit procedure
            //roleTableAdapter1.Fill(rbacDataSet.Role);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //User u = new User
            //{
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
            //var users = from user in db.User
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

        //dataGridView representation test for different tables
        private void cb_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table = cb_Tables.Text;

            /////?! WTF ?! DON'T CHANGE NEXT LINE
            bindingSource_Tables.DataSource = null;

            switch (table)
            {
                case "Action":
                    bindingSource_Tables.DataSource = db.Action;
                    break;
                case "ActiveRole":
                    bindingSource_Tables.DataSource = db.ActiveRole;
                    break;
                case "AuthUserRole":
                    bindingSource_Tables.DataSource = db.AuthUserRole;
                    dataGV_Tables.Columns["Role"].Visible = false;
                    dataGV_Tables.Columns["User"].Visible = false;
                    break;
                case "DynamicSOD":
                    bindingSource_Tables.DataSource = db.DynamicSOD;
                    break;
                case "Object":
                    bindingSource_Tables.DataSource = db.Object;
                    break;
                case "Permission":
                    bindingSource_Tables.DataSource = db.Permission;
                    break;
                case "PermissionPerObject":
                    bindingSource_Tables.DataSource = db.PermissionPerObject;
                    break;
                case "Policy":
                    bindingSource_Tables.DataSource = db.Policy;
                    dataGV_Tables.Columns["Id"].ReadOnly = true;
                    break;
                case "Role":
                    /////1. 'DataSet' way to change database.
                    /////Use with tableAdapterManager1 (see below on Submit Button click)
                    //bindingSource_Tables.DataSource = rbacDataSet.Role;

                    bindingSource_Tables.DataSource = db.Role;
                    dataGV_Tables.Columns["Id"].ReadOnly = true;
                    dataGV_Tables.Columns["Policy"].Visible = false;
                    break;
                case "RoleHierarchy":
                    bindingSource_Tables.DataSource = db.RoleHierarchy;
                    break;
                case "RolePermission":
                    bindingSource_Tables.DataSource = db.RolePermission;
                    break;
                case "Session":
                    bindingSource_Tables.DataSource = db.Session;
                    break;
                case "StaticSOD":
                    bindingSource_Tables.DataSource = db.StaticSOD;
                    break;
                case "User":
                    bindingSource_Tables.DataSource = db.User;
                    dataGV_Tables.Columns["Id"].ReadOnly = true;
                    dataGV_Tables.Columns["Policy"].Visible = false;
                    break;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            db.SubmitChanges();

            /////1. to use with rbacDataSet.Role in "Role"-case:
            //tableAdapterManager1.UpdateAll(rbacDataSet);
        }

    }
}

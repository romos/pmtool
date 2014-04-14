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
    public partial class Form_addAction : Form
    {
        private MainForm mainForm;

        public Form_addAction()
        {
            InitializeComponent();
        }
        public Form_addAction(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addAction_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (tb_Name.Text != "")
            {
                Action a = new Action
                {
                    Name = tb_Name.Text,
                };

                status = RBACManager.AddAction(a, mainForm.db);
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
                                    "Операция добавлена!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                if (status == Program.ExitCode.ElementExists)
                {
                    MessageBox.Show(this,
                                    "Такая операция уже существует!",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show(this,
                            "Вы не ввели название операции!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
        }
        private void Form_addAction_Load(object sender, EventArgs e)
        {
        }

        private void Form_addAction_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class Form_addObject : Form
    {
        private MainForm mainForm;

        public Form_addObject()
        {
            InitializeComponent();
        }
        public Form_addObject(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addObject_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (tb_Name.Text != "")
            {
                Object o = new Object
                {
                    Name = tb_Name.Text,
                };

                status = RBACManager.AddObject(o, mainForm.db);
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
                                    "Объект добавлен!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                if (status == Program.ExitCode.ElementExists)
                {
                    MessageBox.Show(this,
                                    "Такой объект уже существует!",
                                    "Warning",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show(this,
                            "Вы не ввели название объекта!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
        }
        private void Form_addObject_Load(object sender, EventArgs e)
        {
        }

        private void Form_addObject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

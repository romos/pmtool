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
    public partial class Form_addRole : Form
    {
        private MainForm mainForm;

        public Form_addRole()
        {
            InitializeComponent();
        }
        public Form_addRole(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addRole_Save_Click(object sender, EventArgs e)
        {
            int i;
            Program.ExitCode status;

            if (tb_Name.Text != "" && tb_Cardinality.Text != "")
            {
                if (cb_Policy.Text != "")
                {
                    //Check Cardinality to be a number:
                    if (!Int32.TryParse(tb_Cardinality.Text, out i) || Convert.ToInt32(tb_Cardinality.Text) < -1){
                        MessageBox.Show(this,
                                        "Cardinality должно быть целым числом >= -1!\n'-1' обозн. бесконечность.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    Role r = new Role
                    {
                        Name = tb_Name.Text,
                        Cardinality = Convert.ToInt32(tb_Cardinality.Text),
                        Policy_Id = Convert.ToInt32(cb_Policy.SelectedValue)
                    };

                    status = RBACManager.AddRole(r, mainForm.db);
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
                                        "Роль добавлена!",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        this.Close();
                        return;
                    }
                    if (status == Program.ExitCode.ElementExists)
                    {
                        if (MessageBox.Show(this,
                                    "Роль с такими 'Name' и 'Cardinality' уже существует!\nОбновить данные для этой роли?",
                                    "Warning",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            status = RBACManager.UpdateRole(r, mainForm.db);
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
                                            "Данные для роли обновлены!",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                                this.Close();
                                return;
                            }
                        }
                        //MsgBox."NO" pressed => Ignore changes, return to add-Form
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,
                    "Выберите политику 'Policy'!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(this,
                    "Вы не заполнили одно из полей 'Name' или 'Cardinality'!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form_addRole_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

        private void Form_addRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

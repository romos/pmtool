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
    public partial class Form_addUser : Form
    {
        private MainForm mainForm;

        public Form_addUser()
        {
            InitializeComponent();
        }
        public Form_addUser(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_addUser_Save_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text != "" && tb_Pwd.Text != "")
            {
                if (cb_Policy.Text != "")
                {
                    User u = new User
                    {
                        Name = tb_Name.Text,
                        Password = tb_Pwd.Text,
                        Policy_Id = Convert.ToInt32(cb_Policy.SelectedValue)
                    };
                    mainForm.db.User.InsertOnSubmit(u);
                    try
                    {
                        mainForm.db.SubmitChanges();
                        MessageBox.Show(this,
                                    "Пользователь добавлен!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(this,
                                    exc.ToString(),
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
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
                    "Вы не заполнили одно из полей 'Name' или 'Password'!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Form_addUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }
    }
}

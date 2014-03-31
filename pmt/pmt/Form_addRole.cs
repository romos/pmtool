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

            if (tb_Name.Text != "" && tb_Cardinality.Text != "")
            {
                if (cb_Policy.Text != "")
                {
                    //Check Cardinality to be a number:
                    if (!Int32.TryParse(tb_Cardinality.Text, out i)){
                        MessageBox.Show(this,
                                        "Cardinality должно быть числом!",
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

                    //check if the role exists
                    var query = from role in mainForm.db.Role
                                where role.Name == r.Name && role.Policy_Id == r.Policy_Id
                                select role;

                    //if does not exist, add:
                    if (query.Count() == 0)
                    {
                        mainForm.db.Role.InsertOnSubmit(r);
                        try
                        {
                            mainForm.db.SubmitChanges();
                            MessageBox.Show(this,
                                        "Роль добавлена!",
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
                    //if exists, Ignore or Update:
                    else
                    {
                        if (MessageBox.Show(this,
                                    "Роль с такими 'Name' и 'Policy_Id' уже существует!\nОбновить данные для этой роли?",
                                    "Warning",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            //Update existing:
                            query.First().Cardinality = r.Cardinality;
                            try
                            {
                                mainForm.db.SubmitChanges();
                                MessageBox.Show(this,
                                            "Роль обновлена!",
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
                        //Ignore changes, return to add-Form
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
    }
}

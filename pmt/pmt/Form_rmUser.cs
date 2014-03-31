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
    public partial class Form_rmUser : Form
    {
        private MainForm mainForm;

        public Form_rmUser()
        {
            InitializeComponent();
        }
        public Form_rmUser(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void tb_Pwd_UpdateValue()
        {
            tb_Password.Text = ((DataRowView)cb_Name.SelectedItem)["Password"].ToString();
        }

        private void btn_rmUser_Save_Click(object sender, EventArgs e)
        {
            mainForm.db.User.DeleteOnSubmit(mainForm.db.User.Single(u => 
                                                    (u.Id == Convert.ToInt32(cb_Name.SelectedValue) &&
                                                     u.Policy_Id == Convert.ToInt32(cb_Policy.SelectedValue))));
            if (MessageBox.Show(this,
                            "Удалить пользователя?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            //удалить пользователя после подтверждения:
            try
            {
                mainForm.db.SubmitChanges();
                MessageBox.Show(this,
                            "Пользователь удален!",
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

        private void Form_rmUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.rbacDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

    }
}

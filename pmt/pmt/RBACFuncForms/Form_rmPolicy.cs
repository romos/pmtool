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
    public partial class Form_rmPolicy : Form
    {
        private MainForm mainForm;

        public Form_rmPolicy()
        {
            InitializeComponent();
        }
        public Form_rmPolicy(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void btn_rmPolicy_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            if (MessageBox.Show(this,
                            "Удалить политику?\nУдаляются также все связанные с ней объекты (User, Role, Permission...)",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            //удалить политику после подтверждения:
            Policy p = new Policy
            {
                Id = Convert.ToInt32(cb_Policy.SelectedValue),
            };

            status = RBACManager.RmPolicy(p, mainForm.db);

            if (status == Program.ExitCode.Success)
            {
                MessageBox.Show(this,
                            "Политика удалена!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                this.Close();
                return;
            }
            if (status == Program.ExitCode.Error)
            {
                MessageBox.Show(this,
                            "Error while submitting deletion to the DataBase",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }
        }
        private void Form_rmPolicy_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

        private void Form_rmPolicy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

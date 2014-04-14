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
    public partial class Form_drawURP : Form
    {
        private MainForm mainForm;

        public Form_drawURP()
        {
            InitializeComponent();
        }
        public Form_drawURP(MainForm mf)
        {
            InitializeComponent();
            mainForm = mf;
        }

        private void tb_Pwd_UpdateValue()
        {
            tb_Password.Text = ((DataRowView)cb_Name.SelectedItem)["Password"].ToString();
        }

        private void btn_drawURP_Save_Click(object sender, EventArgs e)
        {
            Program.ExitCode status;

            //Получить пользователя:
            User u = new User
            {
                Id = Convert.ToInt32(cb_Name.SelectedValue),
                Name = cb_Name.Text,
                Password = tb_Password.Text,
                Policy_Id = Convert.ToInt32(cb_Policy.SelectedValue)
            };
            
            // Отрисовка диаграммы:
            if (mainForm.axDrawingControl.Document.Application.ActivePage.Shapes.Count == 0)
                status = Visualizer.VisualizeURP(mainForm.axDrawingControl.Document.Application.ActivePage,
                                                mainForm.db,
                                                u);
            else
                status = Visualizer.VisualizeURP(mainForm.axDrawingControl.Document.Pages.Add(),
                                                mainForm.db,
                                                u);

            if (status == Program.ExitCode.Error)
            {
                MessageBox.Show(this,
                            "Error while drawing URP relation!",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                return;
            }

            this.Close();
            return;
        }

        private void Form_drawURP_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.rbacDataSet.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rbacDataSet.Policy". При необходимости она может быть перемещена или удалена.
            this.policyTableAdapter.Fill(this.rbacDataSet.Policy);
        }

        private void Form_drawURP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}

using System;
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
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            rbacLINQ2SQLDataContext db = new rbacLINQ2SQLDataContext();
            var users = from user in db.User
                        where user.Policy_Id == 1
                        select user;

            MessageBox.Show(String.Format("Id = {0}\nName = {1}\nPassword = {2}\nPolicy_Id = {3}", users.First().Id, users.First().Name, users.First().Password, users.First().Policy_Id),"DataItem");
            int l = users.Count();
        }

        private void TSMenuItem_about_Click(object sender, EventArgs e)
        {
            new AboutPmtool().ShowDialog();
        }
    }
}

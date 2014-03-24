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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbacLINQ2SQLDataContext db = new rbacLINQ2SQLDataContext();
            var users = from user in db.User
                        where user.Policy_Id == 1
                        select user;

            MessageBox.Show(String.Format("Id = {0}\nName = {1}\nPassword = {2}\nPolicy_Id = {3}", users.First().Id, users.First().Name, users.First().Password, users.First().Policy_Id),"DataItem");
            int l = users.Count();
            //MessageBox.Show(users.Count().ToString());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmt
{
    class RBACManager
    {
        /*public static string AddUser(User u, rbacLINQ2SQLDataContext db)
        {
            
            //check if the user exists
            var query = from usr in db.User
                        where usr.Name == u.Name && usr.Policy_Id == u.Policy_Id
                        select usr;
            
            //if doesn't exist, add:
            if (query.Count() == 0)
            {
                db.User.InsertOnSubmit(u);
                try
                {
                    db.SubmitChanges();
                    return "Пользователь добавлен!";
                }
                catch (Exception exc)
                {
                    exc.ToString();
                }
            }
            //if exists, either Update, or Ignore:
            else
            {
                if (MessageBox.Show(this,
                            "Пользователь с такими 'Name' и 'Policy_Id' уже существует!\nОбновить данные для этого пользователя?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //обновить данные существующего пользователя
                    query.First().Password = u.Password;
                    try
                    {
                        mainForm.db.SubmitChanges();
                        MessageBox.Show(this,
                                    "Данные пользователя обновлены!",
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
                    //отменить изменение, вернуться в форму добавления
                    return;
                }
            }
        }      
        */
        //...
    }
}

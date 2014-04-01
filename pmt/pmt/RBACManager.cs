using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pmt
{
    class RBACManager
    {
        public static Program.ExitCode AddUser(User u, rbacLINQ2SQLDataContext db)
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
                    return Program.ExitCode.Success;
                }
                catch (Exception exc)
                {
                    return Program.ExitCode.Error;
                }
            }
            //if exists:
            else
            {
                return Program.ExitCode.ElementExists;
            }
        }
        public static Program.ExitCode UpdateUser(User u, rbacLINQ2SQLDataContext db)
        {
            var query = from usr in db.User
                        where usr.Name == u.Name && usr.Policy_Id == u.Policy_Id
                        select usr;
            query.First().Password = u.Password;
            try
            {
                db.SubmitChanges();
                return Program.ExitCode.Success;
            }
            catch (Exception exc)
            {
                return Program.ExitCode.Error;
            }
        }

        public static Program.ExitCode AddRole(Role r, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from role in db.Role
                        where role.Name == r.Name && role.Policy_Id == r.Policy_Id
                        select role;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Role.InsertOnSubmit(r);
                try
                {
                    db.SubmitChanges();
                    return Program.ExitCode.Success;
                }
                catch (Exception exc)
                {
                    return Program.ExitCode.Error;
                }
            }
            //if exists, Ignore or Update:
            else
            {
                return Program.ExitCode.ElementExists;
            }
        }
        public static Program.ExitCode UpdateRole(Role r, rbacLINQ2SQLDataContext db)
        {
            var query = from role in db.Role
                        where role.Name == r.Name && role.Policy_Id == r.Policy_Id
                        select role;
            query.First().Cardinality = r.Cardinality;
            try
            {
                db.SubmitChanges();
                return Program.ExitCode.Success;
            }
            catch (Exception exc)
            {
                return Program.ExitCode.Error;
            }
        }

        public static Program.ExitCode DelUser(User u, rbacLINQ2SQLDataContext db)
        {
            try
            {
                User user = db.User.Single(u1 => (u1.Id == u.Id &&
                                                  u1.Policy_Id == u.Policy_Id));

                db.AuthUserRole.DeleteAllOnSubmit(user.AuthUserRole);
                foreach (Session s in user.Session){
                    db.ActiveRole.DeleteAllOnSubmit(s.ActiveRole);
                }
                db.Session.DeleteAllOnSubmit(user.Session);

                db.User.DeleteOnSubmit(db.User.Single(u1 =>
                                                (u1.Id == u.Id &&
                                                u1.Policy_Id == u.Policy_Id)));
                db.SubmitChanges();
                return Program.ExitCode.Success;
            }
            catch (Exception exc)
            {
                return Program.ExitCode.Error;
            }
        }
        //public static Program.ExitCode DelRole(Role r, rbacLINQ2SQLDataContext db)
        //{
        //    try
        //    {
        //        Role role = db.Role.Single(r1 => (r1.Id == r.Id &&
        //                                          r1.Policy_Id == r.Policy_Id));

        //        db.AuthUserRole.DeleteAllOnSubmit(user.AuthUserRole);
        //        foreach (Session s in user.Session)
        //        {
        //            db.ActiveRole.DeleteAllOnSubmit(s.ActiveRole);
        //        }
        //        db.Session.DeleteAllOnSubmit(user.Session);

        //        db.User.DeleteOnSubmit(db.User.Single(u1 =>
        //                                        (u1.Id == u.Id &&
        //                                        u1.Policy_Id == u.Policy_Id)));
        //        db.SubmitChanges();
        //        return Program.ExitCode.Success;
        //    }
        //    catch (Exception exc)
        //    {
        //        return Program.ExitCode.Error;
        //    }
        //}


    }
}

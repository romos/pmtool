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
        public static void AddUser_noTryCatch(User u, rbacLINQ2SQLDataContext db)
        {
            //check if the user exists
            var query = from usr in db.User
                        where usr.Name == u.Name && usr.Policy_Id == u.Policy_Id
                        select usr;
            //if doesn't exist, add:
            if (query.Count() == 0)
            {
                db.User.InsertOnSubmit(u);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added User: {0}", u.Name);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing User: {0}", u.Name);
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
        public static Program.ExitCode RmUser(User u, rbacLINQ2SQLDataContext db, bool submitChanges = true)
        {
            try
            {
                User user = db.User.Single(u1 => (u1.Id == u.Id && u1.Name == u.Name &&
                                                  u1.Policy_Id == u.Policy_Id));

                //Можем запрещать удалять Юзера, у которого есть assigned roles.
                //if (user.AuthUserRole.Count != 0)
                //{
                //    return Program.ExitCode.HasAssigned;
                //}
                foreach (Session s in user.Session)
                {
                    db.ActiveRole.DeleteAllOnSubmit(s.ActiveRole);
                }
                db.Session.DeleteAllOnSubmit(user.Session);
                db.AuthUserRole.DeleteAllOnSubmit(user.AuthUserRole);
                db.User.DeleteOnSubmit(db.User.Single(u1 =>
                                                (u1.Id == u.Id &&
                                                u1.Policy_Id == u.Policy_Id)));
                if (submitChanges)
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
        public static void AddRole_noTryCatch(Role r, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from role in db.Role
                        where role.Name == r.Name && role.Policy_Id == r.Policy_Id
                        select role;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Role.InsertOnSubmit(r);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added Role: {0}", r.Name);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing Role: {0}", r.Name);
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
        public static Program.ExitCode RmRole(Role r, rbacLINQ2SQLDataContext db, bool submitChanges = true)
        {
            try
            {
                Role role = db.Role.Single(r1 => (r1.Id == r.Id &&
                                                  r1.Policy_Id == r.Policy_Id));
                //Можем запрещать удалять Роли, которые привязаны к каким-то Юзерам
                //if (role.AuthUserRole.Count != 0)
                //{
                //    return Program.ExitCode.HasAssigned;
                //}

                //здесь не удаляется роль из SSOD, DSOD, RH
                db.ActiveRole.DeleteAllOnSubmit(role.ActiveRole);
                db.AuthUserRole.DeleteAllOnSubmit(role.AuthUserRole);
                db.RolePermission.DeleteAllOnSubmit(role.RolePermission);
                db.Role.DeleteOnSubmit(role);

                if (submitChanges)
                    db.SubmitChanges();

                return Program.ExitCode.Success;
            }
            catch (Exception exc)
            {
                return Program.ExitCode.Error;
            }
        }

        public static Program.ExitCode AddAssignment(AuthUserRole assgnUR, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from  aur in db.AuthUserRole
                        where aur.Role_Id == assgnUR.Role_Id && aur.User_Id == assgnUR.User_Id
                        select aur;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                //here must be checking role addition posibility within SSOD
                //...

                db.AuthUserRole.InsertOnSubmit(assgnUR);
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
        public static void AddAssignment_noTryCatch(AuthUserRole assgnUR, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from aur in db.AuthUserRole
                        where aur.Role_Id == assgnUR.Role_Id && aur.User_Id == assgnUR.User_Id
                        select aur;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                //here must be checking role addition posibility within SSOD
                //...

                db.AuthUserRole.InsertOnSubmit(assgnUR);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added User->Role: {0}->{1}", assgnUR.User_Id, assgnUR.Role_Id);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing User->Role: {0}->{1}", assgnUR.User_Id, assgnUR.Role_Id);
            }
        }
        public static Program.ExitCode RmAssignment(AuthUserRole assgnUR, rbacLINQ2SQLDataContext db)
        {
            //check if the Assignment exists
            var query = from aur in db.AuthUserRole
                        where aur.Role_Id == assgnUR.Role_Id && aur.User_Id == assgnUR.User_Id
                        select aur;
            //if does exist, delete:
            if (query.Count() != 0)
            {
                //Без учета Активных ролей.
                db.AuthUserRole.DeleteOnSubmit(query.First());
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
            else
            {
                return Program.ExitCode.ElementDoesNotExists;
            }
        }

        public static Program.ExitCode AddPolicy(Policy p, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from policy in db.Policy
                        where policy.Name == p.Name
                        select policy;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Policy.InsertOnSubmit(p);
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
        public static void AddPolicy_noTryCatch(Policy p, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from policy in db.Policy
                        where policy.Name == p.Name
                        select policy;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Policy.InsertOnSubmit(p);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added Policy: {0}", p.Name);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing Policy: {0}", p.Name);
            }
        }
        public static Program.ExitCode RmPolicy(Policy policy_in, rbacLINQ2SQLDataContext db)
        {
            Program.ExitCode status;

            //check if the policy exists
            var query = from policy in db.Policy
                        where policy.Id == policy_in.Id
                        select policy;
            //if does exist, remove:
            if (query.Count() != 0)
            {
                Policy p = query.First();

                foreach (User u in p.User)
                {
                    status = RmUser(u, db, false);
                    if (status != Program.ExitCode.Success)
                        return status;
                }
                foreach (Role r in p.Role)
                {
                    status = RmRole(r, db, false);
                    if (status != Program.ExitCode.Success)
                        return status;
                }
                foreach (Permission perm in p.Permission)
                {
                    status = RmPermission(perm, db, false);
                    if (status != Program.ExitCode.Success)
                        return status;
                }
                db.Policy.DeleteOnSubmit(p);
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
            //if doesn't exist:
            else
            {
                return Program.ExitCode.ElementDoesNotExists;
            }
        }

        public static Program.ExitCode AddAction(Action a_in, rbacLINQ2SQLDataContext db)
        {
            //check if exists
            var query = from act in db.Action
                        where act.Name == a_in.Name
                        select act;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Action.InsertOnSubmit(a_in);
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
        public static void AddAction_noTryCatch(Action a_in, rbacLINQ2SQLDataContext db)
        {
            //check if exists
            var query = from act in db.Action
                        where act.Name == a_in.Name
                        select act;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Action.InsertOnSubmit(a_in);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added Action: {0}", a_in.Name);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing Action: {0}", a_in.Name);
            }
        }
        public static Program.ExitCode RmAction(Action a_in, rbacLINQ2SQLDataContext db)
        {
            var query = from act in db.Action
                        where act.Name == a_in.Name
                        select act;
            if (query.Count() == 0)
                return Program.ExitCode.ElementDoesNotExists;

            Action a = query.First();
            
            HashSet<int> pids = new HashSet<int>();
            
            foreach (var ppo in a.PermissionPerObject)
            {
                pids.Add(ppo.Permission_Id);
                db.PermissionPerObject.DeleteOnSubmit(ppo);
            }

            try { db.SubmitChanges(); }
            catch (Exception exc) { return Program.ExitCode.Error; }

            //check if there're entities for PPOs deleted. If not - delete these Permission entities:
            var prmsn = db.PermissionPerObject.Where(x => (pids.Contains<int>(x.Permission_Id)))
                                              .Select(x => x.Permission_Id);
            foreach (int i in prmsn)
                pids.Remove(i);

            var query1 = db.Permission.Where(x => pids.Contains<int>(x.Id));
            foreach (var q in query1)
            {
                RmPermission(q, db, false);
            }

            db.Action.DeleteOnSubmit(a);
            try
            {
                db.SubmitChanges();
                return Program.ExitCode.Success;
            }
            catch (Exception exc) { return Program.ExitCode.Error; }
        }

        public static Program.ExitCode AddObject(Object o_in, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from obj in db.Object
                        where obj.Name == o_in.Name
                        select obj;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Object.InsertOnSubmit(o_in);
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
        public static void AddObject_noTryCatch(Object o_in, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from obj in db.Object
                        where obj.Name == o_in.Name
                        select obj;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                db.Object.InsertOnSubmit(o_in);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added Object: {0}", o_in.Name);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing Object: {0}", o_in.Name);
            }
        }
        public static Program.ExitCode RmObject(Object o_in, rbacLINQ2SQLDataContext db)
        {
            var query = from obj in db.Object
                        where obj.Name == o_in.Name
                        select obj;
            if (query.Count() == 0)
                return Program.ExitCode.ElementDoesNotExists;

            Object o = query.First();

            HashSet<int> pids = new HashSet<int>();

            foreach (var ppo in o.PermissionPerObject)
            {
                pids.Add(ppo.Permission_Id);
                db.PermissionPerObject.DeleteOnSubmit(ppo);
            }

            try { db.SubmitChanges(); }
            catch (Exception exc) { return Program.ExitCode.Error; }

            //check if there're entities for PPOs deleted. If not - delete these Permission entities:
            var prmsn = db.PermissionPerObject.Where(x => (pids.Contains<int>(x.Permission_Id)))
                                              .Select(x => x.Permission_Id);
            foreach (int i in prmsn)
                pids.Remove(i);

            var query1 = db.Permission.Where(x => pids.Contains<int>(x.Id));
            foreach (var q in query1)
            {
                RmPermission(q, db, false);
            }

            db.Object.DeleteOnSubmit(o);
            try
            {
                db.SubmitChanges();
                return Program.ExitCode.Success;
            }
            catch (Exception exc) { return Program.ExitCode.Error; }
        }

        public static Program.ExitCode AddPermission(Permission p_in, Action a_in, Object o_in, rbacLINQ2SQLDataContext db)
        {
            bool ppo_exists = false;
            bool p_exists = false;

            var query_p = from p in db.Permission
                          where p.Name == p_in.Name && p.Policy_Id == p_in.Policy_Id
                          select p;
            if (query_p.Count() != 0)
                p_exists = true;
            // if does not exist in Permission_Table, add:
            if (!p_exists)
            {
                db.Permission.InsertOnSubmit(p_in);
                try { db.SubmitChanges(); }
                catch (Exception exc) { return Program.ExitCode.Error; }
            }
            Permission perm = db.Permission.Single(p => p.Name == p_in.Name && p.Policy_Id == p_in.Policy_Id);

            var query_ppo = from ppo in db.PermissionPerObject
                            where ppo.Action_Id == a_in.Id && ppo.Object_Id == o_in.Id && ppo.Permission_Id == perm.Id
                            select ppo;
            if (query_ppo.Count() != 0)
                ppo_exists = true;

            if (ppo_exists)
            {
                return Program.ExitCode.ElementExists;
            }
            // if does not exist in PermissionPerObject_Table, add:
            else
            {
                
                db.PermissionPerObject.InsertOnSubmit(new PermissionPerObject{
                                                            Action_Id = a_in.Id,
                                                            Object_Id = o_in.Id,
                                                            Permission_Id = perm.Id});
                try
                {
                    db.SubmitChanges();
                    return Program.ExitCode.Success;
                }
                catch (Exception exc) { return Program.ExitCode.Error; }
            }
        }
        public static void AddPermission_noTryCatch(Permission p_in, Action a_in, Object o_in, rbacLINQ2SQLDataContext db)
        {
            bool ppo_exists = false;
            bool p_exists = false;

            var query_p = from p in db.Permission
                          where p.Name == p_in.Name && p.Policy_Id == p_in.Policy_Id
                          select p;
            if (query_p.Count() != 0)
                p_exists = true;
            // if does not exist in Permission_Table, add:
            if (!p_exists)
            {
                db.Permission.InsertOnSubmit(p_in);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added Permission {0}:", p_in.Name);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing Permission {0}:", p_in.Name);
            }
            Permission perm = db.Permission.Single(p => p.Name == p_in.Name && p.Policy_Id == p_in.Policy_Id);

            var query_ppo = from ppo in db.PermissionPerObject
                            where ppo.Action_Id == a_in.Id && ppo.Object_Id == o_in.Id && ppo.Permission_Id == perm.Id
                            select ppo;
            if (query_ppo.Count() != 0)
            {
                ppo_exists = true;
                System.Diagnostics.Debug.WriteLine("Existing PermissionPerObject {0}->({1},{2}):",p_in.Name,a_in.Name,o_in.Name);
            }
            // if does not exist in PermissionPerObject_Table, add:
            else
            {
                db.PermissionPerObject.InsertOnSubmit(new PermissionPerObject
                {
                    Action_Id = a_in.Id,
                    Object_Id = o_in.Id,
                    Permission_Id = perm.Id
                });
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added PermissionPerObject {0}->({1},{2}):", p_in.Name, a_in.Name, o_in.Name);
            }
        }
        public static Program.ExitCode RmPermissionPerObject(PermissionPerObject ppo_in, rbacLINQ2SQLDataContext db)
        {
            var query_ppo = from ppo in db.PermissionPerObject
                            where ppo.Action_Id == ppo_in.Action_Id && ppo.Object_Id == ppo_in.Object_Id && ppo.Permission_Id == ppo_in.Permission_Id
                            select ppo;
            // if there's no such an element - return corresponding status:
            if (query_ppo.Count() == 0)
                return Program.ExitCode.ElementDoesNotExists;    

            //Otherwise, delete from PermissionPerObject:
            db.PermissionPerObject.DeleteOnSubmit(query_ppo.First());
            try { db.SubmitChanges(); }
            catch (Exception exc) { return Program.ExitCode.Error; }

            // Check, if there's a PpO entity for the ppo.Permission_Id permission. 
            query_ppo = from ppo in db.PermissionPerObject
                        where ppo.Permission_Id == ppo_in.Permission_Id
                        select ppo;
            // If not, delete this "empty" ppo.Permission_Id from Permission and from RolePermission
            // Otherwise, return success
            if (query_ppo.Count() != 0)
            {
                return Program.ExitCode.Success;
            }
            else
            {
                var query_p = from p in db.Permission
                              where p.Id == ppo_in.Permission_Id
                              select p;
                db.RolePermission.DeleteAllOnSubmit(query_p.First().RolePermission);
                db.Permission.DeleteOnSubmit(query_p.First());
                try { db.SubmitChanges(); }
                catch (Exception exc) { return Program.ExitCode.Error; }
            }

            return Program.ExitCode.Success;
        }
        public static Program.ExitCode RmPermission(Permission p_in, rbacLINQ2SQLDataContext db, bool submitChanges = true)
        {
            var query_p = from p in db.Permission
                            where p.Name == p_in.Name && p.Policy_Id == p_in.Policy_Id
                            select p;
            if (query_p.Count() == 0)
            {
                return Program.ExitCode.ElementDoesNotExists;
            }
            db.PermissionPerObject.DeleteAllOnSubmit(query_p.First().PermissionPerObject);
            db.RolePermission.DeleteAllOnSubmit(query_p.First().RolePermission);
            db.Permission.DeleteOnSubmit(query_p.First());
            try
            {
                if (submitChanges)
                    db.SubmitChanges();
                return Program.ExitCode.Success;
            }
            catch (Exception exc) { return Program.ExitCode.Error; }
        }

        public static Program.ExitCode AddRolePermission(RolePermission rp_in, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from rp in db.RolePermission
                        where rp.Role_Id == rp_in.Role_Id && rp.Permission_Id == rp_in.Permission_Id
                        select rp;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                //here must be checking of role-permission addition posibility within Constraints of RBAC2.
                //...

                db.RolePermission.InsertOnSubmit(rp_in);
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
        public static void AddRolePermission_noTryCatch(RolePermission rp_in, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from rp in db.RolePermission
                        where rp.Role_Id == rp_in.Role_Id && rp.Permission_Id == rp_in.Permission_Id
                        select rp;
            //if does not exist, add:
            if (query.Count() == 0)
            {
                //here must be checking of role-permission addition posibility within Constraints of RBAC2.
                //...

                db.RolePermission.InsertOnSubmit(rp_in);
                db.SubmitChanges();
                System.Diagnostics.Debug.WriteLine("Added RolePermission {0}->{1}:", rp_in.Role_Id, rp_in.Permission_Id);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Existing RolePermission {0}->{1}:", rp_in.Role_Id, rp_in.Permission_Id);
            }
        }
        public static Program.ExitCode RmRolePermission(RolePermission rp_in, rbacLINQ2SQLDataContext db)
        {
            //check if the role exists
            var query = from rp in db.RolePermission
                        where rp.Role_Id == rp_in.Role_Id && rp.Permission_Id == rp_in.Permission_Id
                        select rp;
            //if does exist, remove:
            if (query.Count() != 0)
            {
                //here must be checking of role-permission addition posibility within Constraints of RBAC2.
                //...

                /*
                 * Без учета Активных ролей. Вообще, эта операция должна выполняться, когда выбранная роль не залогинена ни у одного пользователя
                 * Т.е. когда query.First().Role.ActiveRole.Count == 0
                 * Более того, когда все роли, лежащие Выше по ролевой иерархии, не залогинены. (чтобы спокойно у них отобрать permission)
                 * */
                db.RolePermission.DeleteOnSubmit(query.First());
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
            //if doesn't exist:
            else
            {
                return Program.ExitCode.ElementExists;
            }
        }


        // StaticSOD and DynamicSOD are not fully implemented
        // (with paying no attention to Role Hierarchy relations)
        public static Program.ExitCode AddStaticSOD(Role r1, Role r2, rbacLINQ2SQLDataContext db)
        {
            // Check if roles exist
            var role1 = from r in db.Role
                        where r.Name == r1.Name && r.Policy_Id == r1.Policy_Id
                        select r;
            var role2 = from r in db.Role
                        where r.Name == r2.Name && r.Policy_Id == r2.Policy_Id
                        select r;
            if (role1.Count() == 1 || role2.Count() == 1)
            {
                StaticSOD ssod1 = new StaticSOD()
                {
                    Role_Id = role1.First().Id,
                    ExclusiveRole_Id = role2.First().Id,
                };
                    
                StaticSOD ssod2 = new StaticSOD()
                {
                    Role_Id = role2.First().Id,
                    ExclusiveRole_Id = role1.First().Id,
                };

                // Check if SSOD exists:
                var query1 = from t in db.StaticSOD
                             where t.Role_Id == ssod1.Role_Id && t.ExclusiveRole_Id == ssod1.ExclusiveRole_Id
                             select t;
                var query2 = from t in db.StaticSOD
                             where t.Role_Id == ssod2.Role_Id && t.ExclusiveRole_Id == ssod2.ExclusiveRole_Id
                             select t;
                if (query1.Count() == 1 && query2.Count() == 1)
                {
                    return Program.ExitCode.ElementExists;
                }
                try
                {
                    if (query1.Count() != 1)
                        db.StaticSOD.InsertOnSubmit(ssod1);
                    if (query2.Count() != 1)
                        db.StaticSOD.InsertOnSubmit(ssod2);
                    db.SubmitChanges();
                    return Program.ExitCode.Success;
                }
                catch
                {
                    return Program.ExitCode.Error;
                }
            }
            else
            {
                return Program.ExitCode.ElementDoesNotExists;
            }
        }
        public static Program.ExitCode AddDynamicSOD(Role r1, Role r2, rbacLINQ2SQLDataContext db)
        {
            // Check if roles exist
            var role1 = from r in db.Role
                        where r.Name == r1.Name && r.Policy_Id == r1.Policy_Id
                        select r;
            var role2 = from r in db.Role
                        where r.Name == r2.Name && r.Policy_Id == r2.Policy_Id
                        select r;
            if (role1.Count() == 1 || role2.Count() == 1)
            {
                DynamicSOD dsod1 = new DynamicSOD()
                {
                    Role_Id = role1.First().Id,
                    ExclusiveRole_Id = role2.First().Id,
                };
                DynamicSOD dsod2 = new DynamicSOD()
                {
                    Role_Id = role2.First().Id,
                    ExclusiveRole_Id = role1.First().Id,
                };

                // Check if DSOD exists:
                var query1 = from t in db.DynamicSOD
                             where t.Role_Id == dsod1.Role_Id && t.ExclusiveRole_Id == dsod1.ExclusiveRole_Id
                             select t;
                var query2 = from t in db.DynamicSOD
                             where t.Role_Id == dsod2.Role_Id && t.ExclusiveRole_Id == dsod2.ExclusiveRole_Id
                             select t;
                if (query1.Count() == 1 && query2.Count() == 1)
                {
                    return Program.ExitCode.ElementExists;
                }
                try
                {
                    if (query1.Count() != 1)
                        db.DynamicSOD.InsertOnSubmit(dsod1);
                    if (query2.Count() != 1)
                        db.DynamicSOD.InsertOnSubmit(dsod2);
                    db.SubmitChanges();
                    return Program.ExitCode.Success;
                }
                catch
                {
                    return Program.ExitCode.Error;
                }
            }
            else
            {
                return Program.ExitCode.ElementDoesNotExists;
            }
        }
        public static Program.ExitCode AddRH(Role senior, Role junior, rbacLINQ2SQLDataContext db)
        {
            // Check if roles exist
            var roleS = from r in db.Role
                        where r.Name == senior.Name && r.Policy_Id == senior.Policy_Id
                        select r;
            var roleJ = from r in db.Role
                        where r.Name == junior.Name && r.Policy_Id == junior.Policy_Id
                        select r;
            if (roleS.Count() == 1 && roleJ.Count() == 1)
            {
                RoleHierarchy rh = new RoleHierarchy()
                {
                    SeniorRole_Id = roleS.First().Id,
                    JuniorRole_Id = roleJ.First().Id,
                };

                // Check if RH exists:
                var query = from t in db.RoleHierarchy
                            where  t.SeniorRole_Id == rh.SeniorRole_Id 
                                && t.JuniorRole_Id == rh.JuniorRole_Id
                            select t;
                if (query.Count() == 1)
                {
                    return Program.ExitCode.ElementExists;
                }
                try
                {
                    db.RoleHierarchy.InsertOnSubmit(rh);
                    db.SubmitChanges();
                    return Program.ExitCode.Success;
                }
                catch
                {
                    return Program.ExitCode.Error;
                }
            }
            else
            {
                return Program.ExitCode.ElementDoesNotExists;
            }
        }
    }
}

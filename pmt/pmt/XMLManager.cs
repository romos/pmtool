using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Xml;
using System.Transactions;
using System.Windows.Forms;


namespace pmt
{
    class XMLManager
    {
        public static void Test_UsersToXML(rbacLINQ2SQLDataContext db, string fname)
        {
            FileStream fs = new FileStream(fname + ".xml", FileMode.Append);
            FileStream fs_schema = new FileStream(fname + "_schema.xml", FileMode.Append);


            var user = from usr in db.User
                       select usr;
            
            SqlCommand cmd = db.GetCommand(user) as SqlCommand;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet("USER_TABLE");
            adapter.Fill(ds, "User");
            ds.WriteXml(fs);
            ds.WriteXmlSchema(fs_schema);


            var role = from r in db.Role
                       select r;
            cmd = db.GetCommand(role) as SqlCommand;
            adapter = new SqlDataAdapter(cmd);
            ds = new DataSet("ROLE_TABLE");
            adapter.Fill(ds, "Role");
            ds.WriteXml(fs);
            ds.WriteXmlSchema(fs_schema);


            fs.Close();
            fs_schema.Close();
            return;
        }

        public static Program.ExitCode ExportToXML(rbacLINQ2SQLDataContext db, string fname)
        {
            try
            {
                // Create an XmlWriter with custom formatting settings
                XmlWriter xmlWriter;
                XmlWriterSettings xmlWriterSettigns = new XmlWriterSettings();
                xmlWriterSettigns.Indent = true;
                xmlWriterSettigns.IndentChars = "\t";
                xmlWriterSettigns.NewLineOnAttributes = true;
                xmlWriterSettigns.NewLineChars = "\n";
                xmlWriter = XmlWriter.Create(fname, xmlWriterSettigns);

                // Write document
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("MCD_PMTOOL_RBAC_DATABASE");

                XMLWritePolicyBlock(db, xmlWriter);
                XMLWriteActionBlock(db, xmlWriter);
                XMLWriteObjectBlock(db, xmlWriter);

                xmlWriter.WriteEndElement();
                xmlWriter.Close();
            }
            catch
            {
                return Program.ExitCode.Error;
            }
            return Program.ExitCode.Success;
        }

        private static void XMLWritePolicyBlock(rbacLINQ2SQLDataContext db, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("POLICIES");
            foreach (Policy policy in db.Policy)
            {
                XMLWritePolicy(policy, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWritePolicy(Policy policy, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("Policy");
            // Policy details
            xmlWriter.WriteAttributeString("name", policy.Name);
            // User block
            XMLWriteUserBlock(policy.User, xmlWriter);
            // Role block
            XMLWriteRoleBlock(policy.Role, xmlWriter);
            // Permission block
            XMLWritePermissionBlock(policy.Permission, xmlWriter);

            // not implemented in DataBase, but prepared for future here:
            // SSoD block
            XMLWriteSSODBlock(policy.Role, xmlWriter);
            // DSoD block
            XMLWriteDSODBlock(policy.Role, xmlWriter);
            // Role Hierarchy block
            XMLWriteRHBlock(policy.Role, xmlWriter);

            xmlWriter.WriteEndElement();
        }
        
        private static void XMLWriteUserBlock(EntitySet<User> users, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("USERS");
            foreach (User user in users)
            {
                XMLWriteUser(user, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteUser(User user, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("User");
                xmlWriter.WriteAttributeString("name", user.Name);
                xmlWriter.WriteAttributeString("password", user.Password);
                XMLWriteUserAuthRoles(user, xmlWriter);
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteUserAuthRoles(User user, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("AuthRoles");
            foreach (AuthUserRole authUR in user.AuthUserRole)
            {
                xmlWriter.WriteStartElement("Role");
                xmlWriter.WriteAttributeString("name", authUR.Role.Name);
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }
        
        private static void XMLWriteRoleBlock(EntitySet<Role> roles, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("ROLES");
            foreach (Role role in roles)
            {
                XMLWriteRole(role, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteRole(Role role, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("Role");
                xmlWriter.WriteAttributeString("name", role.Name);
                xmlWriter.WriteAttributeString("cardinality", role.Cardinality.ToString());
                XMLWriteRolePermissions(role, xmlWriter);
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteRolePermissions(Role role, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("Permissions");
            foreach (RolePermission rp in role.RolePermission)
            {
                xmlWriter.WriteStartElement("Permission");
                xmlWriter.WriteAttributeString("name", rp.Permission.Name);
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }        
        
        private static void XMLWritePermissionBlock(EntitySet<Permission> permissions, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("PERMISSIONS");
            foreach (Permission permission in permissions)
            {
                XMLWritePermission(permission, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWritePermission(Permission permission, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("Permission");
            xmlWriter.WriteAttributeString("name", permission.Name);
            XMLWritePermissionPerObject(permission, xmlWriter);
            xmlWriter.WriteEndElement();
        }
        private static void XMLWritePermissionPerObject(Permission permission, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("PermissionsPerObject");
            foreach (PermissionPerObject ppo in permission.PermissionPerObject)
            {
                xmlWriter.WriteStartElement("PpO");
                xmlWriter.WriteAttributeString("action", ppo.Action.Name);
                xmlWriter.WriteAttributeString("object", ppo.Object.Name);
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
        }

        private static void XMLWriteActionBlock(rbacLINQ2SQLDataContext db, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("ACTIONS");
            foreach (Action action in db.Action)
            {
                XMLWriteAction(action, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteAction(Action action, XmlWriter xmlWriter)
        {
            // Action details
            xmlWriter.WriteStartElement("Action");
            xmlWriter.WriteAttributeString("name", action.Name);
            xmlWriter.WriteEndElement();
        }

        private static void XMLWriteObjectBlock(rbacLINQ2SQLDataContext db, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("OBJECTS");
            foreach (Object objct in db.Object)
            {
                XMLWriteObject(objct, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteObject(Object objct, XmlWriter xmlWriter)
        {
            // Object details
            xmlWriter.WriteStartElement("Object");
            xmlWriter.WriteAttributeString("name", objct.Name);
            xmlWriter.WriteEndElement();
        }

        private static void XMLWriteSSODBlock(EntitySet<Role> roles, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("SSOD");
            foreach (Role role in roles)
            {
                XMLWriteSSOD(role, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteSSOD(Role role, XmlWriter xmlWriter)
        {
            // Create an entity only if a role has SSOD
            if (role.StaticSOD.Count != 0)
            {
                xmlWriter.WriteStartElement("Role");
                xmlWriter.WriteAttributeString("name", role.Name);
                foreach (StaticSOD ssod in role.StaticSOD)
                {
                    xmlWriter.WriteStartElement("Exclusive_Role");
                    xmlWriter.WriteAttributeString("name", ssod.Role1.Name);
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
        }
        
        private static void XMLWriteDSODBlock(EntitySet<Role> roles, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("DSOD");
            foreach (Role role in roles)
            {
                XMLWriteDSOD(role, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteDSOD(Role role, XmlWriter xmlWriter)
        {
            // Create an entity only if a role has DSOD
            if (role.DynamicSOD.Count != 0)
            {
                xmlWriter.WriteStartElement("Role");
                xmlWriter.WriteAttributeString("name", role.Name);
                foreach (DynamicSOD dsod in role.DynamicSOD)
                {
                    xmlWriter.WriteStartElement("Exclusive_Role");
                    xmlWriter.WriteAttributeString("name", dsod.Role1.Name);
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
        }
        
        private static void XMLWriteRHBlock(EntitySet<Role> roles, XmlWriter xmlWriter)
        {
            xmlWriter.WriteStartElement("RoleHierarchy");
            foreach (Role role in roles)
            {
                XMLWriteRH(role, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWriteRH(Role role, XmlWriter xmlWriter)
        {
            // Create an entity only if a role has RH
            // Here Role1 <-> SeniorRole
            //      Role  <-> JuniorRole
            if (role.RoleHierarchy1.Count != 0)
            {
                xmlWriter.WriteStartElement("SeniorRole");
                xmlWriter.WriteAttributeString("name", role.Name);
                foreach (RoleHierarchy rh in role.RoleHierarchy1)
                {
                    xmlWriter.WriteStartElement("JuniorRole");
                    xmlWriter.WriteAttributeString("name", rh.Role.Name);
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();
            }
        }

        /*private static void XMLWriteBlock(string block, rbacLINQ2SQLDataContext db, XmlWriter xmlWriter)
        {
            switch (block)
            {
                case "Action":

                    break;
                case "ActiveRole":

                    break;
                case "AuthUserRole":

                    break;
                case "DynamicSOD":

                    break;
                case "Object":

                    break;
                case "Permission":

                    break;
                case "PermissionPerObject":

                    break;
                case "Policy":

                    break;
                case "Role":

                    break;
                case "RoleHierarchy":

                    break;
                case "RolePermission":

                    break;
                case "Session":

                    break;
                case "StaticSOD":

                    break;
                case "User":

                    break;
            }
        }
        */


        public static Program.ExitCode ImportFromXML(rbacLINQ2SQLDataContext db, string fname)
        {
            /* TODO 1:
             * 
             * Никаких проверок на корректность входного файла, можно считать, НЕ делается!
             * Следите за корректностью файла, соблюдайте формат!
             * 
             * TODO 2:
             * 
             * Тут используется TransactionScope. Он завершает транзакцию, только если вызван Complete()
             * Пока что используются методы RBACManager, которые работают без try-catch блоков, чтобы не 
             * повлиять на обработку транзакций.
             * Хотя внутри using{...} можно реализовать проверку статусных сообщений от обычных функций
             * RBACManager и в конце делать: if (allSuccessfull) {ts.Complete();}.
             * Т.о. транзакция завершится только если успешно завершились все методы внутри нее.
             * */

            try
            {
                XmlTextReader xmlReader = new XmlTextReader(fname);
                XmlDocument doc = new XmlDocument();
                doc.Load(fname);

                using (TransactionScope ts = new TransactionScope())
                {
                    // Read document
                    XMLReadActionBlock(db, doc);
                    XMLReadObjectBlock(db, doc);
                    XMLReadPolicyBlock(db, doc);

                    ts.Complete();
                }
                xmlReader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return Program.ExitCode.Error;
            }
            return Program.ExitCode.Success;
        }

        private static bool XMLReadPolicyBlock(rbacLINQ2SQLDataContext db, XmlDocument doc)
        {
            XmlNodeList policyBlock = doc.GetElementsByTagName("POLICIES");
            
            // Если не указаны Policies, false
            if (policyBlock.Count != 1)
                return false;

            XmlNodeList policies = policyBlock.Item(0).ChildNodes;
            foreach (XmlNode policyNode in policies)
            {
                XMLReadPolicyNode(policyNode, db);
            }
            return true;
        }
        private static bool XMLReadPolicyNode(XmlNode policyNode, rbacLINQ2SQLDataContext db)
        {
            Policy policy = new Policy()
            {
                Name = policyNode.Attributes["name"].Value
            };
            RBACManager.AddPolicy_noTryCatch(policy, db);

            // Indices for node blocks:
            int iUSERS, iROLES, iPERMISSIONS, iSSOD, iDSOD, iROLEHIERARCHY;
            iUSERS = -1; iROLES = -1; iPERMISSIONS = -1; iSSOD = -1; iDSOD = -1; iROLEHIERARCHY = -1;
            int i = -1;
            foreach (XmlNode node in policyNode.ChildNodes)
            {
                i++;
                switch (node.Name)
                {
                    case "USERS":
                        iUSERS = i;
                        break;
                    case "ROLES":
                        iROLES = i;
                        break;
                    case "PERMISSIONS":
                        iPERMISSIONS = i;
                        break;
                    case "SSOD":
                        iSSOD = i;
                        break;
                    case "DSOD":
                        iDSOD = i;
                        break;
                    case "RoleHierarchy":
                        iROLEHIERARCHY = i;
                        break;
                }
            }
            // if there is a policy, it MUST have ALL inner blocks USER, ROLE, etc.
            if (iUSERS == -1 || iROLES == -1 || iPERMISSIONS == -1 ||
                iSSOD == -1 || iDSOD == -1 || iROLEHIERARCHY == -1 ||
                i > 5)// the last i>5 is for guarantee only one section for each of USER, ROLE,.. blocks
            {
                return false;
            }

            // Get policy_ID of the inserted [or existed, ofc] policy
            int policy_id = db.Policy.Single(x => x.Name == policy.Name).Id;
            // Order of operators below is IMPORTANT to guarantee correctness of DataBase filling
            XMLReadPermissionBlock(policyNode.ChildNodes.Item(iPERMISSIONS), policy_id, db);
            XMLReadRoleBlock(policyNode.ChildNodes.Item(iROLES), policy_id, db);
            XMLReadUserBlock(policyNode.ChildNodes.Item(iUSERS), policy_id, db);

            // Implemented "as is". Without paying attention to RH relation within SODs
            //XMLReadSSODBlock(policyNode.ChildNodes.Item(iSSOD), policy_id, db);
            //XMLReadDSODBlock(policyNode.ChildNodes.Item(iDSOD), policy_id, db);
            //XMLReadRHBlock(policyNode.ChildNodes.Item(iROLEHIERARCHY), policy_id, db);
            
            return true;
        }

        private static bool XMLReadRHBlock(XmlNode nodeRH, int pid, rbacLINQ2SQLDataContext db)
        {
            XmlNodeList rhNodes = nodeRH.ChildNodes;
            foreach (XmlNode rhNode in rhNodes)
            {
                XMLReadRH(rhNode, pid, db);
            }
            return true;
        }
        private static bool XMLReadRH(XmlNode rhNode, int pid, rbacLINQ2SQLDataContext db)
        {
            Role senior, junior;

            // If no junior role defined, error. 
            // 'Cause senior role is presented, but a set of juniors - isn't.
            if (rhNode.ChildNodes.Count == 0)
                return false;

            senior = db.Role.Single(x => x.Name == rhNode.Attributes["name"].Value
                                        && x.Policy_Id == pid);

            foreach (XmlNode jNode in rhNode.ChildNodes)
            {
                junior = db.Role.Single(x => x.Name == jNode.Attributes["name"].Value
                                          && x.Policy_Id == pid);
                RBACManager.AddRH(senior, junior, db);
            }
            return true;
        }

        private static bool XMLReadDSODBlock(XmlNode nodeDSOD, int pid, rbacLINQ2SQLDataContext db)
        {
            XmlNodeList roleSODNodes = nodeDSOD.ChildNodes;
            foreach (XmlNode roleSODNode in roleSODNodes)
            {
                XMLReadSOD(roleSODNode, pid, db, "DYNAMIC");
            }
            return true;
        }
        private static bool XMLReadSSODBlock(XmlNode nodeSSOD, int pid, rbacLINQ2SQLDataContext db)
        {
            XmlNodeList roleSODNodes = nodeSSOD.ChildNodes;
            foreach (XmlNode roleSODNode in roleSODNodes)
            {
                XMLReadSOD(roleSODNode, pid, db, "STATIC");
            }
            return true;
        }
        private static bool XMLReadSOD(XmlNode roleSODNode, int pid, rbacLINQ2SQLDataContext db, string type)
        {
            Role role, exclusiverole;

            // If no exclusive role defined, error. 
            // 'Cause first role of a SOD-pair is presented, but a set of sxclusive ones - not.
            if (roleSODNode.ChildNodes.Count == 0)
                return false;

            role = db.Role.Single(x => x.Name == roleSODNode.Attributes["name"].Value
                                    && x.Policy_Id == pid);
            foreach (XmlNode exclRoleNode in roleSODNode.ChildNodes)
            {
                exclusiverole = db.Role.Single(x => x.Name == exclRoleNode.Attributes["name"].Value
                                                 && x.Policy_Id == pid);
                switch (type)
                {
                    case "DYNAMIC":
                        RBACManager.AddDynamicSOD(role, exclusiverole, db);
                        break;
                    case "STATIC":
                        RBACManager.AddStaticSOD(role, exclusiverole, db);
                        break;
                }
            }
            return true;
        }

        private static bool XMLReadUserBlock(XmlNode nodeUSERS, int pid, rbacLINQ2SQLDataContext db)
        {
            XmlNodeList userNodes = nodeUSERS.ChildNodes;
            foreach (XmlNode userNode in userNodes)
            {
                XMLReadUser(userNode, pid, db);
            }
            return true;
        }
        private static bool XMLReadUser(XmlNode userNode, int pid, rbacLINQ2SQLDataContext db)
        {
            User user;
            Role role;
            AuthUserRole authUR;

            user = new User()
            {
                Name = userNode.Attributes["name"].Value,
                Password = userNode.Attributes["password"].Value,
                Policy_Id = pid,
            };
            RBACManager.AddUser_noTryCatch(user, db);
            // Depending on our specification we could have to update an existing user
            //RBACManager.UpdateUser(user,db);

            // Get this user (just added to the database or existing in it)
            user = db.User.Single(x => x.Name == user.Name && x.Policy_Id == user.Policy_Id);

            // If there's no single AuthRoles block, error:
            if (userNode.ChildNodes.Count != 1)
            {
                return false;
            }
            XmlNode authRoleBlock = userNode.ChildNodes.Item(0);
            foreach (XmlNode authRoleNode in authRoleBlock.ChildNodes)
            {
                role = db.Role.Single(x => x.Name == authRoleNode.Attributes["name"].Value
                                                    && x.Policy_Id == pid);
                authUR = new AuthUserRole()
                {
                    User_Id = user.Id,
                    Role_Id = role.Id,                    
                };
                RBACManager.AddAssignment_noTryCatch(authUR, db);
            }

            return true;
        }

        private static bool XMLReadRoleBlock(XmlNode nodeROLES, int pid, rbacLINQ2SQLDataContext db)
        {
            XmlNodeList roleNodes = nodeROLES.ChildNodes;
            foreach (XmlNode roleNode in roleNodes)
            {
                XMLReadRole(roleNode, pid, db);
            }
            return true;
        }
        private static bool XMLReadRole(XmlNode roleNode, int pid, rbacLINQ2SQLDataContext db)
        {
            Role role;
            Permission perm;
            RolePermission rp;

            int cardinality = 0;
            if (!Int32.TryParse(roleNode.Attributes["cardinality"].Value, out cardinality))
            {
                return false;
            };
            role = new Role()
            {
                Name = roleNode.Attributes["name"].Value,
                Cardinality = cardinality,
                Policy_Id = pid,
            };
            RBACManager.AddRole_noTryCatch(role, db);
            // Depending on our specification we could have to update an existing role
            //RBACManager.UpdateRole(role,db);

            // Get this role (just added to the database or existed in it
            role = db.Role.Single(x => x.Name == role.Name && x.Policy_Id == role.Policy_Id);

            // If there's no single Permissions block, error:
            if (roleNode.ChildNodes.Count != 1)
            {
                return false;
            }
            XmlNode permBlock = roleNode.ChildNodes.Item(0);
            foreach (XmlNode permNode in permBlock.ChildNodes)
            {
                perm = db.Permission.Single(x => x.Name == permNode.Attributes["name"].Value
                                                    && x.Policy_Id == pid);
                rp = new RolePermission()
                {
                    Permission_Id = perm.Id,
                    Role_Id = role.Id
                };
                RBACManager.AddRolePermission_noTryCatch(rp, db);
            }

            return true;
        }

        private static bool XMLReadPermissionBlock(XmlNode nodePERMISSIONS, int pid, rbacLINQ2SQLDataContext db)
        {
            XmlNodeList permissionNodes = nodePERMISSIONS.ChildNodes;
            foreach (XmlNode permissionNode in permissionNodes)
            {
                XMLReadPermission(permissionNode, pid, db);
            }
            return true;
        }
        private static bool XMLReadPermission(XmlNode permissionNode, int pid, rbacLINQ2SQLDataContext db)
        {
            Permission perm;
            Action act;
            Object obj;

            perm = new Permission() { Name = permissionNode.Attributes["name"].Value, Policy_Id = pid };
            
            // If there's no single PermissionPerObject block, error:
            if (permissionNode.ChildNodes.Count != 1)
            {
                return false;
            }
            
            XmlNode ppoBlock = permissionNode.ChildNodes.Item(0);
            // If there's no PpO entry - error;
            // There may not be a permission without any (Action,Object) pair:
            if (ppoBlock.ChildNodes.Count == 0)
            {
                return false;
            }
            foreach (XmlNode ppoNode in ppoBlock.ChildNodes)
            {
                act = db.Action.Single(x => x.Name == ppoNode.Attributes["action"].Value);
                obj = db.Object.Single(x => x.Name == ppoNode.Attributes["object"].Value);
                RBACManager.AddPermission_noTryCatch(perm, act, obj, db);
            }

            return true;
        }

        private static bool XMLReadActionBlock(rbacLINQ2SQLDataContext db, XmlDocument doc)
        {
            XmlNodeList actBlock = doc.GetElementsByTagName("ACTIONS");

            // Если не указан узел ACTIONS, false
            if (actBlock.Count != 1)
                return false;

            XmlNodeList actions = actBlock.Item(0).ChildNodes;
            foreach (XmlNode act in actions)
            {
                RBACManager.AddAction_noTryCatch(new Action() { Name = act.Attributes["name"].Value },
                                                db);
            }
            return true;
        }

        private static bool XMLReadObjectBlock(rbacLINQ2SQLDataContext db, XmlDocument doc)
        {
            XmlNodeList objBlock = doc.GetElementsByTagName("OBJECTS");
            
            // Если не указаны Objects, false
            if (objBlock.Count != 1 )
                return false;

            XmlNodeList objects = objBlock.Item(0).ChildNodes;
            foreach (XmlNode obj in objects)
            {
                RBACManager.AddObject_noTryCatch(new Object() { Name = obj.Attributes["name"].Value },
                                                db);
            }
            return true;
        }
    }
}

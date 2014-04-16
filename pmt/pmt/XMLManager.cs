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
                XMLWritePolicy(policy, db, xmlWriter);
            }
            xmlWriter.WriteEndElement();
        }
        private static void XMLWritePolicy(Policy policy, rbacLINQ2SQLDataContext db, XmlWriter xmlWriter)
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
            if (role.RoleHierarchy1.Count != 0)
            {
                xmlWriter.WriteStartElement("SeniorRole");
                xmlWriter.WriteAttributeString("name", role.Name);
                foreach (RoleHierarchy rh in role.RoleHierarchy1)
                {
                    xmlWriter.WriteStartElement("JuniorRole");
                    System.Diagnostics.Debug.WriteLine(role.Name + "=" + rh.Role.Name + ":" + rh.Role.Id);
                    System.Diagnostics.Debug.WriteLine(role.Name + "->" + rh.Role1.Name + ":" + rh.Role1.Id);
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


        //
        // TODO:
        //
        public static Program.ExitCode ImportFromXML(rbacLINQ2SQLDataContext db, string fname)
        {
            try
            {
            }
            catch
            {
                return Program.ExitCode.Error;
            }
            return Program.ExitCode.Success;
        }
    }
}

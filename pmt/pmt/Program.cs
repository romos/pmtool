using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pmt
{
    static class Program
    {
        public enum ExitCode : int
        {
            Success = 0,
            Error = 1,
            ElementExists = 2,
            ElementDoesNotExists = 3,
            TransactAbort = 5,
            //Ppo_exists = 100, //can be used for AddPermission Functionality
            //HasAssigned = 4
        };
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }


    /*
     * Список таблиц базы данных в MainForm->cb_Tables
        Action
        ActiveRole
        AuthUserRole
        DynamicSOD
        Object
        Permission
        PermissionPerObject
        Policy
        Role
        RoleHierarchy
        RolePermission
        Session
        StaticSOD
        User
     * */
}

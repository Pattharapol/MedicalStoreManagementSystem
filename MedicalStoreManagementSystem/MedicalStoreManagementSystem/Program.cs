using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using MedicalStoreManagementSystem.Forms;
using MedicalStoreManagementSystem.Code;
using MedicalStoreManagementSystem.Forms.AuthenticationForms;

namespace MedicalStoreManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseInitializer.RegisterAdmin();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            //Application.Run(new frm_UserLoginForm2());
            Application.Run(new frm_MainForm());
        }
    }
}

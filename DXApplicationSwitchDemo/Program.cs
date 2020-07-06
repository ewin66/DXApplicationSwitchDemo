using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace DXApplicationSwitchDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledExceptionHandler);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);


            Application.Run(new FormMain());

        }
        static void CurrentDomain_UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception unhandledException = (Exception)args.ExceptionObject;
            ////Console.WriteLine("UnhandledExceptionHandler caught : " + unhandledException.Message);
            throw new NotImplementedException();
            //Application.Restart();
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs args)
        {
            Exception threadException = (Exception)args.Exception;
            //throw new NotImplementedException();
            ////Application.Restart();
        }

    }
}

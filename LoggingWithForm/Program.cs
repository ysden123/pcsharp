using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StulSoft.PCSharp.LoggingWithForm
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Load config
            log4net.Config.XmlConfigurator.Configure();
            
            log.Info("Info");
            log.Debug("Debug");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using log4net.Config;

[assembly: log4net.Config.XmlConfigurator(ConfigFile="log4net.cfg.xml", ConfigFileExtension="xml", Watch=true)]

namespace Mikadocs.OEE.DataEntry
{    
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log.Debug("Starting application");

            System.Threading.Thread.CurrentThread.CurrentUICulture =
                System.Globalization.CultureInfo.GetCultureInfo("da-DK");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataEntryForm());
        }
    }
}

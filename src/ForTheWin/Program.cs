using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ForTheWin
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
            Application.Run(new MainForm(LoadConfig()));
        }

        static DefaultConfig LoadConfig()
        {
            try
            {
                var fileName = Assembly.GetEntryAssembly().GetName().Name + ".xml";
                var xml = new XmlSerializer(typeof(DefaultConfig));
                using (var file = File.OpenRead(fileName))
                    return (DefaultConfig)xml.Deserialize(file);
            }
            catch
            {
                return new DefaultConfig();
            }
        }
    }
}

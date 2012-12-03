using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class ConfigureEpilog : ConfigureApp
    {
        readonly string fileFormat;

        public ConfigureEpilog(string serverAndPort, string fileFormat) : base(
            "Epilog",
            @"HKEY_LOCAL_MACHINE\SOFTWARE\InterSect Alliance\Epilog", 
            serverAndPort)
        {
            this.fileFormat = fileFormat;
        }

        public override void Execute()
        {
            base.Execute();

            var dir = Path.GetDirectoryName(fileFormat);
            var file = Path.GetFileName(fileFormat);

            SetString("Log", "Log0", string.Format("IISWebLog|{0}|{1}|0", dir, file));
        }

    }
}

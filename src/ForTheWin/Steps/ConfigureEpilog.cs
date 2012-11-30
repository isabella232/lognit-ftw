using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class ConfigureEpilog : ConfigureApp
    {
        public ConfigureEpilog(string serverAndPort) : base(
            "Epilog",
            @"HKEY_LOCAL_MACHINE\SOFTWARE\InterSect Alliance\Epilog", 
            serverAndPort)
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class ConfigureSnare : ConfigureApp
    {
        public ConfigureSnare(string serverAndPort)
            : base(
            "Snare", 
            @"HKEY_LOCAL_MACHINE\SOFTWARE\InterSect Alliance\AuditService", 
            serverAndPort)
        {
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ForTheWin
{
    [XmlRoot("Default")]
    public class DefaultConfig
    {
        [XmlElement]
        public string LognitHost { get; set; }
        [XmlElement]
        public string IISLogPath { get; set; }

        public DefaultConfig()
        {
            this.LognitHost = "localhost:5140";
            this.IISLogPath = @"C:\inetpub\logs\LogFiles\W3SVC1\u_ex%.log";
        }
    }
}

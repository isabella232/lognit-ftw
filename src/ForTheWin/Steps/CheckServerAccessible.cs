using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ForTheWin.Steps
{
    public class CheckServerAccessible : IStep
    {
        readonly string serverAndPort;

        public CheckServerAccessible(string serverAndPort)
        {
            this.serverAndPort = serverAndPort;
        }

        public void Execute()
        {
            var parts = serverAndPort.Split(':');
            var tcp = new TcpClient(parts[0], int.Parse(parts[1]));
            tcp.Close();
        }

        public string Title
        {
            get { return "Checking Lognit server connectivity"; }
        }
    }
}

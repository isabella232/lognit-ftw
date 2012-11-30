using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class InstallApp : IStep
    {
        readonly string name;
        readonly byte[] executable;

        public InstallApp(string name, byte[] executable)
        {
            this.name = name;
            this.executable = executable;
        }

        public string Title
        {
            get { return string.Format("Installing {0}", name); }
        }

        public void Execute()
        {
            var filename = Path.GetTempFileName() + ".exe";

            try
            {
                File.WriteAllBytes(filename, executable);

                var psi = new ProcessStartInfo(filename, "/verysilent")
                {
                    UseShellExecute = false
                };

                Process process = new Process();
                process.StartInfo = psi;
                process.Start();
                if (!process.WaitForExit(10000))
                    throw new StepException("Install process timed out: 10 seconds");

                if (process.ExitCode != 0)
                    throw new StepException("Install process failed with exit code: " + process.ExitCode);
            }
            finally
            {
                File.Delete(filename);
            }
        }
    }
}

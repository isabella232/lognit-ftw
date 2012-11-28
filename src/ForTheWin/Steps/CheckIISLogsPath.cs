using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class CheckIISLogsPath : IStep
    {
        private string fileFormat;
        private string directory;
        
        public CheckIISLogsPath(string directory, string fileFormat)
        {
            this.directory = directory;
            this.fileFormat = fileFormat;
        }

        public string Execute()
        {
            var file = fileFormat.Replace("%", DateTime.Today.ToString("yyMMdd"));
            var fullFile = Path.Combine(directory, file);

            if (!File.Exists(directory))
                throw new StepException(string.Format("Could not find directory '{0}'. The IIS server never logged anything in this path. Usually indicates your configuration is wrong.", fullFile));

            if (!File.Exists(fullFile))
                throw new StepException(string.Format("Could not find a file '{0}'. The IIS logging configuration may be wrong or the server did not receive any request today.", fullFile));

            return string.Format("The file '{0}' exists.", fullFile);
        }

        public string Title
        {
            get { return "Check IIS log path configuration"; }
        }

        public string Description
        {
            get { return "Checks whether IIS is logging at the configured path and if there is a file with today's configuration."; }
        }
    }
}

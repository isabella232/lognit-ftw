using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class CheckIISLogsPath : IStep
    {
        readonly string fileFormat;
        
        public CheckIISLogsPath(string fileFormat)
        {
            this.fileFormat = fileFormat;
        }

        public void Execute()
        {
            var fullFile = fileFormat.Replace("%", DateTime.Today.ToString("yyMMdd"));
            var directory = Path.GetDirectoryName(fullFile);

            if (!Directory.Exists(directory))
                throw new StepException(string.Format("Could not find directory '{0}'. The IIS server never logged anything in this path. Usually indicates your configuration is wrong.", directory));

            if (!File.Exists(fullFile))
                throw new StepException(string.Format("Could not find a file '{0}'. The IIS logging configuration may be wrong or the server did not receive any request today.", fullFile));
        }

        public string Title
        {
            get { return "Checking IIS log path configuration"; }
        }
    }
}

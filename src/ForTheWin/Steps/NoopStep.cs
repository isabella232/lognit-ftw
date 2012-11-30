using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public class NoopStep : IStep
    {
        public string Title
        {
            get { return "Some text that describes a requirement"; }
        }

        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}

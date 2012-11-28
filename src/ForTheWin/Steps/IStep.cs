using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    public interface IStep
    {
        string Title { get; }
        string Description { get; }
        string Execute();
    }
}

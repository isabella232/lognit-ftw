using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForTheWin.Steps
{
    [Serializable]
    public class StepException : Exception
    {
        public StepException() { }
        public StepException(string message) : base(message) { }
        public StepException(string message, Exception inner) : base(message, inner) { }
        protected StepException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}

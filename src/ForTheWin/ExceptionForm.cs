using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForTheWin
{
    public partial class ExceptionForm : Form
    {
        public ExceptionForm()
            : this(
                "System.Exceptions.ExceptionTypeException",
                "Some import thing that should happen just didn't, maybe you should do something about this.",
                "Some import thing that should happen just didn't, maybe you should do something about this.") { }

        public ExceptionForm(Exception e)
            : this(e.GetType().FullName, e.Message, e.ToString()) { }

        public ExceptionForm(string type, string message, string stacktrace)
        {
            InitializeComponent();
            header.BindHandleTo(this);
            this.typeLabel.Text = type;
            this.messageBox.Text = message;
            this.stacktraceBox.Text = stacktrace;
        }
    }
}

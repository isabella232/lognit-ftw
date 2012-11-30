using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ForTheWin
{
    public partial class HeaderBar : UserControl
    {
        public HeaderBar()
        {
            InitializeComponent();
        }

        public DraggingHandle BindHandleTo(Form form)
        {
            var handle = new DraggingHandle(form);
            handle.Bind(iconBox, backgroundPanel, this);
            return handle;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}

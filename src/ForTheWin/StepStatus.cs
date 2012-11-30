using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ForTheWin.Steps;
using System.Threading;

namespace ForTheWin
{
    public partial class StepStatus : UserControl
    {
        public event Action Complete;

        private readonly IStep step;
        private Exception lastException;

        public StepStatus()
            : this(new NoopStep())
        {
        }

        public StepStatus(IStep step)
        {
            InitializeComponent();
            this.TitleLabel.Text = step.Title;
            this.step = step;
        }

        public void Start()
        {
            new Thread(Execute).Start();
        }

        private void Execute()
        {
            this.BackColor = Color.LightGray;
            try
            {
                step.Execute();
                Do(() =>
                {
                    this.IconBox.Image = Icons.Ok;
                    this.BackColor = Color.White;
                    InvokeComplete();
                });
            }
            catch (Exception e)
            {
                lastException = e;
                Do(() =>
                {
                    this.IconBox.Image = Icons.Warning;
                    this.BackColor = Color.MistyRose;
                    detailsButton.Visible = true;
                    ignoreButton.Visible = true;
                });
            }
        }

        private void Do(Action action)
        {
            this.Invoke(action);
        }

        private void InvokeComplete()
        {
            ignoreButton.Visible = false;
            if (Complete != null)
                Complete();
        }

        private void ignoreButton_Click(object sender, EventArgs e)
        {
            InvokeComplete();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            new ExceptionForm(lastException).ShowDialog(this);
        }

    }
}

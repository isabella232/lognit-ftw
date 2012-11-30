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
            Thread thread = new Thread(() =>
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
                    Do(() =>
                    {
                        this.IconBox.Image = Icons.Warning;
                        this.BackColor = Color.MistyRose;
                        detailsButton.Visible = true;
                        ignoreButton.Visible = true;
                    });
                }
            });

            thread.Start();
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

        }

    }
}

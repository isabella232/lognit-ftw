namespace ForTheWin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stepStatus1 = new ForTheWin.StepStatus();
            this.stepStatus2 = new ForTheWin.StepStatus();
            this.stepStatus3 = new ForTheWin.StepStatus();
            this.stepStatus4 = new ForTheWin.StepStatus();
            this.headerBar1 = new ForTheWin.HeaderBar();
            this.SuspendLayout();
            // 
            // stepStatus1
            // 
            this.stepStatus1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepStatus1.BackColor = System.Drawing.Color.White;
            this.stepStatus1.Location = new System.Drawing.Point(0, 48);
            this.stepStatus1.Name = "stepStatus1";
            this.stepStatus1.Size = new System.Drawing.Size(695, 88);
            this.stepStatus1.TabIndex = 0;
            // 
            // stepStatus2
            // 
            this.stepStatus2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepStatus2.BackColor = System.Drawing.Color.White;
            this.stepStatus2.Location = new System.Drawing.Point(-2, 142);
            this.stepStatus2.Name = "stepStatus2";
            this.stepStatus2.Size = new System.Drawing.Size(695, 88);
            this.stepStatus2.TabIndex = 1;
            // 
            // stepStatus3
            // 
            this.stepStatus3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepStatus3.BackColor = System.Drawing.Color.White;
            this.stepStatus3.Location = new System.Drawing.Point(0, 236);
            this.stepStatus3.Name = "stepStatus3";
            this.stepStatus3.Size = new System.Drawing.Size(695, 88);
            this.stepStatus3.TabIndex = 2;
            // 
            // stepStatus4
            // 
            this.stepStatus4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepStatus4.BackColor = System.Drawing.Color.White;
            this.stepStatus4.Location = new System.Drawing.Point(-2, 330);
            this.stepStatus4.Name = "stepStatus4";
            this.stepStatus4.Size = new System.Drawing.Size(695, 88);
            this.stepStatus4.TabIndex = 3;
            // 
            // headerBar1
            // 
            this.headerBar1.BackColor = System.Drawing.Color.White;
            this.headerBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerBar1.BackgroundImage")));
            this.headerBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBar1.Location = new System.Drawing.Point(0, 0);
            this.headerBar1.Name = "headerBar1";
            this.headerBar1.Size = new System.Drawing.Size(693, 42);
            this.headerBar1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(693, 498);
            this.ControlBox = false;
            this.Controls.Add(this.headerBar1);
            this.Controls.Add(this.stepStatus4);
            this.Controls.Add(this.stepStatus3);
            this.Controls.Add(this.stepStatus2);
            this.Controls.Add(this.stepStatus1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private StepStatus stepStatus1;
        private StepStatus stepStatus2;
        private StepStatus stepStatus3;
        private StepStatus stepStatus4;
        private HeaderBar headerBar1;
    }
}


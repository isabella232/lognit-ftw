namespace ForTheWin
{
    partial class StepStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepStatus));
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ignoreButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IconBox
            // 
            this.IconBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(0, 0);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(24, 27);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconBox.TabIndex = 0;
            this.IconBox.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(30, 7);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(190, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Some text that describes a requirement";
            // 
            // ignoreButton
            // 
            this.ignoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ignoreButton.BackColor = System.Drawing.Color.White;
            this.ignoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ignoreButton.Image = ((System.Drawing.Image)(resources.GetObject("ignoreButton.Image")));
            this.ignoreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ignoreButton.Location = new System.Drawing.Point(230, 0);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.Size = new System.Drawing.Size(69, 27);
            this.ignoreButton.TabIndex = 3;
            this.ignoreButton.Text = "Ignore";
            this.ignoreButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ignoreButton.UseVisualStyleBackColor = false;
            this.ignoreButton.Visible = false;
            this.ignoreButton.Click += new System.EventHandler(this.ignoreButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsButton.BackColor = System.Drawing.Color.White;
            this.detailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsButton.Image = ((System.Drawing.Image)(resources.GetObject("detailsButton.Image")));
            this.detailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailsButton.Location = new System.Drawing.Point(305, 0);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(27, 27);
            this.detailsButton.TabIndex = 4;
            this.detailsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailsButton.UseVisualStyleBackColor = false;
            this.detailsButton.Visible = false;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // StepStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.IconBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "StepStatus";
            this.Size = new System.Drawing.Size(332, 27);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ignoreButton;
        private System.Windows.Forms.Button detailsButton;
    }
}

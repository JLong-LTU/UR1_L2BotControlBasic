namespace L2BotControlBasic
{
    partial class Form1
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
            this.directionLabel = new System.Windows.Forms.Label();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.coastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directionLabel
            // 
            this.directionLabel.AutoSize = true;
            this.directionLabel.Location = new System.Drawing.Point(13, 13);
            this.directionLabel.Name = "directionLabel";
            this.directionLabel.Size = new System.Drawing.Size(136, 17);
            this.directionLabel.TabIndex = 0;
            this.directionLabel.Text = "Direction: Pending...";
            // 
            // forwardBtn
            // 
            this.forwardBtn.Location = new System.Drawing.Point(296, 86);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(156, 57);
            this.forwardBtn.TabIndex = 1;
            this.forwardBtn.Text = "Forward";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(296, 239);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(156, 57);
            this.reverseButton.TabIndex = 2;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(483, 160);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(156, 57);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(113, 160);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(156, 57);
            this.leftButton.TabIndex = 4;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // coastButton
            // 
            this.coastButton.Location = new System.Drawing.Point(296, 160);
            this.coastButton.Name = "coastButton";
            this.coastButton.Size = new System.Drawing.Size(156, 57);
            this.coastButton.TabIndex = 5;
            this.coastButton.Text = "Coast";
            this.coastButton.UseVisualStyleBackColor = true;
            this.coastButton.Click += new System.EventHandler(this.coastButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.coastButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.directionLabel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Basic L2Bot Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label directionLabel;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button coastButton;
    }
}


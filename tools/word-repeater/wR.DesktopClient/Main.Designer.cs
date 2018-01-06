namespace wR.DesktopClient
{
    partial class Main
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
            this.englishTextBox = new System.Windows.Forms.TextBox();
            this.germanTextBox = new System.Windows.Forms.TextBox();
            this.englishLabel = new System.Windows.Forms.Label();
            this.germanLabel = new System.Windows.Forms.Label();
            this.decisionButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // englishTextBox
            // 
            this.englishTextBox.Location = new System.Drawing.Point(12, 92);
            this.englishTextBox.Name = "englishTextBox";
            this.englishTextBox.Size = new System.Drawing.Size(250, 22);
            this.englishTextBox.TabIndex = 0;
            // 
            // germanTextBox
            // 
            this.germanTextBox.Location = new System.Drawing.Point(310, 92);
            this.germanTextBox.Name = "germanTextBox";
            this.germanTextBox.Size = new System.Drawing.Size(250, 22);
            this.germanTextBox.TabIndex = 1;
            // 
            // englishLabel
            // 
            this.englishLabel.AutoSize = true;
            this.englishLabel.Location = new System.Drawing.Point(12, 72);
            this.englishLabel.Name = "englishLabel";
            this.englishLabel.Size = new System.Drawing.Size(54, 17);
            this.englishLabel.TabIndex = 2;
            this.englishLabel.Text = "English";
            // 
            // germanLabel
            // 
            this.germanLabel.AutoSize = true;
            this.germanLabel.Location = new System.Drawing.Point(307, 72);
            this.germanLabel.Name = "germanLabel";
            this.germanLabel.Size = new System.Drawing.Size(59, 17);
            this.germanLabel.TabIndex = 3;
            this.germanLabel.Text = "German";
            // 
            // decisionButton
            // 
            this.decisionButton.Location = new System.Drawing.Point(381, 375);
            this.decisionButton.Name = "decisionButton";
            this.decisionButton.Size = new System.Drawing.Size(179, 40);
            this.decisionButton.TabIndex = 4;
            this.decisionButton.Text = "Next";
            this.decisionButton.UseVisualStyleBackColor = true;
            this.decisionButton.Click += new System.EventHandler(this.decisionButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(407, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Meaning Retained?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 427);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.decisionButton);
            this.Controls.Add(this.germanLabel);
            this.Controls.Add(this.englishLabel);
            this.Controls.Add(this.germanTextBox);
            this.Controls.Add(this.englishTextBox);
            this.Name = "Main";
            this.Text = "ML Word Repeater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.TextBox germanTextBox;
        private System.Windows.Forms.Label englishLabel;
        private System.Windows.Forms.Label germanLabel;
        private System.Windows.Forms.Button decisionButton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


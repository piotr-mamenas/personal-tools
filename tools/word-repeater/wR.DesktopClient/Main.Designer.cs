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
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DecisionButton = new System.Windows.Forms.Button();
            this.MeaningRetained = new System.Windows.Forms.CheckBox();
            this.ChosenDestination = new System.Windows.Forms.ComboBox();
            this.ChosenSource = new System.Windows.Forms.ComboBox();
            this.ChosenPairLabel = new System.Windows.Forms.Label();
            this.FlipCheckbox = new System.Windows.Forms.CheckBox();
            this.ConfigurationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(15, 253);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(250, 22);
            this.SourceTextBox.TabIndex = 0;
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(310, 253);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(250, 22);
            this.DestinationTextBox.TabIndex = 1;
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Location = new System.Drawing.Point(12, 233);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(54, 17);
            this.SourceLabel.TabIndex = 2;
            this.SourceLabel.Text = "English";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(307, 233);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(59, 17);
            this.DestinationLabel.TabIndex = 3;
            this.DestinationLabel.Text = "German";
            // 
            // DecisionButton
            // 
            this.DecisionButton.Location = new System.Drawing.Point(381, 375);
            this.DecisionButton.Name = "DecisionButton";
            this.DecisionButton.Size = new System.Drawing.Size(179, 40);
            this.DecisionButton.TabIndex = 4;
            this.DecisionButton.Text = "Next";
            this.DecisionButton.UseVisualStyleBackColor = true;
            // 
            // MeaningRetained
            // 
            this.MeaningRetained.AutoSize = true;
            this.MeaningRetained.Location = new System.Drawing.Point(407, 304);
            this.MeaningRetained.Name = "MeaningRetained";
            this.MeaningRetained.Size = new System.Drawing.Size(153, 21);
            this.MeaningRetained.TabIndex = 5;
            this.MeaningRetained.Text = "Meaning Retained?";
            this.MeaningRetained.UseVisualStyleBackColor = true;
            // 
            // ChosenDestination
            // 
            this.ChosenDestination.FormattingEnabled = true;
            this.ChosenDestination.Location = new System.Drawing.Point(191, 63);
            this.ChosenDestination.Name = "ChosenDestination";
            this.ChosenDestination.Size = new System.Drawing.Size(50, 24);
            this.ChosenDestination.TabIndex = 7;
            // 
            // ChosenSource
            // 
            this.ChosenSource.FormattingEnabled = true;
            this.ChosenSource.Location = new System.Drawing.Point(135, 63);
            this.ChosenSource.Name = "ChosenSource";
            this.ChosenSource.Size = new System.Drawing.Size(50, 24);
            this.ChosenSource.TabIndex = 8;
            this.ChosenSource.SelectedIndexChanged += new System.EventHandler(this.ChosenSource_SelectedIndexChanged);
            // 
            // ChosenPairLabel
            // 
            this.ChosenPairLabel.AutoSize = true;
            this.ChosenPairLabel.Location = new System.Drawing.Point(15, 66);
            this.ChosenPairLabel.Name = "ChosenPairLabel";
            this.ChosenPairLabel.Size = new System.Drawing.Size(101, 17);
            this.ChosenPairLabel.TabIndex = 9;
            this.ChosenPairLabel.Text = "Language Pair";
            // 
            // FlipCheckbox
            // 
            this.FlipCheckbox.AutoSize = true;
            this.FlipCheckbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FlipCheckbox.Checked = true;
            this.FlipCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FlipCheckbox.Location = new System.Drawing.Point(18, 105);
            this.FlipCheckbox.Name = "FlipCheckbox";
            this.FlipCheckbox.Size = new System.Drawing.Size(91, 21);
            this.FlipCheckbox.TabIndex = 10;
            this.FlipCheckbox.Text = "Flip Mode";
            this.FlipCheckbox.UseVisualStyleBackColor = true;
            // 
            // ConfigurationLabel
            // 
            this.ConfigurationLabel.AutoSize = true;
            this.ConfigurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ConfigurationLabel.Location = new System.Drawing.Point(13, 18);
            this.ConfigurationLabel.Name = "ConfigurationLabel";
            this.ConfigurationLabel.Size = new System.Drawing.Size(128, 25);
            this.ConfigurationLabel.TabIndex = 11;
            this.ConfigurationLabel.Text = "Configuration";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 427);
            this.Controls.Add(this.ConfigurationLabel);
            this.Controls.Add(this.FlipCheckbox);
            this.Controls.Add(this.ChosenPairLabel);
            this.Controls.Add(this.ChosenSource);
            this.Controls.Add(this.ChosenDestination);
            this.Controls.Add(this.MeaningRetained);
            this.Controls.Add(this.DecisionButton);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.DestinationTextBox);
            this.Controls.Add(this.SourceTextBox);
            this.Name = "Main";
            this.Text = "ML Word Repeater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Button DecisionButton;
        private System.Windows.Forms.CheckBox MeaningRetained;
        private System.Windows.Forms.ComboBox ChosenDestination;
        private System.Windows.Forms.ComboBox ChosenSource;
        private System.Windows.Forms.Label ChosenPairLabel;
        private System.Windows.Forms.CheckBox FlipCheckbox;
        private System.Windows.Forms.Label ConfigurationLabel;
    }
}


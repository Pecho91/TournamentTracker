namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            roundComboBox = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneLabel = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreTextBox = new TextBox();
            teamTwoScoreTextBox = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoLabel = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(30, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 47);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(250, 9);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(147, 47);
            tournamentNameLabel.TabIndex = 2;
            tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.Location = new Point(27, 79);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 3;
            roundLabel.Text = "Round";
            // 
            // roundComboBox
            // 
            roundComboBox.FormattingEnabled = true;
            roundComboBox.Location = new Point(127, 82);
            roundComboBox.Name = "roundComboBox";
            roundComboBox.Size = new Size(249, 38);
            roundComboBox.TabIndex = 6;
            roundComboBox.SelectedIndexChanged += roundComboBox_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.Location = new Point(127, 126);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(212, 41);
            unplayedOnlyCheckBox.TabIndex = 7;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(30, 207);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(346, 394);
            matchupListBox.TabIndex = 8;
            matchupListBox.SelectedIndexChanged += matchupListBox_SelectedIndexChanged;
            // 
            // teamOneLabel
            // 
            teamOneLabel.AutoSize = true;
            teamOneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneLabel.Location = new Point(420, 207);
            teamOneLabel.Name = "teamOneLabel";
            teamOneLabel.Size = new Size(165, 37);
            teamOneLabel.TabIndex = 9;
            teamOneLabel.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.Location = new Point(420, 256);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(82, 37);
            teamOneScoreLabel.TabIndex = 10;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreTextBox
            // 
            teamOneScoreTextBox.Location = new Point(508, 259);
            teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            teamOneScoreTextBox.Size = new Size(118, 35);
            teamOneScoreTextBox.TabIndex = 11;
            // 
            // teamTwoScoreTextBox
            // 
            teamTwoScoreTextBox.Location = new Point(508, 442);
            teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            teamTwoScoreTextBox.Size = new Size(118, 35);
            teamTwoScoreTextBox.TabIndex = 14;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.Location = new Point(420, 439);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(82, 37);
            teamTwoScoreLabel.TabIndex = 13;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoLabel.Location = new Point(420, 390);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(165, 37);
            teamTwoLabel.TabIndex = 12;
            teamTwoLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.Location = new Point(508, 328);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(70, 37);
            versusLabel.TabIndex = 15;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.Location = new Point(638, 325);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(112, 48);
            scoreButton.TabIndex = 16;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(777, 627);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreTextBox);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneScoreTextBox);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneLabel);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundComboBox);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label headerLabel;
        private Label tournamentNameLabel;
        private Label roundLabel;
        private ComboBox roundComboBox;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneLabel;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreTextBox;
        private TextBox teamTwoScoreTextBox;
        private Label teamTwoScoreLabel;
        private Label teamTwoLabel;
        private Label versusLabel;
        private Button scoreButton;
    }
}
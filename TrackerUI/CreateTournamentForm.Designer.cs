namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameTextBox = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeTextBox = new TextBox();
            entryFeeLabel = new Label();
            selectTeamComboBox = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentTeamsListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            removeSelectedPlayerButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(25, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(324, 47);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Tournament:";
            // 
            // tournamentNameTextBox
            // 
            tournamentNameTextBox.Location = new Point(35, 121);
            tournamentNameTextBox.Name = "tournamentNameTextBox";
            tournamentNameTextBox.Size = new Size(311, 35);
            tournamentNameTextBox.TabIndex = 13;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.Location = new Point(25, 81);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(236, 37);
            tournamentNameLabel.TabIndex = 12;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeTextBox
            // 
            entryFeeTextBox.Location = new Point(156, 192);
            entryFeeTextBox.Name = "entryFeeTextBox";
            entryFeeTextBox.Size = new Size(95, 35);
            entryFeeTextBox.TabIndex = 15;
            entryFeeTextBox.Text = "0";
            entryFeeTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.Location = new Point(25, 189);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(125, 37);
            entryFeeLabel.TabIndex = 14;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamComboBox
            // 
            selectTeamComboBox.FormattingEnabled = true;
            selectTeamComboBox.Location = new Point(35, 288);
            selectTeamComboBox.Name = "selectTeamComboBox";
            selectTeamComboBox.Size = new Size(311, 38);
            selectTeamComboBox.TabIndex = 17;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.Location = new Point(25, 248);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 16;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Location = new Point(235, 255);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(114, 30);
            createNewTeamLinkLabel.TabIndex = 18;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "create new";
            createNewTeamLinkLabel.LinkClicked += createNewTeamLinkLabel_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.Location = new Point(99, 346);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(196, 48);
            addTeamButton.TabIndex = 19;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(99, 411);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(196, 48);
            createPrizeButton.TabIndex = 20;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 30;
            tournamentTeamsListBox.Location = new Point(411, 121);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(346, 184);
            tournamentTeamsListBox.TabIndex = 21;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.Location = new Point(411, 81);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(198, 37);
            tournamentPlayersLabel.TabIndex = 22;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // removeSelectedPlayerButton
            // 
            removeSelectedPlayerButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPlayerButton.Location = new Point(763, 121);
            removeSelectedPlayerButton.Name = "removeSelectedPlayerButton";
            removeSelectedPlayerButton.Size = new Size(112, 71);
            removeSelectedPlayerButton.TabIndex = 23;
            removeSelectedPlayerButton.Text = "Remove Selected";
            removeSelectedPlayerButton.UseVisualStyleBackColor = true;
            removeSelectedPlayerButton.Click += removeSelectedPlayerButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPrizeButton.Location = new Point(763, 365);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(112, 71);
            removeSelectedPrizeButton.TabIndex = 26;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.Location = new Point(411, 325);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(85, 37);
            prizesLabel.TabIndex = 25;
            prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(411, 365);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(346, 184);
            prizesListBox.TabIndex = 24;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(307, 576);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(297, 68);
            createTournamentButton.TabIndex = 27;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(910, 674);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(removeSelectedPlayerButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLinkLabel);
            Controls.Add(selectTeamComboBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeTextBox);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameTextBox);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameTextBox;
        private Label tournamentNameLabel;
        private TextBox entryFeeTextBox;
        private Label entryFeeLabel;
        private ComboBox selectTeamComboBox;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentTeamsListBox;
        private Label tournamentPlayersLabel;
        private Button removeSelectedPlayerButton;
        private Button removeSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}
namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameTextBox = new TextBox();
            teamNameLabel = new Label();
            selectTeamMemberLabel = new Label();
            addMemberButton = new Button();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellPhoneTextBox = new TextBox();
            cellPhoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMemberButton = new Button();
            createTeamButton = new Button();
            selectTeamMemberComboBox = new ComboBox();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(30, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(211, 47);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Create Team";
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.Location = new Point(40, 115);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(382, 35);
            teamNameTextBox.TabIndex = 15;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.Location = new Point(30, 75);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(157, 37);
            teamNameLabel.TabIndex = 14;
            teamNameLabel.Text = "Team Name";
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.Location = new Point(30, 168);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(263, 37);
            selectTeamMemberLabel.TabIndex = 16;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            addMemberButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.Location = new Point(133, 261);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(196, 48);
            addMemberButton.TabIndex = 20;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellPhoneTextBox);
            addNewMemberGroupBox.Controls.Add(cellPhoneLabel);
            addNewMemberGroupBox.Controls.Add(emailTextBox);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameTextBox);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameTextBox);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberGroupBox.Location = new Point(40, 336);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(397, 354);
            addNewMemberGroupBox.TabIndex = 21;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.Location = new Point(93, 286);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(196, 48);
            createMemberButton.TabIndex = 28;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellPhoneTextBox
            // 
            cellPhoneTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            cellPhoneTextBox.Location = new Point(156, 230);
            cellPhoneTextBox.Name = "cellPhoneTextBox";
            cellPhoneTextBox.Size = new Size(226, 35);
            cellPhoneTextBox.TabIndex = 19;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cellPhoneLabel.Location = new Point(6, 227);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(144, 37);
            cellPhoneLabel.TabIndex = 18;
            cellPhoneLabel.Text = "Cell Phone";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(156, 177);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(226, 35);
            emailTextBox.TabIndex = 17;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(55, 174);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(156, 118);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(226, 35);
            lastNameTextBox.TabIndex = 15;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(6, 115);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 14;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(156, 65);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(226, 35);
            firstNameTextBox.TabIndex = 13;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(6, 62);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 30;
            teamMembersListBox.Location = new Point(498, 115);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(346, 574);
            teamMembersListBox.TabIndex = 22;
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedMemberButton.Location = new Point(850, 115);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(112, 71);
            removeSelectedMemberButton.TabIndex = 27;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.Location = new Point(348, 713);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(297, 68);
            createTeamButton.TabIndex = 28;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberComboBox
            // 
            selectTeamMemberComboBox.FormattingEnabled = true;
            selectTeamMemberComboBox.Location = new Point(40, 208);
            selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            selectTeamMemberComboBox.Size = new Size(382, 38);
            selectTeamMemberComboBox.TabIndex = 29;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(992, 810);
            Controls.Add(selectTeamMemberComboBox);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameTextBox);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox teamNameTextBox;
        private Label teamNameLabel;
        private Label selectTeamMemberLabel;
        private Button addMemberButton;
        private GroupBox addNewMemberGroupBox;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private TextBox cellPhoneTextBox;
        private Label cellPhoneLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberButton;
        private Button createTeamButton;
        private ComboBox selectTeamMemberComboBox;
    }
}
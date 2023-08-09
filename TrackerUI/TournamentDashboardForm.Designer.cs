namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            loadExistingTournamentComboBox = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(63, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(387, 47);
            headerLabel.TabIndex = 5;
            headerLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentComboBox
            // 
            loadExistingTournamentComboBox.FormattingEnabled = true;
            loadExistingTournamentComboBox.Location = new Point(65, 127);
            loadExistingTournamentComboBox.Name = "loadExistingTournamentComboBox";
            loadExistingTournamentComboBox.Size = new Size(382, 38);
            loadExistingTournamentComboBox.TabIndex = 31;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.Location = new Point(95, 87);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(322, 37);
            loadExistingTournamentLabel.TabIndex = 30;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.Location = new Point(149, 186);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(214, 54);
            loadTournamentButton.TabIndex = 32;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.Location = new Point(108, 272);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(297, 68);
            createTournamentButton.TabIndex = 33;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(512, 372);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentComboBox);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournamnt Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentComboBox;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
    }
}
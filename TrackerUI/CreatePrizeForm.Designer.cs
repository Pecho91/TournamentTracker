namespace TrackerUI
{
    partial class CreatePrizeForm
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
            placeNumberTextBox = new TextBox();
            placeNumberLabel = new Label();
            prizePercentageTextBox = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountTextBox = new TextBox();
            prizeAmountLabel = new Label();
            placeNameTextBox = new TextBox();
            placeNameLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(35, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(204, 47);
            headerLabel.TabIndex = 4;
            headerLabel.Text = "Create Prize";
            // 
            // placeNumberTextBox
            // 
            placeNumberTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberTextBox.Location = new Point(224, 88);
            placeNumberTextBox.Name = "placeNumberTextBox";
            placeNumberTextBox.Size = new Size(226, 35);
            placeNumberTextBox.TabIndex = 15;
            placeNumberTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.Location = new Point(35, 85);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 14;
            placeNumberLabel.Text = "Place Number";
            // 
            // prizePercentageTextBox
            // 
            prizePercentageTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageTextBox.Location = new Point(253, 319);
            prizePercentageTextBox.Name = "prizePercentageTextBox";
            prizePercentageTextBox.Size = new Size(197, 35);
            prizePercentageTextBox.TabIndex = 17;
            prizePercentageTextBox.Text = "0";
            prizePercentageTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.Location = new Point(35, 316);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 16;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountTextBox
            // 
            prizeAmountTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountTextBox.Location = new Point(224, 196);
            prizeAmountTextBox.Name = "prizeAmountTextBox";
            prizeAmountTextBox.Size = new Size(226, 35);
            prizeAmountTextBox.TabIndex = 19;
            prizeAmountTextBox.Text = "0";
            prizeAmountTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.Location = new Point(35, 193);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 18;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameTextBox
            // 
            placeNameTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameTextBox.Location = new Point(224, 142);
            placeNameTextBox.Name = "placeNameTextBox";
            placeNameTextBox.Size = new Size(226, 35);
            placeNameTextBox.TabIndex = 21;
            placeNameTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.Location = new Point(54, 139);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 20;
            placeNameLabel.Text = "Place Name";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.Location = new Point(201, 247);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(64, 37);
            orLabel.TabIndex = 22;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.Location = new Point(105, 386);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(297, 68);
            createPrizeButton.TabIndex = 29;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(507, 486);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(placeNameTextBox);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountTextBox);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizePercentageTextBox);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNumberTextBox);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox placeNumberTextBox;
        private Label placeNumberLabel;
        private TextBox prizePercentageTextBox;
        private Label prizePercentageLabel;
        private TextBox prizeAmountTextBox;
        private Label prizeAmountLabel;
        private TextBox placeNameTextBox;
        private Label placeNameLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}
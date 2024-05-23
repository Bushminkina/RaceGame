namespace Race
{
    partial class userNameForm
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
            userNamePanel = new Panel();
            enterNameLabel = new Label();
            nameTextBox = new TextBox();
            enterButton = new Button();
            raceLabel = new Label();
            userNamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // userNamePanel
            // 
            userNamePanel.BackColor = SystemColors.ControlDarkDark;
            userNamePanel.Controls.Add(enterNameLabel);
            userNamePanel.Controls.Add(nameTextBox);
            userNamePanel.Controls.Add(enterButton);
            userNamePanel.Controls.Add(raceLabel);
            userNamePanel.Location = new Point(2, 1);
            userNamePanel.Margin = new Padding(4);
            userNamePanel.Name = "userNamePanel";
            userNamePanel.Size = new Size(242, 181);
            userNamePanel.TabIndex = 58;
            // 
            // enterNameLabel
            // 
            enterNameLabel.AutoSize = true;
            enterNameLabel.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            enterNameLabel.ForeColor = SystemColors.Window;
            enterNameLabel.Location = new Point(23, 65);
            enterNameLabel.Name = "enterNameLabel";
            enterNameLabel.Size = new Size(133, 28);
            enterNameLabel.TabIndex = 87;
            enterNameLabel.Text = "Enter name";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(23, 96);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(193, 23);
            nameTextBox.TabIndex = 86;
            // 
            // enterButton
            // 
            enterButton.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            enterButton.Location = new Point(74, 134);
            enterButton.Margin = new Padding(4);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(92, 28);
            enterButton.TabIndex = 85;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = true;
            enterButton.Click += EnterButton_Click;
            // 
            // raceLabel
            // 
            raceLabel.BackColor = Color.FromArgb(64, 64, 64);
            raceLabel.Font = new Font("Microsoft Tai Le", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            raceLabel.ForeColor = SystemColors.Control;
            raceLabel.Location = new Point(0, 0);
            raceLabel.Margin = new Padding(4, 0, 4, 0);
            raceLabel.Name = "raceLabel";
            raceLabel.Size = new Size(110, 47);
            raceLabel.TabIndex = 66;
            raceLabel.Text = "Race";
            // 
            // userNameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 176);
            Controls.Add(userNamePanel);
            Name = "userNameForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Enter name";
            userNamePanel.ResumeLayout(false);
            userNamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel userNamePanel;
        private Button enterButton;
        private Label raceLabel;
        private TextBox nameTextBox;
        private Label enterNameLabel;
    }
}
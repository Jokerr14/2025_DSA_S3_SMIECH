namespace DSaA_Project_TimeTracker
{
    partial class userForm
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
            helpButton = new Button();
            userNameLabel = new Label();
            userTasksListBox = new ListBox();
            SuspendLayout();
            // 
            // helpButton
            // 
            helpButton.Location = new Point(551, 30);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(75, 23);
            helpButton.TabIndex = 0;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(258, 34);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(89, 15);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "userNameLabel";
            // 
            // userTasksListBox
            // 
            userTasksListBox.FormattingEnabled = true;
            userTasksListBox.ItemHeight = 15;
            userTasksListBox.Location = new Point(22, 83);
            userTasksListBox.Name = "userTasksListBox";
            userTasksListBox.Size = new Size(604, 334);
            userTasksListBox.TabIndex = 2;
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 450);
            Controls.Add(userTasksListBox);
            Controls.Add(userNameLabel);
            Controls.Add(helpButton);
            Name = "userForm";
            Text = "userForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button helpButton;
        private Label userNameLabel;
        private ListBox userTasksListBox;
    }
}
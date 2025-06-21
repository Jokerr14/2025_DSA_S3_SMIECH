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
            label1 = new Label();
            SuspendLayout();
            // 
            // helpButton
            // 
            helpButton.Location = new Point(630, 40);
            helpButton.Margin = new Padding(3, 4, 3, 4);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(86, 31);
            helpButton.TabIndex = 0;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(295, 45);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(112, 20);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "userNameLabel";
            // 
            // userTasksListBox
            // 
            userTasksListBox.FormattingEnabled = true;
            userTasksListBox.Location = new Point(25, 111);
            userTasksListBox.Margin = new Padding(3, 4, 3, 4);
            userTasksListBox.Name = "userTasksListBox";
            userTasksListBox.Size = new Size(690, 444);
            userTasksListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 87);
            label1.Name = "label1";
            label1.Size = new Size(437, 20);
            label1.TabIndex = 3;
            label1.Text = "The selected employee has the following tasks assigned to them:";
            // 
            // userForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 600);
            Controls.Add(label1);
            Controls.Add(userTasksListBox);
            Controls.Add(userNameLabel);
            Controls.Add(helpButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "userForm";
            Text = "userForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button helpButton;
        private Label userNameLabel;
        private ListBox userTasksListBox;
        private Label label1;
    }
}
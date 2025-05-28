namespace DSaA_Project_TimeTracker
{
    partial class AssignUnassignTeamToProject
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
            unassignTeamFromProjectPanel = new Panel();
            unassignTeamLabel = new Label();
            label5 = new Label();
            cancelUnassignButton = new Button();
            label6 = new Label();
            unassignCheckedListBox = new CheckedListBox();
            helpUnassignButton = new Button();
            removeButton = new Button();
            assignTeamToProjectPanel = new Panel();
            assignTeamLabel = new Label();
            label2 = new Label();
            cancelAssignButton = new Button();
            label1 = new Label();
            assignCheckedListBox = new CheckedListBox();
            helpAssignButton = new Button();
            assignButton = new Button();
            unassignTeamFromProjectPanel.SuspendLayout();
            assignTeamToProjectPanel.SuspendLayout();
            SuspendLayout();
            // 
            // unassignTeamFromProjectPanel
            // 
            unassignTeamFromProjectPanel.Controls.Add(unassignTeamLabel);
            unassignTeamFromProjectPanel.Controls.Add(label5);
            unassignTeamFromProjectPanel.Controls.Add(cancelUnassignButton);
            unassignTeamFromProjectPanel.Controls.Add(label6);
            unassignTeamFromProjectPanel.Controls.Add(unassignCheckedListBox);
            unassignTeamFromProjectPanel.Controls.Add(helpUnassignButton);
            unassignTeamFromProjectPanel.Controls.Add(removeButton);
            unassignTeamFromProjectPanel.Location = new Point(12, 12);
            unassignTeamFromProjectPanel.Name = "unassignTeamFromProjectPanel";
            unassignTeamFromProjectPanel.Size = new Size(546, 623);
            unassignTeamFromProjectPanel.TabIndex = 0;
            // 
            // unassignTeamLabel
            // 
            unassignTeamLabel.AutoSize = true;
            unassignTeamLabel.Location = new Point(190, 76);
            unassignTeamLabel.Name = "unassignTeamLabel";
            unassignTeamLabel.Size = new Size(121, 15);
            unassignTeamLabel.TabIndex = 21;
            unassignTeamLabel.Text = "the name of the team";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(132, 27);
            label5.Name = "label5";
            label5.Size = new Size(294, 30);
            label5.TabIndex = 20;
            label5.Text = "Remove Team from Project/s";
            // 
            // cancelUnassignButton
            // 
            cancelUnassignButton.Location = new Point(299, 559);
            cancelUnassignButton.Name = "cancelUnassignButton";
            cancelUnassignButton.Size = new Size(213, 36);
            cancelUnassignButton.TabIndex = 19;
            cancelUnassignButton.Text = "Cancel";
            cancelUnassignButton.UseVisualStyleBackColor = true;
            cancelUnassignButton.Click += cancelUnassignButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 133);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 18;
            label6.Text = "Choose project/s";
            // 
            // unassignCheckedListBox
            // 
            unassignCheckedListBox.FormattingEnabled = true;
            unassignCheckedListBox.Location = new Point(90, 151);
            unassignCheckedListBox.Name = "unassignCheckedListBox";
            unassignCheckedListBox.Size = new Size(350, 364);
            unassignCheckedListBox.TabIndex = 17;
            // 
            // helpUnassignButton
            // 
            helpUnassignButton.Location = new Point(461, 27);
            helpUnassignButton.Name = "helpUnassignButton";
            helpUnassignButton.Size = new Size(51, 36);
            helpUnassignButton.TabIndex = 16;
            helpUnassignButton.Text = "Help";
            helpUnassignButton.UseVisualStyleBackColor = true;
            helpUnassignButton.Click += helpUnassignButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(35, 559);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(213, 36);
            removeButton.TabIndex = 15;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // assignTeamToProjectPanel
            // 
            assignTeamToProjectPanel.Controls.Add(assignTeamLabel);
            assignTeamToProjectPanel.Controls.Add(label2);
            assignTeamToProjectPanel.Controls.Add(cancelAssignButton);
            assignTeamToProjectPanel.Controls.Add(label1);
            assignTeamToProjectPanel.Controls.Add(assignCheckedListBox);
            assignTeamToProjectPanel.Controls.Add(helpAssignButton);
            assignTeamToProjectPanel.Controls.Add(assignButton);
            assignTeamToProjectPanel.Location = new Point(12, 12);
            assignTeamToProjectPanel.Name = "assignTeamToProjectPanel";
            assignTeamToProjectPanel.Size = new Size(546, 623);
            assignTeamToProjectPanel.TabIndex = 1;
            // 
            // assignTeamLabel
            // 
            assignTeamLabel.AutoSize = true;
            assignTeamLabel.Location = new Point(187, 73);
            assignTeamLabel.Name = "assignTeamLabel";
            assignTeamLabel.Size = new Size(121, 15);
            assignTeamLabel.TabIndex = 14;
            assignTeamLabel.Text = "the name of the team";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(129, 24);
            label2.Name = "label2";
            label2.Size = new Size(250, 30);
            label2.TabIndex = 13;
            label2.Text = "Assign Team to Project/s";
            // 
            // cancelAssignButton
            // 
            cancelAssignButton.Location = new Point(296, 556);
            cancelAssignButton.Name = "cancelAssignButton";
            cancelAssignButton.Size = new Size(213, 36);
            cancelAssignButton.TabIndex = 12;
            cancelAssignButton.Text = "Cancel";
            cancelAssignButton.UseVisualStyleBackColor = true;
            cancelAssignButton.Click += cancelAssignButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 130);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 11;
            label1.Text = "Choose project/s";
            // 
            // assignCheckedListBox
            // 
            assignCheckedListBox.FormattingEnabled = true;
            assignCheckedListBox.Location = new Point(87, 148);
            assignCheckedListBox.Name = "assignCheckedListBox";
            assignCheckedListBox.Size = new Size(350, 364);
            assignCheckedListBox.TabIndex = 10;
            // 
            // helpAssignButton
            // 
            helpAssignButton.Location = new Point(458, 24);
            helpAssignButton.Name = "helpAssignButton";
            helpAssignButton.Size = new Size(51, 36);
            helpAssignButton.TabIndex = 9;
            helpAssignButton.Text = "help";
            helpAssignButton.UseVisualStyleBackColor = true;
            helpAssignButton.Click += helpAssignButton_Click;
            // 
            // assignButton
            // 
            assignButton.Location = new Point(32, 556);
            assignButton.Name = "assignButton";
            assignButton.Size = new Size(213, 36);
            assignButton.TabIndex = 8;
            assignButton.Text = "Assign";
            assignButton.UseVisualStyleBackColor = true;
            assignButton.Click += assignButton_Click;
            // 
            // AssignUnassignTeamToProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 644);
            Controls.Add(unassignTeamFromProjectPanel);
            Controls.Add(assignTeamToProjectPanel);
            Name = "AssignUnassignTeamToProject";
            Text = "AssignUnassignTeamToProject";
            unassignTeamFromProjectPanel.ResumeLayout(false);
            unassignTeamFromProjectPanel.PerformLayout();
            assignTeamToProjectPanel.ResumeLayout(false);
            assignTeamToProjectPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel unassignTeamFromProjectPanel;
        private Panel assignTeamToProjectPanel;
        private Label assignTeamLabel;
        private Label label2;
        private Button cancelAssignButton;
        private Label label1;
        private CheckedListBox assignCheckedListBox;
        private Button helpAssignButton;
        private Button assignButton;
        private Label unassignTeamLabel;
        private Label label5;
        private Button cancelUnassignButton;
        private Label label6;
        private CheckedListBox unassignCheckedListBox;
        private Button helpUnassignButton;
        private Button removeButton;
    }
}
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
            assignTeamToProjectPanel = new Panel();
            assignTeamLabel = new Label();
            label2 = new Label();
            cancelAssignButton = new Button();
            label1 = new Label();
            assignCheckedListBox = new CheckedListBox();
            helpAssignButton = new Button();
            assignButton = new Button();
            assignTeamToProjectPanel.SuspendLayout();
            SuspendLayout();
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
            helpAssignButton.Text = "Help";
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
            Controls.Add(assignTeamToProjectPanel);
            Name = "AssignUnassignTeamToProject";
            Text = "AssignUnassignTeamToProject";
            assignTeamToProjectPanel.ResumeLayout(false);
            assignTeamToProjectPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel assignTeamToProjectPanel;
        private Label assignTeamLabel;
        private Label label2;
        private Button cancelAssignButton;
        private Label label1;
        private CheckedListBox assignCheckedListBox;
        private Button helpAssignButton;
        private Button assignButton;
    }
}
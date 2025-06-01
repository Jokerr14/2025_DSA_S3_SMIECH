namespace DSaA_Project_TimeTracker
{
    partial class AssignUnassignEmployeeToTeam
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
            assignEmployeeToTeamsPanel = new Panel();
            assignTaskLabel = new Label();
            label2 = new Label();
            cancelAssignButton = new Button();
            label1 = new Label();
            assignCheckedListBox = new CheckedListBox();
            helpAssignButton = new Button();
            assignButton = new Button();
            assignEmployeeToTeamsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // assignEmployeeToTeamsPanel
            // 
            assignEmployeeToTeamsPanel.Controls.Add(assignTaskLabel);
            assignEmployeeToTeamsPanel.Controls.Add(label2);
            assignEmployeeToTeamsPanel.Controls.Add(cancelAssignButton);
            assignEmployeeToTeamsPanel.Controls.Add(label1);
            assignEmployeeToTeamsPanel.Controls.Add(assignCheckedListBox);
            assignEmployeeToTeamsPanel.Controls.Add(helpAssignButton);
            assignEmployeeToTeamsPanel.Controls.Add(assignButton);
            assignEmployeeToTeamsPanel.Location = new Point(12, 12);
            assignEmployeeToTeamsPanel.Name = "assignEmployeeToTeamsPanel";
            assignEmployeeToTeamsPanel.Size = new Size(537, 636);
            assignEmployeeToTeamsPanel.TabIndex = 1;
            // 
            // assignTaskLabel
            // 
            assignTaskLabel.AutoSize = true;
            assignTaskLabel.Location = new Point(175, 83);
            assignTaskLabel.Name = "assignTaskLabel";
            assignTaskLabel.Size = new Size(149, 15);
            assignTaskLabel.TabIndex = 28;
            assignTaskLabel.Text = "the name of the employee ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(117, 34);
            label2.Name = "label2";
            label2.Size = new Size(279, 30);
            label2.TabIndex = 27;
            label2.Text = "Assign Employee to Team/s";
            // 
            // cancelAssignButton
            // 
            cancelAssignButton.Location = new Point(284, 566);
            cancelAssignButton.Name = "cancelAssignButton";
            cancelAssignButton.Size = new Size(213, 36);
            cancelAssignButton.TabIndex = 26;
            cancelAssignButton.Text = "Cancel";
            cancelAssignButton.UseVisualStyleBackColor = true;
            cancelAssignButton.Click += cancelAssignButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 140);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 25;
            label1.Text = "Choose team/s";
            // 
            // assignCheckedListBox
            // 
            assignCheckedListBox.FormattingEnabled = true;
            assignCheckedListBox.Location = new Point(75, 158);
            assignCheckedListBox.Name = "assignCheckedListBox";
            assignCheckedListBox.Size = new Size(350, 364);
            assignCheckedListBox.TabIndex = 24;
            // 
            // helpAssignButton
            // 
            helpAssignButton.Location = new Point(446, 34);
            helpAssignButton.Name = "helpAssignButton";
            helpAssignButton.Size = new Size(51, 36);
            helpAssignButton.TabIndex = 23;
            helpAssignButton.Text = "Help";
            helpAssignButton.UseVisualStyleBackColor = true;
            helpAssignButton.Click += helpAssignButton_Click;
            // 
            // assignButton
            // 
            assignButton.Location = new Point(20, 566);
            assignButton.Name = "assignButton";
            assignButton.Size = new Size(213, 36);
            assignButton.TabIndex = 22;
            assignButton.Text = "Assign";
            assignButton.UseVisualStyleBackColor = true;
            assignButton.Click += assignButton_Click;
            // 
            // AssignUnassignEmployeeToTeam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 662);
            Controls.Add(assignEmployeeToTeamsPanel);
            Name = "AssignUnassignEmployeeToTeam";
            Text = "AssignUnassignEmployeeToTeam";
            assignEmployeeToTeamsPanel.ResumeLayout(false);
            assignEmployeeToTeamsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel assignEmployeeToTeamsPanel;
        private Label assignTaskLabel;
        private Label label2;
        private Button cancelAssignButton;
        private Label label1;
        private CheckedListBox assignCheckedListBox;
        private Button helpAssignButton;
        private Button assignButton;
    }
}
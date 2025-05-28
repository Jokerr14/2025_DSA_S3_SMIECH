namespace DSaA_Project_TimeTracker
{
    partial class AssignUnassignTaskToEmployee
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
            removeTaskFromEmployeePanel = new Panel();
            unassignTaskLabel = new Label();
            label5 = new Label();
            cancelUnassignButton = new Button();
            label6 = new Label();
            unassignCheckedListBox = new CheckedListBox();
            helpUnassignButton = new Button();
            removeButton = new Button();
            assignTaskToEmployeePanel = new Panel();
            assignTaskLabel = new Label();
            label2 = new Label();
            cancelAssignButton = new Button();
            label1 = new Label();
            assignCheckedListBox = new CheckedListBox();
            helpAssignButton = new Button();
            assignButton = new Button();
            removeTaskFromEmployeePanel.SuspendLayout();
            assignTaskToEmployeePanel.SuspendLayout();
            SuspendLayout();
            // 
            // removeTaskFromEmployeePanel
            // 
            removeTaskFromEmployeePanel.Controls.Add(unassignTaskLabel);
            removeTaskFromEmployeePanel.Controls.Add(label5);
            removeTaskFromEmployeePanel.Controls.Add(cancelUnassignButton);
            removeTaskFromEmployeePanel.Controls.Add(label6);
            removeTaskFromEmployeePanel.Controls.Add(unassignCheckedListBox);
            removeTaskFromEmployeePanel.Controls.Add(helpUnassignButton);
            removeTaskFromEmployeePanel.Controls.Add(removeButton);
            removeTaskFromEmployeePanel.Location = new Point(12, 12);
            removeTaskFromEmployeePanel.Name = "removeTaskFromEmployeePanel";
            removeTaskFromEmployeePanel.Size = new Size(520, 630);
            removeTaskFromEmployeePanel.TabIndex = 0;
            // 
            // unassignTaskLabel
            // 
            unassignTaskLabel.AutoSize = true;
            unassignTaskLabel.Location = new Point(171, 63);
            unassignTaskLabel.Name = "unassignTaskLabel";
            unassignTaskLabel.Size = new Size(115, 15);
            unassignTaskLabel.TabIndex = 28;
            unassignTaskLabel.Text = "the name of the task";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(113, 14);
            label5.Name = "label5";
            label5.Size = new Size(312, 30);
            label5.TabIndex = 27;
            label5.Text = "Remove Task from Employee/s";
            // 
            // cancelUnassignButton
            // 
            cancelUnassignButton.Location = new Point(280, 546);
            cancelUnassignButton.Name = "cancelUnassignButton";
            cancelUnassignButton.Size = new Size(213, 36);
            cancelUnassignButton.TabIndex = 26;
            cancelUnassignButton.Text = "Cancel";
            cancelUnassignButton.UseVisualStyleBackColor = true;
            cancelUnassignButton.Click += cancelUnassignButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 120);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 25;
            label6.Text = "Choose project/s";
            // 
            // unassignCheckedListBox
            // 
            unassignCheckedListBox.FormattingEnabled = true;
            unassignCheckedListBox.Location = new Point(71, 138);
            unassignCheckedListBox.Name = "unassignCheckedListBox";
            unassignCheckedListBox.Size = new Size(350, 364);
            unassignCheckedListBox.TabIndex = 24;
            // 
            // helpUnassignButton
            // 
            helpUnassignButton.Location = new Point(442, 14);
            helpUnassignButton.Name = "helpUnassignButton";
            helpUnassignButton.Size = new Size(51, 36);
            helpUnassignButton.TabIndex = 23;
            helpUnassignButton.Text = "Help";
            helpUnassignButton.UseVisualStyleBackColor = true;
            helpUnassignButton.Click += helpUnassignButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(16, 546);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(213, 36);
            removeButton.TabIndex = 22;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // assignTaskToEmployeePanel
            // 
            assignTaskToEmployeePanel.Controls.Add(assignTaskLabel);
            assignTaskToEmployeePanel.Controls.Add(label2);
            assignTaskToEmployeePanel.Controls.Add(cancelAssignButton);
            assignTaskToEmployeePanel.Controls.Add(label1);
            assignTaskToEmployeePanel.Controls.Add(assignCheckedListBox);
            assignTaskToEmployeePanel.Controls.Add(helpAssignButton);
            assignTaskToEmployeePanel.Controls.Add(assignButton);
            assignTaskToEmployeePanel.Location = new Point(12, 12);
            assignTaskToEmployeePanel.Name = "assignTaskToEmployeePanel";
            assignTaskToEmployeePanel.Size = new Size(520, 630);
            assignTaskToEmployeePanel.TabIndex = 1;
            // 
            // assignTaskLabel
            // 
            assignTaskLabel.AutoSize = true;
            assignTaskLabel.Location = new Point(175, 77);
            assignTaskLabel.Name = "assignTaskLabel";
            assignTaskLabel.Size = new Size(121, 15);
            assignTaskLabel.TabIndex = 21;
            assignTaskLabel.Text = "the name of the team";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(117, 28);
            label2.Name = "label2";
            label2.Size = new Size(268, 30);
            label2.TabIndex = 20;
            label2.Text = "Assign Task to Employee/s";
            // 
            // cancelAssignButton
            // 
            cancelAssignButton.Location = new Point(284, 560);
            cancelAssignButton.Name = "cancelAssignButton";
            cancelAssignButton.Size = new Size(213, 36);
            cancelAssignButton.TabIndex = 19;
            cancelAssignButton.Text = "Cancel";
            cancelAssignButton.UseVisualStyleBackColor = true;
            cancelAssignButton.Click += cancelAssignButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 134);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 18;
            label1.Text = "Choose project/s";
            // 
            // assignCheckedListBox
            // 
            assignCheckedListBox.FormattingEnabled = true;
            assignCheckedListBox.Location = new Point(75, 152);
            assignCheckedListBox.Name = "assignCheckedListBox";
            assignCheckedListBox.Size = new Size(350, 364);
            assignCheckedListBox.TabIndex = 17;
            // 
            // helpAssignButton
            // 
            helpAssignButton.Location = new Point(446, 28);
            helpAssignButton.Name = "helpAssignButton";
            helpAssignButton.Size = new Size(51, 36);
            helpAssignButton.TabIndex = 16;
            helpAssignButton.Text = "help";
            helpAssignButton.UseVisualStyleBackColor = true;
            helpAssignButton.Click += helpAssignButton_Click;
            // 
            // assignButton
            // 
            assignButton.Location = new Point(20, 560);
            assignButton.Name = "assignButton";
            assignButton.Size = new Size(213, 36);
            assignButton.TabIndex = 15;
            assignButton.Text = "Assign";
            assignButton.UseVisualStyleBackColor = true;
            assignButton.Click += assignButton_Click;
            // 
            // AssignUnassignTaskToEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 654);
            Controls.Add(removeTaskFromEmployeePanel);
            Controls.Add(assignTaskToEmployeePanel);
            Name = "AssignUnassignTaskToEmployee";
            Text = "AssignUnassignTaskToEmployee";
            removeTaskFromEmployeePanel.ResumeLayout(false);
            removeTaskFromEmployeePanel.PerformLayout();
            assignTaskToEmployeePanel.ResumeLayout(false);
            assignTaskToEmployeePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel removeTaskFromEmployeePanel;
        private Panel assignTaskToEmployeePanel;
        private Label unassignTaskLabel;
        private Label label5;
        private Button cancelUnassignButton;
        private Label label6;
        private CheckedListBox unassignCheckedListBox;
        private Button helpUnassignButton;
        private Button removeButton;
        private Label assignTaskLabel;
        private Label label2;
        private Button cancelAssignButton;
        private Label label1;
        private CheckedListBox assignCheckedListBox;
        private Button helpAssignButton;
        private Button assignButton;
    }
}
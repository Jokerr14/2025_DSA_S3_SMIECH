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
            assignTaskToEmployeePanel = new Panel();
            assignTaskLabel = new Label();
            label2 = new Label();
            cancelAssignButton = new Button();
            label1 = new Label();
            assignCheckedListBox = new CheckedListBox();
            helpAssignButton = new Button();
            assignButton = new Button();
            assignTaskToEmployeePanel.SuspendLayout();
            SuspendLayout();
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
            assignTaskLabel.Location = new Point(190, 77);
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
            label1.Location = new Point(54, 134);
            label1.Name = "label1";
            label1.Size = new Size(396, 15);
            label1.TabIndex = 18;
            label1.Text = "Choose which employee(s) from the assigned teams to assign this task to:";
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
            helpAssignButton.Text = "Help";
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
            Controls.Add(assignTaskToEmployeePanel);
            Name = "AssignUnassignTaskToEmployee";
            Text = "AssignUnassignTaskToEmployee";
            assignTaskToEmployeePanel.ResumeLayout(false);
            assignTaskToEmployeePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel assignTaskToEmployeePanel;
        private Label assignTaskLabel;
        private Label label2;
        private Button cancelAssignButton;
        private Label label1;
        private CheckedListBox assignCheckedListBox;
        private Button helpAssignButton;
        private Button assignButton;
    }
}
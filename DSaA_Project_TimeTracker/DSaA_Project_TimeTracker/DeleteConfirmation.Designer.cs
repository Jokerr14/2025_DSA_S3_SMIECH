namespace DSaA_Project_TimeTracker
{
    partial class DeleteConfirmation
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
            deleteProjectPanel = new Panel();
            deleteProjectFalseButton = new Button();
            deleteProjectTrueButton = new Button();
            label1 = new Label();
            deleteTaskPanel = new Panel();
            deleteTaskFalseButton = new Button();
            deleteTaskTrueButton = new Button();
            label2 = new Label();
            deleteEmployeePanel = new Panel();
            deleteEmployeeFalseButton = new Button();
            deleteEmployeeTrueButton = new Button();
            label4 = new Label();
            deleteTeamPanel = new Panel();
            deleteTeamFalseButton = new Button();
            deleteTeamTrueButton = new Button();
            label3 = new Label();
            deleteProjectPanel.SuspendLayout();
            deleteTaskPanel.SuspendLayout();
            deleteEmployeePanel.SuspendLayout();
            deleteTeamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // deleteProjectPanel
            // 
            deleteProjectPanel.Controls.Add(deleteProjectFalseButton);
            deleteProjectPanel.Controls.Add(deleteProjectTrueButton);
            deleteProjectPanel.Controls.Add(label1);
            deleteProjectPanel.Location = new Point(1, 3);
            deleteProjectPanel.Name = "deleteProjectPanel";
            deleteProjectPanel.Size = new Size(372, 173);
            deleteProjectPanel.TabIndex = 0;
            // 
            // deleteProjectFalseButton
            // 
            deleteProjectFalseButton.Location = new Point(227, 81);
            deleteProjectFalseButton.Name = "deleteProjectFalseButton";
            deleteProjectFalseButton.Size = new Size(75, 23);
            deleteProjectFalseButton.TabIndex = 2;
            deleteProjectFalseButton.Text = "no";
            deleteProjectFalseButton.UseVisualStyleBackColor = true;
            deleteProjectFalseButton.Click += deleteProjectFalseButton_Click;
            // 
            // deleteProjectTrueButton
            // 
            deleteProjectTrueButton.Location = new Point(61, 81);
            deleteProjectTrueButton.Name = "deleteProjectTrueButton";
            deleteProjectTrueButton.Size = new Size(75, 23);
            deleteProjectTrueButton.TabIndex = 1;
            deleteProjectTrueButton.Text = "yes";
            deleteProjectTrueButton.UseVisualStyleBackColor = true;
            deleteProjectTrueButton.Click += deleteProjectTrueButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 33);
            label1.Name = "label1";
            label1.Size = new Size(241, 15);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to delete this project?";
            // 
            // deleteTaskPanel
            // 
            deleteTaskPanel.Controls.Add(deleteTaskFalseButton);
            deleteTaskPanel.Controls.Add(deleteTaskTrueButton);
            deleteTaskPanel.Controls.Add(label2);
            deleteTaskPanel.Location = new Point(1, 3);
            deleteTaskPanel.Name = "deleteTaskPanel";
            deleteTaskPanel.Size = new Size(372, 173);
            deleteTaskPanel.TabIndex = 2;
            // 
            // deleteTaskFalseButton
            // 
            deleteTaskFalseButton.Location = new Point(211, 81);
            deleteTaskFalseButton.Name = "deleteTaskFalseButton";
            deleteTaskFalseButton.Size = new Size(75, 23);
            deleteTaskFalseButton.TabIndex = 5;
            deleteTaskFalseButton.Text = "no";
            deleteTaskFalseButton.UseVisualStyleBackColor = true;
            deleteTaskFalseButton.Click += deleteTaskFalseButton_Click;
            // 
            // deleteTaskTrueButton
            // 
            deleteTaskTrueButton.Location = new Point(61, 81);
            deleteTaskTrueButton.Name = "deleteTaskTrueButton";
            deleteTaskTrueButton.Size = new Size(75, 23);
            deleteTaskTrueButton.TabIndex = 4;
            deleteTaskTrueButton.Text = "yes";
            deleteTaskTrueButton.UseVisualStyleBackColor = true;
            deleteTaskTrueButton.Click += deleteTaskTrueButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 33);
            label2.Name = "label2";
            label2.Size = new Size(225, 15);
            label2.TabIndex = 3;
            label2.Text = "Are you sure you want to delete this task?";
            // 
            // deleteEmployeePanel
            // 
            deleteEmployeePanel.Controls.Add(deleteEmployeeFalseButton);
            deleteEmployeePanel.Controls.Add(deleteEmployeeTrueButton);
            deleteEmployeePanel.Controls.Add(label4);
            deleteEmployeePanel.Location = new Point(1, 3);
            deleteEmployeePanel.Name = "deleteEmployeePanel";
            deleteEmployeePanel.Size = new Size(372, 173);
            deleteEmployeePanel.TabIndex = 3;
            // 
            // deleteEmployeeFalseButton
            // 
            deleteEmployeeFalseButton.Location = new Point(227, 81);
            deleteEmployeeFalseButton.Name = "deleteEmployeeFalseButton";
            deleteEmployeeFalseButton.Size = new Size(75, 23);
            deleteEmployeeFalseButton.TabIndex = 8;
            deleteEmployeeFalseButton.Text = "no";
            deleteEmployeeFalseButton.UseVisualStyleBackColor = true;
            deleteEmployeeFalseButton.Click += deleteEmployeeFalseButton_Click;
            // 
            // deleteEmployeeTrueButton
            // 
            deleteEmployeeTrueButton.Location = new Point(53, 81);
            deleteEmployeeTrueButton.Name = "deleteEmployeeTrueButton";
            deleteEmployeeTrueButton.Size = new Size(75, 23);
            deleteEmployeeTrueButton.TabIndex = 7;
            deleteEmployeeTrueButton.Text = "yes";
            deleteEmployeeTrueButton.UseVisualStyleBackColor = true;
            deleteEmployeeTrueButton.Click += deleteEmployeeTrueButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 33);
            label4.Name = "label4";
            label4.Size = new Size(256, 15);
            label4.TabIndex = 6;
            label4.Text = "Are you sure you want to delete this employee?";
            // 
            // deleteTeamPanel
            // 
            deleteTeamPanel.Controls.Add(deleteTeamFalseButton);
            deleteTeamPanel.Controls.Add(deleteTeamTrueButton);
            deleteTeamPanel.Controls.Add(label3);
            deleteTeamPanel.Location = new Point(1, 3);
            deleteTeamPanel.Name = "deleteTeamPanel";
            deleteTeamPanel.Size = new Size(372, 173);
            deleteTeamPanel.TabIndex = 1;
            // 
            // deleteTeamFalseButton
            // 
            deleteTeamFalseButton.Location = new Point(217, 81);
            deleteTeamFalseButton.Name = "deleteTeamFalseButton";
            deleteTeamFalseButton.Size = new Size(75, 23);
            deleteTeamFalseButton.TabIndex = 8;
            deleteTeamFalseButton.Text = "no";
            deleteTeamFalseButton.UseVisualStyleBackColor = true;
            deleteTeamFalseButton.Click += deleteTeamFalseButton_Click;
            // 
            // deleteTeamTrueButton
            // 
            deleteTeamTrueButton.Location = new Point(61, 81);
            deleteTeamTrueButton.Name = "deleteTeamTrueButton";
            deleteTeamTrueButton.Size = new Size(75, 23);
            deleteTeamTrueButton.TabIndex = 7;
            deleteTeamTrueButton.Text = "yes";
            deleteTeamTrueButton.UseVisualStyleBackColor = true;
            deleteTeamTrueButton.Click += deleteTeamTrueButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 33);
            label3.Name = "label3";
            label3.Size = new Size(231, 15);
            label3.TabIndex = 6;
            label3.Text = "Are you sure you want to delete this team?";
            // 
            // DeleteConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 179);
            Controls.Add(deleteTaskPanel);
            Controls.Add(deleteEmployeePanel);
            Controls.Add(deleteProjectPanel);
            Controls.Add(deleteTeamPanel);
            Name = "DeleteConfirmation";
            Text = "DeleteConfirmation";
            deleteProjectPanel.ResumeLayout(false);
            deleteProjectPanel.PerformLayout();
            deleteTaskPanel.ResumeLayout(false);
            deleteTaskPanel.PerformLayout();
            deleteEmployeePanel.ResumeLayout(false);
            deleteEmployeePanel.PerformLayout();
            deleteTeamPanel.ResumeLayout(false);
            deleteTeamPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel deleteProjectPanel;
        private Button deleteProjectFalseButton;
        private Button deleteProjectTrueButton;
        private Panel deleteTeamPanel;
        private Button deleteTeamFalseButton;
        private Button deleteTeamTrueButton;
        private Panel deleteTaskPanel;
        private Button deleteTaskFalseButton;
        private Button deleteTaskTrueButton;
        private Panel deleteEmployeePanel;
        private Button deleteEmployeeFalseButton;
        private Button deleteEmployeeTrueButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
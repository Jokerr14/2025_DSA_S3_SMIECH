namespace DSaA_Project_TimeTracker
{
    partial class AddEditProject
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
            addProjectPanel = new Panel();
            addProjectStartDatePicker = new DateTimePicker();
            addProjectHelpButton = new Button();
            label5 = new Label();
            addProjectDescTextBox = new TextBox();
            discardAddProjectButton = new Button();
            saveAddProjectButton = new Button();
            addProjectNameTextBox = new TextBox();
            label6 = new Label();
            addProjectEndDatePicker = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            editProjectPanel = new Panel();
            editStartDatePicker = new DateTimePicker();
            editProjectHelpButton = new Button();
            label1 = new Label();
            editProjectDescTextBox = new TextBox();
            discardEditProjectButton = new Button();
            saveEditProjectButton = new Button();
            editProjectNameTextBox = new TextBox();
            label2 = new Label();
            editEndDatePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label10 = new Label();
            addProjectPanel.SuspendLayout();
            editProjectPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addProjectPanel
            // 
            addProjectPanel.Controls.Add(addProjectStartDatePicker);
            addProjectPanel.Controls.Add(addProjectHelpButton);
            addProjectPanel.Controls.Add(label5);
            addProjectPanel.Controls.Add(addProjectDescTextBox);
            addProjectPanel.Controls.Add(discardAddProjectButton);
            addProjectPanel.Controls.Add(saveAddProjectButton);
            addProjectPanel.Controls.Add(addProjectNameTextBox);
            addProjectPanel.Controls.Add(label6);
            addProjectPanel.Controls.Add(addProjectEndDatePicker);
            addProjectPanel.Controls.Add(label7);
            addProjectPanel.Controls.Add(label8);
            addProjectPanel.Controls.Add(label9);
            addProjectPanel.Location = new Point(12, 12);
            addProjectPanel.Name = "addProjectPanel";
            addProjectPanel.Size = new Size(782, 665);
            addProjectPanel.TabIndex = 0;
            // 
            // addProjectStartDatePicker
            // 
            addProjectStartDatePicker.Location = new Point(135, 450);
            addProjectStartDatePicker.Name = "addProjectStartDatePicker";
            addProjectStartDatePicker.Size = new Size(235, 23);
            addProjectStartDatePicker.TabIndex = 44;
            // 
            // addProjectHelpButton
            // 
            addProjectHelpButton.Location = new Point(693, 26);
            addProjectHelpButton.Name = "addProjectHelpButton";
            addProjectHelpButton.Size = new Size(48, 23);
            addProjectHelpButton.TabIndex = 43;
            addProjectHelpButton.Text = "Help";
            addProjectHelpButton.UseVisualStyleBackColor = true;
            addProjectHelpButton.Click += addProjectHelpButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(309, 18);
            label5.Name = "label5";
            label5.Size = new Size(176, 30);
            label5.TabIndex = 42;
            label5.Text = "Add New Project";
            // 
            // addProjectDescTextBox
            // 
            addProjectDescTextBox.Location = new Point(135, 142);
            addProjectDescTextBox.Margin = new Padding(3, 2, 3, 2);
            addProjectDescTextBox.Multiline = true;
            addProjectDescTextBox.Name = "addProjectDescTextBox";
            addProjectDescTextBox.ScrollBars = ScrollBars.Vertical;
            addProjectDescTextBox.Size = new Size(606, 267);
            addProjectDescTextBox.TabIndex = 41;
            // 
            // discardAddProjectButton
            // 
            discardAddProjectButton.Location = new Point(300, 596);
            discardAddProjectButton.Name = "discardAddProjectButton";
            discardAddProjectButton.Size = new Size(207, 38);
            discardAddProjectButton.TabIndex = 40;
            discardAddProjectButton.Text = "Discard";
            discardAddProjectButton.UseVisualStyleBackColor = true;
            discardAddProjectButton.Click += discardAddProjectButton_Click;
            // 
            // saveAddProjectButton
            // 
            saveAddProjectButton.Location = new Point(534, 596);
            saveAddProjectButton.Name = "saveAddProjectButton";
            saveAddProjectButton.Size = new Size(207, 38);
            saveAddProjectButton.TabIndex = 39;
            saveAddProjectButton.Text = "Save";
            saveAddProjectButton.UseVisualStyleBackColor = true;
            saveAddProjectButton.Click += saveAddProjectButton_Click;
            // 
            // addProjectNameTextBox
            // 
            addProjectNameTextBox.Location = new Point(135, 80);
            addProjectNameTextBox.Name = "addProjectNameTextBox";
            addProjectNameTextBox.Size = new Size(606, 23);
            addProjectNameTextBox.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 83);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 33;
            label6.Text = "Task Name";
            // 
            // addProjectEndDatePicker
            // 
            addProjectEndDatePicker.Location = new Point(135, 512);
            addProjectEndDatePicker.Name = "addProjectEndDatePicker";
            addProjectEndDatePicker.Size = new Size(235, 23);
            addProjectEndDatePicker.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 518);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 36;
            label7.Text = "End Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 145);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 34;
            label8.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 456);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 35;
            label9.Text = "Start Date";
            // 
            // editProjectPanel
            // 
            editProjectPanel.Controls.Add(editStartDatePicker);
            editProjectPanel.Controls.Add(editProjectHelpButton);
            editProjectPanel.Controls.Add(label1);
            editProjectPanel.Controls.Add(editProjectDescTextBox);
            editProjectPanel.Controls.Add(discardEditProjectButton);
            editProjectPanel.Controls.Add(saveEditProjectButton);
            editProjectPanel.Controls.Add(editProjectNameTextBox);
            editProjectPanel.Controls.Add(label2);
            editProjectPanel.Controls.Add(editEndDatePicker);
            editProjectPanel.Controls.Add(label3);
            editProjectPanel.Controls.Add(label4);
            editProjectPanel.Controls.Add(label10);
            editProjectPanel.Location = new Point(15, 15);
            editProjectPanel.Name = "editProjectPanel";
            editProjectPanel.Size = new Size(779, 662);
            editProjectPanel.TabIndex = 1;
            // 
            // editStartDatePicker
            // 
            editStartDatePicker.Location = new Point(135, 455);
            editStartDatePicker.Name = "editStartDatePicker";
            editStartDatePicker.Size = new Size(235, 23);
            editStartDatePicker.TabIndex = 56;
            // 
            // editProjectHelpButton
            // 
            editProjectHelpButton.Location = new Point(693, 31);
            editProjectHelpButton.Name = "editProjectHelpButton";
            editProjectHelpButton.Size = new Size(48, 23);
            editProjectHelpButton.TabIndex = 55;
            editProjectHelpButton.Text = "Help";
            editProjectHelpButton.UseVisualStyleBackColor = true;
            editProjectHelpButton.Click += editProjectHelpButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 23);
            label1.Name = "label1";
            label1.Size = new Size(122, 30);
            label1.TabIndex = 54;
            label1.Text = "Edit Project";
            // 
            // editProjectDescTextBox
            // 
            editProjectDescTextBox.Location = new Point(135, 147);
            editProjectDescTextBox.Margin = new Padding(3, 2, 3, 2);
            editProjectDescTextBox.Multiline = true;
            editProjectDescTextBox.Name = "editProjectDescTextBox";
            editProjectDescTextBox.ScrollBars = ScrollBars.Vertical;
            editProjectDescTextBox.Size = new Size(606, 267);
            editProjectDescTextBox.TabIndex = 53;
            // 
            // discardEditProjectButton
            // 
            discardEditProjectButton.Location = new Point(300, 601);
            discardEditProjectButton.Name = "discardEditProjectButton";
            discardEditProjectButton.Size = new Size(207, 38);
            discardEditProjectButton.TabIndex = 52;
            discardEditProjectButton.Text = "Discard";
            discardEditProjectButton.UseVisualStyleBackColor = true;
            discardEditProjectButton.Click += discardEditProjectButton_Click;
            // 
            // saveEditProjectButton
            // 
            saveEditProjectButton.Location = new Point(534, 601);
            saveEditProjectButton.Name = "saveEditProjectButton";
            saveEditProjectButton.Size = new Size(207, 38);
            saveEditProjectButton.TabIndex = 51;
            saveEditProjectButton.Text = "Save";
            saveEditProjectButton.UseVisualStyleBackColor = true;
            saveEditProjectButton.Click += saveEditProjectButton_Click;
            // 
            // editProjectNameTextBox
            // 
            editProjectNameTextBox.Location = new Point(135, 85);
            editProjectNameTextBox.Name = "editProjectNameTextBox";
            editProjectNameTextBox.Size = new Size(606, 23);
            editProjectNameTextBox.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 88);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 45;
            label2.Text = "Task Name";
            // 
            // editEndDatePicker
            // 
            editEndDatePicker.Location = new Point(135, 517);
            editEndDatePicker.Name = "editEndDatePicker";
            editEndDatePicker.Size = new Size(235, 23);
            editEndDatePicker.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 523);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 48;
            label3.Text = "End Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 150);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 46;
            label4.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 461);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 47;
            label10.Text = "Start Date";
            // 
            // AddEditProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 698);
            Controls.Add(editProjectPanel);
            Controls.Add(addProjectPanel);
            Name = "AddEditProject";
            Text = "AddEditProjects";
            addProjectPanel.ResumeLayout(false);
            addProjectPanel.PerformLayout();
            editProjectPanel.ResumeLayout(false);
            editProjectPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addProjectPanel;
        private Button addProjectHelpButton;
        private Label label5;
        private TextBox addProjectDescTextBox;
        private Button discardAddProjectButton;
        private Button saveAddProjectButton;
        private TextBox addProjectNameTextBox;
        private Label label6;
        private DateTimePicker addProjectEndDatePicker;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker addProjectStartDatePicker;
        private Panel editProjectPanel;
        private DateTimePicker editStartDatePicker;
        private Button editProjectHelpButton;
        private Label label1;
        private TextBox editProjectDescTextBox;
        private Button discardEditProjectButton;
        private Button saveEditProjectButton;
        private TextBox editProjectNameTextBox;
        private Label label2;
        private DateTimePicker editEndDatePicker;
        private Label label3;
        private Label label4;
        private Label label10;
    }
}
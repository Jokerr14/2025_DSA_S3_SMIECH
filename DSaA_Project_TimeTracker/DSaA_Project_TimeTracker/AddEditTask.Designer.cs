namespace DSaA_Project_TimeTracker
{
    partial class AddEditTask
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            addNewTaskNameTextBox = new TextBox();
            addNewTaskDatePicker = new DateTimePicker();
            saveNewTaskButton = new Button();
            discardNewTaskButton = new Button();
            addTaskPanel = new Panel();
            addNewTaskStatusComboBox = new ComboBox();
            addTaskHelpButton = new Button();
            AddTaskNameLabel = new Label();
            addNewTaskDescTextBox = new TextBox();
            editTaskPanel = new Panel();
            editTaskStatusComboBox = new ComboBox();
            editTaskHelpButton = new Button();
            label5 = new Label();
            editTaskDescTextBox = new TextBox();
            discardEditTaskButton = new Button();
            saveEditTaskButton = new Button();
            editTaskNameTextBox = new TextBox();
            label6 = new Label();
            editTaskDatePicker = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            addTaskPanel.SuspendLayout();
            editTaskPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 76);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Task Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 138);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 443);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Current Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 511);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Due Date";
            // 
            // addNewTaskNameTextBox
            // 
            addNewTaskNameTextBox.Location = new Point(124, 73);
            addNewTaskNameTextBox.Name = "addNewTaskNameTextBox";
            addNewTaskNameTextBox.Size = new Size(606, 23);
            addNewTaskNameTextBox.TabIndex = 4;
            // 
            // addNewTaskDatePicker
            // 
            addNewTaskDatePicker.Location = new Point(124, 505);
            addNewTaskDatePicker.Name = "addNewTaskDatePicker";
            addNewTaskDatePicker.Size = new Size(235, 23);
            addNewTaskDatePicker.TabIndex = 7;
            // 
            // saveNewTaskButton
            // 
            saveNewTaskButton.Location = new Point(523, 589);
            saveNewTaskButton.Name = "saveNewTaskButton";
            saveNewTaskButton.Size = new Size(207, 38);
            saveNewTaskButton.TabIndex = 9;
            saveNewTaskButton.Text = "Save";
            saveNewTaskButton.UseVisualStyleBackColor = true;
            saveNewTaskButton.Click += saveNewTaskButton_Click;
            // 
            // discardNewTaskButton
            // 
            discardNewTaskButton.Location = new Point(289, 589);
            discardNewTaskButton.Name = "discardNewTaskButton";
            discardNewTaskButton.Size = new Size(207, 38);
            discardNewTaskButton.TabIndex = 10;
            discardNewTaskButton.Text = "Discard";
            discardNewTaskButton.UseVisualStyleBackColor = true;
            discardNewTaskButton.Click += discardNewTaskButton_Click;
            // 
            // addTaskPanel
            // 
            addTaskPanel.Controls.Add(addNewTaskStatusComboBox);
            addTaskPanel.Controls.Add(addTaskHelpButton);
            addTaskPanel.Controls.Add(AddTaskNameLabel);
            addTaskPanel.Controls.Add(addNewTaskDescTextBox);
            addTaskPanel.Controls.Add(discardNewTaskButton);
            addTaskPanel.Controls.Add(saveNewTaskButton);
            addTaskPanel.Controls.Add(addNewTaskNameTextBox);
            addTaskPanel.Controls.Add(label1);
            addTaskPanel.Controls.Add(addNewTaskDatePicker);
            addTaskPanel.Controls.Add(label4);
            addTaskPanel.Controls.Add(label2);
            addTaskPanel.Controls.Add(label3);
            addTaskPanel.Location = new Point(12, 12);
            addTaskPanel.Name = "addTaskPanel";
            addTaskPanel.Size = new Size(755, 682);
            addTaskPanel.TabIndex = 11;
            addTaskPanel.Visible = false;
            // 
            // addNewTaskStatusComboBox
            // 
            addNewTaskStatusComboBox.FormattingEnabled = true;
            addNewTaskStatusComboBox.Location = new Point(124, 440);
            addNewTaskStatusComboBox.Name = "addNewTaskStatusComboBox";
            addNewTaskStatusComboBox.Size = new Size(235, 23);
            addNewTaskStatusComboBox.TabIndex = 31;
            addNewTaskStatusComboBox.SelectedIndexChanged += addNewTaskStatusComboBox_SelectedIndexChanged;
            // 
            // addTaskHelpButton
            // 
            addTaskHelpButton.Location = new Point(682, 19);
            addTaskHelpButton.Name = "addTaskHelpButton";
            addTaskHelpButton.Size = new Size(48, 23);
            addTaskHelpButton.TabIndex = 30;
            addTaskHelpButton.Text = "Help";
            addTaskHelpButton.UseVisualStyleBackColor = true;
            addTaskHelpButton.Click += addTaskHelpButton_Click;
            // 
            // AddTaskNameLabel
            // 
            AddTaskNameLabel.AutoSize = true;
            AddTaskNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddTaskNameLabel.Location = new Point(321, 12);
            AddTaskNameLabel.Name = "AddTaskNameLabel";
            AddTaskNameLabel.Size = new Size(150, 30);
            AddTaskNameLabel.TabIndex = 17;
            AddTaskNameLabel.Text = "Add New Task";
            // 
            // addNewTaskDescTextBox
            // 
            addNewTaskDescTextBox.Location = new Point(124, 135);
            addNewTaskDescTextBox.Margin = new Padding(3, 2, 3, 2);
            addNewTaskDescTextBox.Multiline = true;
            addNewTaskDescTextBox.Name = "addNewTaskDescTextBox";
            addNewTaskDescTextBox.ScrollBars = ScrollBars.Vertical;
            addNewTaskDescTextBox.Size = new Size(606, 267);
            addNewTaskDescTextBox.TabIndex = 16;
            // 
            // editTaskPanel
            // 
            editTaskPanel.Controls.Add(editTaskStatusComboBox);
            editTaskPanel.Controls.Add(editTaskHelpButton);
            editTaskPanel.Controls.Add(label5);
            editTaskPanel.Controls.Add(editTaskDescTextBox);
            editTaskPanel.Controls.Add(discardEditTaskButton);
            editTaskPanel.Controls.Add(saveEditTaskButton);
            editTaskPanel.Controls.Add(editTaskNameTextBox);
            editTaskPanel.Controls.Add(label6);
            editTaskPanel.Controls.Add(editTaskDatePicker);
            editTaskPanel.Controls.Add(label7);
            editTaskPanel.Controls.Add(label8);
            editTaskPanel.Controls.Add(label9);
            editTaskPanel.Location = new Point(12, 12);
            editTaskPanel.Name = "editTaskPanel";
            editTaskPanel.Size = new Size(755, 682);
            editTaskPanel.TabIndex = 12;
            // 
            // editTaskStatusComboBox
            // 
            editTaskStatusComboBox.FormattingEnabled = true;
            editTaskStatusComboBox.Location = new Point(124, 440);
            editTaskStatusComboBox.Name = "editTaskStatusComboBox";
            editTaskStatusComboBox.Size = new Size(235, 23);
            editTaskStatusComboBox.TabIndex = 32;
            editTaskStatusComboBox.SelectedIndexChanged += editTaskStatusComboBox_SelectedIndexChanged;
            // 
            // editTaskHelpButton
            // 
            editTaskHelpButton.Location = new Point(682, 19);
            editTaskHelpButton.Name = "editTaskHelpButton";
            editTaskHelpButton.Size = new Size(48, 23);
            editTaskHelpButton.TabIndex = 29;
            editTaskHelpButton.Text = "Help";
            editTaskHelpButton.UseVisualStyleBackColor = true;
            editTaskHelpButton.Click += editTaskHelpButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(321, 12);
            label5.Name = "label5";
            label5.Size = new Size(96, 30);
            label5.TabIndex = 28;
            label5.Text = "Edit Task";
            // 
            // editTaskDescTextBox
            // 
            editTaskDescTextBox.Location = new Point(124, 135);
            editTaskDescTextBox.Margin = new Padding(3, 2, 3, 2);
            editTaskDescTextBox.Multiline = true;
            editTaskDescTextBox.Name = "editTaskDescTextBox";
            editTaskDescTextBox.ScrollBars = ScrollBars.Vertical;
            editTaskDescTextBox.Size = new Size(606, 267);
            editTaskDescTextBox.TabIndex = 27;
            // 
            // discardEditTaskButton
            // 
            discardEditTaskButton.Location = new Point(289, 589);
            discardEditTaskButton.Name = "discardEditTaskButton";
            discardEditTaskButton.Size = new Size(207, 38);
            discardEditTaskButton.TabIndex = 26;
            discardEditTaskButton.Text = "Discard";
            discardEditTaskButton.UseVisualStyleBackColor = true;
            discardEditTaskButton.Click += discardEditTaskButton_Click;
            // 
            // saveEditTaskButton
            // 
            saveEditTaskButton.Location = new Point(523, 589);
            saveEditTaskButton.Name = "saveEditTaskButton";
            saveEditTaskButton.Size = new Size(207, 38);
            saveEditTaskButton.TabIndex = 25;
            saveEditTaskButton.Text = "Save";
            saveEditTaskButton.UseVisualStyleBackColor = true;
            saveEditTaskButton.Click += saveEditTaskButton_Click;
            // 
            // editTaskNameTextBox
            // 
            editTaskNameTextBox.Location = new Point(124, 73);
            editTaskNameTextBox.Name = "editTaskNameTextBox";
            editTaskNameTextBox.Size = new Size(606, 23);
            editTaskNameTextBox.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 76);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 18;
            label6.Text = "Task Name";
            // 
            // editTaskDatePicker
            // 
            editTaskDatePicker.Location = new Point(124, 505);
            editTaskDatePicker.Name = "editTaskDatePicker";
            editTaskDatePicker.Size = new Size(235, 23);
            editTaskDatePicker.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 511);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 21;
            label7.Text = "Due Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 138);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 19;
            label8.Text = "Description";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 443);
            label9.Name = "label9";
            label9.Size = new Size(82, 15);
            label9.TabIndex = 20;
            label9.Text = "Current Status";
            // 
            // AddEditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 710);
            Controls.Add(editTaskPanel);
            Controls.Add(addTaskPanel);
            Name = "AddEditTask";
            Text = "AddEditTask";
            addTaskPanel.ResumeLayout(false);
            addTaskPanel.PerformLayout();
            editTaskPanel.ResumeLayout(false);
            editTaskPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox addNewTaskNameTextBox;
        private DateTimePicker addNewTaskDatePicker;
        private Button saveNewTaskButton;
        private Button discardNewTaskButton;
        private Panel addTaskPanel;
        private TextBox addNewTaskDescTextBox;
        private Label AddTaskNameLabel;
        private Panel editTaskPanel;
        private Label label5;
        private TextBox editTaskDescTextBox;
        private Button discardEditTaskButton;
        private Button saveEditTaskButton;
        private TextBox editTaskNameTextBox;
        private Label label6;
        private DateTimePicker editTaskDatePicker;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button editTaskHelpButton;
        private Button addTaskHelpButton;
        private ComboBox addNewTaskStatusComboBox;
        private ComboBox editTaskStatusComboBox;
    }
}
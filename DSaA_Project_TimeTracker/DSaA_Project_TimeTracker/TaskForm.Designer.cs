namespace DSaA_Project_TimeTracker
{
    partial class TaskForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            popupTaskNameLabel = new Label();
            popupDoneCheckbox = new CheckBox();
            popupProjectNameLabel = new Label();
            popupTaskDescriptionTexbox = new TextBox();
            popupTimerDescriptionLabel = new Label();
            popupTimerStartStopButton = new Button();
            popupTimerPauseButton = new Button();
            popupRecordDescriptionLabel = new Label();
            popupRecordStartDatePicker = new DateTimePicker();
            popupRecordEndDatePicker = new DateTimePicker();
            popupRecordButton = new Button();
            popupRecordStartLabel = new Label();
            popupRecordEndLabel = new Label();
            popupTimerLabel = new Label();
            helpButton = new Button();
            SuspendLayout();
            // 
            // popupTaskNameLabel
            // 
            popupTaskNameLabel.AutoSize = true;
            popupTaskNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            popupTaskNameLabel.Location = new Point(12, 24);
            popupTaskNameLabel.Name = "popupTaskNameLabel";
            popupTaskNameLabel.Size = new Size(118, 30);
            popupTaskNameLabel.TabIndex = 0;
            popupTaskNameLabel.Text = "Task Name";
            // 
            // popupDoneCheckbox
            // 
            popupDoneCheckbox.AutoSize = true;
            popupDoneCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            popupDoneCheckbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            popupDoneCheckbox.Location = new Point(478, 67);
            popupDoneCheckbox.Margin = new Padding(3, 2, 3, 2);
            popupDoneCheckbox.Name = "popupDoneCheckbox";
            popupDoneCheckbox.Size = new Size(76, 29);
            popupDoneCheckbox.TabIndex = 1;
            popupDoneCheckbox.Text = "Done";
            popupDoneCheckbox.TextAlign = ContentAlignment.MiddleRight;
            popupDoneCheckbox.UseVisualStyleBackColor = true;
            // 
            // popupProjectNameLabel
            // 
            popupProjectNameLabel.AutoSize = true;
            popupProjectNameLabel.Location = new Point(12, 76);
            popupProjectNameLabel.Name = "popupProjectNameLabel";
            popupProjectNameLabel.Size = new Size(155, 15);
            popupProjectNameLabel.TabIndex = 2;
            popupProjectNameLabel.Text = "(name of proj. it belongs to)";
            // 
            // popupTaskDescriptionTexbox
            // 
            popupTaskDescriptionTexbox.Location = new Point(22, 115);
            popupTaskDescriptionTexbox.Margin = new Padding(3, 2, 3, 2);
            popupTaskDescriptionTexbox.Multiline = true;
            popupTaskDescriptionTexbox.Name = "popupTaskDescriptionTexbox";
            popupTaskDescriptionTexbox.ReadOnly = true;
            popupTaskDescriptionTexbox.ScrollBars = ScrollBars.Vertical;
            popupTaskDescriptionTexbox.Size = new Size(532, 282);
            popupTaskDescriptionTexbox.TabIndex = 4;
            // 
            // popupTimerDescriptionLabel
            // 
            popupTimerDescriptionLabel.AutoSize = true;
            popupTimerDescriptionLabel.Location = new Point(22, 419);
            popupTimerDescriptionLabel.Name = "popupTimerDescriptionLabel";
            popupTimerDescriptionLabel.Size = new Size(125, 15);
            popupTimerDescriptionLabel.TabIndex = 5;
            popupTimerDescriptionLabel.Text = "Track Time of Working";
            // 
            // popupTimerStartStopButton
            // 
            popupTimerStartStopButton.Location = new Point(22, 457);
            popupTimerStartStopButton.Margin = new Padding(3, 2, 3, 2);
            popupTimerStartStopButton.Name = "popupTimerStartStopButton";
            popupTimerStartStopButton.Size = new Size(90, 22);
            popupTimerStartStopButton.TabIndex = 6;
            popupTimerStartStopButton.Text = "START/STOP";
            popupTimerStartStopButton.UseVisualStyleBackColor = true;
            // 
            // popupTimerPauseButton
            // 
            popupTimerPauseButton.Location = new Point(22, 500);
            popupTimerPauseButton.Margin = new Padding(3, 2, 3, 2);
            popupTimerPauseButton.Name = "popupTimerPauseButton";
            popupTimerPauseButton.Size = new Size(90, 22);
            popupTimerPauseButton.TabIndex = 7;
            popupTimerPauseButton.Text = "PAUSE";
            popupTimerPauseButton.UseVisualStyleBackColor = true;
            // 
            // popupRecordDescriptionLabel
            // 
            popupRecordDescriptionLabel.AutoSize = true;
            popupRecordDescriptionLabel.Location = new Point(317, 419);
            popupRecordDescriptionLabel.Name = "popupRecordDescriptionLabel";
            popupRecordDescriptionLabel.Size = new Size(187, 15);
            popupRecordDescriptionLabel.TabIndex = 8;
            popupRecordDescriptionLabel.Text = "Log time spent working manually:";
            // 
            // popupRecordStartDatePicker
            // 
            popupRecordStartDatePicker.Location = new Point(317, 455);
            popupRecordStartDatePicker.Margin = new Padding(3, 2, 3, 2);
            popupRecordStartDatePicker.Name = "popupRecordStartDatePicker";
            popupRecordStartDatePicker.Size = new Size(214, 23);
            popupRecordStartDatePicker.TabIndex = 10;
            // 
            // popupRecordEndDatePicker
            // 
            popupRecordEndDatePicker.Location = new Point(317, 498);
            popupRecordEndDatePicker.Margin = new Padding(3, 2, 3, 2);
            popupRecordEndDatePicker.Name = "popupRecordEndDatePicker";
            popupRecordEndDatePicker.Size = new Size(214, 23);
            popupRecordEndDatePicker.TabIndex = 11;
            // 
            // popupRecordButton
            // 
            popupRecordButton.Location = new Point(317, 542);
            popupRecordButton.Margin = new Padding(3, 2, 3, 2);
            popupRecordButton.Name = "popupRecordButton";
            popupRecordButton.Size = new Size(109, 23);
            popupRecordButton.TabIndex = 12;
            popupRecordButton.Text = "Record Time";
            popupRecordButton.UseVisualStyleBackColor = true;
            // 
            // popupRecordStartLabel
            // 
            popupRecordStartLabel.AutoSize = true;
            popupRecordStartLabel.Location = new Point(268, 459);
            popupRecordStartLabel.Name = "popupRecordStartLabel";
            popupRecordStartLabel.Size = new Size(38, 15);
            popupRecordStartLabel.TabIndex = 13;
            popupRecordStartLabel.Text = "START";
            // 
            // popupRecordEndLabel
            // 
            popupRecordEndLabel.AutoSize = true;
            popupRecordEndLabel.Location = new Point(278, 502);
            popupRecordEndLabel.Name = "popupRecordEndLabel";
            popupRecordEndLabel.Size = new Size(30, 15);
            popupRecordEndLabel.TabIndex = 14;
            popupRecordEndLabel.Text = "END";
            // 
            // popupTimerLabel
            // 
            popupTimerLabel.AutoSize = true;
            popupTimerLabel.Location = new Point(22, 550);
            popupTimerLabel.Name = "popupTimerLabel";
            popupTimerLabel.Size = new Size(99, 15);
            popupTimerLabel.TabIndex = 15;
            popupTimerLabel.Text = "timer will go here";
            // 
            // helpButton
            // 
            helpButton.Location = new Point(506, 12);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(48, 23);
            helpButton.TabIndex = 16;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 606);
            Controls.Add(helpButton);
            Controls.Add(popupTimerLabel);
            Controls.Add(popupRecordEndLabel);
            Controls.Add(popupRecordStartLabel);
            Controls.Add(popupRecordButton);
            Controls.Add(popupRecordEndDatePicker);
            Controls.Add(popupRecordStartDatePicker);
            Controls.Add(popupRecordDescriptionLabel);
            Controls.Add(popupTimerPauseButton);
            Controls.Add(popupTimerStartStopButton);
            Controls.Add(popupTimerDescriptionLabel);
            Controls.Add(popupTaskDescriptionTexbox);
            Controls.Add(popupProjectNameLabel);
            Controls.Add(popupDoneCheckbox);
            Controls.Add(popupTaskNameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TaskForm";
            Text = "Detailed Information about the Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label popupTaskNameLabel;
        private CheckBox popupDoneCheckbox;
        private Label popupProjectNameLabel;
        private TextBox popupTaskDescriptionTexbox;
        private Label popupTimerDescriptionLabel;
        private Button popupTimerStartStopButton;
        private Button popupTimerPauseButton;
        private Label popupRecordDescriptionLabel;
        private DateTimePicker popupRecordStartDatePicker;
        private DateTimePicker popupRecordEndDatePicker;
        private Button popupRecordButton;
        private Label popupRecordStartLabel;
        private Label popupRecordEndLabel;
        private Label popupTimerLabel;
        private Button helpButton;
    }
}

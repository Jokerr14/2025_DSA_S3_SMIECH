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
            popupTaskDescriptionLabel = new Label();
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
            SuspendLayout();
            // 
            // popupTaskNameLabel
            // 
            popupTaskNameLabel.AutoSize = true;
            popupTaskNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            popupTaskNameLabel.Location = new Point(16, 17);
            popupTaskNameLabel.Name = "popupTaskNameLabel";
            popupTaskNameLabel.Size = new Size(151, 38);
            popupTaskNameLabel.TabIndex = 0;
            popupTaskNameLabel.Text = "Task Name";
            // 
            // popupDoneCheckbox
            // 
            popupDoneCheckbox.AutoSize = true;
            popupDoneCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            popupDoneCheckbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            popupDoneCheckbox.Location = new Point(544, 21);
            popupDoneCheckbox.Name = "popupDoneCheckbox";
            popupDoneCheckbox.Size = new Size(90, 35);
            popupDoneCheckbox.TabIndex = 1;
            popupDoneCheckbox.Text = "Done";
            popupDoneCheckbox.UseVisualStyleBackColor = true;
            // 
            // popupProjectNameLabel
            // 
            popupProjectNameLabel.AutoSize = true;
            popupProjectNameLabel.Location = new Point(16, 55);
            popupProjectNameLabel.Name = "popupProjectNameLabel";
            popupProjectNameLabel.Size = new Size(196, 20);
            popupProjectNameLabel.TabIndex = 2;
            popupProjectNameLabel.Text = "(name of proj. it belongs to)";
            // 
            // popupTaskDescriptionLabel
            // 
            popupTaskDescriptionLabel.AutoSize = true;
            popupTaskDescriptionLabel.Location = new Point(27, 103);
            popupTaskDescriptionLabel.Name = "popupTaskDescriptionLabel";
            popupTaskDescriptionLabel.Size = new Size(85, 20);
            popupTaskDescriptionLabel.TabIndex = 3;
            popupTaskDescriptionLabel.Text = "Description";
            // 
            // popupTaskDescriptionTexbox
            // 
            popupTaskDescriptionTexbox.Location = new Point(27, 126);
            popupTaskDescriptionTexbox.Multiline = true;
            popupTaskDescriptionTexbox.Name = "popupTaskDescriptionTexbox";
            popupTaskDescriptionTexbox.ReadOnly = true;
            popupTaskDescriptionTexbox.ScrollBars = ScrollBars.Vertical;
            popupTaskDescriptionTexbox.Size = new Size(607, 375);
            popupTaskDescriptionTexbox.TabIndex = 4;
            // 
            // popupTimerDescriptionLabel
            // 
            popupTimerDescriptionLabel.AutoSize = true;
            popupTimerDescriptionLabel.Location = new Point(27, 519);
            popupTimerDescriptionLabel.Name = "popupTimerDescriptionLabel";
            popupTimerDescriptionLabel.Size = new Size(157, 20);
            popupTimerDescriptionLabel.TabIndex = 5;
            popupTimerDescriptionLabel.Text = "Track Time of Working";
            // 
            // popupTimerStartStopButton
            // 
            popupTimerStartStopButton.Location = new Point(53, 547);
            popupTimerStartStopButton.Name = "popupTimerStartStopButton";
            popupTimerStartStopButton.Size = new Size(103, 29);
            popupTimerStartStopButton.TabIndex = 6;
            popupTimerStartStopButton.Text = "START/STOP";
            popupTimerStartStopButton.UseVisualStyleBackColor = true;
            // 
            // popupTimerPauseButton
            // 
            popupTimerPauseButton.Location = new Point(53, 582);
            popupTimerPauseButton.Name = "popupTimerPauseButton";
            popupTimerPauseButton.Size = new Size(103, 29);
            popupTimerPauseButton.TabIndex = 7;
            popupTimerPauseButton.Text = "PAUSE";
            popupTimerPauseButton.UseVisualStyleBackColor = true;
            // 
            // popupRecordDescriptionLabel
            // 
            popupRecordDescriptionLabel.AutoSize = true;
            popupRecordDescriptionLabel.Location = new Point(369, 519);
            popupRecordDescriptionLabel.Name = "popupRecordDescriptionLabel";
            popupRecordDescriptionLabel.Size = new Size(232, 20);
            popupRecordDescriptionLabel.TabIndex = 8;
            popupRecordDescriptionLabel.Text = "Log time spent working manually:";
            // 
            // popupRecordStartDatePicker
            // 
            popupRecordStartDatePicker.Location = new Point(390, 551);
            popupRecordStartDatePicker.Name = "popupRecordStartDatePicker";
            popupRecordStartDatePicker.Size = new Size(244, 27);
            popupRecordStartDatePicker.TabIndex = 10;
            // 
            // popupRecordEndDatePicker
            // 
            popupRecordEndDatePicker.Location = new Point(390, 584);
            popupRecordEndDatePicker.Name = "popupRecordEndDatePicker";
            popupRecordEndDatePicker.Size = new Size(244, 27);
            popupRecordEndDatePicker.TabIndex = 11;
            // 
            // popupRecordButton
            // 
            popupRecordButton.Location = new Point(417, 617);
            popupRecordButton.Name = "popupRecordButton";
            popupRecordButton.Size = new Size(125, 31);
            popupRecordButton.TabIndex = 12;
            popupRecordButton.Text = "Record Time";
            popupRecordButton.UseVisualStyleBackColor = true;
            // 
            // popupRecordStartLabel
            // 
            popupRecordStartLabel.AutoSize = true;
            popupRecordStartLabel.Location = new Point(334, 556);
            popupRecordStartLabel.Name = "popupRecordStartLabel";
            popupRecordStartLabel.Size = new Size(50, 20);
            popupRecordStartLabel.TabIndex = 13;
            popupRecordStartLabel.Text = "START";
            // 
            // popupRecordEndLabel
            // 
            popupRecordEndLabel.AutoSize = true;
            popupRecordEndLabel.Location = new Point(345, 589);
            popupRecordEndLabel.Name = "popupRecordEndLabel";
            popupRecordEndLabel.Size = new Size(39, 20);
            popupRecordEndLabel.TabIndex = 14;
            popupRecordEndLabel.Text = "END";
            // 
            // popupTimerLabel
            // 
            popupTimerLabel.AutoSize = true;
            popupTimerLabel.Location = new Point(41, 622);
            popupTimerLabel.Name = "popupTimerLabel";
            popupTimerLabel.Size = new Size(126, 20);
            popupTimerLabel.TabIndex = 15;
            popupTimerLabel.Text = "timer will go here";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 686);
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
            Controls.Add(popupTaskDescriptionLabel);
            Controls.Add(popupProjectNameLabel);
            Controls.Add(popupDoneCheckbox);
            Controls.Add(popupTaskNameLabel);
            Name = "TaskForm";
            Text = "Detailed Information about the Task";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label popupTaskNameLabel;
        private CheckBox popupDoneCheckbox;
        private Label popupProjectNameLabel;
        private Label popupTaskDescriptionLabel;
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
    }
}

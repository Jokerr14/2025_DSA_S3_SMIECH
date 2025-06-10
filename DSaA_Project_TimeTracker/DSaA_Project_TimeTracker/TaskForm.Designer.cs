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
            popupRecordButton = new Button();
            popupTimerLabel = new Label();
            helpButton = new Button();
            manualMinutesInput = new NumericUpDown();
            pageSetupDialog1 = new PageSetupDialog();
            addManualTimeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)manualMinutesInput).BeginInit();
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
            popupRecordDescriptionLabel.Location = new Point(278, 419);
            popupRecordDescriptionLabel.Name = "popupRecordDescriptionLabel";
            popupRecordDescriptionLabel.Size = new Size(254, 15);
            popupRecordDescriptionLabel.TabIndex = 8;
            popupRecordDescriptionLabel.Text = "Log time spent working manually (in minutes):";
            // 
            // popupRecordButton
            // 
            popupRecordButton.Location = new Point(22, 559);
            popupRecordButton.Margin = new Padding(3, 2, 3, 2);
            popupRecordButton.Name = "popupRecordButton";
            popupRecordButton.Size = new Size(109, 23);
            popupRecordButton.TabIndex = 12;
            popupRecordButton.Text = "Record Time";
            popupRecordButton.UseVisualStyleBackColor = true;
            // 
            // popupTimerLabel
            // 
            popupTimerLabel.AutoSize = true;
            popupTimerLabel.Location = new Point(22, 524);
            popupTimerLabel.Name = "popupTimerLabel";
            popupTimerLabel.Size = new Size(59, 15);
            popupTimerLabel.TabIndex = 15;
            popupTimerLabel.Text = "hh:mm:ss";
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
            // manualMinutesInput
            // 
            manualMinutesInput.Location = new Point(317, 457);
            manualMinutesInput.Margin = new Padding(2, 2, 2, 2);
            manualMinutesInput.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            manualMinutesInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            manualMinutesInput.Name = "manualMinutesInput";
            manualMinutesInput.Size = new Size(126, 23);
            manualMinutesInput.TabIndex = 17;
            manualMinutesInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addManualTimeButton
            // 
            addManualTimeButton.Location = new Point(317, 502);
            addManualTimeButton.Margin = new Padding(2, 2, 2, 2);
            addManualTimeButton.Name = "addManualTimeButton";
            addManualTimeButton.Size = new Size(126, 20);
            addManualTimeButton.TabIndex = 18;
            addManualTimeButton.Text = "Record Manually";
            addManualTimeButton.UseVisualStyleBackColor = true;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 606);
            Controls.Add(addManualTimeButton);
            Controls.Add(manualMinutesInput);
            Controls.Add(helpButton);
            Controls.Add(popupTimerLabel);
            Controls.Add(popupRecordButton);
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
            ((System.ComponentModel.ISupportInitialize)manualMinutesInput).EndInit();
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
        private Button popupRecordButton;
        private Label popupTimerLabel;
        private Button helpButton;
        private NumericUpDown manualMinutesInput;
        private PageSetupDialog pageSetupDialog1;
        private Button addManualTimeButton;
    }
}

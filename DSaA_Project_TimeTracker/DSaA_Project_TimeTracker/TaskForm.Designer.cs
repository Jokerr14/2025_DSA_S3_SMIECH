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
            popupTaskNameLabel.Location = new Point(17, 40);
            popupTaskNameLabel.Margin = new Padding(4, 0, 4, 0);
            popupTaskNameLabel.Name = "popupTaskNameLabel";
            popupTaskNameLabel.Size = new Size(176, 45);
            popupTaskNameLabel.TabIndex = 0;
            popupTaskNameLabel.Text = "Task Name";
            // 
            // popupDoneCheckbox
            // 
            popupDoneCheckbox.AutoSize = true;
            popupDoneCheckbox.CheckAlign = ContentAlignment.MiddleRight;
            popupDoneCheckbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            popupDoneCheckbox.Location = new Point(683, 112);
            popupDoneCheckbox.Margin = new Padding(4, 3, 4, 3);
            popupDoneCheckbox.Name = "popupDoneCheckbox";
            popupDoneCheckbox.Size = new Size(110, 42);
            popupDoneCheckbox.TabIndex = 1;
            popupDoneCheckbox.Text = "Done";
            popupDoneCheckbox.TextAlign = ContentAlignment.MiddleRight;
            popupDoneCheckbox.UseVisualStyleBackColor = true;
            // 
            // popupProjectNameLabel
            // 
            popupProjectNameLabel.AutoSize = true;
            popupProjectNameLabel.Location = new Point(17, 127);
            popupProjectNameLabel.Margin = new Padding(4, 0, 4, 0);
            popupProjectNameLabel.Name = "popupProjectNameLabel";
            popupProjectNameLabel.Size = new Size(235, 25);
            popupProjectNameLabel.TabIndex = 2;
            popupProjectNameLabel.Text = "(name of proj. it belongs to)";
            // 
            // popupTaskDescriptionTexbox
            // 
            popupTaskDescriptionTexbox.Location = new Point(31, 192);
            popupTaskDescriptionTexbox.Margin = new Padding(4, 3, 4, 3);
            popupTaskDescriptionTexbox.Multiline = true;
            popupTaskDescriptionTexbox.Name = "popupTaskDescriptionTexbox";
            popupTaskDescriptionTexbox.ReadOnly = true;
            popupTaskDescriptionTexbox.ScrollBars = ScrollBars.Vertical;
            popupTaskDescriptionTexbox.Size = new Size(758, 467);
            popupTaskDescriptionTexbox.TabIndex = 4;
            // 
            // popupTimerDescriptionLabel
            // 
            popupTimerDescriptionLabel.AutoSize = true;
            popupTimerDescriptionLabel.Location = new Point(31, 698);
            popupTimerDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            popupTimerDescriptionLabel.Name = "popupTimerDescriptionLabel";
            popupTimerDescriptionLabel.Size = new Size(188, 25);
            popupTimerDescriptionLabel.TabIndex = 5;
            popupTimerDescriptionLabel.Text = "Track Time of Working";
            // 
            // popupTimerStartStopButton
            // 
            popupTimerStartStopButton.Location = new Point(31, 762);
            popupTimerStartStopButton.Margin = new Padding(4, 3, 4, 3);
            popupTimerStartStopButton.Name = "popupTimerStartStopButton";
            popupTimerStartStopButton.Size = new Size(129, 37);
            popupTimerStartStopButton.TabIndex = 6;
            popupTimerStartStopButton.Text = "START/STOP";
            popupTimerStartStopButton.UseVisualStyleBackColor = true;
            // 
            // popupTimerPauseButton
            // 
            popupTimerPauseButton.Location = new Point(31, 833);
            popupTimerPauseButton.Margin = new Padding(4, 3, 4, 3);
            popupTimerPauseButton.Name = "popupTimerPauseButton";
            popupTimerPauseButton.Size = new Size(129, 37);
            popupTimerPauseButton.TabIndex = 7;
            popupTimerPauseButton.Text = "PAUSE";
            popupTimerPauseButton.UseVisualStyleBackColor = true;
            // 
            // popupRecordDescriptionLabel
            // 
            popupRecordDescriptionLabel.AutoSize = true;
            popupRecordDescriptionLabel.Location = new Point(453, 698);
            popupRecordDescriptionLabel.Margin = new Padding(4, 0, 4, 0);
            popupRecordDescriptionLabel.Name = "popupRecordDescriptionLabel";
            popupRecordDescriptionLabel.Size = new Size(280, 25);
            popupRecordDescriptionLabel.TabIndex = 8;
            popupRecordDescriptionLabel.Text = "Log time spent working manually:";
            // 
            // popupRecordButton
            // 
            popupRecordButton.Location = new Point(31, 921);
            popupRecordButton.Margin = new Padding(4, 3, 4, 3);
            popupRecordButton.Name = "popupRecordButton";
            popupRecordButton.Size = new Size(156, 38);
            popupRecordButton.TabIndex = 12;
            popupRecordButton.Text = "Record Time";
            popupRecordButton.UseVisualStyleBackColor = true;
            // 
            // popupTimerLabel
            // 
            popupTimerLabel.AutoSize = true;
            popupTimerLabel.Location = new Point(31, 883);
            popupTimerLabel.Margin = new Padding(4, 0, 4, 0);
            popupTimerLabel.Name = "popupTimerLabel";
            popupTimerLabel.Size = new Size(88, 25);
            popupTimerLabel.TabIndex = 15;
            popupTimerLabel.Text = "hh:mm:ss";
            // 
            // helpButton
            // 
            helpButton.Location = new Point(723, 20);
            helpButton.Margin = new Padding(4, 5, 4, 5);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(69, 38);
            helpButton.TabIndex = 16;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // manualMinutesInput
            // 
            manualMinutesInput.Location = new Point(453, 762);
            manualMinutesInput.Maximum = new decimal(new int[] { 1440, 0, 0, 0 });
            manualMinutesInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            manualMinutesInput.Name = "manualMinutesInput";
            manualMinutesInput.Size = new Size(180, 31);
            manualMinutesInput.TabIndex = 17;
            manualMinutesInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // addManualTimeButton
            // 
            addManualTimeButton.Location = new Point(453, 836);
            addManualTimeButton.Name = "addManualTimeButton";
            addManualTimeButton.Size = new Size(180, 34);
            addManualTimeButton.TabIndex = 18;
            addManualTimeButton.Text = "Record Manually";
            addManualTimeButton.UseVisualStyleBackColor = true;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 1010);
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
            Margin = new Padding(4, 3, 4, 3);
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

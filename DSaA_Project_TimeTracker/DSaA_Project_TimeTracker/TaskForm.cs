using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace DSaA_Project_TimeTracker
{
    using DSaA_Project_TimeTracker.Database;
    using DSaA_Project_TimeTracker.Database.Entities;
    using DSaA_Project_TimeTracker.Database.Repos;
    using DSaA_Project_TimeTracker.DTOs.Task;

    public partial class TaskForm : Form
    {
        public event EventHandler StatusChanged;

        private bool isHelpVisible = false;
        private Label[] helpLabels;
        private TaskToDo _task;
        private TaskAssignmentRepo _taskAssignmentRepo = new();
        private int _currentTaskId;
        private int _currentUserId;

        private TimeSpan _pausedTime = TimeSpan.Zero;
        private TimeSpan _sessionTime = TimeSpan.Zero;
        private bool _isRunning = false;
        private bool _isPaused = false;
        private DateTime _startTime;

        private System.Windows.Forms.Timer workTimer;  

        // Add this constructor
        public TaskForm(TaskToDo task)
        {
            InitializeComponent();
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            _task = task;
            _currentUserId = Globals.LoggedInUserId;

            popupTimerStartStopButton.Click += popupTimerStartStopButton_Click;
            popupTimerPauseButton.Click += popupTimerPauseButton_Click;
            popupRecordButton.Click += popupRecordButton_Click;
            addManualTimeButton.Click += addManualTimeButton_Click;
            popupDoneCheckbox.CheckedChanged += PopupDoneCheckbox_CheckedChanged;



            popupTaskNameLabel.Text = task.Title;
            popupTaskDescriptionTexbox.Text = task.Description;
            popupDoneCheckbox.Checked = task.Status == "Done";
            workTimer = new System.Windows.Forms.Timer();
            workTimer.Interval = 1000;
            workTimer.Tick += WorkTimer_Tick;


            this.Load += TaskForm_Load;
        }
        private void InitializeHelpLabels()
        {
            // Create labels for each control
            helpLabels = new Label[]
            {
                CreateHelpLabel(popupTaskNameLabel, "Name of your task."),
                CreateHelpLabel(popupProjectNameLabel, "Name of the project the task belongs to."),
                CreateHelpLabel(popupTaskDescriptionTexbox, "Description of your task."),
                CreateHelpLabel(popupDoneCheckbox, "Check once the task is done."),
                CreateHelpLabel(popupTimerStartStopButton, "Click to start/stop the timer."),
                CreateHelpLabel(popupTimerPauseButton, "Click to pause the timer."),
                CreateHelpLabel(addManualTimeButton, "Click to manually add the time spent."),
                CreateHelpLabel(manualMinutesInput, "Input the amount of minutes you have spent working."),
                CreateHelpLabel(popupRecordButton, "Click to save the time you spent on task.")
            };

            // Initially hide all help labels
            foreach (var label in helpLabels)
            {
                label.Visible = false;
                this.Controls.Add(label); // Add labels to the form
            }
        }

        private Label CreateHelpLabel(Control control, string text)
        {
            // Adjust position for specific controls
            int offsetX = 0; // Default horizontal offset
            int offsetY = -control.Height + 6; // Default vertical offset

            if (control == popupDoneCheckbox)
            {
                offsetX = -70;
                offsetY = -control.Height + 12;
            }

            if (control == popupTaskNameLabel)
            {
                offsetY = -control.Height + 18;
            }

            if (control == popupProjectNameLabel)
            {
                offsetY = -control.Height - 2;
            }

            // Create a label and position it near the control
            Label label = new Label
            {
                Text = text,
                AutoSize = true,
                BackColor = System.Drawing.Color.LightYellow,
                ForeColor = System.Drawing.Color.Black,
                Location = new System.Drawing.Point(control.Location.X + offsetX, control.Location.Y + offsetY)
            };
            return label;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            isHelpVisible = !isHelpVisible;
            foreach (var label in helpLabels)
            {
                label.Visible = isHelpVisible;
            }
        }


        // Implementing ShowDialog method
        public new DialogResult ShowDialog()
        {
            // Call the base class's ShowDialog method
            return base.ShowDialog();
        }
        private async void TaskForm_Load(object sender, EventArgs e)
        {
            var projectRepo = new ProjectRepo();
            var project = await projectRepo.GetById(_task.ProjectId);
            if (project != null)
            {
                popupProjectNameLabel.Text = project.ProjectName;
            }
            else
            {
                popupProjectNameLabel.Text = "Unknown Project";
            }
        }
        private void popupTimerStartStopButton_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _startTime = DateTime.Now;
                _pausedTime = TimeSpan.Zero;
                _isRunning = true;
                _isPaused = false;
                popupRecordButton.Enabled = false;
                workTimer.Start();
                popupTimerStartStopButton.Text = "Stop";
            }
            else
            {
                workTimer.Stop();
                _isRunning = false;
                _sessionTime = _pausedTime + (DateTime.Now - _startTime);
                popupRecordButton.Enabled = true;
                popupTimerStartStopButton.Text = "Start";
            }
        }

        private void popupTimerPauseButton_Click(object sender, EventArgs e)
        {
            if (!_isRunning) return;

            if (!_isPaused)
            {
                _pausedTime += DateTime.Now - _startTime;
                _isPaused = true;
                workTimer.Stop();
                popupRecordButton.Enabled = false;
                popupTimerPauseButton.Text = "Resume";
            }
            else
            {
                _startTime = DateTime.Now;
                _isPaused = false;
                workTimer.Start();
                popupTimerPauseButton.Text = "Pause";
            }
        }

        private void WorkTimer_Tick(object sender, EventArgs e)
        {
            if (_isRunning && !_isPaused)
            {
                TimeSpan elapsed = DateTime.Now - _startTime;
                var total = _pausedTime + elapsed;
                popupTimerLabel.Text = total.ToString(@"hh\:mm\:ss");
            }
        }

        private async void popupRecordButton_Click(object sender, EventArgs e)
        {
            decimal hoursWorked = (decimal)_sessionTime.TotalHours;

            try
            {
                using (var context = new TTDbContext())
                {
                    var assignment = await context.TaskAssignments
                        .FirstOrDefaultAsync(a => a.TaskId == _task.Id && a.UserId == _currentUserId);

                    if (assignment != null)
                    {
                        assignment.TimeSpentHours += hoursWorked;
                        await context.SaveChangesAsync();

                        MessageBox.Show($"Recorded {hoursWorked:F2} hours!");
                        popupRecordButton.Enabled = false;
                        popupTimerLabel.Text = "00:00:00";
                        _sessionTime = TimeSpan.Zero;
                    }
                    else
                    {
                        MessageBox.Show("Task assignment not found for the current user.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private async void addManualTimeButton_Click(object sender, EventArgs e)
        {
            int minutes = (int)manualMinutesInput.Value;
            decimal hoursToAdd = Math.Round((decimal)minutes / 60, 2);

            try
            {
                using (var context = new TTDbContext())
                {
                    var assignment = await context.TaskAssignments
                        .FirstOrDefaultAsync(a => a.TaskId == _task.Id && a.UserId == _currentUserId);

                    if (assignment != null)
                    {
                        assignment.TimeSpentHours += hoursToAdd;
                        await context.SaveChangesAsync();

                        MessageBox.Show($"Added {hoursToAdd:F2} hours manually.");
                        manualMinutesInput.Value = 1;
                    }
                    else
                    {
                        MessageBox.Show("Assignment not found for this task and user.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving manual time: " + ex.Message);
            }
        }

        private async void PopupDoneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new TTDbContext())
                {
                    var taskToUpdate = await context.Tasks.FindAsync(_task.Id);

                    if (taskToUpdate != null)
                    {
                        taskToUpdate.Status = popupDoneCheckbox.Checked ? "Done" : "ToDo";
                        await context.SaveChangesAsync();

                        _task.Status = taskToUpdate.Status;

                        StatusChanged?.Invoke(this, EventArgs.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating task status: " + ex.Message);
            }
        }


    }
}
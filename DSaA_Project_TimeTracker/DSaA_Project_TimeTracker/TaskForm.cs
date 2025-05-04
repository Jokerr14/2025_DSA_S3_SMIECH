using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSaA_Project_TimeTracker
{
    public partial class TaskForm : Form
    {

        private bool isHelpVisible = false;
        private Label[] helpLabels;
        public TaskForm()
        {
            InitializeComponent(); 
            InitializeHelpLabels();

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
                CreateHelpLabel(popupRecordStartDatePicker, "Mark when you started the task."),
                CreateHelpLabel(popupRecordEndDatePicker, "Mark when you finished the task."),
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
                offsetX = - 70;
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

        
    }
}

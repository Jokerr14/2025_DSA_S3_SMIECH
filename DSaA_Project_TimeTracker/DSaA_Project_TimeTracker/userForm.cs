using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.Database.Repos;

namespace DSaA_Project_TimeTracker
{
    public partial class userForm : Form
    {
        private bool isHelpVisible = false;
        private Label[] helpLabels;
        public object SelectedUser { get; set; }

        public userForm(object selectedUser)
        {
            InitializeComponent();
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            SelectedUser = selectedUser;

            if (SelectedUser is User user)
            {
                userNameLabel.Text = user.Username;

                userTasksListBox.Items.Clear();
                var taskTitles = user.TaskAssignments?
                    .Select(ta => ta.TaskToDo?.Title)
                    .Where(title => !string.IsNullOrEmpty(title))
                    .ToList() ?? new List<string>();

                foreach (var title in taskTitles)
                {
                    userTasksListBox.Items.Add(title);
                }
            }
            else
            {
                MessageBox.Show("Invalid user selected.");
                this.Close();
            }
        }

        private void InitializeHelpLabels()
        {
            // Create labels for each control  
            helpLabels = new Label[]
            {
                   CreateHelpLabel(userNameLabel, "Name of selected employee."),
                   CreateHelpLabel(userTasksListBox, "List of tasks the selected employee completed."),
                   CreateHelpLabel(helpButton, "Show help."),

            };

            // Initially hide all help labels  
            foreach (var label in helpLabels)
            {
                label.Visible = false;
                this.Controls.Add(label);
            }
        }

        private Label CreateHelpLabel(Control control, string text)
        {
            // Adjust position for specific controls  
            int offsetX = 0;
            int offsetY = control.Height;

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
    }
}

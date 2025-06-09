using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Task;
using DSaA_Project_TimeTracker.Database.Repos;
using DSaA_Project_TimeTracker.Utils;

namespace DSaA_Project_TimeTracker
{
    public partial class AssignUnassignTaskToEmployee : Form
    {
        private string _panelToShow;
        private Dictionary<Control, Label[]> subPanelHelpLabels;

        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }
        public object passedTask { get; set; }
        public AssignUnassignTaskToEmployee(object _passedTask) : this()
        {
            passedTask = _passedTask;
        }
        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public AssignUnassignTaskToEmployee()
        {
            InitializeComponent();
            assignCheckedListBox.ItemCheck += assignCheckedListBox_ItemCheck;
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            assignTaskToEmployeePanel.Visible = false;
            assignCheckedListBox.Items.Insert(0, "Select All Employees");
        }

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    assignTaskToEmployeePanel, new Label[]
                    {
                        CreateHelpLabel(assignCheckedListBox, "Select employee/s to assign task to.", assignTaskToEmployeePanel),
                        CreateHelpLabel(assignButton, "Click to assign task to selected employee/s.", assignTaskToEmployeePanel),
                        CreateHelpLabel(cancelAssignButton, "Click to cancel assignment.", assignTaskToEmployeePanel),
                        CreateHelpLabel(helpAssignButton, "Show help.", assignTaskToEmployeePanel)
                    }
                },
            };

            // Initially hide all help labels
            foreach (var subPanelLabels in subPanelHelpLabels.Values)
            {
                foreach (var label in subPanelLabels)
                {
                    label.Visible = false;
                    label.BringToFront(); // Ensure the label is on top of other controls
                }
            }
        }

        private Label CreateHelpLabel(Control control, string text, Control parentPanel)
        {
            // Adjust position for specific controls
            int offsetX = 0; // Align horizontally with the control
            int offsetY = control.Height; // Place the label just below the control with a small gap



            // Create a label and position it near the control
            Label label = new Label
            {
                Text = text,
                AutoSize = true,
                BackColor = System.Drawing.Color.LightYellow,
                ForeColor = System.Drawing.Color.Black,
                Location = new System.Drawing.Point(
                    Math.Max(0, control.Location.X + offsetX),
                    Math.Max(0, control.Location.Y + offsetY)
                )
            };

            // Add the label to the specified panel
            parentPanel.Controls.Add(label);
            label.BringToFront(); // Ensure the label is on top of other controls
            return label;
        }

        private void ToggleHelpLabels()
        {
            isHelpEnabled = !isHelpEnabled;
            isHelpVisible = isHelpEnabled;

            // Hide all labels first
            foreach (var subPanelLabels in subPanelHelpLabels.Values)
            {
                foreach (var label in subPanelLabels)
                {
                    label.Visible = false;
                }
            }

                foreach (var label in subPanelHelpLabels[assignTaskToEmployeePanel])
                {
                    label.Visible = isHelpVisible;
                }
            
        }
        private bool _suppressItemCheck = false;
        private void assignCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_suppressItemCheck) return;
            if (e.Index == 0)
            {
                _suppressItemCheck = true;
                bool checkAll = e.NewValue == CheckState.Checked;
                for (int i = 1; i < assignCheckedListBox.Items.Count; i++)
                {
                    assignCheckedListBox.SetItemChecked(i, checkAll);
                }
                _suppressItemCheck = false;
            }
            else if (e.NewValue == CheckState.Unchecked && assignCheckedListBox.GetItemChecked(0))
            {
                _suppressItemCheck = true;
                assignCheckedListBox.SetItemChecked(0, false);
                _suppressItemCheck = false;
            }
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (_panelToShow == "AssignEmployeeToTask")
            {
                assignTaskToEmployeePanel.BringToFront();
                assignTaskToEmployeePanel.Visible = false;
                assignTaskToEmployeePanel.Visible = true;
                var task = (TaskToDo)passedTask;
                assignTaskLabel.Text = task.Title;
                var projectRepo = new ProjectRepo();
                var project = await projectRepo.GetById(task.ProjectId);

                if (project != null && project.TeamProjects != null)
                {
                    var usersSet = new HashSet<User>(new UserIdComparer());

                    foreach (var teamProject in project.TeamProjects)
                    {
                        var team = await new TeamRepo().GetById(teamProject.TeamId);
                        if (team?.TeamMembers != null)
                        {
                            foreach (var member in team.TeamMembers)
                            {
                                if (member.User != null)
                                    usersSet.Add(member.User);
                            }
                        }
                    }

                    var taskAssignmentRepo = new TaskAssignmentRepo();
                    var assignments = await taskAssignmentRepo.GetAll();
                    var assignedUserIds = assignments
                        .Where(a => a.TaskId == task.Id)
                        .Select(a => a.UserId)
                        .ToHashSet();

                    assignCheckedListBox.Items.Clear();
                    assignCheckedListBox.Items.Insert(0, "Select All Employees");
                    assignCheckedListBox.DisplayMember = "Username";
                    assignCheckedListBox.ValueMember = "Id";
                    int idx = 1;
                    foreach (var user in usersSet)
                    {
                        assignCheckedListBox.Items.Add(user);
                        if (assignedUserIds.Contains(user.Id))
                        {
                            assignCheckedListBox.SetItemChecked(idx, true);
                        }
                        idx++;
                    }
                }

            }
        }

        private void helpAssignButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void helpUnassignButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void cancelAssignButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelUnassignButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void assignButton_Click(object sender, EventArgs e)
        {
            var task = (TaskToDo)passedTask;
            var taskAssignmentRepo = new TaskAssignmentRepo();

            var assignments = await taskAssignmentRepo.GetAll();
            var assignedUserIds = assignments
                .Where(a => a.TaskId == task.Id)
                .Select(a => a.UserId)
                .ToHashSet();

            for (int i = 1; i < assignCheckedListBox.Items.Count; i++)
            {
                if (assignCheckedListBox.Items[i] is User user)
                {
                    bool isChecked = assignCheckedListBox.GetItemChecked(i);
                    bool wasAssigned = assignedUserIds.Contains(user.Id);

                    if (isChecked && !wasAssigned)
                    {
                        await taskAssignmentRepo.Add(task.Id, user.Id);
                    }
                    else if (!isChecked && wasAssigned)
                    {
                        await taskAssignmentRepo.Delete(task.Id, user.Id);
                    }
                }
            }

            MessageBox.Show("Task assignments updated.");
            this.Close();
        }
    }
}

class UserIdComparer : IEqualityComparer<User>
{
    public bool Equals(User x, User y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (x is null || y is null) return false;
        return x.Id == y.Id;
    }

    public int GetHashCode(User obj)
    {
        return obj.Id.GetHashCode();
    }
}

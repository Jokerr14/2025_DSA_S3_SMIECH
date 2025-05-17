using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSaA_Project_TimeTracker.Database.Repos;
using DSaA_Project_TimeTracker.DTOs.Task;

namespace DSaA_Project_TimeTracker
{
    public partial class AddEditTask : Form
    {
        private string _panelToShow;
        private Dictionary<Control, Label[]> subPanelHelpLabels;
        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }
        private DSaA_Project_TimeTracker.DTOs.Project.ProjectDto _project;
        public AddEditTask(DSaA_Project_TimeTracker.DTOs.Project.ProjectDto project)
        {
            InitializeComponent();
            _project = project;
        }
        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public AddEditTask()
        {
            InitializeComponent();
            InitializeHelpLabels();

            addTaskPanel.Visible = false;
            editTaskPanel.Visible = false;
        }

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    editTaskPanel, new Label[]
                    {
                        CreateHelpLabel(editTaskNameTextBox, "Change name.", editTaskPanel),
                        CreateHelpLabel(editTaskDescTextBox, "Change description.", editTaskPanel),
                        CreateHelpLabel(editTaskStatusComboBox, "Change status.", editTaskPanel),
                        CreateHelpLabel(editTaskDatePicker, "Change date to which the task ought to be completed.", editTaskPanel),
                        CreateHelpLabel(discardEditTaskButton, "Discard all changes.", editTaskPanel),
                        CreateHelpLabel(saveEditTaskButton, "Save all changes.", editTaskPanel),
                        CreateHelpLabel(editTaskHelpButton, "Show help.", editTaskPanel),
                    }
                },
                {
                    addTaskPanel, new Label[]
                    {
                        CreateHelpLabel(addNewTaskNameTextBox, "Add name.", addTaskPanel),
                        CreateHelpLabel(addNewTaskDescTextBox, "Add description.", addTaskPanel),
                        CreateHelpLabel(addNewTaskStatusComboBox, "Set status of task.", addTaskPanel),
                        CreateHelpLabel(addNewTaskDatePicker, "Set date to which the task ought to be completed.", addTaskPanel),
                        CreateHelpLabel(discardNewTaskButton, "Discard task.", addTaskPanel),
                        CreateHelpLabel(saveNewTaskButton, "Save task.", addTaskPanel),
                        CreateHelpLabel(addTaskHelpButton, "Show help.", addTaskPanel),

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

            // Determine the currently active panel
            Control activePanel = null;
            if (addTaskPanel.Visible) activePanel = addTaskPanel;
            else if (editTaskPanel.Visible) activePanel = editTaskPanel;

            // Show labels for the active panel
            if (activePanel != null && subPanelHelpLabels.ContainsKey(activePanel))
            {
                foreach (var label in subPanelHelpLabels[activePanel])
                {
                    label.Visible = isHelpVisible;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Show the correct panel based on the value of PanelToShow
            if (_panelToShow == "AddTask")
            {
                addTaskPanel.BringToFront();
                editTaskPanel.Visible = false;
                addTaskPanel.Visible = true;

            }
            else if (_panelToShow == "EditTask")
            {
                editTaskPanel.BringToFront();
                addTaskPanel.Visible = false;
                editTaskPanel.Visible = true;
            }
        }

        private void addTaskHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void editTaskHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void discardNewTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void discardEditTaskButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveNewTaskButton_Click(object sender, EventArgs e)
        {
            int projectId = 0;
            if (_project is DSaA_Project_TimeTracker.DTOs.Project.ProjectDto project)
            {
                projectId = project.Id;
            }
            var taskName = addNewTaskNameTextBox.Text;
            var taskDesc = addNewTaskDescTextBox.Text;
            var taskStatus = addNewTaskStatusComboBox.Text.ToString();
            var taskDate = addNewTaskDatePicker.Value;
            var newTask = new DTOs.Task.ModifyTaskProgramDto
            {
                Title = taskName,
                Description = taskDesc,
                Status = taskStatus,
                DueDate = taskDate,
                ProjectId = projectId
            };
            var repo = new DSaA_Project_TimeTracker.Database.Repos.TaskRepo();
            await repo.Add(newTask);
            this.Close();
        }

        private void saveEditTaskButton_Click(object sender, EventArgs e)
        {

        }

        private void addNewTaskStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void editTaskStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }

}

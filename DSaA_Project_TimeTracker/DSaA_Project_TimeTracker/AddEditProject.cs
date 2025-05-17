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
    public partial class AddEditProject : Form
    {
        private string _panelToShow;
        private Dictionary<Control, Label[]> subPanelHelpLabels;
        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }

        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public AddEditProject()
        {
            InitializeComponent();
            InitializeHelpLabels();

            addProjectPanel.Visible = false;
            editProjectPanel.Visible = false;
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

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    editProjectPanel, new Label[]
                    {
                        CreateHelpLabel(editProjectNameTextBox, "Change name.", editProjectPanel),
                        CreateHelpLabel(editProjectDescTextBox, "Change description.", editProjectPanel),
                        CreateHelpLabel(editStartDatePicker, "Change the start date of the task.", editProjectPanel),
                        CreateHelpLabel(editEndDatePicker, "Change the end date of the task.", editProjectPanel),
                        CreateHelpLabel(discardEditProjectButton, "Discard all changes.", editProjectPanel),
                        CreateHelpLabel(saveEditProjectButton, "Save all changes.", editProjectPanel),
                        CreateHelpLabel(editProjectHelpButton, "Show help.", editProjectPanel),
                    }
                },
                {
                    addProjectPanel, new Label[]
                    {
                        CreateHelpLabel(addProjectNameTextBox, "Add name.", addProjectPanel),
                        CreateHelpLabel(addProjectDescTextBox, "Add description.", addProjectPanel),
                        CreateHelpLabel(addProjectStartDatePicker, "Set the start date of the task.", addProjectPanel),
                        CreateHelpLabel(addProjectEndDatePicker, "Set the end date of the task.", addProjectPanel),
                        CreateHelpLabel(discardAddProjectButton, "Discard task.", addProjectPanel),
                        CreateHelpLabel(saveAddProjectButton, "Save task.", addProjectPanel),
                        CreateHelpLabel(addProjectHelpButton, "Show help.", addProjectPanel),

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
            if (addProjectPanel.Visible) activePanel = addProjectPanel;
            else if (editProjectPanel.Visible) activePanel = editProjectPanel;

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
            if (_panelToShow == "AddProject")
            {
                addProjectPanel.BringToFront();
                editProjectPanel.Visible = false;
                addProjectPanel.Visible = true;

            }
            else if (_panelToShow == "EditProject")
            {
                editProjectPanel.BringToFront();
                addProjectPanel.Visible = false;
                editProjectPanel.Visible = true;
            }
        }

        private void editProjectHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void addProjectHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void discardEditProjectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void discardAddProjectButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveEditProjectButton_Click(object sender, EventArgs e)
        {

        }

        private async void saveAddProjectButton_Click(object sender, EventArgs e)
        {
            var name = addProjectNameTextBox.Text.Trim();
            var desc = addProjectDescTextBox.Text.Trim();
            var startDate = addProjectStartDatePicker.Value;
            var endDate = addProjectEndDatePicker.Value;
            var newProject = new DSaA_Project_TimeTracker.DTOs.Project.ModifyProjectDto
            {
                ProjectName = name,
                Description = desc,
                StartDate = startDate,
                EndDate = endDate
            };
            var repo = new DSaA_Project_TimeTracker.Database.Repos.ProjectRepo();
            await repo.Add(newProject);

            this.Close();
        }
    }
}

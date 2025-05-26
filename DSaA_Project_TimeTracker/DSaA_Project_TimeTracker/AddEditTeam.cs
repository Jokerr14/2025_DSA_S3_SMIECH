using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSaA_Project_TimeTracker.DTOs.Team;
using DSaA_Project_TimeTracker.Database.Repos;
using DSaA_Project_TimeTracker.Database.Entities;

namespace DSaA_Project_TimeTracker
{
    public partial class AddEditTeam : Form
    {
        private string _panelToShow;
        private Dictionary<Control, Label[]> subPanelHelpLabels;
        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }
        public object ItemToEdit { get; set; }
        public AddEditTeam(object itemToEdit) : this()
        {
            ItemToEdit = itemToEdit;
        }
        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public AddEditTeam()
        {
            InitializeComponent();
            InitializeHelpLabels();

            addTeamPanel.Visible = false;
            editTeamPanel.Visible = false;
        }

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    editTeamPanel, new Label[]
                    {
                        CreateHelpLabel(editTeamNameTextBox, "Change name.", editTeamPanel),
                        CreateHelpLabel(editTeamDescTextBox, "Change description.", editTeamPanel),
                        CreateHelpLabel(discardEditTeamButton, "Discard all changes.", editTeamPanel),
                        CreateHelpLabel(saveEditTeamButton, "Save all changes.", editTeamPanel),
                        CreateHelpLabel(editTeamHelpButton, "Show help.", editTeamPanel),
                    }
                },
                {
                    addTeamPanel, new Label[]
                    {
                        CreateHelpLabel(addNewTeamNameTextBox, "Add name.", addTeamPanel),
                        CreateHelpLabel(addNewTeamDescTextBox, "Add description.", addTeamPanel),
                        CreateHelpLabel(discardNewTeamButton, "Discard task.", addTeamPanel),
                        CreateHelpLabel(saveNewTeamButton, "Save task.", addTeamPanel),
                        CreateHelpLabel(addTeamHelpButton, "Show help.", addTeamPanel),

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
            if (addTeamPanel.Visible) activePanel = addTeamPanel;
            else if (editTeamPanel.Visible) activePanel = editTeamPanel;

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
            if (_panelToShow == "AddTeam")
            {
                addTeamPanel.BringToFront();
                editTeamPanel.Visible = false;
                addTeamPanel.Visible = true;

            }
            else if (_panelToShow == "EditTeam")
            {
                editTeamPanel.BringToFront();
                addTeamPanel.Visible = false;
                editTeamPanel.Visible = true;
                editTeamNameTextBox.Text = ((Team)ItemToEdit).TeamName;
                editTeamDescTextBox.Text = ((Team)ItemToEdit).Description;

            }
        }

        private void addTeamHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void editTeamHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void discardNewTeamButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void discardEditTeamButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveNewTeamButton_Click(object sender, EventArgs e)
        {
            
            var newTeam = new ModifyTeamDto
            {
                TeamName = addNewTeamNameTextBox.Text,
                Description = addNewTeamDescTextBox.Text
            };
            var repo = new TeamRepo();
            await repo.Add(newTeam);
            this.Close();
        }

        private async void saveEditTeamButton_Click(object sender, EventArgs e)
        {
            var teamName = editTeamNameTextBox.Text;
            var teamDescription = editTeamDescTextBox.Text;
            var modifiedTeam = new ModifyTeamDto
            {
                TeamName = teamName,
                Description = teamDescription
            };
            var repo = new TeamRepo();
            await repo.UpdateById(((Team)ItemToEdit).Id, modifiedTeam);
            this.Close();
        }
    }
}

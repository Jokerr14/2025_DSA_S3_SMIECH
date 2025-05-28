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
    public partial class AssignUnassignEmployeeToTeam : Form
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

        public AssignUnassignEmployeeToTeam()
        {
            InitializeComponent();
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            unassignEmployeeFromTeamsPanel.Visible = false;
            assignEmployeeToTeamsPanel.Visible = false;

            unassignCheckedListBox.Items.Insert(0, "Select All Teams");
            assignCheckedListBox.Items.Insert(0, "Select All Teams");
        }

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    assignEmployeeToTeamsPanel, new Label[]
                    {
                        CreateHelpLabel(assignCheckedListBox, "Select teams to assign employee to.", assignEmployeeToTeamsPanel),
                        CreateHelpLabel(assignButton, "Click to assign employee to selected team/s.", assignEmployeeToTeamsPanel),
                        CreateHelpLabel(cancelAssignButton, "Click to cancel assignment.", assignEmployeeToTeamsPanel),
                        CreateHelpLabel(helpAssignButton, "Show help.", assignEmployeeToTeamsPanel)
                    }
                },
                {
                    unassignEmployeeFromTeamsPanel, new Label[]
                    {
                        CreateHelpLabel(unassignCheckedListBox, "Select teams to remove employee from.", unassignEmployeeFromTeamsPanel),
                        CreateHelpLabel(removeButton, "Click to remove employee from selected team/s.", unassignEmployeeFromTeamsPanel),
                        CreateHelpLabel(cancelUnassignButton, "Click to cancel removal.", unassignEmployeeFromTeamsPanel),
                        CreateHelpLabel(helpUnassignButton, "Show help.", unassignEmployeeFromTeamsPanel)
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
            if (assignEmployeeToTeamsPanel.Visible) activePanel = assignEmployeeToTeamsPanel;
            else if (unassignEmployeeFromTeamsPanel.Visible) activePanel = unassignEmployeeFromTeamsPanel;

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

            if (_panelToShow == "AssignEmployeeToTeam")
            {
                assignEmployeeToTeamsPanel.BringToFront();
                assignEmployeeToTeamsPanel.Visible = false;
                assignEmployeeToTeamsPanel.Visible = true;

            }
            else if (_panelToShow == "UnassignEmployeeFromTeam")
            {
                unassignEmployeeFromTeamsPanel.BringToFront();
                unassignEmployeeFromTeamsPanel.Visible = false;
                unassignEmployeeFromTeamsPanel.Visible = true;
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

        private void assignButton_Click(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace DSaA_Project_TimeTracker
{
    public partial class AssignUnassignTeamToProject : Form
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

        public AssignUnassignTeamToProject()
        {
            InitializeComponent();
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            unassignTeamFromProjectPanel.Visible = false;
            assignTeamToProjectPanel.Visible = false;

            unassignCheckedListBox.Items.Insert(0, "Select All Projects");
            assignCheckedListBox.Items.Insert(0, "Select All Projects");
        }

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    assignTeamToProjectPanel, new Label[]
                    {
                        CreateHelpLabel(assignCheckedListBox, "Select teams to assign to project.", assignTeamToProjectPanel),
                        CreateHelpLabel(assignButton, "Click to assign selected teams to project.", assignTeamToProjectPanel),
                        CreateHelpLabel(cancelAssignButton, "Click to cancel assignment.", assignTeamToProjectPanel),
                        CreateHelpLabel(helpAssignButton, "Show help.", assignTeamToProjectPanel)
                    }
                },
                {
                    unassignTeamFromProjectPanel, new Label[]
                    {
                        CreateHelpLabel(unassignCheckedListBox, "Select teams to remove from project.", unassignTeamFromProjectPanel),
                        CreateHelpLabel(removeButton, "Click to remove selected teams from project.", unassignTeamFromProjectPanel),
                        CreateHelpLabel(cancelUnassignButton, "Click to cancel removal.", unassignTeamFromProjectPanel),
                        CreateHelpLabel(helpUnassignButton, "Show help.", unassignTeamFromProjectPanel)
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
            if (unassignTeamFromProjectPanel.Visible) activePanel = unassignTeamFromProjectPanel;
            else if (assignTeamToProjectPanel.Visible) activePanel = assignTeamToProjectPanel;

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

            if (_panelToShow == "AssignTeamToProject")
            {
                assignTeamToProjectPanel.BringToFront();
                assignTeamToProjectPanel.Visible = false;
                assignTeamToProjectPanel.Visible = true;

            }
            else if (_panelToShow == "UnassignTeamFromProject")
            {
                unassignTeamFromProjectPanel.BringToFront();
                assignTeamToProjectPanel.Visible = false;
                unassignTeamFromProjectPanel.Visible = true;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelUnassignButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void assignButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelAssignButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpAssignButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void helpUnassignButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }
    }
}

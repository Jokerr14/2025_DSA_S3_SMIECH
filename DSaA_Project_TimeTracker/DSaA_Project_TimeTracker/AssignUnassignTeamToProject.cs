using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.Database.Repos;
using DSaA_Project_TimeTracker.Utils;
namespace DSaA_Project_TimeTracker
{
    public partial class AssignUnassignTeamToProject : Form
    {
        private string _panelToShow;
        private List<Project> _projectsCache = new();
        private Dictionary<Control, Label[]> subPanelHelpLabels;

        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }
        public object passedTeam { get; set; }
        public AssignUnassignTeamToProject(object _passedTeam) : this()
        {
            passedTeam = _passedTeam;
        }
        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public AssignUnassignTeamToProject()
        {
            InitializeComponent();
            assignCheckedListBox.ItemCheck += assignCheckedListBox_ItemCheck;
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            assignTeamToProjectPanel.Visible = false;
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
                        CreateHelpLabel(assignCheckedListBox, "Select projects to assign team to.", assignTeamToProjectPanel),
                        CreateHelpLabel(assignButton, "Click to assign team to selected project/s.", assignTeamToProjectPanel),
                        CreateHelpLabel(cancelAssignButton, "Click to cancel assignment.", assignTeamToProjectPanel),
                        CreateHelpLabel(helpAssignButton, "Show help.", assignTeamToProjectPanel)
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
            // Show labels for the active panel

                foreach (var label in subPanelHelpLabels[assignTeamToProjectPanel])
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
   
            if (_panelToShow == "AssignTeamToProject")
            {
                assignTeamToProjectPanel.BringToFront();
                assignTeamToProjectPanel.Visible = false;
                assignTeamToProjectPanel.Visible = true;
                assignTeamLabel.Text = ((Team)passedTeam).TeamName;

                var projectRepo = new ProjectRepo();
                var projects = await projectRepo.GetAll();
                if (projects != null)
                {
                    _projectsCache = projects.ToList();
                    assignCheckedListBox.DisplayMember = "ProjectName";
                    assignCheckedListBox.ValueMember = "Id";
                    for (int i = 0; i < _projectsCache.Count; i++)
                    {
                        var project = _projectsCache[i];
                        assignCheckedListBox.Items.Add(project);
                        if (project.TeamProjects != null && project.TeamProjects.Any(tp => tp.TeamId == ((Team)passedTeam).Id))
                        {
                            assignCheckedListBox.SetItemChecked(i + 1, true);
                        }
                    }
                }
            }

        }

        private void cancelUnassignButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void assignButton_Click(object sender, EventArgs e)
        {
            var team = (Team)passedTeam;
            var assignmentsRepo = new AssignmentsRepo();

            for (int i = 0; i < _projectsCache.Count; i++)
            {
                var project = _projectsCache[i];
                bool isChecked = assignCheckedListBox.GetItemChecked(i + 1);
                bool wasMember = project.TeamProjects != null && project.TeamProjects.Any(tp => tp.TeamId == team.Id);

                if (isChecked && !wasMember)
                {
                    await assignmentsRepo.AssignProjectToTeam(team.Id, project.Id);
                }
                else if (!isChecked && wasMember)
                {
                    await assignmentsRepo.DeleteProjectFromTeam(team.Id, project.Id);
                }
            }

            MessageBox.Show("Team assignments updated.");
            this.Close();
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

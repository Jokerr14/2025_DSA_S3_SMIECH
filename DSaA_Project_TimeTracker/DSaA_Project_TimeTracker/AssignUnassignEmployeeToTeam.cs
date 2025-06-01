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
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.Database.Repos;
using DSaA_Project_TimeTracker.Utils;

namespace DSaA_Project_TimeTracker
{
    public partial class AssignUnassignEmployeeToTeam : Form
    {
        private string _panelToShow;
        private List<Team> _teamsCache = new();
        private Dictionary<Control, Label[]> subPanelHelpLabels;

        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }
        public object passedEmployee { get; set; }
        public AssignUnassignEmployeeToTeam(object _passedEmployee) : this()
        {
            passedEmployee = _passedEmployee;
        }
        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public AssignUnassignEmployeeToTeam()
        {
            InitializeComponent();
            assignCheckedListBox.ItemCheck += assignCheckedListBox_ItemCheck;
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            assignEmployeeToTeamsPanel.Visible = false;
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
                        CreateHelpLabel(assignCheckedListBox, "Select which teams the employee should belong to.", assignEmployeeToTeamsPanel),
                        CreateHelpLabel(assignButton, "Click to save changes.", assignEmployeeToTeamsPanel),
                        CreateHelpLabel(cancelAssignButton, "Click to cancel assignment.", assignEmployeeToTeamsPanel),
                        CreateHelpLabel(helpAssignButton, "Show help.", assignEmployeeToTeamsPanel)
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

                foreach (var label in subPanelHelpLabels[assignEmployeeToTeamsPanel])
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

            if (_panelToShow == "AssignEmployeeToTeam")
            {
                assignEmployeeToTeamsPanel.BringToFront();
                assignEmployeeToTeamsPanel.Visible = true;
                assignTaskLabel.Text = ((User)passedEmployee).Username;
                var teamRepo = new TeamRepo();
                var teams = await teamRepo.GetAll();
                if (teams != null)
                {
                    _teamsCache = teams.ToList();
                    assignCheckedListBox.DisplayMember = "TeamName";
                    assignCheckedListBox.ValueMember = "Id";
                    for (int i = 0; i < _teamsCache.Count; i++)
                    {
                        var team = _teamsCache[i];
                        assignCheckedListBox.Items.Add(team);
                        if (team.TeamMembers != null && team.TeamMembers.Any(tm => tm.UserId == ((User)passedEmployee).Id))
                        {
                            assignCheckedListBox.SetItemChecked(i + 1, true);
                        }
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

            bool anyTeamSelected = false;
            for (int i = 1; i < assignCheckedListBox.Items.Count; i++)
            {
                if (assignCheckedListBox.GetItemChecked(i))
                {
                    anyTeamSelected = true;
                    break;
                }
            }

            if (!anyTeamSelected)
            {
                MessageBox.Show("An employee must belong to at least one team. Please select at least one team.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var user = (User)passedEmployee;
            var assignmentsRepo = new AssignmentsRepo();

            for (int i = 0; i < _teamsCache.Count; i++)
            {
                var team = _teamsCache[i];
                bool isChecked = assignCheckedListBox.GetItemChecked(i + 1);
                bool wasMember = team.TeamMembers != null && team.TeamMembers.Any(tm => tm.UserId == user.Id);

                if (isChecked && !wasMember)
                {
                    await assignmentsRepo.AssignMemberToTeam(team.Id, user.Id);
                }
                else if (!isChecked && wasMember)
                {
                    await assignmentsRepo.DeleteMemberFromTeam(team.Id, user.Id);
                }
            }

            MessageBox.Show("Team assignments updated.");
            this.Close();
        }
    }
}

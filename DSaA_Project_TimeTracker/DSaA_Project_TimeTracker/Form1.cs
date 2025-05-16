using DSaA_Project_TimeTracker.Database;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.DTOs.Team;
using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DSaA_Project_TimeTracker.Database.Repositories;
using DSaA_Project_TimeTracker.DTOs.Project;
using DSaA_Project_TimeTracker.DTOs.TeamProject;
using DSaA_Project_TimeTracker.DTOs.UserHistory;
using DSaA_Project_TimeTracker.DTOs.Task;

namespace DSaA_Project_TimeTracker
{
    public partial class Form1 : Form
    {
        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public Form1()
        {
            InitializeComponent();
            InitializeHelpLabels();
        }

        private Dictionary<Control, Label[]> subPanelHelpLabels;

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    adminViewPanel, new Label[]
                    {
                        CreateHelpLabel(projectsAdminButton, "View available projects to manage.", adminViewPanel),
                        CreateHelpLabel(tasksAdminButton, "View available tasks to manage.", adminViewPanel),
                        CreateHelpLabel(teamsAdminButton, "View available teams to manage.", adminViewPanel),
                        CreateHelpLabel(employeesAdminButton, "View available employees to manage.", adminViewPanel),
                        CreateHelpLabel(logOutAdminButton, "Log out of the admin panel.", adminViewPanel),
                        CreateHelpLabel(helpButtonAdmin, "Show help.", adminViewPanel),
                    }
                },
                {
                    projectsAdminPanel, new Label[]
                    {
                        CreateHelpLabel(projectsAdminListbox, "List of projects.", projectsAdminPanel),
                        CreateHelpLabel(projectsNameAdminTextbox, "Name of selected project.", projectsAdminPanel),
                        CreateHelpLabel(projectsDescriptionAdminTextbox, "Description of selected project.", projectsAdminPanel),
                        CreateHelpLabel(projectsStartDateAdminDatePicker, "Start date of selected project.", projectsAdminPanel),
                        CreateHelpLabel(projectsEndDateAdminDatePicker, "End date of selected project.", projectsAdminPanel),

                        CreateHelpLabel(projectsAddProjectAdminButton, "Click to add a new project.", projectsAdminPanel),
                        CreateHelpLabel(projectsEditProjectAdminButton, "Click to edit the selected project.", projectsAdminPanel),
                        CreateHelpLabel(projectsDeleteProjectAdminButton, "Click to delete the selected project.", projectsAdminPanel)
                    }
                },
                {                  
                    tasksAdminPanel, new Label[]
                    {
                        CreateHelpLabel(tasksProjectNameAdminLabel, "Name of project that the task belongs to.", tasksAdminPanel),
                        CreateHelpLabel(tasksAdminListbox, "List of tasks in selected project.", tasksAdminPanel),

                        CreateHelpLabel(tasksNameAdminTextbox, "Name of selected task", tasksAdminPanel),
                        CreateHelpLabel(tasksDescriptionAdminTextbox, "Description of selected task.", tasksAdminPanel),

                        CreateHelpLabel(tasksStatusAdminTextbox, "Status of selected task.", tasksAdminPanel),
                        CreateHelpLabel(tasksDueDateAdminDatePicker, "Date to which the task ought to be completed.", tasksAdminPanel),

                        CreateHelpLabel(tasksAddTaskAdminButton, "Click to add a new task.", tasksAdminPanel),
                        CreateHelpLabel(tasksEditTaskAdminButton, "Click to edit the selected task.", tasksAdminPanel),
                        CreateHelpLabel(tasksDeleteTaskAdminButton, "Click to delete the selected task.", tasksAdminPanel)
                    }
                },
                {
                    teamsAdminPanel, new Label[]
                    {
                        CreateHelpLabel(teamsAdminListbox, "List of teams.", teamsAdminPanel),
                        CreateHelpLabel(teamsNameAdminTexbox, "Name of selected team.", teamsAdminPanel),
                        CreateHelpLabel(teamsDescriptionAdminTextbox, "Description of selected team.", teamsAdminPanel),

                        CreateHelpLabel(teamsAddTeamAdminButton, "Click to add a new team.", teamsAdminPanel),
                        CreateHelpLabel(teamsEditTeamAdminButton, "Click to edit the selected team.", teamsAdminPanel),
                        CreateHelpLabel(teamsDeleteTeamAdminButton, "Click to delete the selected team.", teamsAdminPanel)
                    }
                },
                {
                    employeesAdminPanel, new Label[]
                    {
                        CreateHelpLabel(teamNameEmployeesAdminPanel, "Name of the team that the employees belong to.", employeesAdminPanel),
                        CreateHelpLabel(employeesAdminListbox, "List of employees.", employeesAdminPanel),

                        CreateHelpLabel(employeesUsernameAdminTexbox, "Username of the employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesEmailAdminTextbox, "Email of the employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesRoleAdminTextbox, "Role of the employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesStatusAdminTextbox, "Status of the employee.", employeesAdminPanel),

                        CreateHelpLabel(employeesAddEmployeeAdminButton, "Click to add a new employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesEditEmployeeAdminButton, "Click to edit the selected employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesDeleteEmployeeAdminButton, "Click to delete the selected employee.", employeesAdminPanel)
                    }
                },
                {
                    userViewPanel,new Label[]
                    {
                        CreateHelpLabel(teamsUserButton, "View the teams you belong to.", userViewPanel),
                        CreateHelpLabel(tasksUserButton, "View the tasks assigned to you.", userViewPanel),
                        CreateHelpLabel(logOutUserButton, "Log out of the user panel.", userViewPanel),
                        CreateHelpLabel(helpButtonUser, "Show help.", userViewPanel)
                    }
                },
                {
                    teamsUserPanel, new Label[]
                    {
                        CreateHelpLabel(teamsNameUserListbox, "List of teams you belong to.", teamsUserPanel),
                        CreateHelpLabel(teamsMembersUserListbox, "List of members of the currently selected team.", teamsUserPanel)
                    }
                },
                {
                    tasksUserPanel, new Label[]
                    {
                        CreateHelpLabel(tasksTodoUserListbox, "List of tasks assigned to you.", tasksUserPanel),
                        CreateHelpLabel(tasksDoneUserListbox, "List of the tasks you completed.", tasksUserPanel)
                    }
                }
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

            // Always show adminViewPanel labels
            if (subPanelHelpLabels.ContainsKey(adminViewPanel))
            {
                foreach (var label in subPanelHelpLabels[adminViewPanel])
                {
                    label.Visible = isHelpVisible;
                }
            }

            // Always show userViewPanel labels
            if (subPanelHelpLabels.ContainsKey(userViewPanel))
            {
                foreach (var label in subPanelHelpLabels[userViewPanel])
                {
                    label.Visible = isHelpVisible;
                }
            }

            // Determine the currently visible sub-panel
            Control activeSubPanel = null;
            if (tasksAdminPanel.Visible) activeSubPanel = tasksAdminPanel;
            else if (projectsAdminPanel.Visible) activeSubPanel = projectsAdminPanel;
            else if (teamsAdminPanel.Visible) activeSubPanel = teamsAdminPanel;
            else if (employeesAdminPanel.Visible) activeSubPanel = employeesAdminPanel;
            else if (teamsUserPanel.Visible) activeSubPanel = teamsUserPanel;
            else if (tasksUserPanel.Visible) activeSubPanel = tasksUserPanel;


            // Show labels for the active sub-panel
            if (activeSubPanel != null && subPanelHelpLabels.ContainsKey(activeSubPanel))
            {
                foreach (var label in subPanelHelpLabels[activeSubPanel])
                {
                    label.Visible = isHelpVisible;
                }
            }
        }

        private void ResetHelpState()
        {
            isHelpEnabled = false;
            isHelpVisible = false;

            // Hide all help labels
            foreach (var subPanelLabels in subPanelHelpLabels.Values)
            {
                foreach (var label in subPanelLabels)
                {
                    label.Visible = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminViewPanel.Visible = false;
            userViewPanel.Visible = true;
            loginPanel.Visible = false;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            adminViewPanel.Visible = true;
            userViewPanel.Visible = false;
            loginPanel.Visible = false;

            var teamRepo = new TeamRepo();
            var userRepo = new UserRepo();
            var roleRepo = new RoleRepo();
            var projectRepo = new ProjectRepo();
            var tpRepo = new TeamProjectRepo();
            var uhRepo = new UserHistoryRepo();
            var taskRepo = new TaskRepo();
            
            var a = await userRepo.GetAll();
            var b = await teamRepo.GetAll();
            var c = await roleRepo.GetAll();
            var d = await projectRepo.GetAll();
            var ea = await tpRepo.GetAll();
            var his = await uhRepo.GetAll();
            var ta = await taskRepo.GetAll();
        }

        private void logOutAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            loginLoginTextbox.Text = "";
            loginPasswordTextbox.Text = "";
            loginPanel.Visible = true;
        }
        private void logOutUserButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            teamsUserPanel.Visible = false;
            tasksUserPanel.Visible = false;
            loginLoginTextbox.Text = "";
            loginPasswordTextbox.Text = "";
            loginPanel.Visible = true;
        }
        private void projectsAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            projectsAdminPanel.Visible = true;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
        }

        private void tasksAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = true;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
        }

        private void teamsAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = true;
            employeesAdminPanel.Visible = false;
        }

        private void employeesAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = true;
        }

        private void tasksUserButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            teamsUserPanel.Visible = false;
            tasksUserPanel.Visible = true;
        }

        private void teamsUserButton_Click(object sender, EventArgs e)
        {
            ResetHelpState(); // Reset help state when switching panels
            tasksUserPanel.Visible = false;
            teamsUserPanel.Visible = true;
            var repo = new UserRepo();
            var user = repo.GetById(0);
        }

        ////////////////////////////TO DO///////////////////////////////////////////
        //Add backend logic for creating, editing and deleting projects, tasks, teams, and employees
        //Maybe it opens a new window to input necessary data??

        private void projectsAddProjectAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void projectsEditProjectAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void projectsDeleteProjectAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void teamsAddTeamAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void teamsEditTeamAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void teamsDeleteTeamAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void tasksAddTaskAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void tasksEditTaskAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void tasksDeleteTaskAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void employeesAddEmployeeAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void employeesEditEmployeeAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void employeesDeleteEmployeeAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the TaskForm
            TaskForm taskForm = new TaskForm();

            // Set the form to open as a dialog without closing the current form
            taskForm.ShowDialog();
        }

        private void helpButtonUser_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void helpButtonAdmin_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }








        ///////////////////////////////////////////////////////////////////////

    }
}

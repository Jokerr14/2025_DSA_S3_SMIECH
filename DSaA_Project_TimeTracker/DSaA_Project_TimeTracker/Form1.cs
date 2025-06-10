using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.Database.Repos;
using DSaA_Project_TimeTracker.DTOs.User;
//using Microsoft.VisualBasic.ApplicationServices;
using System.Threading.Tasks;


namespace DSaA_Project_TimeTracker
{
    public partial class Form1 : Form
    {
        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        private async void tasksTodoUserListbox_DoubleClick_Handler(object sender, EventArgs e)
        {
            if (tasksTodoUserListbox.SelectedItem is DSaA_Project_TimeTracker.Database.Entities.TaskToDo selectedTask)
            {
                var taskRepo = new TaskRepo();
                var taskDetails = await taskRepo.GetById(selectedTask.Id);

                if (taskDetails != null)
                {
                    var taskForm = new TaskForm(taskDetails);
                    taskForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Could not load task details.");
                }
            }
        }

        private async void tasksDoneUserListbox_DoubleClick_Handler(object sender, EventArgs e)
        {
            if (tasksDoneUserListbox.SelectedItem is DSaA_Project_TimeTracker.Database.Entities.TaskToDo selectedTask)
            {
                var taskRepo = new TaskRepo();
                var taskDetails = await taskRepo.GetById(selectedTask.Id);

                if (taskDetails != null)
                {
                    var taskForm = new TaskForm(taskDetails);
                    taskForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Could not load task details.");
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            projectTeamsAdminListBox = new ListBox
            {
                Name = "projectTeamsAdminListBox",
                Width = projectsDescriptionAdminTextbox.Width,
                Height = (int)(projectsDescriptionAdminTextbox.Height), 
                Location = new System.Drawing.Point(
                projectsDescriptionAdminTextbox.Left,
                projectsDescriptionAdminTextbox.Top + projectsDescriptionAdminTextbox.Height +20
                )
            };
            projectsAdminPanel.Controls.Add(projectTeamsAdminListBox);


            taskAssignmentsAdminListView = new System.Windows.Forms.ListView
            {
                Name = "taskAssignmentsAdminListView",
                View = View.Details,
                FullRowSelect = true,
                Width = tasksDescriptionAdminTextbox.Width,
                Height = tasksDescriptionAdminTextbox.Height, 
                Location = new System.Drawing.Point(
                    tasksDescriptionAdminTextbox.Left,
                    tasksDescriptionAdminTextbox.Top + tasksDescriptionAdminTextbox.Height + 20 
                )
            };
            taskAssignmentsAdminListView.Columns.Add("Assigned User", (int)(taskAssignmentsAdminListView.Width * 0.6));
            taskAssignmentsAdminListView.Columns.Add("Time Spent (hours)", (int)(taskAssignmentsAdminListView.Width * 0.35));
            tasksAdminPanel.Controls.Add(taskAssignmentsAdminListView);

            

            tasksTodoUserListbox.DoubleClick += tasksTodoUserListbox_DoubleClick_Handler;
            tasksDoneUserListbox.DoubleClick += tasksDoneUserListbox_DoubleClick_Handler;

            
            InitializeHelpLabels();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private Dictionary<Control, Label[]> subPanelHelpLabels;
        private List<Project> _projectsCache = new();
        private int currentProjectId;
        private List<Team> _teamsCache = new();



        private readonly UserRepo _userRepo = new UserRepo();

        private int userId = 0; // SUS idk what else to do
        private System.Windows.Forms.ListView taskAssignmentsAdminListView;
        private ListBox projectTeamsAdminListBox;

        private void InitializeHelpLabels()
        {
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
                        CreateHelpLabel(projectsEndDateAdminDatePicker, "Expected finish date of selected project.", projectsAdminPanel),
                        CreateHelpLabel(projectTeamsAdminListBox, "View which teams are assigned to selected project.", projectsAdminPanel),
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

                        CreateHelpLabel(tasksNameAdminTextbox, "Name of selected task.", tasksAdminPanel),
                        CreateHelpLabel(tasksDescriptionAdminTextbox, "Description of selected task.", tasksAdminPanel),
                        CreateHelpLabel(taskAssignmentsAdminListView, "View which users are assigned to selected task, and how much time they've spent working on it.", tasksAdminPanel),

                        CreateHelpLabel(tasksStatusAdminTextbox, "Status of selected task.", tasksAdminPanel),
                        CreateHelpLabel(tasksDueDateAdminDatePicker, "Date to which the task ought to be completed.", tasksAdminPanel),

                        CreateHelpLabel(tasksAddTaskAdminButton, "Click to add a new task.", tasksAdminPanel),
                        CreateHelpLabel(tasksEditTaskAdminButton, "Click to edit the selected task.", tasksAdminPanel),
                        CreateHelpLabel(tasksDeleteTaskAdminButton, "Click to delete the selected task.", tasksAdminPanel),

                        CreateHelpLabel(AssignTaskToEmployeeButton, "Click to select which employees should work on the selected task.", tasksAdminPanel),
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
                        CreateHelpLabel(teamsDeleteTeamAdminButton, "Click to delete the selected team.", teamsAdminPanel),

                        CreateHelpLabel(AssignTeamToProjectButton, "Click to change which project(s) this team is assigned to.", teamsAdminPanel),
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

                        CreateHelpLabel(addHistoryRecordButton, "Click to add a new history record.", employeesAdminPanel),
                        CreateHelpLabel(editHistoryRecordButton, "Click to edit the selected history record.", employeesAdminPanel),
                        CreateHelpLabel(deleteHistoryRecordButton, "Click to delete the selected history record.", employeesAdminPanel),
                        CreateHelpLabel(employeeHistoryListView, "List of history records of the selected employee.", employeesAdminPanel),

                        CreateHelpLabel(employeesAddEmployeeAdminButton, "Click to add a new employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesEditEmployeeAdminButton, "Click to edit the selected employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesDeleteEmployeeAdminButton, "Click to delete the selected employee.", employeesAdminPanel),
                        CreateHelpLabel(generateReportButton, "Click to generate a report.", employeesAdminPanel),

                        CreateHelpLabel(AssignEmployeeToTeamButton, "Click to assign/unassign this employee to/from certain teams", employeesAdminPanel),
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
                        CreateHelpLabel(teamsMembersUserListview, "List of members of the currently selected team.", teamsUserPanel)
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
                    label.BringToFront();
                }
            }
        }

        private Label CreateHelpLabel(Control control, string text, Control parentPanel)
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
                Location = new System.Drawing.Point(
                    Math.Max(0, control.Location.X + offsetX),
                    Math.Max(0, control.Location.Y + offsetY)
                )
            };

            // Add the label to the specified panel
            parentPanel.Controls.Add(label);
            label.BringToFront();
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
        }


        ////////////////////LOG OUT///////////////////

        private void logOutAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            tasksAdminButton.Enabled = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            employeesAdminButton.Enabled = false;
            loginLoginTextbox.Text = "";
            loginPasswordTextbox.Text = "";
            loginPanel.Visible = true;
        }
        private void logOutUserButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            teamsUserPanel.Visible = false;
            tasksUserPanel.Visible = false;
            loginLoginTextbox.Text = "";
            loginPasswordTextbox.Text = "";
            loginPanel.Visible = true;
        }

        ///////////////////////////////////////PROJECTS//////////////////////////////////////
        private async void loadProjects()
        {
            projectsAdminPanel.Visible = true;
            employeesAdminButton.Enabled = false;
            tasksAdminButton.Enabled = false;
            projectsEditProjectAdminButton.Enabled = false;
            projectsDeleteProjectAdminButton.Enabled = false;
            projectsNameAdminTextbox.Text = "";
            projectsDescriptionAdminTextbox.Text = "";
            projectsDescriptionAdminTextbox.Height = projectsDescriptionAdminTextbox.Height;
            projectsStartDateAdminDatePicker.Value = DateTime.Now;
            projectsEndDateAdminDatePicker.Value = DateTime.Now;
            projectsAdminListbox.Items.Clear();
            projectTeamsAdminListBox.Items.Clear();

            var projectRepo = new ProjectRepo();
            var projects = await projectRepo.GetAll();
            if (projects != null)
            {
                _projectsCache = projects.ToList();
                projectsAdminListbox.DisplayMember = "ProjectName";
                projectsAdminListbox.ValueMember = "Id";
                foreach (var project in _projectsCache)
                {
                    projectsAdminListbox.Items.Add(project);
                }
            }
        }
        private async void projectsAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();

            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            loadProjects();
        }

        //Select project from the list
        private void projectsAdminListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectsAdminListbox.SelectedItem is Project selectedProject)
            {
                projectsNameAdminTextbox.Text = selectedProject.ProjectName;
                projectsDescriptionAdminTextbox.Text = selectedProject.Description;
                projectsStartDateAdminDatePicker.Value = selectedProject.StartDate ?? DateTime.Now;
                projectsEndDateAdminDatePicker.Value = selectedProject.EndDate ?? DateTime.Now;
                tasksAdminButton.Enabled = true;
                projectsEditProjectAdminButton.Enabled = true;
                projectsDeleteProjectAdminButton.Enabled = true;

                // Populate the teams list
                projectTeamsAdminListBox.Items.Clear();
                if (selectedProject.TeamProjects != null)
                {
                    foreach (var teamProject in selectedProject.TeamProjects)
                    {
                        if (teamProject.Team != null)
                            projectTeamsAdminListBox.Items.Add(teamProject.Team.TeamName);
                    }
                }
            }
        }

        //Add project button
        private void projectsAddProjectAdminButton_Click(object sender, EventArgs e)
        {
            AddEditProject addEditProject = new AddEditProject
            {
                PanelToShow = "AddProject"
            };
            addEditProject.FormClosed += (s, args) => loadProjects();
            addEditProject.ShowDialog();
        }

        //Edit project button
        private void projectsEditProjectAdminButton_Click(object sender, EventArgs e)
        {
            AddEditProject addEditProject = new AddEditProject
            {
                PanelToShow = "EditProject",
                ItemToEdit = projectsAdminListbox.SelectedItem
            };
            addEditProject.FormClosed += (s, args) => loadProjects();
            addEditProject.ShowDialog();
        }

        //Delete project button
        private void projectsDeleteProjectAdminButton_Click(object sender, EventArgs e)
        {
            var selectedProject = projectsAdminListbox.SelectedItem as Project;
            if (selectedProject == null)
                return;

            DeleteConfirmation confirmDelete = new DeleteConfirmation(selectedProject)
            {
                PanelToShow = "DeleteProject"
            };
            confirmDelete.FormClosed += (s, args) => loadProjects();
            confirmDelete.ShowDialog();
        }

        ///////////////////////////////////////TASKS//////////////////////////////////////

        private async void loadTasks()
        {
            ResetHelpState();
            tasksAdminPanel.Visible = true;
            tasksEditTaskAdminButton.Enabled = false;
            tasksDeleteTaskAdminButton.Enabled = false;
            AssignTaskToEmployeeButton.Enabled = false;
            tasksNameAdminTextbox.Text = "";
            tasksDescriptionAdminTextbox.Text = "";
            tasksStatusAdminTextbox.Text = "";
            tasksDueDateAdminDatePicker.Value = DateTime.Now;
            tasksAdminListbox.Items.Clear();
            taskAssignmentsAdminListView.Items.Clear();

            var selectedProject = projectsAdminListbox.SelectedItem as Project;
            var project = await new ProjectRepo().GetById(selectedProject.Id);

            if (project != null)
            {
                tasksAdminListbox.DisplayMember = "Title";
                tasksAdminListbox.ValueMember = "Id";
                foreach (var task in project.Tasks)
                {

                    tasksAdminListbox.Items.Add(task);

                }
            }
            currentProjectId = selectedProject.Id;
            tasksProjectNameAdminLabel.Text = selectedProject.ProjectName;

        }
        private async void tasksAdminButton_Click(object sender, EventArgs e)
        {
            projectsAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            loadTasks();
        }

        private async void tasksAdminListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksAdminListbox.SelectedItem is TaskToDo selectedTask)
            {
                tasksNameAdminTextbox.Text = selectedTask.Title;
                tasksStatusAdminTextbox.Text = selectedTask.Status;
                tasksDueDateAdminDatePicker.Value = selectedTask.DueDate ?? DateTime.Now;
                tasksEditTaskAdminButton.Enabled = true;
                tasksDeleteTaskAdminButton.Enabled = true;

                // Show only the description (shortened box)
                tasksDescriptionAdminTextbox.Text = selectedTask.Description?.Trim();

                // Populate the ListView with assignments
                taskAssignmentsAdminListView.Items.Clear();
                var taskRepo = new TaskRepo();
                var taskDetails = await taskRepo.GetById(selectedTask.Id);

                if (taskDetails?.TaskAssignments != null && taskDetails.TaskAssignments.Any())
                {
                    foreach (var assignment in taskDetails.TaskAssignments)
                    {
                        string username = assignment.User?.Username ?? "Unknown";
                        string timeSpent = assignment.TimeSpentHours.ToString("0.##");
                        var item = new ListViewItem(new[] { username, timeSpent });
                        taskAssignmentsAdminListView.Items.Add(item);
                    }
                }
                AssignTaskToEmployeeButton.Enabled = true;
            }
        }

        private void tasksAddTaskAdminButton_Click(object sender, EventArgs e)
        {
            var selectedProject = projectsAdminListbox.SelectedItem as Project;
            if (selectedProject == null)
            {
                MessageBox.Show("Please select a project first.");
                return;
            }
            AddEditTask addEditTask = new AddEditTask(selectedProject)
            {
                PanelToShow = "AddTask"
            };
            addEditTask.FormClosed += (s, args) => loadTasks();
            addEditTask.ShowDialog();
        }

        private void tasksEditTaskAdminButton_Click(object sender, EventArgs e)
        {
            AddEditTask addEditTask = new AddEditTask()
            {
                PanelToShow = "EditTask",
                ItemToEdit = tasksAdminListbox.SelectedItem
            };
            addEditTask.FormClosed += (s, args) => loadTasks();
            addEditTask.ShowDialog();
        }

        private void tasksDeleteTaskAdminButton_Click(object sender, EventArgs e)
        {
            var selectedTask = tasksAdminListbox.SelectedItem as TaskToDo;
            if (selectedTask == null)
                return;
            DeleteConfirmation confirmDelete = new DeleteConfirmation(selectedTask)
            {
                PanelToShow = "DeleteTask"
            };
            confirmDelete.FormClosed += (s, args) => loadTasks();
            confirmDelete.ShowDialog();
        }

        private void AssignTaskToEmployeesButton_Click(object sender, EventArgs e)
        {
            var selectedTask = tasksAdminListbox.SelectedItem as TaskToDo;
            AssignUnassignTaskToEmployee assignUnassignTaskToEmployees = new AssignUnassignTaskToEmployee(selectedTask)
            {
                PanelToShow = "AssignEmployeeToTask"
            };
            assignUnassignTaskToEmployees.ShowDialog();
        }

        ///////////////////////////////////////TEAMS//////////////////////////////////////

        private async void loadTeams()
        {
            ResetHelpState();
            teamsAdminPanel.Visible = true;
            employeesAdminButton.Enabled = false;
            teamsEditTeamAdminButton.Enabled = false;
            teamsDeleteTeamAdminButton.Enabled = false;
            AssignTeamToProjectButton.Enabled = false;
            tasksAdminButton.Enabled = false;
            teamsNameAdminTexbox.Text = "";
            teamsDescriptionAdminTextbox.Text = "";
            teamsAdminListbox.Items.Clear();

            var teamRepo = new TeamRepo();
            var teams = await teamRepo.GetAll();
            if (teams != null)
            {
                _teamsCache = teams.ToList();
                teamsAdminListbox.DisplayMember = "TeamName";
                teamsAdminListbox.ValueMember = "Id";
                foreach (var team in _teamsCache)
                {
                    teamsAdminListbox.Items.Add(team);
                }

            }
        }
        private async void teamsAdminButton_Click(object sender, EventArgs e)
        {
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            loadTeams();
        }

        private void teamsAdminListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamsAdminListbox.SelectedItem is Team selectedTeam)
            {
                teamsNameAdminTexbox.Text = selectedTeam.TeamName;
                teamsDescriptionAdminTextbox.Text = selectedTeam.Description;
                teamsEditTeamAdminButton.Enabled = true;
                teamsDeleteTeamAdminButton.Enabled = true;
                employeesAdminButton.Enabled = true;
                AssignTeamToProjectButton.Enabled = true;
            }
        }

        private void teamsAddTeamAdminButton_Click(object sender, EventArgs e)
        {
            AddEditTeam addEditTeam = new AddEditTeam
            {
                PanelToShow = "AddTeam"
            };
            addEditTeam.FormClosed += (s, args) => loadTeams();
            addEditTeam.ShowDialog();
        }

        private void teamsEditTeamAdminButton_Click(object sender, EventArgs e)
        {
            AddEditTeam addEditTeam = new AddEditTeam
            {
                PanelToShow = "EditTeam",
                ItemToEdit = teamsAdminListbox.SelectedItem
            };
            addEditTeam.FormClosed += (s, args) => loadTeams();
            addEditTeam.ShowDialog();
        }

        private void teamsDeleteTeamAdminButton_Click(object sender, EventArgs e)
        {
            var selectedTeam = teamsAdminListbox.SelectedItem as Team;
            if (selectedTeam == null)
                return;
            DeleteConfirmation confirmDelete = new DeleteConfirmation(selectedTeam)
            {
                PanelToShow = "DeleteTeam"
            };
            confirmDelete.FormClosed += (s, args) => loadTeams();
            confirmDelete.ShowDialog();
        }

        private void AssignTeamToProjectsButton_Click(object sender, EventArgs e)
        {
            var selectedTeam = teamsAdminListbox.SelectedItem as Team;
            AssignUnassignTeamToProject assignUnassignTeamToProject = new AssignUnassignTeamToProject(selectedTeam)
            {
                PanelToShow = "AssignTeamToProject"
            };
            assignUnassignTeamToProject.ShowDialog();
        }

        ///////////////////////////////////////EMPLOYEES//////////////////////////////////////
        private async void loadEmployees()
        {
            employeesAdminPanel.Visible = true;
            employeesEditEmployeeAdminButton.Enabled = false;
            employeesDeleteEmployeeAdminButton.Enabled = false;
            editHistoryRecordButton.Enabled = false;
            deleteHistoryRecordButton.Enabled = false;
            AssignEmployeeToTeamButton.Enabled = false;
            employeesEmailAdminTextbox.Text = "";
            employeesUsernameAdminTexbox.Text = "";
            employeesRoleAdminTextbox.Text = "";
            employeesStatusAdminTextbox.Text = "";
            employeeHistoryListView.Items.Clear();
            employeesAdminListbox.Items.Clear();

            var selectedTeam = teamsAdminListbox.SelectedItem as Team;
            var team = await new TeamRepo().GetById(selectedTeam.Id);
            if (team != null)
            {
                employeesAdminListbox.DisplayMember = "Username";
                employeesAdminListbox.ValueMember = "Id";
                foreach (var member in team.TeamMembers)
                {

                    employeesAdminListbox.Items.Add(member.User);

                }
            }
            teamNameEmployeesAdminPanel.Text = selectedTeam.TeamName;
        }

        private async void employeesAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            loadEmployees();
            
        }
        private void employeesAdminListbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            {

                if (employeesAdminListbox.SelectedItem is Database.Entities.User selectedUser)
                {
                    employeesUsernameAdminTexbox.Text = selectedUser.Username;
                    employeesEmailAdminTextbox.Text = selectedUser.Email;
                    employeesRoleAdminTextbox.Text = selectedUser.Role.RoleName;
                    employeesStatusAdminTextbox.Text = selectedUser.EmploymentStatus;
                    employeeHistoryListView.Items.Clear();
                    var selectedUserRecords = selectedUser.UserEvents;

                    if (selectedUserRecords != null)
                    {


                        foreach (var record in selectedUserRecords)
                        {
                            var listViewItem = new ListViewItem(record.EventType);
                            listViewItem.SubItems.Add(record.EventDate.ToString());
                            listViewItem.SubItems.Add(record.Notes);
                            listViewItem.Tag = record;
                            employeeHistoryListView.Items.Add(listViewItem);
                        }
                    }

                    employeesEditEmployeeAdminButton.Enabled = true;
                    employeesDeleteEmployeeAdminButton.Enabled = true;
                    employeesAdminButton.Enabled = true;
                    AssignEmployeeToTeamButton.Enabled = true;
                }
            }
        }
        private void employeeHistoryListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            editHistoryRecordButton.Enabled = true;
            deleteHistoryRecordButton.Enabled = true;
        }
        private void employeesAddEmployeeAdminButton_Click(object sender, EventArgs e)
        {
            var selectedTeam = teamsAdminListbox.SelectedItem as Team;
            if (selectedTeam == null)
            {
                MessageBox.Show("Please select a team first.");
                return;
            }
            AddEditEmployee addEditEmployee = new AddEditEmployee(selectedTeam)
            {
                PanelToShow = "AddEmployee"
            };
            addEditEmployee.FormClosed += (s, args) => loadEmployees();
            addEditEmployee.ShowDialog();
        }

        private void employeesEditEmployeeAdminButton_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee
            {
                PanelToShow = "EditEmployee",
                ItemToEdit = employeesAdminListbox.SelectedItem
            };
            addEditEmployee.FormClosed += (s, args) => loadEmployees();
            addEditEmployee.ShowDialog();
        }

        private void employeesDeleteEmployeeAdminButton_Click(object sender, EventArgs e)
        {
            var selectedUser = employeesAdminListbox.SelectedItem as Database.Entities.User;
            if (selectedUser == null)
                return;
            DeleteConfirmation confirmDelete = new DeleteConfirmation(selectedUser)
            {
                PanelToShow = "DeleteEmployee"
            };
            confirmDelete.FormClosed += (s, args) => loadEmployees();
            confirmDelete.ShowDialog();
        }

        private void addHistoryRecordButton_Click(object sender, EventArgs e)
        {
            AddEditHistoryRecord addEditHistoryRecord = new AddEditHistoryRecord(employeesAdminListbox.SelectedItem as Database.Entities.User)
            {
                PanelToShow = "AddHistoryRecord"
            };
            addEditHistoryRecord.FormClosed += (s, args) => loadEmployees();
            addEditHistoryRecord.ShowDialog();
        }

        private void AddEditHistoryRecord_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void editHistoryRecordButton_Click(object sender, EventArgs e)
        {
            if (employeeHistoryListView.SelectedItems.Count > 0)
            {
                var selectedListViewItem = employeeHistoryListView.SelectedItems[0];
                var selectedUserHistory = selectedListViewItem.Tag as UserHistory;
                if (selectedUserHistory != null)
                {
                    AddEditHistoryRecord addEditHistoryRecord = new AddEditHistoryRecord(employeesAdminListbox.SelectedItem as Database.Entities.User, selectedUserHistory)
                    {
                        PanelToShow = "EditHistoryRecord"
                    };
                    addEditHistoryRecord.FormClosed += (s, args) => loadEmployees();
                    addEditHistoryRecord.ShowDialog();
                }
            }
        }

        private void deleteHistoryRecordButton_Click(object sender, EventArgs e)
        {
            if (employeeHistoryListView.SelectedItems.Count > 0)
            {
                var selectedListViewItem = employeeHistoryListView.SelectedItems[0];
                var selectedUserHistory = selectedListViewItem.Tag as UserHistory;
                if (selectedUserHistory != null)
                {
                    DeleteConfirmation confirmDelete = new DeleteConfirmation(selectedUserHistory)
                    {
                        PanelToShow = "DeleteHistoryRecord"
                    };
                    confirmDelete.FormClosed += (s, args) => loadEmployees();
                    confirmDelete.ShowDialog();
                }
            }
        }

        private void AssignEmployeeToTeamButton_Click(object sender, EventArgs e)
        {
            var selectedEmployee = employeesAdminListbox.SelectedItem as User;
            AssignUnassignEmployeeToTeam assignUnassignEmployeeToTeam = new AssignUnassignEmployeeToTeam(selectedEmployee)
            {
                PanelToShow = "AssignEmployeeToTeam"
            };
            assignUnassignEmployeeToTeam.FormClosed += (s, args) => loadEmployees();
            assignUnassignEmployeeToTeam.ShowDialog();
        }
        ///////////////////////////////////////////////////////USER BUTTONS///////////////////////////////////////
        private async void tasksUserButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            teamsUserPanel.Visible = false;
            tasksUserPanel.Visible = true;

            tasksTodoUserListbox.Items.Clear();
            tasksDoneUserListbox.Items.Clear();

            var _taskRepo = new TaskRepo();
            var _taskAssignRepo = new TaskAssignmentRepo();

            var tasks = await _taskRepo.GetAll();
            var taskAssignments = await _taskAssignRepo.GetAll();

            var loggedUserTasks = taskAssignments.Where(x => x.UserId == userId).ToList();

            if (loggedUserTasks != null && tasks != null)
            {
                tasksTodoUserListbox.DisplayMember = "Title";
                tasksTodoUserListbox.ValueMember = "Id";
                tasksDoneUserListbox.DisplayMember = "Title";
                tasksDoneUserListbox.ValueMember = "Id";

                var userTaskIds = loggedUserTasks.Select(x => x.TaskId).ToHashSet();
                var userTasks = tasks.Where(t => userTaskIds.Contains(t.Id));

                foreach (var task in userTasks)
                {
                    if (task.Status == "ToDo")
                        tasksTodoUserListbox.Items.Add(task);
                    else if (task.Status == "Done")
                        tasksDoneUserListbox.Items.Add(task);
                }
            }
        }

        private async void teamsUserButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            tasksUserPanel.Visible = false;
            teamsUserPanel.Visible = true;
            teamsMembersUserListview.Items.Clear();
            teamsNameUserListbox.Items.Clear();
            var _userRepo = new UserRepo();
            var teams = new TeamRepo();
            var userTeams = await teams.GetAll();
            var loggedUser = await _userRepo.GetById(userId);
            var loggedUserTeams = userTeams.Where(x => x.TeamMembers.Any(m => m.UserId == loggedUser.Id)).ToList();
            if (loggedUserTeams != null && loggedUserTeams.Count > 0)
            {
                teamsNameUserListbox.DisplayMember = "TeamName";
                teamsNameUserListbox.ValueMember = "Id";
                teamsMembersUserListview.Items.Clear();
                teamsNameUserListbox.Items.Clear();
                foreach (var team in loggedUserTeams)
                {
                    teamsNameUserListbox.Items.Add(team);
                }
            }
        }

        private async void teamsNameUserListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _taskRepo = new TaskRepo();
            var _taskAssignRepo = new TaskAssignmentRepo();

            var tasks = await _taskRepo.GetAll();
            var taskAssignments = await _taskAssignRepo.GetAll();
            var userSelectedTeam = teamsNameUserListbox.SelectedItem as Team;
            if (userSelectedTeam != null)
            {
                var team = await new TeamRepo().GetById(userSelectedTeam.Id);
                if (team != null)
                {
                    teamsMembersUserListview.Items.Clear();
                    foreach (var member in team.TeamMembers)
                    {
                        if (member.UserId == userId)
                            continue;
                        var item = new ListViewItem(member.User.Username);
                        item.SubItems.Add(member.User.Email);

                        var teamUserTasks = taskAssignments.Where(x => x.UserId == member.UserId).ToList();
                        var taskList = "";
                        if (teamUserTasks != null && tasks != null)
                        {

                            var userTaskIds = teamUserTasks.Select(x => x.TaskId).ToHashSet();
                            var userTasks = tasks.Where(t => userTaskIds.Contains(t.Id));
                            var taskNames = new List<string>();
                            foreach (var task in userTasks)
                            {
                                if (task.Status == "ToDo")
                                    taskNames.Add(task.Title);
                            }
                            taskList = string.Join(", ", taskNames);
                        }
                        item.SubItems.Add(taskList);

                        teamsMembersUserListview.Items.Add(item);
                    }
                }
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////

        private async void tasksTodoUserListbox_DoubleClick(object sender, EventArgs e)
        {
            if (tasksTodoUserListbox.SelectedItem is DSaA_Project_TimeTracker.Database.Entities.TaskToDo selectedTask)
            {
                var taskRepo = new TaskRepo();
                var taskDetails = await taskRepo.GetById(selectedTask.Id);

                if (taskDetails != null)
                {
                    var taskForm = new TaskForm(taskDetails);
                    taskForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Could not load task details.");
                }
            }
        }

        private async void tasksDoneUserListbox_DoubleClick(object sender, EventArgs e)
        {
            if (tasksDoneUserListbox.SelectedItem is DSaA_Project_TimeTracker.Database.Entities.TaskToDo selectedTask)
            {
                var taskRepo = new TaskRepo();
                var taskDetails = await taskRepo.GetById(selectedTask.Id);

                if (taskDetails != null)
                {
                    var taskForm = new TaskForm(taskDetails);
                    taskForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Could not load task details.");
                }
            }
        }


        private void helpButtonUser_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void helpButtonAdmin_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }


        //Logging system
        private async void loginButton_Click(object sender, EventArgs e)
        {
            var loginDto = new LoginUserDto
            {
                Username = loginLoginTextbox.Text,
                Password = loginPasswordTextbox.Text
            };

            var user = await _userRepo.Login(loginDto);

            if (user != null)
            {
                userId = user.Id;
                Globals.LoggedInUserId = user.Id;
                if (user.Role.RoleName == "Admin")
                {
                    //show admin panel
                    adminViewPanel.Visible = true;
                    userViewPanel.Visible = false;
                    loginPanel.Visible = false;
                }
                else
                {
                    //show user panel
                    adminViewPanel.Visible = false;
                    userViewPanel.Visible = true;
                    loginPanel.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }

        }






        private void generateReportButton_Click(object sender, EventArgs e)
        {
            var generateReport = new GenerateReport();
            generateReport.ShowDialog();
        }






        ///////////////////////////////////////////////////////////////////////

    }
}

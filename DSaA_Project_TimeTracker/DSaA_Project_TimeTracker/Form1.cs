using DSaA_Project_TimeTracker.Database;
using DSaA_Project_TimeTracker.DTOs;
using DSaA_Project_TimeTracker.Database.Repos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.DTOs.Team;
using DSaA_Project_TimeTracker.DTOs.User;

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
            InitializeHelpLabels();

            tasksTodoUserListbox.DoubleClick += tasksTodoUserListbox_DoubleClick_Handler;
            tasksDoneUserListbox.DoubleClick += tasksDoneUserListbox_DoubleClick_Handler;
        }

        private Dictionary<Control, Label[]> subPanelHelpLabels;
        private List<Project> _projectsCache = new();
        private int currentProjectId;
        private List<Team> _teamsCache = new();
        private List<TaskToDo> _tasksCache = new();
        private List<User> _usersCache = new();

        private readonly UserRepo _userRepo = new UserRepo();

        private int userId = 0; // SUS idk what else to do

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
                        CreateHelpLabel(projectsEndDateAdminDatePicker, "Expected finish date of selected project.", projectsAdminPanel),

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

                        CreateHelpLabel(addHistoryRecordButton, "Click to add a new history record.", employeesAdminPanel),
                        CreateHelpLabel(editHistoryRecordButton, "Click to edit the selected history record.", employeesAdminPanel),
                        CreateHelpLabel(deleteHistoryRecordButton, "Click to delete the selected history record.", employeesAdminPanel),
                        CreateHelpLabel(employeeHistoryListView, "List of history records of the selected employee.", employeesAdminPanel),

                        CreateHelpLabel(employeesAddEmployeeAdminButton, "Click to add a new employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesEditEmployeeAdminButton, "Click to edit the selected employee.", employeesAdminPanel),
                        CreateHelpLabel(employeesDeleteEmployeeAdminButton, "Click to delete the selected employee.", employeesAdminPanel),
                        CreateHelpLabel(generateSummaryReportButton, "Click to generate a summary report.", employeesAdminPanel),
                        CreateHelpLabel(generateDetailedReportButton, "Click to generate a detailed report.", employeesAdminPanel)
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

            //var teamRepo = new TeamRepo();    //MOVED TO APPROPRIATE FUNCTION
            var userRepo = new UserRepo();
            // var roleRepo = new RoleRepo();   //not working
            //var projectRepo = new ProjectRepo();      //MOVED TO APPROPRIATE FUNCTION
            // var tpRepo = new TeamProjectRepo();  //not working
            var uhRepo = new UserHistoryRepo();
            //var taskRepo = new TaskRepo();        //MOVED TO APPROPRIATE FUNCTION

            var a = await userRepo.GetAll();
            //var b = await teamRepo.GetAll();        //MOVED TO APPROPRIATE FUNCTION
            //var c = await roleRepo.GetAll();  //not working
            //var d = await projectRepo.GetAll();        //MOVED TO APPROPRIATE FUNCTION
            //var ea = await tpRepo.GetAll();   //not working
            //var his = await uhRepo.GetAll();  //not working
            //var ta = await taskRepo.GetAll();        //MOVED TO APPROPRIATE FUNCTION
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
        //Enter projects view as admin
        private async void projectsAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            projectsAdminPanel.Visible = true;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            employeesAdminButton.Enabled = false;
            tasksAdminButton.Enabled = false;
            projectsNameAdminTextbox.Text = "";
            projectsDescriptionAdminTextbox.Text = "";
            projectsStartDateAdminDatePicker.Value = DateTime.Now;
            projectsEndDateAdminDatePicker.Value = DateTime.Now;
            projectsAdminListbox.Items.Clear();

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
            }
        }

        //Add project button
        private void projectsAddProjectAdminButton_Click(object sender, EventArgs e)
        {
            AddEditProject addEditProject = new AddEditProject
            {
                PanelToShow = "AddProject"
            };
            addEditProject.ShowDialog();
        }

        //Edit project button
        private void projectsEditProjectAdminButton_Click(object sender, EventArgs e)
        {
            AddEditProject addEditProject = new AddEditProject
            {
                PanelToShow = "EditProject"
            };
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
            confirmDelete.ShowDialog();
        }

        ///////////////////////////////////////TASKS//////////////////////////////////////
        private async void tasksAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = true;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            tasksNameAdminTextbox.Text = "";
            tasksDescriptionAdminTextbox.Text = "";
            tasksStatusAdminTextbox.Text = "";
            tasksDueDateAdminDatePicker.Value = DateTime.Now;
            tasksAdminListbox.Items.Clear();

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

        private void tasksAdminListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tasksAdminListbox.SelectedItem is TaskToDo selectedTask)
            {
                tasksNameAdminTextbox.Text = selectedTask.Title;
                tasksDescriptionAdminTextbox.Text = selectedTask.Description;
                tasksStatusAdminTextbox.Text = selectedTask.Status;
                tasksDueDateAdminDatePicker.Value = selectedTask.DueDate ?? DateTime.Now;
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
            addEditTask.ShowDialog();
        }

        private void tasksEditTaskAdminButton_Click(object sender, EventArgs e)
        {
            AddEditTask addEditTask = new AddEditTask
            {
                PanelToShow = "EditTask"
            };
            addEditTask.ShowDialog();
        }

        private void tasksDeleteTaskAdminButton_Click(object sender, EventArgs e)
        {
            DeleteConfirmation confirmDelete = new DeleteConfirmation
            {
                PanelToShow = "DeleteTask"
            };
            confirmDelete.ShowDialog();
        }

        ///////////////////////////////////////TEAMS//////////////////////////////////////
        private async void teamsAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = true;
            employeesAdminPanel.Visible = false;
            employeesAdminButton.Enabled = false;
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

        private void teamsAdminListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (teamsAdminListbox.SelectedItem is Team selectedTeam)
            {
                teamsNameAdminTexbox.Text = selectedTeam.TeamName;
                teamsDescriptionAdminTextbox.Text = selectedTeam.Description;
                employeesAdminButton.Enabled = true;
            }
        }

        ///////////////////////////////////////EMPLOYEES//////////////////////////////////////
        private async void employeesAdminButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = true;
            employeesEmailAdminTextbox.Text = "";
            employeesUsernameAdminTexbox.Text = "";
            employeesRoleAdminTextbox.Text = "";
            employeesAdminListbox.Items.Clear();

            var selectedTeam = teamsAdminListbox.SelectedItem as Team;
            var team = await new TeamRepo().GetById(selectedTeam.Id);
             if (team != null)
             {
                 employeesAdminListbox.DisplayMember = "Username";
                 employeesAdminListbox.ValueMember = "Id";
                 foreach (var member in team.TeamMembers)
                 {
                     
                         employeesAdminListbox.Items.Add(member.User.Username);
                     
                 }
             }
            teamNameEmployeesAdminPanel.Text = selectedTeam.TeamName;


        }

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

        private void teamsUserButton_Click(object sender, EventArgs e)
        {
            ResetHelpState();
            tasksUserPanel.Visible = false;
            teamsUserPanel.Visible = true;
            var repo = new UserRepo();
            var user = repo.GetById(0);
        }

        ////////////////////////////TO DO///////////////////////////////////////////
        //Add backend logic for creating, editing and deleting projects, tasks, teams, and employees




        private void teamsAddTeamAdminButton_Click(object sender, EventArgs e)
        {
            AddEditTeam addEditTeam = new AddEditTeam
            {
                PanelToShow = "AddTeam"
            };
            addEditTeam.ShowDialog();
        }

        private void teamsEditTeamAdminButton_Click(object sender, EventArgs e)
        {
            AddEditTeam addEditTeam = new AddEditTeam
            {
                PanelToShow = "EditTeam"
            };
            addEditTeam.ShowDialog();
        }

        private void teamsDeleteTeamAdminButton_Click(object sender, EventArgs e)
        {
            DeleteConfirmation confirmDelete = new DeleteConfirmation
            {
                PanelToShow = "DeleteTeam"
            };
            confirmDelete.ShowDialog();
        }



        private void employeesAddEmployeeAdminButton_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee
            {
                PanelToShow = "AddEmployee"
            };
            addEditEmployee.ShowDialog();
        }

        private void employeesEditEmployeeAdminButton_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee
            {
                PanelToShow = "EditEmployee"
            };
            addEditEmployee.ShowDialog();
        }

        private void employeesDeleteEmployeeAdminButton_Click(object sender, EventArgs e)
        {
            DeleteConfirmation confirmDelete = new DeleteConfirmation
            {
                PanelToShow = "DeleteEmployee"
            };
            confirmDelete.ShowDialog();
        }

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

        private void generateSummaryReportButton_Click(object sender, EventArgs e)
        {

        }

        private void generateDetailedReportButton_Click(object sender, EventArgs e)
        {

        }

        private void addHistoryRecordButton_Click(object sender, EventArgs e)
        {
            AddEditHistoryRecord addEditHistoryRecord = new AddEditHistoryRecord
            {
                PanelToShow = "AddHistoryRecord"
            };
            addEditHistoryRecord.ShowDialog();
        }

        private void editHistoryRecordButton_Click(object sender, EventArgs e)
        {
            AddEditHistoryRecord addEditHistoryRecord = new AddEditHistoryRecord
            {
                PanelToShow = "EditHistoryRecord"
            };
            addEditHistoryRecord.ShowDialog();
        }

        private void deleteHistoryRecordButton_Click(object sender, EventArgs e)
        {
            DeleteConfirmation confirmDelete = new DeleteConfirmation
            {
                PanelToShow = "DeleteHistoryRecord"
            };
            confirmDelete.ShowDialog();
        }














        ///////////////////////////////////////////////////////////////////////

    }
}

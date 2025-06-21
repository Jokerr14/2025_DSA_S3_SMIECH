namespace DSaA_Project_TimeTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanel = new Panel();
            loginAuthorLabel = new Label();
            loginTitleLabel = new Label();
            loginLoginLabel = new Label();
            loginPasswordLabel = new Label();
            loginButton = new Button();
            loginPasswordTextbox = new TextBox();
            loginLoginTextbox = new TextBox();
            userViewPanel = new Panel();
            helpButtonUser = new Button();
            logOutUserButton = new Button();
            teamsUserButton = new Button();
            tasksUserButton = new Button();
            teamsUserPanel = new Panel();
            teamsMembersUserListview = new ListView();
            userName = new ColumnHeader();
            userEmail = new ColumnHeader();
            teamsMembersUserLabel = new Label();
            teamsNameUserListbox = new ListBox();
            label5 = new Label();
            tasksUserPanel = new Panel();
            tasksDoneUserLabel = new Label();
            tasksTodoUserLabel = new Label();
            tasksDoneUserListbox = new ListBox();
            tasksTodoUserListbox = new ListBox();
            adminViewPanel = new Panel();
            helpButtonAdmin = new Button();
            logOutAdminButton = new Button();
            employeesAdminButton = new Button();
            teamsAdminButton = new Button();
            tasksAdminButton = new Button();
            projectsAdminButton = new Button();
            employeesAdminPanel = new Panel();
            generateReportButton = new Button();
            AssignEmployeeToTeamButton = new Button();
            employeeHistoryListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            deleteHistoryRecordButton = new Button();
            editHistoryRecordButton = new Button();
            addHistoryRecordButton = new Button();
            label1 = new Label();
            employeesStatusAdminTextbox = new TextBox();
            employeesRoleAdminTextbox = new TextBox();
            teamNameEmployeesAdminPanel = new Label();
            employeesEmailAdminTextbox = new TextBox();
            employeesUsernameAdminTexbox = new TextBox();
            employeesStatusAdminLabel = new Label();
            employeesRoleAdminLabel = new Label();
            employeesEmailAdminLabel = new Label();
            employeesUsernameAdminLabel = new Label();
            employeesDeleteEmployeeAdminButton = new Button();
            employeesEditEmployeeAdminButton = new Button();
            employeesAddEmployeeAdminButton = new Button();
            employeesAdminListbox = new ListBox();
            projectsAdminPanel = new Panel();
            label2 = new Label();
            projectsEndDateAdminDatePicker = new DateTimePicker();
            projectsStartDateAdminDatePicker = new DateTimePicker();
            projectsEndDateAdminLabel = new Label();
            projectsStartDateAdminLabel = new Label();
            projectsDescriptionAdminTextbox = new TextBox();
            projectsDeleteProjectAdminButton = new Button();
            projectsEditProjectAdminButton = new Button();
            projectsNameAdminTextbox = new TextBox();
            projectsDescriptionAdminLabel = new Label();
            projectsNameAdminLabel = new Label();
            projectsAddProjectAdminButton = new Button();
            projectsAdminListbox = new ListBox();
            tasksAdminPanel = new Panel();
            AssignTaskToEmployeeButton = new Button();
            tasksDeleteTaskAdminButton = new Button();
            tasksEditTaskAdminButton = new Button();
            tasksNameAdminTextbox = new TextBox();
            tasksDescriptionAdminTextbox = new TextBox();
            tasksStatusAdminTextbox = new TextBox();
            tasksProjectNameAdminLabel = new Label();
            tasksDueDateAdminDatePicker = new DateTimePicker();
            tasksDueDateLabel = new Label();
            tasksStatusAdminLabel = new Label();
            tasksDescriptionAdminLabel = new Label();
            tasksNameAdminLabel = new Label();
            tasksAddTaskAdminButton = new Button();
            tasksAdminListbox = new ListBox();
            teamsAdminPanel = new Panel();
            AssignTeamToProjectButton = new Button();
            teamsDescriptionAdminTextbox = new TextBox();
            teamsDeleteTeamAdminButton = new Button();
            teamsEditTeamAdminButton = new Button();
            teamsNameAdminTexbox = new TextBox();
            teamsDescriptionAdminLabel = new Label();
            teamsNameAdminLabel = new Label();
            teamsAddTeamAdminButton = new Button();
            teamsAdminListbox = new ListBox();
            Event = new ColumnHeader();
            Date = new ColumnHeader();
            Notes = new ColumnHeader();
            loginPanel.SuspendLayout();
            userViewPanel.SuspendLayout();
            teamsUserPanel.SuspendLayout();
            tasksUserPanel.SuspendLayout();
            adminViewPanel.SuspendLayout();
            employeesAdminPanel.SuspendLayout();
            projectsAdminPanel.SuspendLayout();
            tasksAdminPanel.SuspendLayout();
            teamsAdminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(loginAuthorLabel);
            loginPanel.Controls.Add(loginTitleLabel);
            loginPanel.Controls.Add(loginLoginLabel);
            loginPanel.Controls.Add(loginPasswordLabel);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(loginPasswordTextbox);
            loginPanel.Controls.Add(loginLoginTextbox);
            loginPanel.Location = new Point(3, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1293, 915);
            loginPanel.TabIndex = 0;
            // 
            // loginAuthorLabel
            // 
            loginAuthorLabel.AutoEllipsis = true;
            loginAuthorLabel.Location = new Point(0, 133);
            loginAuthorLabel.Name = "loginAuthorLabel";
            loginAuthorLabel.Size = new Size(1258, 25);
            loginAuthorLabel.TabIndex = 8;
            loginAuthorLabel.Text = "made by: Patryk Kwiecień, Mikołaj Musioł, Julia Przybyłowicz, Paweł Sosin, Paweł Strzępa, Mateusz Śmiech\r\n";
            loginAuthorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginTitleLabel
            // 
            loginTitleLabel.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginTitleLabel.Location = new Point(0, 51);
            loginTitleLabel.Name = "loginTitleLabel";
            loginTitleLabel.Size = new Size(1258, 84);
            loginTitleLabel.TabIndex = 7;
            loginTitleLabel.Text = "Time Tracking System";
            loginTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLoginLabel
            // 
            loginLoginLabel.AutoSize = true;
            loginLoginLabel.Location = new Point(461, 419);
            loginLoginLabel.Name = "loginLoginLabel";
            loginLoginLabel.Size = new Size(46, 20);
            loginLoginLabel.TabIndex = 6;
            loginLoginLabel.Text = "Login";
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Location = new Point(453, 459);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(70, 20);
            loginPasswordLabel.TabIndex = 5;
            loginPasswordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(528, 498);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 2;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginPasswordTextbox
            // 
            loginPasswordTextbox.Location = new Point(528, 456);
            loginPasswordTextbox.Name = "loginPasswordTextbox";
            loginPasswordTextbox.PasswordChar = '*';
            loginPasswordTextbox.Size = new Size(319, 27);
            loginPasswordTextbox.TabIndex = 1;
            // 
            // loginLoginTextbox
            // 
            loginLoginTextbox.Location = new Point(528, 415);
            loginLoginTextbox.Name = "loginLoginTextbox";
            loginLoginTextbox.Size = new Size(319, 27);
            loginLoginTextbox.TabIndex = 0;
            // 
            // userViewPanel
            // 
            userViewPanel.Controls.Add(helpButtonUser);
            userViewPanel.Controls.Add(logOutUserButton);
            userViewPanel.Controls.Add(teamsUserButton);
            userViewPanel.Controls.Add(tasksUserButton);
            userViewPanel.Controls.Add(teamsUserPanel);
            userViewPanel.Controls.Add(tasksUserPanel);
            userViewPanel.Location = new Point(3, 3);
            userViewPanel.Name = "userViewPanel";
            userViewPanel.Size = new Size(1293, 905);
            userViewPanel.TabIndex = 7;
            userViewPanel.Visible = false;
            // 
            // helpButtonUser
            // 
            helpButtonUser.Location = new Point(1217, 3);
            helpButtonUser.Margin = new Padding(3, 4, 3, 4);
            helpButtonUser.Name = "helpButtonUser";
            helpButtonUser.Size = new Size(57, 39);
            helpButtonUser.TabIndex = 5;
            helpButtonUser.Text = "Help";
            helpButtonUser.UseVisualStyleBackColor = true;
            helpButtonUser.Click += helpButtonUser_Click;
            // 
            // logOutUserButton
            // 
            logOutUserButton.Location = new Point(861, 4);
            logOutUserButton.Name = "logOutUserButton";
            logOutUserButton.Size = new Size(351, 39);
            logOutUserButton.TabIndex = 2;
            logOutUserButton.Text = "Log Out";
            logOutUserButton.UseVisualStyleBackColor = true;
            logOutUserButton.Click += logOutUserButton_Click;
            // 
            // teamsUserButton
            // 
            teamsUserButton.Location = new Point(441, 4);
            teamsUserButton.Name = "teamsUserButton";
            teamsUserButton.Size = new Size(414, 39);
            teamsUserButton.TabIndex = 1;
            teamsUserButton.Text = "My Teams";
            teamsUserButton.UseVisualStyleBackColor = true;
            teamsUserButton.Click += teamsUserButton_Click;
            // 
            // tasksUserButton
            // 
            tasksUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasksUserButton.Location = new Point(19, 4);
            tasksUserButton.Name = "tasksUserButton";
            tasksUserButton.Size = new Size(414, 39);
            tasksUserButton.TabIndex = 0;
            tasksUserButton.Text = "My Tasks";
            tasksUserButton.UseVisualStyleBackColor = true;
            tasksUserButton.Click += tasksUserButton_Click;
            // 
            // teamsUserPanel
            // 
            teamsUserPanel.Controls.Add(teamsMembersUserListview);
            teamsUserPanel.Controls.Add(teamsMembersUserLabel);
            teamsUserPanel.Controls.Add(teamsNameUserListbox);
            teamsUserPanel.Controls.Add(label5);
            teamsUserPanel.Location = new Point(3, 91);
            teamsUserPanel.Name = "teamsUserPanel";
            teamsUserPanel.Size = new Size(1293, 796);
            teamsUserPanel.TabIndex = 4;
            teamsUserPanel.Visible = false;
            // 
            // teamsMembersUserListview
            // 
            teamsMembersUserListview.Columns.AddRange(new ColumnHeader[] { userName, userEmail });
            teamsMembersUserListview.FullRowSelect = true;
            teamsMembersUserListview.Location = new Point(435, 41);
            teamsMembersUserListview.Margin = new Padding(3, 4, 3, 4);
            teamsMembersUserListview.Name = "teamsMembersUserListview";
            teamsMembersUserListview.Size = new Size(805, 604);
            teamsMembersUserListview.TabIndex = 4;
            teamsMembersUserListview.UseCompatibleStateImageBehavior = false;
            teamsMembersUserListview.View = View.Details;
            teamsMembersUserListview.DoubleClick += teamsMembersUserListview_DoubleClick;
            // 
            // userName
            // 
            userName.Text = "User";
            userName.Width = 350;
            // 
            // userEmail
            // 
            userEmail.Text = "Email";
            userEmail.Width = 355;
            // 
            // teamsMembersUserLabel
            // 
            teamsMembersUserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamsMembersUserLabel.Location = new Point(455, 3);
            teamsMembersUserLabel.Name = "teamsMembersUserLabel";
            teamsMembersUserLabel.Size = new Size(810, 37);
            teamsMembersUserLabel.TabIndex = 3;
            teamsMembersUserLabel.Text = "The selected team contains the following members:";
            teamsMembersUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teamsNameUserListbox
            // 
            teamsNameUserListbox.FormattingEnabled = true;
            teamsNameUserListbox.Location = new Point(23, 41);
            teamsNameUserListbox.Name = "teamsNameUserListbox";
            teamsNameUserListbox.Size = new Size(426, 604);
            teamsNameUserListbox.TabIndex = 1;
            teamsNameUserListbox.SelectedIndexChanged += teamsNameUserListview_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 3);
            label5.Name = "label5";
            label5.Size = new Size(425, 40);
            label5.TabIndex = 0;
            label5.Text = "You are currently assigned to the following teams:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksUserPanel
            // 
            tasksUserPanel.Controls.Add(tasksDoneUserLabel);
            tasksUserPanel.Controls.Add(tasksTodoUserLabel);
            tasksUserPanel.Controls.Add(tasksDoneUserListbox);
            tasksUserPanel.Controls.Add(tasksTodoUserListbox);
            tasksUserPanel.Location = new Point(3, 80);
            tasksUserPanel.Name = "tasksUserPanel";
            tasksUserPanel.Size = new Size(1253, 689);
            tasksUserPanel.TabIndex = 3;
            tasksUserPanel.Visible = false;
            // 
            // tasksDoneUserLabel
            // 
            tasksDoneUserLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasksDoneUserLabel.Location = new Point(629, 11);
            tasksDoneUserLabel.Name = "tasksDoneUserLabel";
            tasksDoneUserLabel.Size = new Size(619, 25);
            tasksDoneUserLabel.TabIndex = 3;
            tasksDoneUserLabel.Text = "Done:";
            tasksDoneUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksTodoUserLabel
            // 
            tasksTodoUserLabel.Font = new Font("Segoe UI", 11F);
            tasksTodoUserLabel.Location = new Point(5, 13);
            tasksTodoUserLabel.Name = "tasksTodoUserLabel";
            tasksTodoUserLabel.Size = new Size(619, 25);
            tasksTodoUserLabel.TabIndex = 2;
            tasksTodoUserLabel.Text = "To Do:";
            tasksTodoUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksDoneUserListbox
            // 
            tasksDoneUserListbox.FormattingEnabled = true;
            tasksDoneUserListbox.Location = new Point(629, 39);
            tasksDoneUserListbox.Name = "tasksDoneUserListbox";
            tasksDoneUserListbox.Size = new Size(620, 604);
            tasksDoneUserListbox.TabIndex = 1;
            // 
            // tasksTodoUserListbox
            // 
            tasksTodoUserListbox.Location = new Point(3, 39);
            tasksTodoUserListbox.Name = "tasksTodoUserListbox";
            tasksTodoUserListbox.Size = new Size(620, 604);
            tasksTodoUserListbox.TabIndex = 0;
            // 
            // adminViewPanel
            // 
            adminViewPanel.Controls.Add(helpButtonAdmin);
            adminViewPanel.Controls.Add(logOutAdminButton);
            adminViewPanel.Controls.Add(employeesAdminButton);
            adminViewPanel.Controls.Add(teamsAdminButton);
            adminViewPanel.Controls.Add(tasksAdminButton);
            adminViewPanel.Controls.Add(projectsAdminButton);
            adminViewPanel.Controls.Add(employeesAdminPanel);
            adminViewPanel.Controls.Add(projectsAdminPanel);
            adminViewPanel.Controls.Add(tasksAdminPanel);
            adminViewPanel.Controls.Add(teamsAdminPanel);
            adminViewPanel.Location = new Point(0, 3);
            adminViewPanel.Name = "adminViewPanel";
            adminViewPanel.Size = new Size(1299, 920);
            adminViewPanel.TabIndex = 1;
            adminViewPanel.Visible = false;
            // 
            // helpButtonAdmin
            // 
            helpButtonAdmin.Location = new Point(1194, 4);
            helpButtonAdmin.Margin = new Padding(3, 4, 3, 4);
            helpButtonAdmin.Name = "helpButtonAdmin";
            helpButtonAdmin.Size = new Size(91, 88);
            helpButtonAdmin.TabIndex = 17;
            helpButtonAdmin.Text = "Help";
            helpButtonAdmin.UseVisualStyleBackColor = true;
            helpButtonAdmin.Click += helpButtonAdmin_Click;
            // 
            // logOutAdminButton
            // 
            logOutAdminButton.Location = new Point(994, 4);
            logOutAdminButton.Name = "logOutAdminButton";
            logOutAdminButton.Size = new Size(193, 88);
            logOutAdminButton.TabIndex = 5;
            logOutAdminButton.Text = "Log Out";
            logOutAdminButton.UseVisualStyleBackColor = true;
            logOutAdminButton.Click += logOutAdminButton_Click;
            // 
            // employeesAdminButton
            // 
            employeesAdminButton.Enabled = false;
            employeesAdminButton.Location = new Point(503, 57);
            employeesAdminButton.Name = "employeesAdminButton";
            employeesAdminButton.Size = new Size(486, 35);
            employeesAdminButton.TabIndex = 4;
            employeesAdminButton.Text = "Employees";
            employeesAdminButton.UseVisualStyleBackColor = true;
            employeesAdminButton.Click += employeesAdminButton_Click;
            // 
            // teamsAdminButton
            // 
            teamsAdminButton.Location = new Point(503, 3);
            teamsAdminButton.Name = "teamsAdminButton";
            teamsAdminButton.Size = new Size(486, 35);
            teamsAdminButton.TabIndex = 3;
            teamsAdminButton.Text = "Teams";
            teamsAdminButton.UseVisualStyleBackColor = true;
            teamsAdminButton.Click += teamsAdminButton_Click;
            // 
            // tasksAdminButton
            // 
            tasksAdminButton.Enabled = false;
            tasksAdminButton.Location = new Point(10, 57);
            tasksAdminButton.Name = "tasksAdminButton";
            tasksAdminButton.Size = new Size(486, 35);
            tasksAdminButton.TabIndex = 2;
            tasksAdminButton.Text = "Tasks";
            tasksAdminButton.UseVisualStyleBackColor = true;
            tasksAdminButton.Click += tasksAdminButton_Click;
            // 
            // projectsAdminButton
            // 
            projectsAdminButton.Location = new Point(10, 3);
            projectsAdminButton.Name = "projectsAdminButton";
            projectsAdminButton.Size = new Size(486, 35);
            projectsAdminButton.TabIndex = 1;
            projectsAdminButton.Text = "Projects";
            projectsAdminButton.UseVisualStyleBackColor = true;
            projectsAdminButton.Click += projectsAdminButton_Click;
            // 
            // employeesAdminPanel
            // 
            employeesAdminPanel.Controls.Add(generateReportButton);
            employeesAdminPanel.Controls.Add(AssignEmployeeToTeamButton);
            employeesAdminPanel.Controls.Add(employeeHistoryListView);
            employeesAdminPanel.Controls.Add(deleteHistoryRecordButton);
            employeesAdminPanel.Controls.Add(editHistoryRecordButton);
            employeesAdminPanel.Controls.Add(addHistoryRecordButton);
            employeesAdminPanel.Controls.Add(label1);
            employeesAdminPanel.Controls.Add(employeesStatusAdminTextbox);
            employeesAdminPanel.Controls.Add(employeesRoleAdminTextbox);
            employeesAdminPanel.Controls.Add(teamNameEmployeesAdminPanel);
            employeesAdminPanel.Controls.Add(employeesEmailAdminTextbox);
            employeesAdminPanel.Controls.Add(employeesUsernameAdminTexbox);
            employeesAdminPanel.Controls.Add(employeesStatusAdminLabel);
            employeesAdminPanel.Controls.Add(employeesRoleAdminLabel);
            employeesAdminPanel.Controls.Add(employeesEmailAdminLabel);
            employeesAdminPanel.Controls.Add(employeesUsernameAdminLabel);
            employeesAdminPanel.Controls.Add(employeesDeleteEmployeeAdminButton);
            employeesAdminPanel.Controls.Add(employeesEditEmployeeAdminButton);
            employeesAdminPanel.Controls.Add(employeesAddEmployeeAdminButton);
            employeesAdminPanel.Controls.Add(employeesAdminListbox);
            employeesAdminPanel.Location = new Point(10, 116);
            employeesAdminPanel.Name = "employeesAdminPanel";
            employeesAdminPanel.Size = new Size(1279, 801);
            employeesAdminPanel.TabIndex = 15;
            employeesAdminPanel.Visible = false;
            // 
            // generateReportButton
            // 
            generateReportButton.Location = new Point(431, 727);
            generateReportButton.Margin = new Padding(3, 5, 3, 5);
            generateReportButton.Name = "generateReportButton";
            generateReportButton.Size = new Size(414, 39);
            generateReportButton.TabIndex = 26;
            generateReportButton.Text = "Generate Report";
            generateReportButton.UseVisualStyleBackColor = true;
            generateReportButton.Click += generateReportButton_Click;
            // 
            // AssignEmployeeToTeamButton
            // 
            AssignEmployeeToTeamButton.Location = new Point(431, 661);
            AssignEmployeeToTeamButton.Margin = new Padding(3, 5, 3, 5);
            AssignEmployeeToTeamButton.Name = "AssignEmployeeToTeamButton";
            AssignEmployeeToTeamButton.Size = new Size(414, 39);
            AssignEmployeeToTeamButton.TabIndex = 24;
            AssignEmployeeToTeamButton.Text = "Modify Which Teams This Employee Belongs To";
            AssignEmployeeToTeamButton.UseVisualStyleBackColor = true;
            AssignEmployeeToTeamButton.Click += AssignEmployeeToTeamButton_Click;
            // 
            // employeeHistoryListView
            // 
            employeeHistoryListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            employeeHistoryListView.FullRowSelect = true;
            employeeHistoryListView.GridLines = true;
            employeeHistoryListView.Location = new Point(505, 325);
            employeeHistoryListView.Margin = new Padding(3, 5, 3, 5);
            employeeHistoryListView.Name = "employeeHistoryListView";
            employeeHistoryListView.Size = new Size(751, 241);
            employeeHistoryListView.TabIndex = 23;
            employeeHistoryListView.UseCompatibleStateImageBehavior = false;
            employeeHistoryListView.View = View.Details;
            employeeHistoryListView.SelectedIndexChanged += employeeHistoryListView_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Event";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Date";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Notes";
            columnHeader3.Width = 450;
            // 
            // deleteHistoryRecordButton
            // 
            deleteHistoryRecordButton.Location = new Point(1029, 264);
            deleteHistoryRecordButton.Margin = new Padding(3, 5, 3, 5);
            deleteHistoryRecordButton.Name = "deleteHistoryRecordButton";
            deleteHistoryRecordButton.Size = new Size(229, 39);
            deleteHistoryRecordButton.TabIndex = 21;
            deleteHistoryRecordButton.Text = "Delete Record";
            deleteHistoryRecordButton.UseVisualStyleBackColor = true;
            deleteHistoryRecordButton.Click += deleteHistoryRecordButton_Click;
            // 
            // editHistoryRecordButton
            // 
            editHistoryRecordButton.Location = new Point(766, 264);
            editHistoryRecordButton.Margin = new Padding(3, 5, 3, 5);
            editHistoryRecordButton.Name = "editHistoryRecordButton";
            editHistoryRecordButton.Size = new Size(229, 39);
            editHistoryRecordButton.TabIndex = 20;
            editHistoryRecordButton.Text = "Edit Record";
            editHistoryRecordButton.UseVisualStyleBackColor = true;
            editHistoryRecordButton.Click += editHistoryRecordButton_Click;
            // 
            // addHistoryRecordButton
            // 
            addHistoryRecordButton.Location = new Point(505, 264);
            addHistoryRecordButton.Margin = new Padding(3, 5, 3, 5);
            addHistoryRecordButton.Name = "addHistoryRecordButton";
            addHistoryRecordButton.Size = new Size(229, 39);
            addHistoryRecordButton.TabIndex = 19;
            addHistoryRecordButton.Text = "Add New Record";
            addHistoryRecordButton.UseVisualStyleBackColor = true;
            addHistoryRecordButton.Click += addHistoryRecordButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 273);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 18;
            label1.Text = "Employee History";
            // 
            // employeesStatusAdminTextbox
            // 
            employeesStatusAdminTextbox.Location = new Point(505, 201);
            employeesStatusAdminTextbox.Name = "employeesStatusAdminTextbox";
            employeesStatusAdminTextbox.ReadOnly = true;
            employeesStatusAdminTextbox.Size = new Size(746, 27);
            employeesStatusAdminTextbox.TabIndex = 15;
            // 
            // employeesRoleAdminTextbox
            // 
            employeesRoleAdminTextbox.Location = new Point(505, 143);
            employeesRoleAdminTextbox.Name = "employeesRoleAdminTextbox";
            employeesRoleAdminTextbox.ReadOnly = true;
            employeesRoleAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            employeesRoleAdminTextbox.Size = new Size(746, 27);
            employeesRoleAdminTextbox.TabIndex = 14;
            // 
            // teamNameEmployeesAdminPanel
            // 
            teamNameEmployeesAdminPanel.AutoEllipsis = true;
            teamNameEmployeesAdminPanel.Font = new Font("Segoe UI", 13F);
            teamNameEmployeesAdminPanel.Location = new Point(17, 1);
            teamNameEmployeesAdminPanel.Name = "teamNameEmployeesAdminPanel";
            teamNameEmployeesAdminPanel.Size = new Size(322, 59);
            teamNameEmployeesAdminPanel.TabIndex = 13;
            teamNameEmployeesAdminPanel.Text = "selected team name goes here";
            teamNameEmployeesAdminPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // employeesEmailAdminTextbox
            // 
            employeesEmailAdminTextbox.Location = new Point(505, 75);
            employeesEmailAdminTextbox.Name = "employeesEmailAdminTextbox";
            employeesEmailAdminTextbox.ReadOnly = true;
            employeesEmailAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            employeesEmailAdminTextbox.Size = new Size(746, 27);
            employeesEmailAdminTextbox.TabIndex = 9;
            // 
            // employeesUsernameAdminTexbox
            // 
            employeesUsernameAdminTexbox.Location = new Point(505, 12);
            employeesUsernameAdminTexbox.Name = "employeesUsernameAdminTexbox";
            employeesUsernameAdminTexbox.ReadOnly = true;
            employeesUsernameAdminTexbox.ScrollBars = ScrollBars.Horizontal;
            employeesUsernameAdminTexbox.Size = new Size(746, 27);
            employeesUsernameAdminTexbox.TabIndex = 8;
            // 
            // employeesStatusAdminLabel
            // 
            employeesStatusAdminLabel.AutoSize = true;
            employeesStatusAdminLabel.Location = new Point(362, 205);
            employeesStatusAdminLabel.Name = "employeesStatusAdminLabel";
            employeesStatusAdminLabel.Size = new Size(137, 20);
            employeesStatusAdminLabel.TabIndex = 7;
            employeesStatusAdminLabel.Text = "Employment Status";
            // 
            // employeesRoleAdminLabel
            // 
            employeesRoleAdminLabel.AutoSize = true;
            employeesRoleAdminLabel.Location = new Point(454, 153);
            employeesRoleAdminLabel.Name = "employeesRoleAdminLabel";
            employeesRoleAdminLabel.Size = new Size(39, 20);
            employeesRoleAdminLabel.TabIndex = 6;
            employeesRoleAdminLabel.Text = "Role";
            // 
            // employeesEmailAdminLabel
            // 
            employeesEmailAdminLabel.AutoSize = true;
            employeesEmailAdminLabel.Location = new Point(441, 79);
            employeesEmailAdminLabel.Name = "employeesEmailAdminLabel";
            employeesEmailAdminLabel.Size = new Size(52, 20);
            employeesEmailAdminLabel.TabIndex = 5;
            employeesEmailAdminLabel.Text = "E-mail";
            // 
            // employeesUsernameAdminLabel
            // 
            employeesUsernameAdminLabel.AutoSize = true;
            employeesUsernameAdminLabel.Location = new Point(419, 16);
            employeesUsernameAdminLabel.Name = "employeesUsernameAdminLabel";
            employeesUsernameAdminLabel.Size = new Size(75, 20);
            employeesUsernameAdminLabel.TabIndex = 4;
            employeesUsernameAdminLabel.Text = "Username";
            // 
            // employeesDeleteEmployeeAdminButton
            // 
            employeesDeleteEmployeeAdminButton.Location = new Point(846, 595);
            employeesDeleteEmployeeAdminButton.Name = "employeesDeleteEmployeeAdminButton";
            employeesDeleteEmployeeAdminButton.Size = new Size(411, 37);
            employeesDeleteEmployeeAdminButton.TabIndex = 3;
            employeesDeleteEmployeeAdminButton.Text = "Delete Employee";
            employeesDeleteEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesDeleteEmployeeAdminButton.Click += employeesDeleteEmployeeAdminButton_Click;
            // 
            // employeesEditEmployeeAdminButton
            // 
            employeesEditEmployeeAdminButton.Location = new Point(431, 595);
            employeesEditEmployeeAdminButton.Name = "employeesEditEmployeeAdminButton";
            employeesEditEmployeeAdminButton.Size = new Size(414, 39);
            employeesEditEmployeeAdminButton.TabIndex = 2;
            employeesEditEmployeeAdminButton.Text = "Edit Employee";
            employeesEditEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesEditEmployeeAdminButton.Click += employeesEditEmployeeAdminButton_Click;
            // 
            // employeesAddEmployeeAdminButton
            // 
            employeesAddEmployeeAdminButton.Location = new Point(16, 595);
            employeesAddEmployeeAdminButton.Name = "employeesAddEmployeeAdminButton";
            employeesAddEmployeeAdminButton.Size = new Size(414, 39);
            employeesAddEmployeeAdminButton.TabIndex = 1;
            employeesAddEmployeeAdminButton.Text = "Add New Employee";
            employeesAddEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesAddEmployeeAdminButton.Click += employeesAddEmployeeAdminButton_Click;
            // 
            // employeesAdminListbox
            // 
            employeesAdminListbox.FormattingEnabled = true;
            employeesAdminListbox.Location = new Point(19, 81);
            employeesAdminListbox.Name = "employeesAdminListbox";
            employeesAdminListbox.Size = new Size(321, 484);
            employeesAdminListbox.TabIndex = 0;
            employeesAdminListbox.SelectedIndexChanged += employeesAdminListbox_SelectedIndexChanged_1;
            // 
            // projectsAdminPanel
            // 
            projectsAdminPanel.Controls.Add(label2);
            projectsAdminPanel.Controls.Add(projectsEndDateAdminDatePicker);
            projectsAdminPanel.Controls.Add(projectsStartDateAdminDatePicker);
            projectsAdminPanel.Controls.Add(projectsEndDateAdminLabel);
            projectsAdminPanel.Controls.Add(projectsStartDateAdminLabel);
            projectsAdminPanel.Controls.Add(projectsDescriptionAdminTextbox);
            projectsAdminPanel.Controls.Add(projectsDeleteProjectAdminButton);
            projectsAdminPanel.Controls.Add(projectsEditProjectAdminButton);
            projectsAdminPanel.Controls.Add(projectsNameAdminTextbox);
            projectsAdminPanel.Controls.Add(projectsDescriptionAdminLabel);
            projectsAdminPanel.Controls.Add(projectsNameAdminLabel);
            projectsAdminPanel.Controls.Add(projectsAddProjectAdminButton);
            projectsAdminPanel.Controls.Add(projectsAdminListbox);
            projectsAdminPanel.Location = new Point(10, 116);
            projectsAdminPanel.Name = "projectsAdminPanel";
            projectsAdminPanel.Size = new Size(1275, 801);
            projectsAdminPanel.TabIndex = 16;
            projectsAdminPanel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 253);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 16;
            label2.Text = "Assigned Teams";
            // 
            // projectsEndDateAdminDatePicker
            // 
            projectsEndDateAdminDatePicker.Enabled = false;
            projectsEndDateAdminDatePicker.Location = new Point(454, 495);
            projectsEndDateAdminDatePicker.Name = "projectsEndDateAdminDatePicker";
            projectsEndDateAdminDatePicker.Size = new Size(250, 27);
            projectsEndDateAdminDatePicker.TabIndex = 15;
            // 
            // projectsStartDateAdminDatePicker
            // 
            projectsStartDateAdminDatePicker.Enabled = false;
            projectsStartDateAdminDatePicker.Location = new Point(454, 435);
            projectsStartDateAdminDatePicker.Name = "projectsStartDateAdminDatePicker";
            projectsStartDateAdminDatePicker.Size = new Size(250, 27);
            projectsStartDateAdminDatePicker.TabIndex = 14;
            // 
            // projectsEndDateAdminLabel
            // 
            projectsEndDateAdminLabel.AutoSize = true;
            projectsEndDateAdminLabel.Location = new Point(375, 503);
            projectsEndDateAdminLabel.Name = "projectsEndDateAdminLabel";
            projectsEndDateAdminLabel.Size = new Size(69, 20);
            projectsEndDateAdminLabel.TabIndex = 13;
            projectsEndDateAdminLabel.Text = "Deadline";
            // 
            // projectsStartDateAdminLabel
            // 
            projectsStartDateAdminLabel.AutoSize = true;
            projectsStartDateAdminLabel.Location = new Point(369, 441);
            projectsStartDateAdminLabel.Name = "projectsStartDateAdminLabel";
            projectsStartDateAdminLabel.Size = new Size(76, 20);
            projectsStartDateAdminLabel.TabIndex = 12;
            projectsStartDateAdminLabel.Text = "Start Date";
            // 
            // projectsDescriptionAdminTextbox
            // 
            projectsDescriptionAdminTextbox.Location = new Point(454, 77);
            projectsDescriptionAdminTextbox.Multiline = true;
            projectsDescriptionAdminTextbox.Name = "projectsDescriptionAdminTextbox";
            projectsDescriptionAdminTextbox.ReadOnly = true;
            projectsDescriptionAdminTextbox.Size = new Size(781, 147);
            projectsDescriptionAdminTextbox.TabIndex = 11;
            // 
            // projectsDeleteProjectAdminButton
            // 
            projectsDeleteProjectAdminButton.Location = new Point(827, 556);
            projectsDeleteProjectAdminButton.Name = "projectsDeleteProjectAdminButton";
            projectsDeleteProjectAdminButton.Size = new Size(414, 39);
            projectsDeleteProjectAdminButton.TabIndex = 10;
            projectsDeleteProjectAdminButton.Text = "Delete Project";
            projectsDeleteProjectAdminButton.UseVisualStyleBackColor = true;
            projectsDeleteProjectAdminButton.Click += projectsDeleteProjectAdminButton_Click;
            // 
            // projectsEditProjectAdminButton
            // 
            projectsEditProjectAdminButton.Location = new Point(417, 556);
            projectsEditProjectAdminButton.Name = "projectsEditProjectAdminButton";
            projectsEditProjectAdminButton.Size = new Size(414, 39);
            projectsEditProjectAdminButton.TabIndex = 9;
            projectsEditProjectAdminButton.Text = "Edit Project";
            projectsEditProjectAdminButton.UseVisualStyleBackColor = true;
            projectsEditProjectAdminButton.Click += projectsEditProjectAdminButton_Click;
            // 
            // projectsNameAdminTextbox
            // 
            projectsNameAdminTextbox.Location = new Point(454, 11);
            projectsNameAdminTextbox.Name = "projectsNameAdminTextbox";
            projectsNameAdminTextbox.ReadOnly = true;
            projectsNameAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            projectsNameAdminTextbox.Size = new Size(781, 27);
            projectsNameAdminTextbox.TabIndex = 8;
            // 
            // projectsDescriptionAdminLabel
            // 
            projectsDescriptionAdminLabel.AutoSize = true;
            projectsDescriptionAdminLabel.Location = new Point(360, 81);
            projectsDescriptionAdminLabel.Name = "projectsDescriptionAdminLabel";
            projectsDescriptionAdminLabel.Size = new Size(85, 20);
            projectsDescriptionAdminLabel.TabIndex = 5;
            projectsDescriptionAdminLabel.Text = "Description";
            // 
            // projectsNameAdminLabel
            // 
            projectsNameAdminLabel.AutoSize = true;
            projectsNameAdminLabel.Location = new Point(347, 15);
            projectsNameAdminLabel.Name = "projectsNameAdminLabel";
            projectsNameAdminLabel.Size = new Size(99, 20);
            projectsNameAdminLabel.TabIndex = 4;
            projectsNameAdminLabel.Text = "Project Name";
            // 
            // projectsAddProjectAdminButton
            // 
            projectsAddProjectAdminButton.Location = new Point(0, 556);
            projectsAddProjectAdminButton.Name = "projectsAddProjectAdminButton";
            projectsAddProjectAdminButton.Size = new Size(414, 39);
            projectsAddProjectAdminButton.TabIndex = 1;
            projectsAddProjectAdminButton.Text = "Add New Project";
            projectsAddProjectAdminButton.UseVisualStyleBackColor = true;
            projectsAddProjectAdminButton.Click += projectsAddProjectAdminButton_Click;
            // 
            // projectsAdminListbox
            // 
            projectsAdminListbox.FormattingEnabled = true;
            projectsAdminListbox.Location = new Point(3, 0);
            projectsAdminListbox.Name = "projectsAdminListbox";
            projectsAdminListbox.Size = new Size(321, 524);
            projectsAdminListbox.TabIndex = 0;
            projectsAdminListbox.SelectedIndexChanged += projectsAdminListbox_SelectedIndexChanged;
            // 
            // tasksAdminPanel
            // 
            tasksAdminPanel.Controls.Add(AssignTaskToEmployeeButton);
            tasksAdminPanel.Controls.Add(tasksDeleteTaskAdminButton);
            tasksAdminPanel.Controls.Add(tasksEditTaskAdminButton);
            tasksAdminPanel.Controls.Add(tasksNameAdminTextbox);
            tasksAdminPanel.Controls.Add(tasksDescriptionAdminTextbox);
            tasksAdminPanel.Controls.Add(tasksStatusAdminTextbox);
            tasksAdminPanel.Controls.Add(tasksProjectNameAdminLabel);
            tasksAdminPanel.Controls.Add(tasksDueDateAdminDatePicker);
            tasksAdminPanel.Controls.Add(tasksDueDateLabel);
            tasksAdminPanel.Controls.Add(tasksStatusAdminLabel);
            tasksAdminPanel.Controls.Add(tasksDescriptionAdminLabel);
            tasksAdminPanel.Controls.Add(tasksNameAdminLabel);
            tasksAdminPanel.Controls.Add(tasksAddTaskAdminButton);
            tasksAdminPanel.Controls.Add(tasksAdminListbox);
            tasksAdminPanel.Location = new Point(10, 119);
            tasksAdminPanel.Name = "tasksAdminPanel";
            tasksAdminPanel.Size = new Size(1279, 784);
            tasksAdminPanel.TabIndex = 13;
            tasksAdminPanel.Visible = false;
            // 
            // AssignTaskToEmployeeButton
            // 
            AssignTaskToEmployeeButton.Enabled = false;
            AssignTaskToEmployeeButton.Location = new Point(415, 659);
            AssignTaskToEmployeeButton.Margin = new Padding(3, 5, 3, 5);
            AssignTaskToEmployeeButton.Name = "AssignTaskToEmployeeButton";
            AssignTaskToEmployeeButton.Size = new Size(414, 39);
            AssignTaskToEmployeeButton.TabIndex = 19;
            AssignTaskToEmployeeButton.Text = "Select Which Employees Are Assigned To This Task";
            AssignTaskToEmployeeButton.UseVisualStyleBackColor = true;
            AssignTaskToEmployeeButton.Click += AssignTaskToEmployeesButton_Click;
            // 
            // tasksDeleteTaskAdminButton
            // 
            tasksDeleteTaskAdminButton.Location = new Point(832, 583);
            tasksDeleteTaskAdminButton.Name = "tasksDeleteTaskAdminButton";
            tasksDeleteTaskAdminButton.Size = new Size(414, 39);
            tasksDeleteTaskAdminButton.TabIndex = 18;
            tasksDeleteTaskAdminButton.Text = "Delete Task";
            tasksDeleteTaskAdminButton.UseVisualStyleBackColor = true;
            tasksDeleteTaskAdminButton.Click += tasksDeleteTaskAdminButton_Click;
            // 
            // tasksEditTaskAdminButton
            // 
            tasksEditTaskAdminButton.Location = new Point(415, 583);
            tasksEditTaskAdminButton.Name = "tasksEditTaskAdminButton";
            tasksEditTaskAdminButton.Size = new Size(414, 39);
            tasksEditTaskAdminButton.TabIndex = 17;
            tasksEditTaskAdminButton.Text = "Edit Task";
            tasksEditTaskAdminButton.UseVisualStyleBackColor = true;
            tasksEditTaskAdminButton.Click += tasksEditTaskAdminButton_Click;
            // 
            // tasksNameAdminTextbox
            // 
            tasksNameAdminTextbox.Location = new Point(454, 11);
            tasksNameAdminTextbox.Name = "tasksNameAdminTextbox";
            tasksNameAdminTextbox.ReadOnly = true;
            tasksNameAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            tasksNameAdminTextbox.Size = new Size(781, 27);
            tasksNameAdminTextbox.TabIndex = 16;
            // 
            // tasksDescriptionAdminTextbox
            // 
            tasksDescriptionAdminTextbox.Location = new Point(454, 71);
            tasksDescriptionAdminTextbox.Multiline = true;
            tasksDescriptionAdminTextbox.Name = "tasksDescriptionAdminTextbox";
            tasksDescriptionAdminTextbox.ReadOnly = true;
            tasksDescriptionAdminTextbox.ScrollBars = ScrollBars.Vertical;
            tasksDescriptionAdminTextbox.Size = new Size(781, 151);
            tasksDescriptionAdminTextbox.TabIndex = 15;
            // 
            // tasksStatusAdminTextbox
            // 
            tasksStatusAdminTextbox.Location = new Point(454, 457);
            tasksStatusAdminTextbox.Name = "tasksStatusAdminTextbox";
            tasksStatusAdminTextbox.ReadOnly = true;
            tasksStatusAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            tasksStatusAdminTextbox.Size = new Size(781, 27);
            tasksStatusAdminTextbox.TabIndex = 14;
            // 
            // tasksProjectNameAdminLabel
            // 
            tasksProjectNameAdminLabel.AutoEllipsis = true;
            tasksProjectNameAdminLabel.AutoSize = true;
            tasksProjectNameAdminLabel.Font = new Font("Segoe UI", 13F);
            tasksProjectNameAdminLabel.Location = new Point(2, 4);
            tasksProjectNameAdminLabel.MaximumSize = new Size(321, 67);
            tasksProjectNameAdminLabel.Name = "tasksProjectNameAdminLabel";
            tasksProjectNameAdminLabel.Size = new Size(280, 60);
            tasksProjectNameAdminLabel.TabIndex = 13;
            tasksProjectNameAdminLabel.Text = "selected project name goes here";
            tasksProjectNameAdminLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksDueDateAdminDatePicker
            // 
            tasksDueDateAdminDatePicker.Enabled = false;
            tasksDueDateAdminDatePicker.Location = new Point(454, 523);
            tasksDueDateAdminDatePicker.Name = "tasksDueDateAdminDatePicker";
            tasksDueDateAdminDatePicker.Size = new Size(250, 27);
            tasksDueDateAdminDatePicker.TabIndex = 12;
            tasksDueDateAdminDatePicker.Value = new DateTime(2025, 8, 1, 0, 0, 0, 0);
            // 
            // tasksDueDateLabel
            // 
            tasksDueDateLabel.AutoSize = true;
            tasksDueDateLabel.Location = new Point(374, 529);
            tasksDueDateLabel.Name = "tasksDueDateLabel";
            tasksDueDateLabel.Size = new Size(69, 20);
            tasksDueDateLabel.TabIndex = 7;
            tasksDueDateLabel.Text = "Deadline";
            // 
            // tasksStatusAdminLabel
            // 
            tasksStatusAdminLabel.AutoSize = true;
            tasksStatusAdminLabel.Location = new Point(344, 461);
            tasksStatusAdminLabel.Name = "tasksStatusAdminLabel";
            tasksStatusAdminLabel.Size = new Size(101, 20);
            tasksStatusAdminLabel.TabIndex = 6;
            tasksStatusAdminLabel.Text = "Current Status";
            // 
            // tasksDescriptionAdminLabel
            // 
            tasksDescriptionAdminLabel.AutoSize = true;
            tasksDescriptionAdminLabel.Location = new Point(361, 77);
            tasksDescriptionAdminLabel.Name = "tasksDescriptionAdminLabel";
            tasksDescriptionAdminLabel.Size = new Size(85, 20);
            tasksDescriptionAdminLabel.TabIndex = 5;
            tasksDescriptionAdminLabel.Text = "Description";
            // 
            // tasksNameAdminLabel
            // 
            tasksNameAdminLabel.AutoSize = true;
            tasksNameAdminLabel.Location = new Point(365, 13);
            tasksNameAdminLabel.Name = "tasksNameAdminLabel";
            tasksNameAdminLabel.Size = new Size(80, 20);
            tasksNameAdminLabel.TabIndex = 4;
            tasksNameAdminLabel.Text = "Task Name";
            // 
            // tasksAddTaskAdminButton
            // 
            tasksAddTaskAdminButton.Location = new Point(-3, 583);
            tasksAddTaskAdminButton.Name = "tasksAddTaskAdminButton";
            tasksAddTaskAdminButton.Size = new Size(414, 39);
            tasksAddTaskAdminButton.TabIndex = 1;
            tasksAddTaskAdminButton.Text = "Add New Task";
            tasksAddTaskAdminButton.UseVisualStyleBackColor = true;
            tasksAddTaskAdminButton.Click += tasksAddTaskAdminButton_Click;
            // 
            // tasksAdminListbox
            // 
            tasksAdminListbox.FormattingEnabled = true;
            tasksAdminListbox.Location = new Point(3, 80);
            tasksAdminListbox.Name = "tasksAdminListbox";
            tasksAdminListbox.Size = new Size(321, 464);
            tasksAdminListbox.TabIndex = 0;
            tasksAdminListbox.SelectedIndexChanged += tasksAdminListbox_SelectedIndexChanged;
            // 
            // teamsAdminPanel
            // 
            teamsAdminPanel.Controls.Add(AssignTeamToProjectButton);
            teamsAdminPanel.Controls.Add(teamsDescriptionAdminTextbox);
            teamsAdminPanel.Controls.Add(teamsDeleteTeamAdminButton);
            teamsAdminPanel.Controls.Add(teamsEditTeamAdminButton);
            teamsAdminPanel.Controls.Add(teamsNameAdminTexbox);
            teamsAdminPanel.Controls.Add(teamsDescriptionAdminLabel);
            teamsAdminPanel.Controls.Add(teamsNameAdminLabel);
            teamsAdminPanel.Controls.Add(teamsAddTeamAdminButton);
            teamsAdminPanel.Controls.Add(teamsAdminListbox);
            teamsAdminPanel.Location = new Point(10, 119);
            teamsAdminPanel.Name = "teamsAdminPanel";
            teamsAdminPanel.Size = new Size(1279, 787);
            teamsAdminPanel.TabIndex = 14;
            teamsAdminPanel.Visible = false;
            // 
            // AssignTeamToProjectButton
            // 
            AssignTeamToProjectButton.Enabled = false;
            AssignTeamToProjectButton.Location = new Point(415, 639);
            AssignTeamToProjectButton.Margin = new Padding(3, 5, 3, 5);
            AssignTeamToProjectButton.Name = "AssignTeamToProjectButton";
            AssignTeamToProjectButton.Size = new Size(414, 39);
            AssignTeamToProjectButton.TabIndex = 20;
            AssignTeamToProjectButton.Text = "Modify This Team's Project Assignments";
            AssignTeamToProjectButton.UseVisualStyleBackColor = true;
            AssignTeamToProjectButton.Click += AssignTeamToProjectsButton_Click;
            // 
            // teamsDescriptionAdminTextbox
            // 
            teamsDescriptionAdminTextbox.Location = new Point(454, 71);
            teamsDescriptionAdminTextbox.Multiline = true;
            teamsDescriptionAdminTextbox.Name = "teamsDescriptionAdminTextbox";
            teamsDescriptionAdminTextbox.ReadOnly = true;
            teamsDescriptionAdminTextbox.Size = new Size(781, 468);
            teamsDescriptionAdminTextbox.TabIndex = 11;
            // 
            // teamsDeleteTeamAdminButton
            // 
            teamsDeleteTeamAdminButton.Location = new Point(827, 571);
            teamsDeleteTeamAdminButton.Name = "teamsDeleteTeamAdminButton";
            teamsDeleteTeamAdminButton.Size = new Size(414, 39);
            teamsDeleteTeamAdminButton.TabIndex = 10;
            teamsDeleteTeamAdminButton.Text = "Delete Team";
            teamsDeleteTeamAdminButton.UseVisualStyleBackColor = true;
            teamsDeleteTeamAdminButton.Click += teamsDeleteTeamAdminButton_Click;
            // 
            // teamsEditTeamAdminButton
            // 
            teamsEditTeamAdminButton.Location = new Point(415, 571);
            teamsEditTeamAdminButton.Name = "teamsEditTeamAdminButton";
            teamsEditTeamAdminButton.Size = new Size(414, 39);
            teamsEditTeamAdminButton.TabIndex = 9;
            teamsEditTeamAdminButton.Text = "Edit Team";
            teamsEditTeamAdminButton.UseVisualStyleBackColor = true;
            teamsEditTeamAdminButton.Click += teamsEditTeamAdminButton_Click;
            // 
            // teamsNameAdminTexbox
            // 
            teamsNameAdminTexbox.Location = new Point(454, 11);
            teamsNameAdminTexbox.Name = "teamsNameAdminTexbox";
            teamsNameAdminTexbox.ReadOnly = true;
            teamsNameAdminTexbox.ScrollBars = ScrollBars.Horizontal;
            teamsNameAdminTexbox.Size = new Size(781, 27);
            teamsNameAdminTexbox.TabIndex = 8;
            // 
            // teamsDescriptionAdminLabel
            // 
            teamsDescriptionAdminLabel.AutoSize = true;
            teamsDescriptionAdminLabel.Location = new Point(359, 76);
            teamsDescriptionAdminLabel.Name = "teamsDescriptionAdminLabel";
            teamsDescriptionAdminLabel.Size = new Size(85, 20);
            teamsDescriptionAdminLabel.TabIndex = 5;
            teamsDescriptionAdminLabel.Text = "Description";
            // 
            // teamsNameAdminLabel
            // 
            teamsNameAdminLabel.AutoSize = true;
            teamsNameAdminLabel.Location = new Point(357, 13);
            teamsNameAdminLabel.Name = "teamsNameAdminLabel";
            teamsNameAdminLabel.Size = new Size(89, 20);
            teamsNameAdminLabel.TabIndex = 4;
            teamsNameAdminLabel.Text = "Team Name";
            // 
            // teamsAddTeamAdminButton
            // 
            teamsAddTeamAdminButton.Location = new Point(2, 571);
            teamsAddTeamAdminButton.Name = "teamsAddTeamAdminButton";
            teamsAddTeamAdminButton.Size = new Size(414, 39);
            teamsAddTeamAdminButton.TabIndex = 1;
            teamsAddTeamAdminButton.Text = "Add New Team";
            teamsAddTeamAdminButton.UseVisualStyleBackColor = true;
            teamsAddTeamAdminButton.Click += teamsAddTeamAdminButton_Click;
            // 
            // teamsAdminListbox
            // 
            teamsAdminListbox.FormattingEnabled = true;
            teamsAdminListbox.Location = new Point(3, 0);
            teamsAdminListbox.Name = "teamsAdminListbox";
            teamsAdminListbox.Size = new Size(321, 544);
            teamsAdminListbox.TabIndex = 0;
            teamsAdminListbox.SelectedIndexChanged += teamsAdminListbox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 923);
            Controls.Add(loginPanel);
            Controls.Add(adminViewPanel);
            Controls.Add(userViewPanel);
            Name = "Form1";
            Text = "Time Tracker - DSaA Project";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            userViewPanel.ResumeLayout(false);
            teamsUserPanel.ResumeLayout(false);
            tasksUserPanel.ResumeLayout(false);
            adminViewPanel.ResumeLayout(false);
            employeesAdminPanel.ResumeLayout(false);
            employeesAdminPanel.PerformLayout();
            projectsAdminPanel.ResumeLayout(false);
            projectsAdminPanel.PerformLayout();
            tasksAdminPanel.ResumeLayout(false);
            tasksAdminPanel.PerformLayout();
            teamsAdminPanel.ResumeLayout(false);
            teamsAdminPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button loginButton;
        private TextBox loginPasswordTextbox;
        private TextBox loginLoginTextbox;
        private Label loginPasswordLabel;
        private Label loginLoginLabel;
        private Panel userViewPanel;
        private Panel adminViewPanel;
        private Button projectsAdminButton;
        private Button logOutAdminButton;
        private Button employeesAdminButton;
        private Button teamsAdminButton;
        private Button tasksAdminButton;
        private Label employeesRoleAdminLabel;
        private Button editProjectButton;
        private Button newProjectButton;
        private ListBox projectsListBoxAdmin;
        private Button deleteProjectButton;
        private Label projectNameAdminLabel;
        private Label projectEndDateAdminLabel;
        private Label projectStartDateAdminLabel;
        private Label projectDescriptionAdminLabel;
        private TextBox projectDescriptionAdminTextbox;
        private TextBox projectNameAdminTextbox;
        private Panel tasksAdminPanel;
        private DateTimePicker tasksDueDateAdminDatePicker;
        private TextBox employeesEmailAdminTextbox;
        private Label tasksDueDateLabel;
        private Label tasksStatusAdminLabel;
        private Label tasksDescriptionAdminLabel;
        private Label tasksNameAdminLabel;
        private Button tasksAddTaskAdminButton;
        private ListBox tasksAdminListbox;
        private Label tasksProjectNameAdminLabel;
        private TextBox tasksStatusAdminTextbox;
        private Panel teamsAdminPanel;
        private DateTimePicker projectsStartDateAdminDatePicker;
        private TextBox employeesRoleAdminTextbox;
        private TextBox teamsNameAdminTexbox;
        private Label teamNameEmployeesAdminPanel;
        private Label employeesStatusAdminLabel;
        private Label teamsDescriptionAdminLabel;
        private Label teamsNameAdminLabel;
        private Button employeesDeleteEmployeeAdminButton;
        private Button employeesEditEmployeeAdminButton;
        private Button teamsAddTeamAdminButton;
        private ListBox teamsAdminListbox;
        private Panel employeesAdminPanel;
        private TextBox employeesUsernameAdminTexbox;
        private Label employeesEmailAdminLabel;
        private Label employeesUsernameAdminLabel;
        private Button employeesAddEmployeeAdminButton;
        private ListBox employeesAdminListbox;
        private Button teamsDeleteTeamAdminButton;
        private Button teamsEditTeamAdminButton;
        private TextBox teamsDescriptionAdminTextbox;
        private Panel projectsAdminPanel;
        private TextBox projectsDescriptionAdminTextbox;
        private Button projectsDeleteProjectAdminButton;
        private Button projectsEditProjectAdminButton;
        private TextBox projectsNameAdminTextbox;
        private Label projectsDescriptionAdminLabel;
        private Label projectsNameAdminLabel;
        private Button projectsAddProjectAdminButton;
        private ListBox projectsAdminListbox;
        private Label projectsEndDateAdminLabel;
        private Label projectsStartDateAdminLabel;
        private DateTimePicker projectsEndDateAdminDatePicker;
        private TextBox tasksDescriptionAdminTextbox;
        private TextBox tasksNameAdminTextbox;
        private Button tasksEditTaskAdminButton;
        private Button tasksDeleteTaskAdminButton;
        private TextBox employeesStatusAdminTextbox;
        private Label loginAuthorLabel;
        private Label loginTitleLabel;
        private Button tasksUserButton;
        private Button teamsUserButton;
        private Button logOutUserButton;
        private Panel tasksUserPanel;
        private Panel teamsUserPanel;
        private ListBox teamsNameUserListbox;
        private Label label5;
        private Label teamsMembersUserLabel;
        private Label tasksTodoUserLabel;
        private ListBox tasksDoneUserListbox;
        private ListBox tasksTodoUserListbox;
        private Label tasksDoneUserLabel;
        private Button helpButtonUser;
        private Button helpButtonAdmin;
        private Label label1;
        private Button deleteHistoryRecordButton;
        private Button editHistoryRecordButton;
        private Button addHistoryRecordButton;
        private ListView employeeHistoryListView;
        private ColumnHeader Event;
        private ColumnHeader Date;
        private ColumnHeader Notes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button AssignEmployeeToTeamButton;
        private Button AssignTaskToEmployeeButton;
        private Button AssignTeamToProjectButton;
        private Button generateReportButton;
        private Label label2;
        private ListView teamsMembersUserListview;
        private ColumnHeader userName;
        private ColumnHeader userEmail;
    }
}

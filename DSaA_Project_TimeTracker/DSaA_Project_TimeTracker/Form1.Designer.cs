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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            loginPasswordTextbox = new TextBox();
            loginLoginTextbox = new TextBox();
            userViewPanel = new Panel();
            logOutUserButton = new Button();
            teamsUserButton = new Button();
            tasksUserButton = new Button();
            teamsUserPanel = new Panel();
            teamsMembersUserLabel = new Label();
            teamsMembersUserListbox = new ListBox();
            teamsNameUserListbox = new ListBox();
            label5 = new Label();
            tasksUserPanel = new Panel();
            button4 = new Button();
            tasksDoneUserLabel = new Label();
            tasksTodoUserLabel = new Label();
            tasksDoneUserListbox = new ListBox();
            tasksTodoUserListbox = new ListBox();
            adminViewPanel = new Panel();
            logOutAdminButton = new Button();
            employeesAdminButton = new Button();
            teamsAdminButton = new Button();
            tasksAdminButton = new Button();
            projectsAdminButton = new Button();
            teamsAdminPanel = new Panel();
            teamsDescriptionAdminTextbox = new TextBox();
            teamsDeleteTeamAdminButton = new Button();
            teamsEditTeamAdminButton = new Button();
            teamsNameAdminTexbox = new TextBox();
            teamsDescriptionAdminLabel = new Label();
            teamsNameAdminLabel = new Label();
            teamsAddTeamAdminButton = new Button();
            teamsAdminListbox = new ListBox();
            tasksAdminPanel = new Panel();
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
            employeesAdminPanel = new Panel();
            label4 = new Label();
            employeesStatusAdminTextbox = new TextBox();
            employeesRoleAdminTextbox = new TextBox();
            label3 = new Label();
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
            loginPanel.SuspendLayout();
            userViewPanel.SuspendLayout();
            teamsUserPanel.SuspendLayout();
            tasksUserPanel.SuspendLayout();
            adminViewPanel.SuspendLayout();
            teamsAdminPanel.SuspendLayout();
            tasksAdminPanel.SuspendLayout();
            employeesAdminPanel.SuspendLayout();
            projectsAdminPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(loginAuthorLabel);
            loginPanel.Controls.Add(loginTitleLabel);
            loginPanel.Controls.Add(loginLoginLabel);
            loginPanel.Controls.Add(loginPasswordLabel);
            loginPanel.Controls.Add(button3);
            loginPanel.Controls.Add(button2);
            loginPanel.Controls.Add(button1);
            loginPanel.Controls.Add(loginPasswordTextbox);
            loginPanel.Controls.Add(loginLoginTextbox);
            loginPanel.Location = new Point(3, 2);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1258, 668);
            loginPanel.TabIndex = 0;
            // 
            // loginAuthorLabel
            // 
            loginAuthorLabel.AutoEllipsis = true;
            loginAuthorLabel.Location = new Point(0, 134);
            loginAuthorLabel.Name = "loginAuthorLabel";
            loginAuthorLabel.Size = new Size(1258, 25);
            loginAuthorLabel.TabIndex = 8;
            loginAuthorLabel.Text = "made by: Patryk Kwiecień, Mikołaj Musioł, Julia Przybyłowicz, Paweł Sosin, Paweł Strzępa, Mateusz Śmiech\r\n";
            loginAuthorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginTitleLabel
            // 
            loginTitleLabel.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginTitleLabel.Location = new Point(0, 50);
            loginTitleLabel.Name = "loginTitleLabel";
            loginTitleLabel.Size = new Size(1258, 84);
            loginTitleLabel.TabIndex = 7;
            loginTitleLabel.Text = "Time Tracking System";
            loginTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLoginLabel
            // 
            loginLoginLabel.AutoSize = true;
            loginLoginLabel.Location = new Point(461, 234);
            loginLoginLabel.Name = "loginLoginLabel";
            loginLoginLabel.Size = new Size(46, 20);
            loginLoginLabel.TabIndex = 6;
            loginLoginLabel.Text = "Login";
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Location = new Point(452, 275);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(70, 20);
            loginPasswordLabel.TabIndex = 5;
            loginPasswordLabel.Text = "Password";
            // 
            // button3
            // 
            button3.Location = new Point(451, 467);
            button3.Name = "button3";
            button3.Size = new Size(397, 36);
            button3.TabIndex = 4;
            button3.Text = "Show Admin View - Testing Purposes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(451, 417);
            button2.Name = "button2";
            button2.Size = new Size(397, 36);
            button2.TabIndex = 3;
            button2.Text = "Show User View - Testing Purposes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(528, 314);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            // 
            // loginPasswordTextbox
            // 
            loginPasswordTextbox.Location = new Point(528, 272);
            loginPasswordTextbox.Name = "loginPasswordTextbox";
            loginPasswordTextbox.PasswordChar = '*';
            loginPasswordTextbox.Size = new Size(320, 27);
            loginPasswordTextbox.TabIndex = 1;
            // 
            // loginLoginTextbox
            // 
            loginLoginTextbox.Location = new Point(528, 231);
            loginLoginTextbox.Name = "loginLoginTextbox";
            loginLoginTextbox.Size = new Size(320, 27);
            loginLoginTextbox.TabIndex = 0;
            // 
            // userViewPanel
            // 
            userViewPanel.Controls.Add(logOutUserButton);
            userViewPanel.Controls.Add(teamsUserButton);
            userViewPanel.Controls.Add(tasksUserButton);
            userViewPanel.Controls.Add(teamsUserPanel);
            userViewPanel.Controls.Add(tasksUserPanel);
            userViewPanel.Location = new Point(3, 2);
            userViewPanel.Name = "userViewPanel";
            userViewPanel.Size = new Size(1258, 668);
            userViewPanel.TabIndex = 7;
            userViewPanel.Visible = false;
            // 
            // logOutUserButton
            // 
            logOutUserButton.Location = new Point(841, 0);
            logOutUserButton.Name = "logOutUserButton";
            logOutUserButton.Size = new Size(414, 39);
            logOutUserButton.TabIndex = 2;
            logOutUserButton.Text = "Log Out";
            logOutUserButton.UseVisualStyleBackColor = true;
            logOutUserButton.Click += logOutUserButton_Click;
            // 
            // teamsUserButton
            // 
            teamsUserButton.Location = new Point(422, 0);
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
            tasksUserButton.Location = new Point(0, 0);
            tasksUserButton.Name = "tasksUserButton";
            tasksUserButton.Size = new Size(414, 39);
            tasksUserButton.TabIndex = 0;
            tasksUserButton.Text = "My Tasks";
            tasksUserButton.UseVisualStyleBackColor = true;
            tasksUserButton.Click += tasksUserButton_Click;
            // 
            // teamsUserPanel
            // 
            teamsUserPanel.Controls.Add(teamsMembersUserLabel);
            teamsUserPanel.Controls.Add(teamsMembersUserListbox);
            teamsUserPanel.Controls.Add(teamsNameUserListbox);
            teamsUserPanel.Controls.Add(label5);
            teamsUserPanel.Location = new Point(3, 39);
            teamsUserPanel.Name = "teamsUserPanel";
            teamsUserPanel.Size = new Size(1252, 626);
            teamsUserPanel.TabIndex = 4;
            teamsUserPanel.Visible = false;
            // 
            // teamsMembersUserLabel
            // 
            teamsMembersUserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamsMembersUserLabel.Location = new Point(435, 3);
            teamsMembersUserLabel.Name = "teamsMembersUserLabel";
            teamsMembersUserLabel.Size = new Size(810, 37);
            teamsMembersUserLabel.TabIndex = 3;
            teamsMembersUserLabel.Text = "The selected team contains the following members:";
            teamsMembersUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teamsMembersUserListbox
            // 
            teamsMembersUserListbox.FormattingEnabled = true;
            teamsMembersUserListbox.Location = new Point(435, 41);
            teamsMembersUserListbox.Name = "teamsMembersUserListbox";
            teamsMembersUserListbox.Size = new Size(811, 584);
            teamsMembersUserListbox.TabIndex = 2;
            // 
            // teamsNameUserListbox
            // 
            teamsNameUserListbox.FormattingEnabled = true;
            teamsNameUserListbox.Location = new Point(3, 41);
            teamsNameUserListbox.Name = "teamsNameUserListbox";
            teamsNameUserListbox.Size = new Size(426, 584);
            teamsNameUserListbox.TabIndex = 1;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 3);
            label5.Name = "label5";
            label5.Size = new Size(425, 40);
            label5.TabIndex = 0;
            label5.Text = "You are currently assigned to the following teams:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksUserPanel
            // 
            tasksUserPanel.Controls.Add(button4);
            tasksUserPanel.Controls.Add(tasksDoneUserLabel);
            tasksUserPanel.Controls.Add(tasksTodoUserLabel);
            tasksUserPanel.Controls.Add(tasksDoneUserListbox);
            tasksUserPanel.Controls.Add(tasksTodoUserListbox);
            tasksUserPanel.Location = new Point(3, 39);
            tasksUserPanel.Name = "tasksUserPanel";
            tasksUserPanel.Size = new Size(1252, 626);
            tasksUserPanel.TabIndex = 3;
            tasksUserPanel.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(455, 59);
            button4.Name = "button4";
            button4.Size = new Size(141, 82);
            button4.TabIndex = 4;
            button4.Text = "temp button to show task window";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
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
            tasksTodoUserLabel.Location = new Point(4, 13);
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
            tasksDoneUserListbox.Size = new Size(620, 584);
            tasksDoneUserListbox.TabIndex = 1;
            // 
            // tasksTodoUserListbox
            // 
            tasksTodoUserListbox.Items.AddRange(new object[] { "Example Task" });
            tasksTodoUserListbox.Location = new Point(3, 39);
            tasksTodoUserListbox.Name = "tasksTodoUserListbox";
            tasksTodoUserListbox.Size = new Size(620, 584);
            tasksTodoUserListbox.TabIndex = 0;
            // 
            // adminViewPanel
            // 
            adminViewPanel.Controls.Add(logOutAdminButton);
            adminViewPanel.Controls.Add(employeesAdminButton);
            adminViewPanel.Controls.Add(teamsAdminButton);
            adminViewPanel.Controls.Add(tasksAdminButton);
            adminViewPanel.Controls.Add(projectsAdminButton);
            adminViewPanel.Controls.Add(teamsAdminPanel);
            adminViewPanel.Controls.Add(tasksAdminPanel);
            adminViewPanel.Controls.Add(employeesAdminPanel);
            adminViewPanel.Controls.Add(projectsAdminPanel);
            adminViewPanel.Location = new Point(0, 2);
            adminViewPanel.Name = "adminViewPanel";
            adminViewPanel.Size = new Size(1258, 668);
            adminViewPanel.TabIndex = 1;
            adminViewPanel.Visible = false;
            // 
            // logOutAdminButton
            // 
            logOutAdminButton.Location = new Point(994, 10);
            logOutAdminButton.Name = "logOutAdminButton";
            logOutAdminButton.Size = new Size(257, 74);
            logOutAdminButton.TabIndex = 5;
            logOutAdminButton.Text = "Log Out";
            logOutAdminButton.UseVisualStyleBackColor = true;
            logOutAdminButton.Click += logOutAdminButton_Click;
            // 
            // employeesAdminButton
            // 
            employeesAdminButton.Location = new Point(502, 50);
            employeesAdminButton.Name = "employeesAdminButton";
            employeesAdminButton.Size = new Size(486, 34);
            employeesAdminButton.TabIndex = 4;
            employeesAdminButton.Text = "Employees";
            employeesAdminButton.UseVisualStyleBackColor = true;
            employeesAdminButton.Click += employeesAdminButton_Click;
            // 
            // teamsAdminButton
            // 
            teamsAdminButton.Location = new Point(502, 10);
            teamsAdminButton.Name = "teamsAdminButton";
            teamsAdminButton.Size = new Size(486, 34);
            teamsAdminButton.TabIndex = 3;
            teamsAdminButton.Text = "Teams";
            teamsAdminButton.UseVisualStyleBackColor = true;
            teamsAdminButton.Click += teamsAdminButton_Click;
            // 
            // tasksAdminButton
            // 
            tasksAdminButton.Location = new Point(10, 50);
            tasksAdminButton.Name = "tasksAdminButton";
            tasksAdminButton.Size = new Size(486, 34);
            tasksAdminButton.TabIndex = 2;
            tasksAdminButton.Text = "Tasks";
            tasksAdminButton.UseVisualStyleBackColor = true;
            tasksAdminButton.Click += tasksAdminButton_Click;
            // 
            // projectsAdminButton
            // 
            projectsAdminButton.Location = new Point(10, 10);
            projectsAdminButton.Name = "projectsAdminButton";
            projectsAdminButton.Size = new Size(486, 34);
            projectsAdminButton.TabIndex = 1;
            projectsAdminButton.Text = "Projects";
            projectsAdminButton.UseVisualStyleBackColor = true;
            projectsAdminButton.Click += projectsAdminButton_Click;
            // 
            // teamsAdminPanel
            // 
            teamsAdminPanel.Controls.Add(teamsDescriptionAdminTextbox);
            teamsAdminPanel.Controls.Add(teamsDeleteTeamAdminButton);
            teamsAdminPanel.Controls.Add(teamsEditTeamAdminButton);
            teamsAdminPanel.Controls.Add(teamsNameAdminTexbox);
            teamsAdminPanel.Controls.Add(teamsDescriptionAdminLabel);
            teamsAdminPanel.Controls.Add(teamsNameAdminLabel);
            teamsAdminPanel.Controls.Add(teamsAddTeamAdminButton);
            teamsAdminPanel.Controls.Add(teamsAdminListbox);
            teamsAdminPanel.Location = new Point(10, 88);
            teamsAdminPanel.Name = "teamsAdminPanel";
            teamsAdminPanel.Size = new Size(1241, 571);
            teamsAdminPanel.TabIndex = 14;
            teamsAdminPanel.Visible = false;
            // 
            // teamsDescriptionAdminTextbox
            // 
            teamsDescriptionAdminTextbox.Location = new Point(454, 56);
            teamsDescriptionAdminTextbox.Multiline = true;
            teamsDescriptionAdminTextbox.Name = "teamsDescriptionAdminTextbox";
            teamsDescriptionAdminTextbox.ReadOnly = true;
            teamsDescriptionAdminTextbox.Size = new Size(781, 468);
            teamsDescriptionAdminTextbox.TabIndex = 11;
            // 
            // teamsDeleteTeamAdminButton
            // 
            teamsDeleteTeamAdminButton.Location = new Point(828, 530);
            teamsDeleteTeamAdminButton.Name = "teamsDeleteTeamAdminButton";
            teamsDeleteTeamAdminButton.Size = new Size(414, 39);
            teamsDeleteTeamAdminButton.TabIndex = 10;
            teamsDeleteTeamAdminButton.Text = "Delete Team";
            teamsDeleteTeamAdminButton.UseVisualStyleBackColor = true;
            teamsDeleteTeamAdminButton.Click += teamsDeleteTeamAdminButton_Click;
            // 
            // teamsEditTeamAdminButton
            // 
            teamsEditTeamAdminButton.Location = new Point(415, 530);
            teamsEditTeamAdminButton.Name = "teamsEditTeamAdminButton";
            teamsEditTeamAdminButton.Size = new Size(414, 39);
            teamsEditTeamAdminButton.TabIndex = 9;
            teamsEditTeamAdminButton.Text = "Edit Team";
            teamsEditTeamAdminButton.UseVisualStyleBackColor = true;
            teamsEditTeamAdminButton.Click += teamsEditTeamAdminButton_Click;
            // 
            // teamsNameAdminTexbox
            // 
            teamsNameAdminTexbox.Location = new Point(454, 10);
            teamsNameAdminTexbox.Name = "teamsNameAdminTexbox";
            teamsNameAdminTexbox.ReadOnly = true;
            teamsNameAdminTexbox.ScrollBars = ScrollBars.Horizontal;
            teamsNameAdminTexbox.Size = new Size(781, 27);
            teamsNameAdminTexbox.TabIndex = 8;
            // 
            // teamsDescriptionAdminLabel
            // 
            teamsDescriptionAdminLabel.AutoSize = true;
            teamsDescriptionAdminLabel.Location = new Point(360, 56);
            teamsDescriptionAdminLabel.Name = "teamsDescriptionAdminLabel";
            teamsDescriptionAdminLabel.Size = new Size(85, 20);
            teamsDescriptionAdminLabel.TabIndex = 5;
            teamsDescriptionAdminLabel.Text = "Description";
            // 
            // teamsNameAdminLabel
            // 
            teamsNameAdminLabel.AutoSize = true;
            teamsNameAdminLabel.Location = new Point(356, 13);
            teamsNameAdminLabel.Name = "teamsNameAdminLabel";
            teamsNameAdminLabel.Size = new Size(89, 20);
            teamsNameAdminLabel.TabIndex = 4;
            teamsNameAdminLabel.Text = "Team Name";
            // 
            // teamsAddTeamAdminButton
            // 
            teamsAddTeamAdminButton.Location = new Point(2, 530);
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
            teamsAdminListbox.Size = new Size(321, 524);
            teamsAdminListbox.TabIndex = 0;
            // 
            // tasksAdminPanel
            // 
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
            tasksAdminPanel.Location = new Point(10, 88);
            tasksAdminPanel.Name = "tasksAdminPanel";
            tasksAdminPanel.Size = new Size(1241, 571);
            tasksAdminPanel.TabIndex = 13;
            tasksAdminPanel.Visible = false;
            // 
            // tasksDeleteTaskAdminButton
            // 
            tasksDeleteTaskAdminButton.Location = new Point(828, 530);
            tasksDeleteTaskAdminButton.Name = "tasksDeleteTaskAdminButton";
            tasksDeleteTaskAdminButton.Size = new Size(414, 39);
            tasksDeleteTaskAdminButton.TabIndex = 18;
            tasksDeleteTaskAdminButton.Text = "Delete Task";
            tasksDeleteTaskAdminButton.UseVisualStyleBackColor = true;
            tasksDeleteTaskAdminButton.Click += tasksDeleteTaskAdminButton_Click;
            // 
            // tasksEditTaskAdminButton
            // 
            tasksEditTaskAdminButton.Location = new Point(415, 530);
            tasksEditTaskAdminButton.Name = "tasksEditTaskAdminButton";
            tasksEditTaskAdminButton.Size = new Size(414, 39);
            tasksEditTaskAdminButton.TabIndex = 17;
            tasksEditTaskAdminButton.Text = "Edit Task";
            tasksEditTaskAdminButton.UseVisualStyleBackColor = true;
            tasksEditTaskAdminButton.Click += tasksEditTaskAdminButton_Click;
            // 
            // tasksNameAdminTextbox
            // 
            tasksNameAdminTextbox.Location = new Point(454, 10);
            tasksNameAdminTextbox.Name = "tasksNameAdminTextbox";
            tasksNameAdminTextbox.ReadOnly = true;
            tasksNameAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            tasksNameAdminTextbox.Size = new Size(781, 27);
            tasksNameAdminTextbox.TabIndex = 16;
            // 
            // tasksDescriptionAdminTextbox
            // 
            tasksDescriptionAdminTextbox.Location = new Point(454, 43);
            tasksDescriptionAdminTextbox.Multiline = true;
            tasksDescriptionAdminTextbox.Name = "tasksDescriptionAdminTextbox";
            tasksDescriptionAdminTextbox.ReadOnly = true;
            tasksDescriptionAdminTextbox.ScrollBars = ScrollBars.Vertical;
            tasksDescriptionAdminTextbox.Size = new Size(781, 378);
            tasksDescriptionAdminTextbox.TabIndex = 15;
            // 
            // tasksStatusAdminTextbox
            // 
            tasksStatusAdminTextbox.Location = new Point(454, 427);
            tasksStatusAdminTextbox.Name = "tasksStatusAdminTextbox";
            tasksStatusAdminTextbox.ReadOnly = true;
            tasksStatusAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            tasksStatusAdminTextbox.Size = new Size(781, 27);
            tasksStatusAdminTextbox.TabIndex = 14;
            // 
            // tasksProjectNameAdminLabel
            // 
            tasksProjectNameAdminLabel.AutoEllipsis = true;
            tasksProjectNameAdminLabel.Location = new Point(2, 17);
            tasksProjectNameAdminLabel.Name = "tasksProjectNameAdminLabel";
            tasksProjectNameAdminLabel.Size = new Size(322, 59);
            tasksProjectNameAdminLabel.TabIndex = 13;
            tasksProjectNameAdminLabel.Text = "selected project name goes here";
            tasksProjectNameAdminLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksDueDateAdminDatePicker
            // 
            tasksDueDateAdminDatePicker.Enabled = false;
            tasksDueDateAdminDatePicker.Location = new Point(454, 461);
            tasksDueDateAdminDatePicker.Name = "tasksDueDateAdminDatePicker";
            tasksDueDateAdminDatePicker.Size = new Size(250, 27);
            tasksDueDateAdminDatePicker.TabIndex = 12;
            tasksDueDateAdminDatePicker.Value = new DateTime(2025, 8, 1, 0, 0, 0, 0);
            // 
            // tasksDueDateLabel
            // 
            tasksDueDateLabel.AutoSize = true;
            tasksDueDateLabel.Location = new Point(373, 466);
            tasksDueDateLabel.Name = "tasksDueDateLabel";
            tasksDueDateLabel.Size = new Size(72, 20);
            tasksDueDateLabel.TabIndex = 7;
            tasksDueDateLabel.Text = "Due Date";
            // 
            // tasksStatusAdminLabel
            // 
            tasksStatusAdminLabel.AutoSize = true;
            tasksStatusAdminLabel.Location = new Point(346, 430);
            tasksStatusAdminLabel.Name = "tasksStatusAdminLabel";
            tasksStatusAdminLabel.Size = new Size(101, 20);
            tasksStatusAdminLabel.TabIndex = 6;
            tasksStatusAdminLabel.Text = "Current Status";
            // 
            // tasksDescriptionAdminLabel
            // 
            tasksDescriptionAdminLabel.AutoSize = true;
            tasksDescriptionAdminLabel.Location = new Point(360, 46);
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
            tasksAddTaskAdminButton.Location = new Point(2, 530);
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
            tasksAdminListbox.Size = new Size(321, 444);
            tasksAdminListbox.TabIndex = 0;
            // 
            // employeesAdminPanel
            // 
            employeesAdminPanel.Controls.Add(label4);
            employeesAdminPanel.Controls.Add(employeesStatusAdminTextbox);
            employeesAdminPanel.Controls.Add(employeesRoleAdminTextbox);
            employeesAdminPanel.Controls.Add(label3);
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
            employeesAdminPanel.Location = new Point(10, 88);
            employeesAdminPanel.Name = "employeesAdminPanel";
            employeesAdminPanel.Size = new Size(1241, 571);
            employeesAdminPanel.TabIndex = 15;
            employeesAdminPanel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 337);
            label4.Name = "label4";
            label4.Size = new Size(681, 20);
            label4.TabIndex = 16;
            label4.Text = "Employment History will be displayed here (Events like getting hired, moving teams, promotions, etc.)";
            // 
            // employeesStatusAdminTextbox
            // 
            employeesStatusAdminTextbox.Location = new Point(489, 140);
            employeesStatusAdminTextbox.Name = "employeesStatusAdminTextbox";
            employeesStatusAdminTextbox.ReadOnly = true;
            employeesStatusAdminTextbox.Size = new Size(746, 27);
            employeesStatusAdminTextbox.TabIndex = 15;
            // 
            // employeesRoleAdminTextbox
            // 
            employeesRoleAdminTextbox.Location = new Point(489, 98);
            employeesRoleAdminTextbox.Name = "employeesRoleAdminTextbox";
            employeesRoleAdminTextbox.ReadOnly = true;
            employeesRoleAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            employeesRoleAdminTextbox.Size = new Size(746, 27);
            employeesRoleAdminTextbox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.Location = new Point(2, 17);
            label3.Name = "label3";
            label3.Size = new Size(322, 59);
            label3.TabIndex = 13;
            label3.Text = "selected team name goes here";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // employeesEmailAdminTextbox
            // 
            employeesEmailAdminTextbox.Location = new Point(489, 53);
            employeesEmailAdminTextbox.Name = "employeesEmailAdminTextbox";
            employeesEmailAdminTextbox.ReadOnly = true;
            employeesEmailAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            employeesEmailAdminTextbox.Size = new Size(746, 27);
            employeesEmailAdminTextbox.TabIndex = 9;
            // 
            // employeesUsernameAdminTexbox
            // 
            employeesUsernameAdminTexbox.Location = new Point(489, 10);
            employeesUsernameAdminTexbox.Name = "employeesUsernameAdminTexbox";
            employeesUsernameAdminTexbox.ReadOnly = true;
            employeesUsernameAdminTexbox.ScrollBars = ScrollBars.Horizontal;
            employeesUsernameAdminTexbox.Size = new Size(746, 27);
            employeesUsernameAdminTexbox.TabIndex = 8;
            // 
            // employeesStatusAdminLabel
            // 
            employeesStatusAdminLabel.AutoSize = true;
            employeesStatusAdminLabel.Location = new Point(346, 143);
            employeesStatusAdminLabel.Name = "employeesStatusAdminLabel";
            employeesStatusAdminLabel.Size = new Size(137, 20);
            employeesStatusAdminLabel.TabIndex = 7;
            employeesStatusAdminLabel.Text = "Employment Status";
            // 
            // employeesRoleAdminLabel
            // 
            employeesRoleAdminLabel.AutoSize = true;
            employeesRoleAdminLabel.Location = new Point(444, 101);
            employeesRoleAdminLabel.Name = "employeesRoleAdminLabel";
            employeesRoleAdminLabel.Size = new Size(39, 20);
            employeesRoleAdminLabel.TabIndex = 6;
            employeesRoleAdminLabel.Text = "Role";
            // 
            // employeesEmailAdminLabel
            // 
            employeesEmailAdminLabel.AutoSize = true;
            employeesEmailAdminLabel.Location = new Point(431, 56);
            employeesEmailAdminLabel.Name = "employeesEmailAdminLabel";
            employeesEmailAdminLabel.Size = new Size(52, 20);
            employeesEmailAdminLabel.TabIndex = 5;
            employeesEmailAdminLabel.Text = "E-mail";
            // 
            // employeesUsernameAdminLabel
            // 
            employeesUsernameAdminLabel.AutoSize = true;
            employeesUsernameAdminLabel.Location = new Point(408, 13);
            employeesUsernameAdminLabel.Name = "employeesUsernameAdminLabel";
            employeesUsernameAdminLabel.Size = new Size(75, 20);
            employeesUsernameAdminLabel.TabIndex = 4;
            employeesUsernameAdminLabel.Text = "Username";
            // 
            // employeesDeleteEmployeeAdminButton
            // 
            employeesDeleteEmployeeAdminButton.Location = new Point(828, 530);
            employeesDeleteEmployeeAdminButton.Name = "employeesDeleteEmployeeAdminButton";
            employeesDeleteEmployeeAdminButton.Size = new Size(412, 38);
            employeesDeleteEmployeeAdminButton.TabIndex = 3;
            employeesDeleteEmployeeAdminButton.Text = "Delete Employee";
            employeesDeleteEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesDeleteEmployeeAdminButton.Click += employeesDeleteEmployeeAdminButton_Click;
            // 
            // employeesEditEmployeeAdminButton
            // 
            employeesEditEmployeeAdminButton.Location = new Point(415, 530);
            employeesEditEmployeeAdminButton.Name = "employeesEditEmployeeAdminButton";
            employeesEditEmployeeAdminButton.Size = new Size(414, 39);
            employeesEditEmployeeAdminButton.TabIndex = 2;
            employeesEditEmployeeAdminButton.Text = "Edit Employee";
            employeesEditEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesEditEmployeeAdminButton.Click += employeesEditEmployeeAdminButton_Click;
            // 
            // employeesAddEmployeeAdminButton
            // 
            employeesAddEmployeeAdminButton.Location = new Point(2, 530);
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
            employeesAdminListbox.Location = new Point(3, 80);
            employeesAdminListbox.Name = "employeesAdminListbox";
            employeesAdminListbox.Size = new Size(321, 444);
            employeesAdminListbox.TabIndex = 0;
            // 
            // projectsAdminPanel
            // 
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
            projectsAdminPanel.Location = new Point(10, 88);
            projectsAdminPanel.Name = "projectsAdminPanel";
            projectsAdminPanel.Size = new Size(1241, 571);
            projectsAdminPanel.TabIndex = 16;
            projectsAdminPanel.Visible = false;
            // 
            // projectsEndDateAdminDatePicker
            // 
            projectsEndDateAdminDatePicker.Enabled = false;
            projectsEndDateAdminDatePicker.Location = new Point(454, 456);
            projectsEndDateAdminDatePicker.Name = "projectsEndDateAdminDatePicker";
            projectsEndDateAdminDatePicker.Size = new Size(250, 27);
            projectsEndDateAdminDatePicker.TabIndex = 15;
            // 
            // projectsStartDateAdminDatePicker
            // 
            projectsStartDateAdminDatePicker.Enabled = false;
            projectsStartDateAdminDatePicker.Location = new Point(454, 413);
            projectsStartDateAdminDatePicker.Name = "projectsStartDateAdminDatePicker";
            projectsStartDateAdminDatePicker.Size = new Size(250, 27);
            projectsStartDateAdminDatePicker.TabIndex = 14;
            // 
            // projectsEndDateAdminLabel
            // 
            projectsEndDateAdminLabel.AutoSize = true;
            projectsEndDateAdminLabel.Location = new Point(375, 461);
            projectsEndDateAdminLabel.Name = "projectsEndDateAdminLabel";
            projectsEndDateAdminLabel.Size = new Size(70, 20);
            projectsEndDateAdminLabel.TabIndex = 13;
            projectsEndDateAdminLabel.Text = "End Date";
            // 
            // projectsStartDateAdminLabel
            // 
            projectsStartDateAdminLabel.AutoSize = true;
            projectsStartDateAdminLabel.Location = new Point(369, 418);
            projectsStartDateAdminLabel.Name = "projectsStartDateAdminLabel";
            projectsStartDateAdminLabel.Size = new Size(76, 20);
            projectsStartDateAdminLabel.TabIndex = 12;
            projectsStartDateAdminLabel.Text = "Start Date";
            // 
            // projectsDescriptionAdminTextbox
            // 
            projectsDescriptionAdminTextbox.Location = new Point(454, 56);
            projectsDescriptionAdminTextbox.Multiline = true;
            projectsDescriptionAdminTextbox.Name = "projectsDescriptionAdminTextbox";
            projectsDescriptionAdminTextbox.ReadOnly = true;
            projectsDescriptionAdminTextbox.Size = new Size(781, 343);
            projectsDescriptionAdminTextbox.TabIndex = 11;
            // 
            // projectsDeleteProjectAdminButton
            // 
            projectsDeleteProjectAdminButton.Location = new Point(828, 530);
            projectsDeleteProjectAdminButton.Name = "projectsDeleteProjectAdminButton";
            projectsDeleteProjectAdminButton.Size = new Size(414, 39);
            projectsDeleteProjectAdminButton.TabIndex = 10;
            projectsDeleteProjectAdminButton.Text = "Delete Project";
            projectsDeleteProjectAdminButton.UseVisualStyleBackColor = true;
            projectsDeleteProjectAdminButton.Click += projectsDeleteProjectAdminButton_Click;
            // 
            // projectsEditProjectAdminButton
            // 
            projectsEditProjectAdminButton.Location = new Point(415, 530);
            projectsEditProjectAdminButton.Name = "projectsEditProjectAdminButton";
            projectsEditProjectAdminButton.Size = new Size(414, 39);
            projectsEditProjectAdminButton.TabIndex = 9;
            projectsEditProjectAdminButton.Text = "Edit Project";
            projectsEditProjectAdminButton.UseVisualStyleBackColor = true;
            projectsEditProjectAdminButton.Click += projectsEditProjectAdminButton_Click;
            // 
            // projectsNameAdminTextbox
            // 
            projectsNameAdminTextbox.Location = new Point(454, 10);
            projectsNameAdminTextbox.Name = "projectsNameAdminTextbox";
            projectsNameAdminTextbox.ReadOnly = true;
            projectsNameAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            projectsNameAdminTextbox.Size = new Size(781, 27);
            projectsNameAdminTextbox.TabIndex = 8;
            // 
            // projectsDescriptionAdminLabel
            // 
            projectsDescriptionAdminLabel.AutoSize = true;
            projectsDescriptionAdminLabel.Location = new Point(360, 59);
            projectsDescriptionAdminLabel.Name = "projectsDescriptionAdminLabel";
            projectsDescriptionAdminLabel.Size = new Size(85, 20);
            projectsDescriptionAdminLabel.TabIndex = 5;
            projectsDescriptionAdminLabel.Text = "Description";
            // 
            // projectsNameAdminLabel
            // 
            projectsNameAdminLabel.AutoSize = true;
            projectsNameAdminLabel.Location = new Point(346, 13);
            projectsNameAdminLabel.Name = "projectsNameAdminLabel";
            projectsNameAdminLabel.Size = new Size(99, 20);
            projectsNameAdminLabel.TabIndex = 4;
            projectsNameAdminLabel.Text = "Project Name";
            // 
            // projectsAddProjectAdminButton
            // 
            projectsAddProjectAdminButton.Location = new Point(2, 530);
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
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
            teamsAdminPanel.ResumeLayout(false);
            teamsAdminPanel.PerformLayout();
            tasksAdminPanel.ResumeLayout(false);
            tasksAdminPanel.PerformLayout();
            employeesAdminPanel.ResumeLayout(false);
            employeesAdminPanel.PerformLayout();
            projectsAdminPanel.ResumeLayout(false);
            projectsAdminPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button button1;
        private TextBox loginPasswordTextbox;
        private TextBox loginLoginTextbox;
        private Label loginPasswordLabel;
        private Button button3;
        private Button button2;
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
        private Label label3;
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
        private Label label4;
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
        private ListBox teamsMembersUserListbox;
        private Label tasksTodoUserLabel;
        private ListBox tasksDoneUserListbox;
        private ListBox tasksTodoUserListbox;
        private Label tasksDoneUserLabel;
        private Button button4;
    }
}

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
            loginButton = new Button();
            loginPasswordTextbox = new TextBox();
            loginLoginTextbox = new TextBox();
            userViewPanel = new Panel();
            helpButtonUser = new Button();
            logOutUserButton = new Button();
            teamsUserButton = new Button();
            tasksUserButton = new Button();
            tasksUserPanel = new Panel();
            button4 = new Button();
            tasksDoneUserLabel = new Label();
            tasksTodoUserLabel = new Label();
            tasksDoneUserListbox = new ListBox();
            tasksTodoUserListbox = new ListBox();
            teamsUserPanel = new Panel();
            teamsMembersUserLabel = new Label();
            teamsMembersUserListbox = new ListBox();
            teamsNameUserListbox = new ListBox();
            label5 = new Label();
            adminViewPanel = new Panel();
            helpButtonAdmin = new Button();
            logOutAdminButton = new Button();
            employeesAdminButton = new Button();
            teamsAdminButton = new Button();
            tasksAdminButton = new Button();
            projectsAdminButton = new Button();
            employeesAdminPanel = new Panel();
            employeeHistoryListView = new ListView();
            deleteHistoryRecordButton = new Button();
            editHistoryRecordButton = new Button();
            addHistoryRecordButton = new Button();
            label1 = new Label();
            generateDetailedReportButton = new Button();
            generateSummaryReportButton = new Button();
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
            teamsDescriptionAdminTextbox = new TextBox();
            teamsDeleteTeamAdminButton = new Button();
            teamsEditTeamAdminButton = new Button();
            teamsNameAdminTexbox = new TextBox();
            teamsDescriptionAdminLabel = new Label();
            teamsNameAdminLabel = new Label();
            teamsAddTeamAdminButton = new Button();
            teamsAdminListbox = new ListBox();
            loginPanel.SuspendLayout();
            userViewPanel.SuspendLayout();
            tasksUserPanel.SuspendLayout();
            teamsUserPanel.SuspendLayout();
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
            loginPanel.Controls.Add(button3);
            loginPanel.Controls.Add(button2);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(loginPasswordTextbox);
            loginPanel.Controls.Add(loginLoginTextbox);
            loginPanel.Location = new Point(3, 2);
            loginPanel.Margin = new Padding(3, 2, 3, 2);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1112, 575);
            loginPanel.TabIndex = 0;
            // 
            // loginAuthorLabel
            // 
            loginAuthorLabel.AutoEllipsis = true;
            loginAuthorLabel.Location = new Point(0, 100);
            loginAuthorLabel.Name = "loginAuthorLabel";
            loginAuthorLabel.Size = new Size(1101, 19);
            loginAuthorLabel.TabIndex = 8;
            loginAuthorLabel.Text = "made by: Patryk Kwiecień, Mikołaj Musioł, Julia Przybyłowicz, Paweł Sosin, Paweł Strzępa, Mateusz Śmiech\r\n";
            loginAuthorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginTitleLabel
            // 
            loginTitleLabel.Font = new Font("Tahoma", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginTitleLabel.Location = new Point(0, 38);
            loginTitleLabel.Name = "loginTitleLabel";
            loginTitleLabel.Size = new Size(1101, 63);
            loginTitleLabel.TabIndex = 7;
            loginTitleLabel.Text = "Time Tracking System";
            loginTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLoginLabel
            // 
            loginLoginLabel.AutoSize = true;
            loginLoginLabel.Location = new Point(403, 176);
            loginLoginLabel.Name = "loginLoginLabel";
            loginLoginLabel.Size = new Size(37, 15);
            loginLoginLabel.TabIndex = 6;
            loginLoginLabel.Text = "Login";
            // 
            // loginPasswordLabel
            // 
            loginPasswordLabel.AutoSize = true;
            loginPasswordLabel.Location = new Point(396, 206);
            loginPasswordLabel.Name = "loginPasswordLabel";
            loginPasswordLabel.Size = new Size(57, 15);
            loginPasswordLabel.TabIndex = 5;
            loginPasswordLabel.Text = "Password";
            // 
            // button3
            // 
            button3.Location = new Point(395, 350);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(347, 27);
            button3.TabIndex = 4;
            button3.Text = "Show Admin View - Testing Purposes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(395, 313);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(347, 27);
            button2.TabIndex = 3;
            button2.Text = "Show User View - Testing Purposes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(462, 236);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(82, 22);
            loginButton.TabIndex = 2;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginPasswordTextbox
            // 
            loginPasswordTextbox.Location = new Point(462, 204);
            loginPasswordTextbox.Margin = new Padding(3, 2, 3, 2);
            loginPasswordTextbox.Name = "loginPasswordTextbox";
            loginPasswordTextbox.PasswordChar = '*';
            loginPasswordTextbox.Size = new Size(280, 23);
            loginPasswordTextbox.TabIndex = 1;
            // 
            // loginLoginTextbox
            // 
            loginLoginTextbox.Location = new Point(462, 173);
            loginLoginTextbox.Margin = new Padding(3, 2, 3, 2);
            loginLoginTextbox.Name = "loginLoginTextbox";
            loginLoginTextbox.Size = new Size(280, 23);
            loginLoginTextbox.TabIndex = 0;
            // 
            // userViewPanel
            // 
            userViewPanel.Controls.Add(helpButtonUser);
            userViewPanel.Controls.Add(logOutUserButton);
            userViewPanel.Controls.Add(teamsUserButton);
            userViewPanel.Controls.Add(tasksUserButton);
            userViewPanel.Controls.Add(tasksUserPanel);
            userViewPanel.Controls.Add(teamsUserPanel);
            userViewPanel.Location = new Point(3, 2);
            userViewPanel.Margin = new Padding(3, 2, 3, 2);
            userViewPanel.Name = "userViewPanel";
            userViewPanel.Size = new Size(1112, 579);
            userViewPanel.TabIndex = 7;
            userViewPanel.Visible = false;
            // 
            // helpButtonUser
            // 
            helpButtonUser.Location = new Point(1048, -1);
            helpButtonUser.Name = "helpButtonUser";
            helpButtonUser.Size = new Size(50, 29);
            helpButtonUser.TabIndex = 5;
            helpButtonUser.Text = "Help";
            helpButtonUser.UseVisualStyleBackColor = true;
            helpButtonUser.Click += helpButtonUser_Click;
            // 
            // logOutUserButton
            // 
            logOutUserButton.Location = new Point(736, 0);
            logOutUserButton.Margin = new Padding(3, 2, 3, 2);
            logOutUserButton.Name = "logOutUserButton";
            logOutUserButton.Size = new Size(307, 29);
            logOutUserButton.TabIndex = 2;
            logOutUserButton.Text = "Log Out";
            logOutUserButton.UseVisualStyleBackColor = true;
            logOutUserButton.Click += logOutUserButton_Click;
            // 
            // teamsUserButton
            // 
            teamsUserButton.Location = new Point(369, 0);
            teamsUserButton.Margin = new Padding(3, 2, 3, 2);
            teamsUserButton.Name = "teamsUserButton";
            teamsUserButton.Size = new Size(362, 29);
            teamsUserButton.TabIndex = 1;
            teamsUserButton.Text = "My Teams";
            teamsUserButton.UseVisualStyleBackColor = true;
            teamsUserButton.Click += teamsUserButton_Click;
            // 
            // tasksUserButton
            // 
            tasksUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasksUserButton.Location = new Point(0, 0);
            tasksUserButton.Margin = new Padding(3, 2, 3, 2);
            tasksUserButton.Name = "tasksUserButton";
            tasksUserButton.Size = new Size(362, 29);
            tasksUserButton.TabIndex = 0;
            tasksUserButton.Text = "My Tasks";
            tasksUserButton.UseVisualStyleBackColor = true;
            tasksUserButton.Click += tasksUserButton_Click;
            // 
            // tasksUserPanel
            // 
            tasksUserPanel.Controls.Add(button4);
            tasksUserPanel.Controls.Add(tasksDoneUserLabel);
            tasksUserPanel.Controls.Add(tasksTodoUserLabel);
            tasksUserPanel.Controls.Add(tasksDoneUserListbox);
            tasksUserPanel.Controls.Add(tasksTodoUserListbox);
            tasksUserPanel.Location = new Point(3, 60);
            tasksUserPanel.Margin = new Padding(3, 2, 3, 2);
            tasksUserPanel.Name = "tasksUserPanel";
            tasksUserPanel.Size = new Size(1096, 517);
            tasksUserPanel.TabIndex = 3;
            tasksUserPanel.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(398, 44);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(123, 62);
            button4.TabIndex = 4;
            button4.Text = "temp button to show task window";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // tasksDoneUserLabel
            // 
            tasksDoneUserLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasksDoneUserLabel.Location = new Point(550, 8);
            tasksDoneUserLabel.Name = "tasksDoneUserLabel";
            tasksDoneUserLabel.Size = new Size(542, 19);
            tasksDoneUserLabel.TabIndex = 3;
            tasksDoneUserLabel.Text = "Done:";
            tasksDoneUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksTodoUserLabel
            // 
            tasksTodoUserLabel.Font = new Font("Segoe UI", 11F);
            tasksTodoUserLabel.Location = new Point(4, 10);
            tasksTodoUserLabel.Name = "tasksTodoUserLabel";
            tasksTodoUserLabel.Size = new Size(542, 19);
            tasksTodoUserLabel.TabIndex = 2;
            tasksTodoUserLabel.Text = "To Do:";
            tasksTodoUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksDoneUserListbox
            // 
            tasksDoneUserListbox.FormattingEnabled = true;
            tasksDoneUserListbox.ItemHeight = 15;
            tasksDoneUserListbox.Location = new Point(550, 29);
            tasksDoneUserListbox.Margin = new Padding(3, 2, 3, 2);
            tasksDoneUserListbox.Name = "tasksDoneUserListbox";
            tasksDoneUserListbox.Size = new Size(543, 454);
            tasksDoneUserListbox.TabIndex = 1;
            // 
            // tasksTodoUserListbox
            // 
            tasksTodoUserListbox.ItemHeight = 15;
            tasksTodoUserListbox.Location = new Point(3, 29);
            tasksTodoUserListbox.Margin = new Padding(3, 2, 3, 2);
            tasksTodoUserListbox.Name = "tasksTodoUserListbox";
            tasksTodoUserListbox.Size = new Size(543, 454);
            tasksTodoUserListbox.TabIndex = 0;
            // 
            // teamsUserPanel
            // 
            teamsUserPanel.Controls.Add(teamsMembersUserLabel);
            teamsUserPanel.Controls.Add(teamsMembersUserListbox);
            teamsUserPanel.Controls.Add(teamsNameUserListbox);
            teamsUserPanel.Controls.Add(label5);
            teamsUserPanel.Location = new Point(3, 58);
            teamsUserPanel.Margin = new Padding(3, 2, 3, 2);
            teamsUserPanel.Name = "teamsUserPanel";
            teamsUserPanel.Size = new Size(1096, 519);
            teamsUserPanel.TabIndex = 4;
            teamsUserPanel.Visible = false;
            // 
            // teamsMembersUserLabel
            // 
            teamsMembersUserLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamsMembersUserLabel.Location = new Point(381, 2);
            teamsMembersUserLabel.Name = "teamsMembersUserLabel";
            teamsMembersUserLabel.Size = new Size(709, 28);
            teamsMembersUserLabel.TabIndex = 3;
            teamsMembersUserLabel.Text = "The selected team contains the following members:";
            teamsMembersUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // teamsMembersUserListbox
            // 
            teamsMembersUserListbox.FormattingEnabled = true;
            teamsMembersUserListbox.ItemHeight = 15;
            teamsMembersUserListbox.Location = new Point(381, 31);
            teamsMembersUserListbox.Margin = new Padding(3, 2, 3, 2);
            teamsMembersUserListbox.Name = "teamsMembersUserListbox";
            teamsMembersUserListbox.Size = new Size(710, 454);
            teamsMembersUserListbox.TabIndex = 2;
            // 
            // teamsNameUserListbox
            // 
            teamsNameUserListbox.FormattingEnabled = true;
            teamsNameUserListbox.ItemHeight = 15;
            teamsNameUserListbox.Location = new Point(3, 31);
            teamsNameUserListbox.Margin = new Padding(3, 2, 3, 2);
            teamsNameUserListbox.Name = "teamsNameUserListbox";
            teamsNameUserListbox.Size = new Size(373, 454);
            teamsNameUserListbox.TabIndex = 1;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 2);
            label5.Name = "label5";
            label5.Size = new Size(372, 30);
            label5.TabIndex = 0;
            label5.Text = "You are currently assigned to the following teams:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
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
            adminViewPanel.Location = new Point(0, 2);
            adminViewPanel.Margin = new Padding(3, 2, 3, 2);
            adminViewPanel.Name = "adminViewPanel";
            adminViewPanel.Size = new Size(1137, 645);
            adminViewPanel.TabIndex = 1;
            adminViewPanel.Visible = false;
            // 
            // helpButtonAdmin
            // 
            helpButtonAdmin.Location = new Point(1045, 3);
            helpButtonAdmin.Name = "helpButtonAdmin";
            helpButtonAdmin.Size = new Size(80, 66);
            helpButtonAdmin.TabIndex = 17;
            helpButtonAdmin.Text = "Help";
            helpButtonAdmin.UseVisualStyleBackColor = true;
            helpButtonAdmin.Click += helpButtonAdmin_Click;
            // 
            // logOutAdminButton
            // 
            logOutAdminButton.Location = new Point(870, 3);
            logOutAdminButton.Margin = new Padding(3, 2, 3, 2);
            logOutAdminButton.Name = "logOutAdminButton";
            logOutAdminButton.Size = new Size(169, 66);
            logOutAdminButton.TabIndex = 5;
            logOutAdminButton.Text = "Log Out";
            logOutAdminButton.UseVisualStyleBackColor = true;
            logOutAdminButton.Click += logOutAdminButton_Click;
            // 
            // employeesAdminButton
            // 
            employeesAdminButton.Enabled = false;
            employeesAdminButton.Location = new Point(440, 43);
            employeesAdminButton.Margin = new Padding(3, 2, 3, 2);
            employeesAdminButton.Name = "employeesAdminButton";
            employeesAdminButton.Size = new Size(425, 26);
            employeesAdminButton.TabIndex = 4;
            employeesAdminButton.Text = "Employees";
            employeesAdminButton.UseVisualStyleBackColor = true;
            employeesAdminButton.Click += employeesAdminButton_Click;
            // 
            // teamsAdminButton
            // 
            teamsAdminButton.Location = new Point(440, 2);
            teamsAdminButton.Margin = new Padding(3, 2, 3, 2);
            teamsAdminButton.Name = "teamsAdminButton";
            teamsAdminButton.Size = new Size(425, 26);
            teamsAdminButton.TabIndex = 3;
            teamsAdminButton.Text = "Teams";
            teamsAdminButton.UseVisualStyleBackColor = true;
            teamsAdminButton.Click += teamsAdminButton_Click;
            // 
            // tasksAdminButton
            // 
            tasksAdminButton.Enabled = false;
            tasksAdminButton.Location = new Point(9, 43);
            tasksAdminButton.Margin = new Padding(3, 2, 3, 2);
            tasksAdminButton.Name = "tasksAdminButton";
            tasksAdminButton.Size = new Size(425, 26);
            tasksAdminButton.TabIndex = 2;
            tasksAdminButton.Text = "Tasks";
            tasksAdminButton.UseVisualStyleBackColor = true;
            tasksAdminButton.Click += tasksAdminButton_Click;
            // 
            // projectsAdminButton
            // 
            projectsAdminButton.Location = new Point(9, 2);
            projectsAdminButton.Margin = new Padding(3, 2, 3, 2);
            projectsAdminButton.Name = "projectsAdminButton";
            projectsAdminButton.Size = new Size(425, 26);
            projectsAdminButton.TabIndex = 1;
            projectsAdminButton.Text = "Projects";
            projectsAdminButton.UseVisualStyleBackColor = true;
            projectsAdminButton.Click += projectsAdminButton_Click;
            // 
            // employeesAdminPanel
            // 
            employeesAdminPanel.Controls.Add(employeeHistoryListView);
            employeesAdminPanel.Controls.Add(deleteHistoryRecordButton);
            employeesAdminPanel.Controls.Add(editHistoryRecordButton);
            employeesAdminPanel.Controls.Add(addHistoryRecordButton);
            employeesAdminPanel.Controls.Add(label1);
            employeesAdminPanel.Controls.Add(generateDetailedReportButton);
            employeesAdminPanel.Controls.Add(generateSummaryReportButton);
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
            employeesAdminPanel.Location = new Point(9, 87);
            employeesAdminPanel.Margin = new Padding(3, 2, 3, 2);
            employeesAdminPanel.Name = "employeesAdminPanel";
            employeesAdminPanel.Size = new Size(1119, 558);
            employeesAdminPanel.TabIndex = 15;
            employeesAdminPanel.Visible = false;
            // 
            // employeeHistoryListView
            // 
            employeeHistoryListView.Location = new Point(428, 243);
            employeeHistoryListView.Name = "employeeHistoryListView";
            employeeHistoryListView.Size = new Size(658, 182);
            employeeHistoryListView.TabIndex = 23;
            employeeHistoryListView.UseCompatibleStateImageBehavior = false;
            employeeHistoryListView.SelectedIndexChanged += employeeHistoryListView_SelectedIndexChanged;
            // 
            // deleteHistoryRecordButton
            // 
            deleteHistoryRecordButton.Location = new Point(886, 197);
            deleteHistoryRecordButton.Name = "deleteHistoryRecordButton";
            deleteHistoryRecordButton.Size = new Size(200, 29);
            deleteHistoryRecordButton.TabIndex = 21;
            deleteHistoryRecordButton.Text = "Delete Record";
            deleteHistoryRecordButton.UseVisualStyleBackColor = true;
            deleteHistoryRecordButton.Click += deleteHistoryRecordButton_Click;
            // 
            // editHistoryRecordButton
            // 
            editHistoryRecordButton.Location = new Point(656, 197);
            editHistoryRecordButton.Name = "editHistoryRecordButton";
            editHistoryRecordButton.Size = new Size(200, 29);
            editHistoryRecordButton.TabIndex = 20;
            editHistoryRecordButton.Text = "Edit Record";
            editHistoryRecordButton.UseVisualStyleBackColor = true;
            editHistoryRecordButton.Click += editHistoryRecordButton_Click;
            // 
            // addHistoryRecordButton
            // 
            addHistoryRecordButton.Location = new Point(428, 197);
            addHistoryRecordButton.Name = "addHistoryRecordButton";
            addHistoryRecordButton.Size = new Size(200, 29);
            addHistoryRecordButton.TabIndex = 19;
            addHistoryRecordButton.Text = "Add New Record";
            addHistoryRecordButton.UseVisualStyleBackColor = true;
            addHistoryRecordButton.Click += addHistoryRecordButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 204);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 18;
            label1.Text = "Employee History";
            // 
            // generateDetailedReportButton
            // 
            generateDetailedReportButton.Enabled = false;
            generateDetailedReportButton.Location = new Point(548, 493);
            generateDetailedReportButton.Name = "generateDetailedReportButton";
            generateDetailedReportButton.Size = new Size(538, 29);
            generateDetailedReportButton.TabIndex = 17;
            generateDetailedReportButton.Text = "Generate Detailed Report";
            generateDetailedReportButton.UseVisualStyleBackColor = true;
            generateDetailedReportButton.Click += generateDetailedReportButton_Click;
            // 
            // generateSummaryReportButton
            // 
            generateSummaryReportButton.Enabled = false;
            generateSummaryReportButton.Location = new Point(1, 493);
            generateSummaryReportButton.Name = "generateSummaryReportButton";
            generateSummaryReportButton.Size = new Size(538, 29);
            generateSummaryReportButton.TabIndex = 16;
            generateSummaryReportButton.Text = "Generate Summary Report";
            generateSummaryReportButton.UseVisualStyleBackColor = true;
            generateSummaryReportButton.Click += generateSummaryReportButton_Click;
            // 
            // employeesStatusAdminTextbox
            // 
            employeesStatusAdminTextbox.Location = new Point(428, 150);
            employeesStatusAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            employeesStatusAdminTextbox.Name = "employeesStatusAdminTextbox";
            employeesStatusAdminTextbox.ReadOnly = true;
            employeesStatusAdminTextbox.Size = new Size(653, 23);
            employeesStatusAdminTextbox.TabIndex = 15;
            // 
            // employeesRoleAdminTextbox
            // 
            employeesRoleAdminTextbox.Location = new Point(428, 106);
            employeesRoleAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            employeesRoleAdminTextbox.Name = "employeesRoleAdminTextbox";
            employeesRoleAdminTextbox.ReadOnly = true;
            employeesRoleAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            employeesRoleAdminTextbox.Size = new Size(653, 23);
            employeesRoleAdminTextbox.TabIndex = 14;
            // 
            // teamNameEmployeesAdminPanel
            // 
            teamNameEmployeesAdminPanel.AutoEllipsis = true;
            teamNameEmployeesAdminPanel.Location = new Point(1, 0);
            teamNameEmployeesAdminPanel.Name = "teamNameEmployeesAdminPanel";
            teamNameEmployeesAdminPanel.Size = new Size(282, 44);
            teamNameEmployeesAdminPanel.TabIndex = 13;
            teamNameEmployeesAdminPanel.Text = "selected team name goes here";
            teamNameEmployeesAdminPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // employeesEmailAdminTextbox
            // 
            employeesEmailAdminTextbox.Location = new Point(428, 55);
            employeesEmailAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            employeesEmailAdminTextbox.Name = "employeesEmailAdminTextbox";
            employeesEmailAdminTextbox.ReadOnly = true;
            employeesEmailAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            employeesEmailAdminTextbox.Size = new Size(653, 23);
            employeesEmailAdminTextbox.TabIndex = 9;
            // 
            // employeesUsernameAdminTexbox
            // 
            employeesUsernameAdminTexbox.Location = new Point(428, 8);
            employeesUsernameAdminTexbox.Margin = new Padding(3, 2, 3, 2);
            employeesUsernameAdminTexbox.Name = "employeesUsernameAdminTexbox";
            employeesUsernameAdminTexbox.ReadOnly = true;
            employeesUsernameAdminTexbox.ScrollBars = ScrollBars.Horizontal;
            employeesUsernameAdminTexbox.Size = new Size(653, 23);
            employeesUsernameAdminTexbox.TabIndex = 8;
            // 
            // employeesStatusAdminLabel
            // 
            employeesStatusAdminLabel.AutoSize = true;
            employeesStatusAdminLabel.Location = new Point(303, 153);
            employeesStatusAdminLabel.Name = "employeesStatusAdminLabel";
            employeesStatusAdminLabel.Size = new Size(110, 15);
            employeesStatusAdminLabel.TabIndex = 7;
            employeesStatusAdminLabel.Text = "Employment Status";
            // 
            // employeesRoleAdminLabel
            // 
            employeesRoleAdminLabel.AutoSize = true;
            employeesRoleAdminLabel.Location = new Point(383, 114);
            employeesRoleAdminLabel.Name = "employeesRoleAdminLabel";
            employeesRoleAdminLabel.Size = new Size(30, 15);
            employeesRoleAdminLabel.TabIndex = 6;
            employeesRoleAdminLabel.Text = "Role";
            // 
            // employeesEmailAdminLabel
            // 
            employeesEmailAdminLabel.AutoSize = true;
            employeesEmailAdminLabel.Location = new Point(372, 58);
            employeesEmailAdminLabel.Name = "employeesEmailAdminLabel";
            employeesEmailAdminLabel.Size = new Size(41, 15);
            employeesEmailAdminLabel.TabIndex = 5;
            employeesEmailAdminLabel.Text = "E-mail";
            // 
            // employeesUsernameAdminLabel
            // 
            employeesUsernameAdminLabel.AutoSize = true;
            employeesUsernameAdminLabel.Location = new Point(353, 11);
            employeesUsernameAdminLabel.Name = "employeesUsernameAdminLabel";
            employeesUsernameAdminLabel.Size = new Size(60, 15);
            employeesUsernameAdminLabel.TabIndex = 4;
            employeesUsernameAdminLabel.Text = "Username";
            // 
            // employeesDeleteEmployeeAdminButton
            // 
            employeesDeleteEmployeeAdminButton.Location = new Point(726, 445);
            employeesDeleteEmployeeAdminButton.Margin = new Padding(3, 2, 3, 2);
            employeesDeleteEmployeeAdminButton.Name = "employeesDeleteEmployeeAdminButton";
            employeesDeleteEmployeeAdminButton.Size = new Size(360, 28);
            employeesDeleteEmployeeAdminButton.TabIndex = 3;
            employeesDeleteEmployeeAdminButton.Text = "Delete Employee";
            employeesDeleteEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesDeleteEmployeeAdminButton.Click += employeesDeleteEmployeeAdminButton_Click;
            // 
            // employeesEditEmployeeAdminButton
            // 
            employeesEditEmployeeAdminButton.Location = new Point(363, 445);
            employeesEditEmployeeAdminButton.Margin = new Padding(3, 2, 3, 2);
            employeesEditEmployeeAdminButton.Name = "employeesEditEmployeeAdminButton";
            employeesEditEmployeeAdminButton.Size = new Size(362, 29);
            employeesEditEmployeeAdminButton.TabIndex = 2;
            employeesEditEmployeeAdminButton.Text = "Edit Employee";
            employeesEditEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesEditEmployeeAdminButton.Click += employeesEditEmployeeAdminButton_Click;
            // 
            // employeesAddEmployeeAdminButton
            // 
            employeesAddEmployeeAdminButton.Location = new Point(0, 445);
            employeesAddEmployeeAdminButton.Margin = new Padding(3, 2, 3, 2);
            employeesAddEmployeeAdminButton.Name = "employeesAddEmployeeAdminButton";
            employeesAddEmployeeAdminButton.Size = new Size(362, 29);
            employeesAddEmployeeAdminButton.TabIndex = 1;
            employeesAddEmployeeAdminButton.Text = "Add New Employee";
            employeesAddEmployeeAdminButton.UseVisualStyleBackColor = true;
            employeesAddEmployeeAdminButton.Click += employeesAddEmployeeAdminButton_Click;
            // 
            // employeesAdminListbox
            // 
            employeesAdminListbox.FormattingEnabled = true;
            employeesAdminListbox.ItemHeight = 15;
            employeesAdminListbox.Location = new Point(3, 60);
            employeesAdminListbox.Margin = new Padding(3, 2, 3, 2);
            employeesAdminListbox.Name = "employeesAdminListbox";
            employeesAdminListbox.Size = new Size(281, 364);
            employeesAdminListbox.TabIndex = 0;
            employeesAdminListbox.SelectedIndexChanged += employeesAdminListbox_SelectedIndexChanged_1;
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
            projectsAdminPanel.Location = new Point(9, 87);
            projectsAdminPanel.Margin = new Padding(3, 2, 3, 2);
            projectsAdminPanel.Name = "projectsAdminPanel";
            projectsAdminPanel.Size = new Size(1116, 562);
            projectsAdminPanel.TabIndex = 16;
            projectsAdminPanel.Visible = false;
            // 
            // projectsEndDateAdminDatePicker
            // 
            projectsEndDateAdminDatePicker.Enabled = false;
            projectsEndDateAdminDatePicker.Location = new Point(397, 371);
            projectsEndDateAdminDatePicker.Margin = new Padding(3, 2, 3, 2);
            projectsEndDateAdminDatePicker.Name = "projectsEndDateAdminDatePicker";
            projectsEndDateAdminDatePicker.Size = new Size(219, 23);
            projectsEndDateAdminDatePicker.TabIndex = 15;
            // 
            // projectsStartDateAdminDatePicker
            // 
            projectsStartDateAdminDatePicker.Enabled = false;
            projectsStartDateAdminDatePicker.Location = new Point(397, 326);
            projectsStartDateAdminDatePicker.Margin = new Padding(3, 2, 3, 2);
            projectsStartDateAdminDatePicker.Name = "projectsStartDateAdminDatePicker";
            projectsStartDateAdminDatePicker.Size = new Size(219, 23);
            projectsStartDateAdminDatePicker.TabIndex = 14;
            // 
            // projectsEndDateAdminLabel
            // 
            projectsEndDateAdminLabel.AutoSize = true;
            projectsEndDateAdminLabel.Location = new Point(328, 377);
            projectsEndDateAdminLabel.Name = "projectsEndDateAdminLabel";
            projectsEndDateAdminLabel.Size = new Size(53, 15);
            projectsEndDateAdminLabel.TabIndex = 13;
            projectsEndDateAdminLabel.Text = "Deadline";
            // 
            // projectsStartDateAdminLabel
            // 
            projectsStartDateAdminLabel.AutoSize = true;
            projectsStartDateAdminLabel.Location = new Point(323, 331);
            projectsStartDateAdminLabel.Name = "projectsStartDateAdminLabel";
            projectsStartDateAdminLabel.Size = new Size(58, 15);
            projectsStartDateAdminLabel.TabIndex = 12;
            projectsStartDateAdminLabel.Text = "Start Date";
            // 
            // projectsDescriptionAdminTextbox
            // 
            projectsDescriptionAdminTextbox.Location = new Point(397, 58);
            projectsDescriptionAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            projectsDescriptionAdminTextbox.Multiline = true;
            projectsDescriptionAdminTextbox.Name = "projectsDescriptionAdminTextbox";
            projectsDescriptionAdminTextbox.ReadOnly = true;
            projectsDescriptionAdminTextbox.Size = new Size(684, 246);
            projectsDescriptionAdminTextbox.TabIndex = 11;
            // 
            // projectsDeleteProjectAdminButton
            // 
            projectsDeleteProjectAdminButton.Location = new Point(724, 417);
            projectsDeleteProjectAdminButton.Margin = new Padding(3, 2, 3, 2);
            projectsDeleteProjectAdminButton.Name = "projectsDeleteProjectAdminButton";
            projectsDeleteProjectAdminButton.Size = new Size(362, 29);
            projectsDeleteProjectAdminButton.TabIndex = 10;
            projectsDeleteProjectAdminButton.Text = "Delete Project";
            projectsDeleteProjectAdminButton.UseVisualStyleBackColor = true;
            projectsDeleteProjectAdminButton.Click += projectsDeleteProjectAdminButton_Click;
            // 
            // projectsEditProjectAdminButton
            // 
            projectsEditProjectAdminButton.Location = new Point(365, 417);
            projectsEditProjectAdminButton.Margin = new Padding(3, 2, 3, 2);
            projectsEditProjectAdminButton.Name = "projectsEditProjectAdminButton";
            projectsEditProjectAdminButton.Size = new Size(362, 29);
            projectsEditProjectAdminButton.TabIndex = 9;
            projectsEditProjectAdminButton.Text = "Edit Project";
            projectsEditProjectAdminButton.UseVisualStyleBackColor = true;
            projectsEditProjectAdminButton.Click += projectsEditProjectAdminButton_Click;
            // 
            // projectsNameAdminTextbox
            // 
            projectsNameAdminTextbox.Location = new Point(397, 8);
            projectsNameAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            projectsNameAdminTextbox.Name = "projectsNameAdminTextbox";
            projectsNameAdminTextbox.ReadOnly = true;
            projectsNameAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            projectsNameAdminTextbox.Size = new Size(684, 23);
            projectsNameAdminTextbox.TabIndex = 8;
            // 
            // projectsDescriptionAdminLabel
            // 
            projectsDescriptionAdminLabel.AutoSize = true;
            projectsDescriptionAdminLabel.Location = new Point(315, 61);
            projectsDescriptionAdminLabel.Name = "projectsDescriptionAdminLabel";
            projectsDescriptionAdminLabel.Size = new Size(67, 15);
            projectsDescriptionAdminLabel.TabIndex = 5;
            projectsDescriptionAdminLabel.Text = "Description";
            // 
            // projectsNameAdminLabel
            // 
            projectsNameAdminLabel.AutoSize = true;
            projectsNameAdminLabel.Location = new Point(304, 11);
            projectsNameAdminLabel.Name = "projectsNameAdminLabel";
            projectsNameAdminLabel.Size = new Size(79, 15);
            projectsNameAdminLabel.TabIndex = 4;
            projectsNameAdminLabel.Text = "Project Name";
            // 
            // projectsAddProjectAdminButton
            // 
            projectsAddProjectAdminButton.Location = new Point(0, 417);
            projectsAddProjectAdminButton.Margin = new Padding(3, 2, 3, 2);
            projectsAddProjectAdminButton.Name = "projectsAddProjectAdminButton";
            projectsAddProjectAdminButton.Size = new Size(362, 29);
            projectsAddProjectAdminButton.TabIndex = 1;
            projectsAddProjectAdminButton.Text = "Add New Project";
            projectsAddProjectAdminButton.UseVisualStyleBackColor = true;
            projectsAddProjectAdminButton.Click += projectsAddProjectAdminButton_Click;
            // 
            // projectsAdminListbox
            // 
            projectsAdminListbox.FormattingEnabled = true;
            projectsAdminListbox.ItemHeight = 15;
            projectsAdminListbox.Location = new Point(3, 0);
            projectsAdminListbox.Margin = new Padding(3, 2, 3, 2);
            projectsAdminListbox.Name = "projectsAdminListbox";
            projectsAdminListbox.Size = new Size(281, 394);
            projectsAdminListbox.TabIndex = 0;
            projectsAdminListbox.SelectedIndexChanged += projectsAdminListbox_SelectedIndexChanged;
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
            tasksAdminPanel.Location = new Point(9, 89);
            tasksAdminPanel.Margin = new Padding(3, 2, 3, 2);
            tasksAdminPanel.Name = "tasksAdminPanel";
            tasksAdminPanel.Size = new Size(1086, 494);
            tasksAdminPanel.TabIndex = 13;
            tasksAdminPanel.Visible = false;
            // 
            // tasksDeleteTaskAdminButton
            // 
            tasksDeleteTaskAdminButton.Location = new Point(728, 437);
            tasksDeleteTaskAdminButton.Margin = new Padding(3, 2, 3, 2);
            tasksDeleteTaskAdminButton.Name = "tasksDeleteTaskAdminButton";
            tasksDeleteTaskAdminButton.Size = new Size(362, 29);
            tasksDeleteTaskAdminButton.TabIndex = 18;
            tasksDeleteTaskAdminButton.Text = "Delete Task";
            tasksDeleteTaskAdminButton.UseVisualStyleBackColor = true;
            tasksDeleteTaskAdminButton.Click += tasksDeleteTaskAdminButton_Click;
            // 
            // tasksEditTaskAdminButton
            // 
            tasksEditTaskAdminButton.Location = new Point(363, 437);
            tasksEditTaskAdminButton.Margin = new Padding(3, 2, 3, 2);
            tasksEditTaskAdminButton.Name = "tasksEditTaskAdminButton";
            tasksEditTaskAdminButton.Size = new Size(362, 29);
            tasksEditTaskAdminButton.TabIndex = 17;
            tasksEditTaskAdminButton.Text = "Edit Task";
            tasksEditTaskAdminButton.UseVisualStyleBackColor = true;
            tasksEditTaskAdminButton.Click += tasksEditTaskAdminButton_Click;
            // 
            // tasksNameAdminTextbox
            // 
            tasksNameAdminTextbox.Location = new Point(397, 8);
            tasksNameAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            tasksNameAdminTextbox.Name = "tasksNameAdminTextbox";
            tasksNameAdminTextbox.ReadOnly = true;
            tasksNameAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            tasksNameAdminTextbox.Size = new Size(684, 23);
            tasksNameAdminTextbox.TabIndex = 16;
            // 
            // tasksDescriptionAdminTextbox
            // 
            tasksDescriptionAdminTextbox.Location = new Point(397, 53);
            tasksDescriptionAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            tasksDescriptionAdminTextbox.Multiline = true;
            tasksDescriptionAdminTextbox.Name = "tasksDescriptionAdminTextbox";
            tasksDescriptionAdminTextbox.ReadOnly = true;
            tasksDescriptionAdminTextbox.ScrollBars = ScrollBars.Vertical;
            tasksDescriptionAdminTextbox.Size = new Size(684, 267);
            tasksDescriptionAdminTextbox.TabIndex = 15;
            // 
            // tasksStatusAdminTextbox
            // 
            tasksStatusAdminTextbox.Location = new Point(397, 343);
            tasksStatusAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            tasksStatusAdminTextbox.Name = "tasksStatusAdminTextbox";
            tasksStatusAdminTextbox.ReadOnly = true;
            tasksStatusAdminTextbox.ScrollBars = ScrollBars.Horizontal;
            tasksStatusAdminTextbox.Size = new Size(684, 23);
            tasksStatusAdminTextbox.TabIndex = 14;
            // 
            // tasksProjectNameAdminLabel
            // 
            tasksProjectNameAdminLabel.AutoEllipsis = true;
            tasksProjectNameAdminLabel.Location = new Point(2, 2);
            tasksProjectNameAdminLabel.Name = "tasksProjectNameAdminLabel";
            tasksProjectNameAdminLabel.Size = new Size(282, 40);
            tasksProjectNameAdminLabel.TabIndex = 13;
            tasksProjectNameAdminLabel.Text = "selected project name goes here";
            tasksProjectNameAdminLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tasksDueDateAdminDatePicker
            // 
            tasksDueDateAdminDatePicker.Enabled = false;
            tasksDueDateAdminDatePicker.Location = new Point(397, 392);
            tasksDueDateAdminDatePicker.Margin = new Padding(3, 2, 3, 2);
            tasksDueDateAdminDatePicker.Name = "tasksDueDateAdminDatePicker";
            tasksDueDateAdminDatePicker.Size = new Size(219, 23);
            tasksDueDateAdminDatePicker.TabIndex = 12;
            tasksDueDateAdminDatePicker.Value = new DateTime(2025, 8, 1, 0, 0, 0, 0);
            // 
            // tasksDueDateLabel
            // 
            tasksDueDateLabel.AutoSize = true;
            tasksDueDateLabel.Location = new Point(327, 397);
            tasksDueDateLabel.Name = "tasksDueDateLabel";
            tasksDueDateLabel.Size = new Size(53, 15);
            tasksDueDateLabel.TabIndex = 7;
            tasksDueDateLabel.Text = "Deadline";
            // 
            // tasksStatusAdminLabel
            // 
            tasksStatusAdminLabel.AutoSize = true;
            tasksStatusAdminLabel.Location = new Point(301, 346);
            tasksStatusAdminLabel.Name = "tasksStatusAdminLabel";
            tasksStatusAdminLabel.Size = new Size(82, 15);
            tasksStatusAdminLabel.TabIndex = 6;
            tasksStatusAdminLabel.Text = "Current Status";
            // 
            // tasksDescriptionAdminLabel
            // 
            tasksDescriptionAdminLabel.AutoSize = true;
            tasksDescriptionAdminLabel.Location = new Point(316, 58);
            tasksDescriptionAdminLabel.Name = "tasksDescriptionAdminLabel";
            tasksDescriptionAdminLabel.Size = new Size(67, 15);
            tasksDescriptionAdminLabel.TabIndex = 5;
            tasksDescriptionAdminLabel.Text = "Description";
            // 
            // tasksNameAdminLabel
            // 
            tasksNameAdminLabel.AutoSize = true;
            tasksNameAdminLabel.Location = new Point(319, 10);
            tasksNameAdminLabel.Name = "tasksNameAdminLabel";
            tasksNameAdminLabel.Size = new Size(64, 15);
            tasksNameAdminLabel.TabIndex = 4;
            tasksNameAdminLabel.Text = "Task Name";
            // 
            // tasksAddTaskAdminButton
            // 
            tasksAddTaskAdminButton.Location = new Point(-3, 437);
            tasksAddTaskAdminButton.Margin = new Padding(3, 2, 3, 2);
            tasksAddTaskAdminButton.Name = "tasksAddTaskAdminButton";
            tasksAddTaskAdminButton.Size = new Size(362, 29);
            tasksAddTaskAdminButton.TabIndex = 1;
            tasksAddTaskAdminButton.Text = "Add New Task";
            tasksAddTaskAdminButton.UseVisualStyleBackColor = true;
            tasksAddTaskAdminButton.Click += tasksAddTaskAdminButton_Click;
            // 
            // tasksAdminListbox
            // 
            tasksAdminListbox.FormattingEnabled = true;
            tasksAdminListbox.ItemHeight = 15;
            tasksAdminListbox.Location = new Point(3, 60);
            tasksAdminListbox.Margin = new Padding(3, 2, 3, 2);
            tasksAdminListbox.Name = "tasksAdminListbox";
            tasksAdminListbox.Size = new Size(281, 349);
            tasksAdminListbox.TabIndex = 0;
            tasksAdminListbox.SelectedIndexChanged += tasksAdminListbox_SelectedIndexChanged;
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
            teamsAdminPanel.Location = new Point(9, 89);
            teamsAdminPanel.Margin = new Padding(3, 2, 3, 2);
            teamsAdminPanel.Name = "teamsAdminPanel";
            teamsAdminPanel.Size = new Size(1119, 558);
            teamsAdminPanel.TabIndex = 14;
            teamsAdminPanel.Visible = false;
            // 
            // teamsDescriptionAdminTextbox
            // 
            teamsDescriptionAdminTextbox.Location = new Point(397, 53);
            teamsDescriptionAdminTextbox.Margin = new Padding(3, 2, 3, 2);
            teamsDescriptionAdminTextbox.Multiline = true;
            teamsDescriptionAdminTextbox.Name = "teamsDescriptionAdminTextbox";
            teamsDescriptionAdminTextbox.ReadOnly = true;
            teamsDescriptionAdminTextbox.Size = new Size(684, 352);
            teamsDescriptionAdminTextbox.TabIndex = 11;
            // 
            // teamsDeleteTeamAdminButton
            // 
            teamsDeleteTeamAdminButton.Location = new Point(724, 428);
            teamsDeleteTeamAdminButton.Margin = new Padding(3, 2, 3, 2);
            teamsDeleteTeamAdminButton.Name = "teamsDeleteTeamAdminButton";
            teamsDeleteTeamAdminButton.Size = new Size(362, 29);
            teamsDeleteTeamAdminButton.TabIndex = 10;
            teamsDeleteTeamAdminButton.Text = "Delete Team";
            teamsDeleteTeamAdminButton.UseVisualStyleBackColor = true;
            teamsDeleteTeamAdminButton.Click += teamsDeleteTeamAdminButton_Click;
            // 
            // teamsEditTeamAdminButton
            // 
            teamsEditTeamAdminButton.Location = new Point(363, 428);
            teamsEditTeamAdminButton.Margin = new Padding(3, 2, 3, 2);
            teamsEditTeamAdminButton.Name = "teamsEditTeamAdminButton";
            teamsEditTeamAdminButton.Size = new Size(362, 29);
            teamsEditTeamAdminButton.TabIndex = 9;
            teamsEditTeamAdminButton.Text = "Edit Team";
            teamsEditTeamAdminButton.UseVisualStyleBackColor = true;
            teamsEditTeamAdminButton.Click += teamsEditTeamAdminButton_Click;
            // 
            // teamsNameAdminTexbox
            // 
            teamsNameAdminTexbox.Location = new Point(397, 8);
            teamsNameAdminTexbox.Margin = new Padding(3, 2, 3, 2);
            teamsNameAdminTexbox.Name = "teamsNameAdminTexbox";
            teamsNameAdminTexbox.ReadOnly = true;
            teamsNameAdminTexbox.ScrollBars = ScrollBars.Horizontal;
            teamsNameAdminTexbox.Size = new Size(684, 23);
            teamsNameAdminTexbox.TabIndex = 8;
            // 
            // teamsDescriptionAdminLabel
            // 
            teamsDescriptionAdminLabel.AutoSize = true;
            teamsDescriptionAdminLabel.Location = new Point(314, 57);
            teamsDescriptionAdminLabel.Name = "teamsDescriptionAdminLabel";
            teamsDescriptionAdminLabel.Size = new Size(67, 15);
            teamsDescriptionAdminLabel.TabIndex = 5;
            teamsDescriptionAdminLabel.Text = "Description";
            // 
            // teamsNameAdminLabel
            // 
            teamsNameAdminLabel.AutoSize = true;
            teamsNameAdminLabel.Location = new Point(312, 10);
            teamsNameAdminLabel.Name = "teamsNameAdminLabel";
            teamsNameAdminLabel.Size = new Size(70, 15);
            teamsNameAdminLabel.TabIndex = 4;
            teamsNameAdminLabel.Text = "Team Name";
            // 
            // teamsAddTeamAdminButton
            // 
            teamsAddTeamAdminButton.Location = new Point(2, 428);
            teamsAddTeamAdminButton.Margin = new Padding(3, 2, 3, 2);
            teamsAddTeamAdminButton.Name = "teamsAddTeamAdminButton";
            teamsAddTeamAdminButton.Size = new Size(362, 29);
            teamsAddTeamAdminButton.TabIndex = 1;
            teamsAddTeamAdminButton.Text = "Add New Team";
            teamsAddTeamAdminButton.UseVisualStyleBackColor = true;
            teamsAddTeamAdminButton.Click += teamsAddTeamAdminButton_Click;
            // 
            // teamsAdminListbox
            // 
            teamsAdminListbox.FormattingEnabled = true;
            teamsAdminListbox.ItemHeight = 15;
            teamsAdminListbox.Location = new Point(3, 0);
            teamsAdminListbox.Margin = new Padding(3, 2, 3, 2);
            teamsAdminListbox.Name = "teamsAdminListbox";
            teamsAdminListbox.Size = new Size(281, 409);
            teamsAdminListbox.TabIndex = 0;
            teamsAdminListbox.SelectedIndexChanged += teamsAdminListbox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 650);
            Controls.Add(adminViewPanel);
            Controls.Add(userViewPanel);
            Controls.Add(loginPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Time Tracker - DSaA Project";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            userViewPanel.ResumeLayout(false);
            tasksUserPanel.ResumeLayout(false);
            teamsUserPanel.ResumeLayout(false);
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
        private ListBox teamsMembersUserListbox;
        private Label tasksTodoUserLabel;
        private ListBox tasksDoneUserListbox;
        private ListBox tasksTodoUserListbox;
        private Label tasksDoneUserLabel;
        private Button button4;
        private Button helpButtonUser;
        private Button helpButtonAdmin;
        private Button generateDetailedReportButton;
        private Button generateSummaryReportButton;
        private Label label1;
        private Button deleteHistoryRecordButton;
        private Button editHistoryRecordButton;
        private Button addHistoryRecordButton;
        private ListView employeeHistoryListView;
    }
}

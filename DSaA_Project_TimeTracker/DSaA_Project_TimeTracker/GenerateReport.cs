using AutoMapper.Execution;
using DSaA_Project_TimeTracker.Database.Entities;
using DSaA_Project_TimeTracker.Database.Repos;
using QuestPDF.Elements;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuestPDF.Helpers.Colors;


namespace DSaA_Project_TimeTracker
{
    public partial class GenerateReport : Form
    {

        private bool isHelpVisible = false;
        private Label[] helpLabels;
        private Team selectedTeam;

        public GenerateReport(Team team)
        {
            selectedTeam = team;
            InitializeComponent();
            InitializeHelpLabels();

            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            checkedListBox.Items.Insert(0, "Select All Employees"); 
            if (selectedTeam != null)
            {
                checkedListBox.DisplayMember = "Username";
                foreach (var member in selectedTeam.TeamMembers)
                {

                    checkedListBox.Items.Add(member.User);

                }
                checkedListBox.Text = selectedTeam.TeamName;
            }
        }


        private void InitializeHelpLabels()
        {
            // Create labels for each control
            helpLabels = new Label[]
            {
                CreateHelpLabel(checkedListBox, "Select the employees you want to include in the report."),
                CreateHelpLabel(generateSummaryReportButton, "Click to generate a summary report of tasks."),
                CreateHelpLabel(generateDetailedReportButton, "Click to generate a detailed report of tasks."),
                CreateHelpLabel(discardButton, "Click to discard the report."),
                CreateHelpLabel(helpButton, "Show help.")
            };

            // Initially hide all help labels
            foreach (var label in helpLabels)
            {
                label.Visible = false;
                this.Controls.Add(label); // Add labels to the form
            }
        }

        private Label CreateHelpLabel(Control control, string text)
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
                Location = new System.Drawing.Point(control.Location.X + offsetX, control.Location.Y + offsetY)
            };
            return label;
        }

        private void discardButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void generateSummaryReportButton_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            TaskAssignmentRepo taskAssignmentRepo = new TaskAssignmentRepo();
            UserRepo userRepo = new UserRepo();
            TaskRepo taskRepo = new TaskRepo();
            ProjectRepo projectRepo = new ProjectRepo();

            var taskAssignments = new List<TaskAssignment>();

            // Get all task assignments
            var allAssignments = await taskAssignmentRepo.GetAll();

            // Select all checked users
            List<User> selectedUsers = new List<User>();
            bool selectAll = checkedListBox.CheckedItems.Contains("Select All Employees");

            if (selectAll && selectedTeam != null)
            {
                selectedUsers = selectedTeam.TeamMembers.Select(tm => tm.User).ToList();
            }
            else
            {
                foreach (var item in checkedListBox.CheckedItems)
                {
                    if (item is User user)
                        selectedUsers.Add(user);
                }
            }

            if (selectedTeam == null || selectedUsers.Count == 0)
                return;

            var reportData = new List<(string Username, string ProjectName, decimal TotalHours)>();


            foreach (var user in selectedUsers)
            {
                // 1. Get all teams the user is a member of
                var userTeams = user.TeamMembers.Select(tm => tm.Team);

                // 2. Get all projects assigned to those teams
                var userProjectIds = userTeams
                    .SelectMany(t => t.TeamProjects)
                    .Select(tp => tp.ProjectId)
                    .Distinct()
                    .ToHashSet();

                // 3. Get all assignments for this user in those projects
                var userAssignments = allAssignments
                    .Where(a => a.UserId == user.Id && a.TaskToDo != null && userProjectIds.Contains(a.TaskToDo.ProjectId))
                    .ToList();

                // 4. Group by project and sum hours
                var grouped = userAssignments
                    .GroupBy(a => a.TaskToDo.ProjectId);

                foreach (var group in grouped)
                {
                    var project = await projectRepo.GetById(group.Key);
                    if (project != null)
                    {
                        decimal totalHours = group.Sum(a => a.TimeSpentHours);
                        reportData.Add((user.Username, project.ProjectName, totalHours));
                    }
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save PDF Report";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "SummaryReportTTS.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(2, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(14));

                            page.Header()
                                .Text("Summary Report")
                                .AlignCenter().SemiBold().FontSize(24).FontColor(Colors.Blue.Darken2);

                            page.Content()
                                .Table(table =>
                                {
                                    table.ColumnsDefinition(columns =>
                                    {
                                        columns.RelativeColumn();
                                        columns.RelativeColumn();
                                        columns.ConstantColumn(100);
                                    });

                                    table.Header(header =>
                                    {
                                        header.Cell().Text("Username").SemiBold();
                                        header.Cell().Text("Project Name").SemiBold();
                                        header.Cell().AlignRight().Text("Total hours spent on this project").SemiBold();
                                    });

                                    foreach (var item in reportData)
                                    {
                                        table.Cell().Text(item.Username);
                                        table.Cell().Text(item.ProjectName);
                                        table.Cell().AlignRight().Text(item.TotalHours.ToString("0.##"));
                                    }
                                });

                            page.Footer()
                                .AlignCenter()
                                .Text(x =>
                                {
                                    x.Span("Page ");
                                    x.CurrentPageNumber();
                                });
                        });
                    }).GeneratePdf(filePath);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
            }
        }

        private async void generateDetailedReportButton_Click(object sender, EventArgs e)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            TaskAssignmentRepo taskAssignmentRepo = new TaskAssignmentRepo();
            UserRepo userRepo = new UserRepo();
            TaskRepo taskRepo = new TaskRepo();
            ProjectRepo projectRepo = new ProjectRepo();

            var allAssignments = await taskAssignmentRepo.GetAll();

            List<User> selectedUsers = new List<User>();
            bool selectAll = checkedListBox.CheckedItems.Contains("Select All Employees");

            if (selectAll && selectedTeam != null)
            {
                selectedUsers = selectedTeam.TeamMembers.Select(tm => tm.User).ToList();
            }
            else
            {
                foreach (var item in checkedListBox.CheckedItems)
                {
                    if (item is User user)
                        selectedUsers.Add(user);
                }
            }

            if (selectedUsers.Count == 0)
                return;

            var reportData = new List<(string Username, string ProjectName, decimal TotalHours, List<(string TaskTitle, decimal Hours)>)>();

            foreach (var user in selectedUsers)
            {
                var userTeams = user.TeamMembers.Select(tm => tm.Team);

                var userProjectIds = userTeams
                    .SelectMany(t => t.TeamProjects)
                    .Select(tp => tp.ProjectId)
                    .Distinct()
                    .ToHashSet();

                var userAssignments = allAssignments
                    .Where(a => a.UserId == user.Id && a.TaskToDo != null && userProjectIds.Contains(a.TaskToDo.ProjectId))
                    .ToList();

                var groupedByProject = userAssignments
                    .GroupBy(a => a.TaskToDo.ProjectId);

                foreach (var projectGroup in groupedByProject)
                {
                    var project = await projectRepo.GetById(projectGroup.Key);
                    if (project == null) continue;

                    var taskDetails = projectGroup
                        .Select(a => (a.TaskToDo.Title, a.TimeSpentHours))
                        .ToList();

                    decimal totalHours = taskDetails.Sum(td => td.TimeSpentHours);

                    reportData.Add((user.Username, project.ProjectName, totalHours,
                        taskDetails.Select(td => (td.Title, td.TimeSpentHours)).ToList()));
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save PDF Report";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "DetailedReportTTS.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(2, Unit.Centimetre);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(14));

                            page.Header()
                                .Text("Detailed Report")
                                .AlignCenter().SemiBold().FontSize(24).FontColor(Colors.Blue.Darken2);

                            page.Content().Column(col =>
                            {
                                string lastUser = null;
                                foreach (var entry in reportData.OrderBy(x => x.Username).ThenBy(x => x.ProjectName))
                                {
                                    if (lastUser != entry.Username)
                                    {
                                        if (lastUser != null)
                                            col.Item().PaddingBottom(10);
                                        col.Item().Text($"Employee: {entry.Username}")
                                            .AlignCenter().SemiBold().FontSize(18).FontColor(Colors.Black);
                                        lastUser = entry.Username;
                                    }

                                    col.Item().Text($"Project: {entry.ProjectName}")
                                        .AlignCenter().Bold().FontSize(15).FontColor(Colors.Blue.Darken1);
                                    col.Item().Text($"Total sum of hours spent on project: {entry.TotalHours:0.##}")
                                        .AlignCenter().Italic().FontSize(13).FontColor(Colors.Black);
                                    col.Item().PaddingBottom(10);

                                    // Task breakdown
                                    foreach (var (taskTitle, hours) in entry.Item4)
                                    {
                                        col.Item().Text($"- {taskTitle}: {hours:0.##}h")
                                            .FontSize(12).FontColor(Colors.Black);
                                    }
                                    col.Item().PaddingBottom(10);
                                }
                            });

                            page.Footer()
                                .AlignCenter()
                                .Text(x =>
                                {
                                    x.Span("Page ");
                                    x.CurrentPageNumber();
                                });
                        });
                    }).GeneratePdf(filePath);

                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            isHelpVisible = !isHelpVisible;
            foreach (var label in helpLabels)
            {
                label.Visible = isHelpVisible;
            }
        }

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}

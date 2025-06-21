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
using DSaA_Project_TimeTracker.Database.Repos;
using QuestPDF.Fluent;
using QuestPDF.Elements;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using AutoMapper.Execution;


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

            if (selectedTeam == null)
                return;

            // Filter only assignments that match: user is in selected users, and task.ProjectId is in team projects
            var teamProjectIds = selectedTeam.TeamProjects.Select(tp => tp.ProjectId).ToHashSet();

            foreach (var assignment in allAssignments)
            {
                if (!selectedUsers.Any(u => u.Id == assignment.UserId))
                    continue;

                var task = await taskRepo.GetById(assignment.TaskId);
                if (task != null && teamProjectIds.Contains(task.ProjectId))
                {
                    taskAssignments.Add(assignment);
                }
            }

            // Build report items
            var reportItems = new List<(string Username, string TaskTitle, decimal TimeSpentHours)>();
            foreach (var assignment in taskAssignments)
            {
                var user = await userRepo.GetById(assignment.UserId);
                var task = await taskRepo.GetById(assignment.TaskId);

                if (user != null && task != null)
                {
                    reportItems.Add((user.Username, task.Title, assignment.TimeSpentHours));
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save PDF Report";
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.FileName = "report.pdf";

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
                                .Text("Task Report")
                                .SemiBold().FontSize(24).FontColor(Colors.Blue.Darken2);

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
                                        header.Cell().Text("Task Title").SemiBold();
                                        header.Cell().AlignRight().Text("Time (hrs)").SemiBold();
                                    });

                                    foreach (var item in reportItems)
                                    {
                                        table.Cell().Text(item.Username);
                                        table.Cell().Text(item.TaskTitle);
                                        table.Cell().AlignRight().Text(item.TimeSpentHours.ToString("0.##"));
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

        private void generateDetailedReportButton_Click(object sender, EventArgs e)
        {

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

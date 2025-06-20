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
            QuestPDF.Settings.License = LicenseType.Community;  //without this it doesnt work
            TaskAssignmentRepo taskAssignmentRepo = new TaskAssignmentRepo();
            UserRepo userRepo = new UserRepo();
            TaskRepo taskRepo = new TaskRepo();
            List<TaskAssignment> taskAssignments = new List<TaskAssignment>(); ;
            foreach (var item in checkedListBox.CheckedItems)
            {
                if (item.ToString() == "Select All Employees")
                {
                    // If "Select All Employees" is checked, select all users in the team
                    if(selectedTeam != null)
                    {
                        foreach (var member in selectedTeam.TeamMembers)
                        {
                            if (!checkedListBox.CheckedItems.Contains(member.User))
                            {
                                checkedListBox.SetItemChecked(checkedListBox.Items.IndexOf(member.User), true);
                                taskAssignments.Add(await taskAssignmentRepo.GetById(selectedTeam.Id, member.UserId));
                            }
                        }
                        break; // Exit the loop after processing "Select All Employees"
                    }
                    
                }
                else if (item is User user)
                {
                    if (selectedTeam != null)
                        taskAssignments.Add(await taskAssignmentRepo.GetById(selectedTeam.Id, user.Id));
                }
            }
            var reportItems = new List<(string Username, string TaskTitle, decimal TimeSpentHours)>();
            foreach (var assignment in taskAssignments)
            {
                if (assignment.UserId == 0 || assignment.TaskId == 0)
                    continue;
                var user = await userRepo.GetById(assignment.UserId);
                var task = await taskRepo.GetById(assignment.TaskId);
                reportItems.Add((user.Username, task.Title, assignment.TimeSpentHours));
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
                                    .Table(async table =>
                                    {
                                        table.ColumnsDefinition(columns =>
                                        {
                                            columns.RelativeColumn(); // Username
                                            columns.RelativeColumn(); // Task Title
                                            columns.ConstantColumn(100); // Time Spent
                                        });

                                        // Table header
                                        table.Header(header =>
                                        {
                                            header.Cell().Text("Username").SemiBold();
                                            header.Cell().Text("Task Title").SemiBold();
                                            header.Cell().AlignRight().Text("Time (hrs)").SemiBold();

                                        });

                                        // Table rows
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
                            UseShellExecute = true // required to open with default PDF viewer
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

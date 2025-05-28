using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSaA_Project_TimeTracker
{
    public partial class GenerateReport : Form
    {

        private bool isHelpVisible = false;
        private Label[] helpLabels;


        public GenerateReport()
        {
            InitializeComponent();
            InitializeHelpLabels();

            checkedListBox.Items.Insert(0, "Select All Employees");
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

        private void generateSummaryReportButton_Click(object sender, EventArgs e)
        {

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

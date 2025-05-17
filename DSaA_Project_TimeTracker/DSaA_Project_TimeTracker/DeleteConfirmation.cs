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
    public partial class DeleteConfirmation : Form
    {

        private string _panelToShow;
        private Dictionary<Control, Label[]> subPanelHelpLabels;
        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }
        public DeleteConfirmation()
        {
            InitializeComponent();
            deleteTaskPanel.Visible = false;
            deleteEmployeePanel.Visible = false;
            deleteTeamPanel.Visible = false;
            deleteProjectPanel.Visible = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Show the correct panel based on the value of PanelToShow
            if (_panelToShow == "DeleteProject")
            {
                deleteProjectPanel.BringToFront();
                deleteTeamPanel.Visible = false;
                deleteTaskPanel.Visible = false;
                deleteEmployeePanel.Visible = false;
                deleteProjectPanel.Visible = true;

            }
            else if (_panelToShow == "DeleteTask")
            {
                deleteTaskPanel.BringToFront();
                deleteProjectPanel.Visible = false;

                deleteTaskPanel.Visible = true;
                deleteEmployeePanel.Visible = false;
                deleteTeamPanel.Visible = false;
            }
            else if (_panelToShow == "DeleteTeam")
            {
                deleteTeamPanel.BringToFront();
                deleteProjectPanel.Visible = false;
                deleteTeamPanel.Visible = true;

                deleteEmployeePanel.Visible = false;
                deleteTaskPanel.Visible = false;
            }
            else if (_panelToShow == "DeleteEmployee")
            {
                deleteEmployeePanel.BringToFront();
                deleteProjectPanel.Visible = false;
                deleteTeamPanel.Visible = false;
                deleteTaskPanel.Visible = false;
                deleteEmployeePanel.Visible = true;
            }
        }

        private void deleteTeamTrueButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteTeamFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteEmployeeTrueButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteTaskTrueButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteTaskFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteProjectTrueButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteProjectFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

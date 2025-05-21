using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSaA_Project_TimeTracker.Database.Repos;

namespace DSaA_Project_TimeTracker
{
    public partial class DeleteConfirmation : Form
    {

        private string _panelToShow;
        private Dictionary<Control, Label[]> subPanelHelpLabels;
        public object ItemToDelete { get; set; }
        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }
        public DeleteConfirmation(object itemToDelete) : this()
        {
            ItemToDelete = itemToDelete;
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
                deleteHistoryRecordPanel.Visible = false;

            }
            else if (_panelToShow == "DeleteTask")
            {
                deleteTaskPanel.BringToFront();
                deleteProjectPanel.Visible = false;
                deleteTaskPanel.Visible = true;
                deleteEmployeePanel.Visible = false;
                deleteTeamPanel.Visible = false;
                deleteHistoryRecordPanel.Visible = false;
            }
            else if (_panelToShow == "DeleteTeam")
            {
                deleteTeamPanel.BringToFront();
                deleteProjectPanel.Visible = false;
                deleteTeamPanel.Visible = true;
                deleteEmployeePanel.Visible = false;
                deleteTaskPanel.Visible = false;
                deleteHistoryRecordPanel.Visible = false;
            }
            else if (_panelToShow == "DeleteEmployee")
            {
                deleteEmployeePanel.BringToFront();
                deleteProjectPanel.Visible = false;
                deleteTeamPanel.Visible = false;
                deleteTaskPanel.Visible = false;
                deleteEmployeePanel.Visible = true;
                deleteHistoryRecordPanel.Visible = false;
            }
            else if (_panelToShow == "DeleteHistoryRecord")
            {
                deleteHistoryRecordPanel.BringToFront();
                deleteProjectPanel.Visible = false;
                deleteTeamPanel.Visible = false;
                deleteTaskPanel.Visible = false;
                deleteEmployeePanel.Visible = false;
                deleteHistoryRecordPanel.Visible = true;
            }

        }

        private async void deleteTeamTrueButton_Click(object sender, EventArgs e)
        {
            if (ItemToDelete is DSaA_Project_TimeTracker.DTOs.Team.TeamDto team)
            {
                await new TeamRepo().DeleteById(team.Id);
            }
            this.Close();
        }

        private void deleteTeamFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void deleteEmployeeTrueButton_Click(object sender, EventArgs e)
        {
            if (ItemToDelete is DSaA_Project_TimeTracker.DTOs.User.UserDto user)
            {
                await new UserRepo().DeleteById(user.Id);
            }
            this.Close();
        }

        private void deleteEmployeeFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void deleteTaskTrueButton_Click(object sender, EventArgs e)
        {
            if (ItemToDelete is DSaA_Project_TimeTracker.DTOs.Task.TaskProgramDto task)
            {
                await new TaskRepo().DeleteById(task.Id);
            }
            this.Close();
        }

        private void deleteTaskFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void deleteProjectTrueButton_Click(object sender, EventArgs e)
        {
            if (ItemToDelete is DSaA_Project_TimeTracker.DTOs.Project.ProjectDto project)
            {
                await new ProjectRepo().DeleteById(project.Id);
            }
            this.Close();
        }

        private void deleteProjectFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteHistoryRecordTrueButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteHistoryRecordFalseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

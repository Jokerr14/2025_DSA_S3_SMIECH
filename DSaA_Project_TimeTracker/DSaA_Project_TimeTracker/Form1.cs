using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DSaA_Project_TimeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button3_Click(object sender, EventArgs e)
        {
            adminViewPanel.Visible = true;
            userViewPanel.Visible = false;
            loginPanel.Visible = false;
        }

        private void logOutAdminButton_Click(object sender, EventArgs e)
        {
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
            loginLoginTextbox.Text = "";
            loginPasswordTextbox.Text = "";
            loginPanel.Visible = true;
        }
        private void logOutUserButton_Click(object sender, EventArgs e)
        {
            adminViewPanel.Visible = false;
            userViewPanel.Visible = false;
            teamsUserPanel.Visible = false;
            tasksUserPanel.Visible = false;
            loginLoginTextbox.Text = "";
            loginPasswordTextbox.Text = "";
            loginPanel.Visible = true;
        }
        private void projectsAdminButton_Click(object sender, EventArgs e)
        {
            projectsAdminPanel.Visible = true;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
        }

        private void tasksAdminButton_Click(object sender, EventArgs e)
        {
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = true;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = false;
        }

        private void teamsAdminButton_Click(object sender, EventArgs e)
        {
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = true;
            employeesAdminPanel.Visible = false;
        }

        private void employeesAdminButton_Click(object sender, EventArgs e)
        {
            projectsAdminPanel.Visible = false;
            tasksAdminPanel.Visible = false;
            teamsAdminPanel.Visible = false;
            employeesAdminPanel.Visible = true;
        }

        private void tasksUserButton_Click(object sender, EventArgs e)
        {
            teamsUserPanel.Visible = false;
            tasksUserPanel.Visible = true;
        }

        private void teamsUserButton_Click(object sender, EventArgs e)
        {
            tasksUserPanel.Visible = false;
            teamsUserPanel.Visible = true;
        }

        ////////////////////////////TO DO///////////////////////////////////////////
        //Add backend logic for creating, editing and deleting projects, tasks, teams, and employees
        //Maybe it opens a new window to input necessary data??

        private void projectsAddProjectAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void projectsEditProjectAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void projectsDeleteProjectAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void teamsAddTeamAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void teamsEditTeamAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void teamsDeleteTeamAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void tasksAddTaskAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void tasksEditTaskAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void tasksDeleteTaskAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void employeesAddEmployeeAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void employeesEditEmployeeAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void employeesDeleteEmployeeAdminButton_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the TaskForm
            TaskForm taskForm = new TaskForm();

            // Set the form to open as a dialog without closing the current form
            taskForm.ShowDialog();
        }






        ///////////////////////////////////////////////////////////////////////

    }
}

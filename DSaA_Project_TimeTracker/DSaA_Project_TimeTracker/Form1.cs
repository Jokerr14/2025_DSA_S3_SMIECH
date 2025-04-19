using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DSaA_Project_TimeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userTabControl.SelectedIndexChanged += new EventHandler(logOutTab_Selected);
        }

        void logOutTab_Selected(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            if (tabControl != null && tabControl.SelectedTab == logOutUserTab)
            {
                adminViewPanel.Visible = false;
                userViewPanel.Visible = false;
                loginPanel.Visible = true;
                tabControl.SelectedTab = tasksUserTab;
            }

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

        ///////////////////////////////////////////////////////////////////////

    }
}

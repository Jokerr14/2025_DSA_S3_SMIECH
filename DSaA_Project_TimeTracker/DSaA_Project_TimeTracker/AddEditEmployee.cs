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
using DSaA_Project_TimeTracker.DTOs.User;
using DSaA_Project_TimeTracker.Database.Repos;
using DSaA_Project_TimeTracker.Utils;

namespace DSaA_Project_TimeTracker
{
    public partial class AddEditEmployee : Form
    {
        
        private string _panelToShow;
        private Dictionary<Control, Label[]> subPanelHelpLabels;
        
        public string PanelToShow
        {
            get => _panelToShow;
            set => _panelToShow = value;
        }

        private bool isHelpVisible = false;
        private bool isHelpEnabled = false;

        public object ItemToEdit { get; set; }
        public AddEditEmployee(object itemToEdit) : this()
        {
            ItemToEdit = itemToEdit;
        }
        public AddEditEmployee()
        {
            InitializeComponent();
            InitializeHelpLabels();

            addEmployeePanel.Visible = false;
            editEmployeePanel.Visible = false;
        }

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    editEmployeePanel, new Label[]
                    {
                        CreateHelpLabel(editEmployeeNameTextBox, "Change name.", editEmployeePanel),
                        CreateHelpLabel(editEmployeeMailTextBox, "Change E-mail.", editEmployeePanel),
                        CreateHelpLabel(editEmployeeRoleComboBox, "Change role.", editEmployeePanel),
                        CreateHelpLabel(editEmployeeStatusComboBox, "Change status.", editEmployeePanel),
                        CreateHelpLabel(discardEditEmployeeButton, "Discard all changes.", editEmployeePanel),
                        CreateHelpLabel(saveEditEmployeeButton, "Save all changes.", editEmployeePanel),
                        CreateHelpLabel(editEmployeeHelpButton, "Show help.", editEmployeePanel),
                    }
                },
                {
                    addEmployeePanel, new Label[]
                    {
                        CreateHelpLabel(addNewEmployeeNameTextBox, "Add name.", addEmployeePanel),
                        CreateHelpLabel(addNewEmployeeMailTextBox, "Add E-mail.", addEmployeePanel),
                        CreateHelpLabel(addNewEmployeeRoleComboBox, "Add role.", addEmployeePanel),
                        CreateHelpLabel(addNewEmployeeStatusComboBox, "Set status of employment.", addEmployeePanel),
                        CreateHelpLabel(discardNewEmployeeButton, "Discard task.", addEmployeePanel),
                        CreateHelpLabel(saveNewEmployeeButton, "Save task.", addEmployeePanel),
                        CreateHelpLabel(addEmployeeHelpButton, "Show help.", addEmployeePanel),

                    }
                },
            };

            // Initially hide all help labels
            foreach (var subPanelLabels in subPanelHelpLabels.Values)
            {
                foreach (var label in subPanelLabels)
                {
                    label.Visible = false;
                    label.BringToFront(); // Ensure the label is on top of other controls
                }
            }
        }

        private Label CreateHelpLabel(Control control, string text, Control parentPanel)
        {
            // Adjust position for specific controls
            int offsetX = 0; // Align horizontally with the control
            int offsetY = control.Height; // Place the label just below the control with a small gap



            // Create a label and position it near the control
            Label label = new Label
            {
                Text = text,
                AutoSize = true,
                BackColor = System.Drawing.Color.LightYellow,
                ForeColor = System.Drawing.Color.Black,
                Location = new System.Drawing.Point(
                    Math.Max(0, control.Location.X + offsetX),
                    Math.Max(0, control.Location.Y + offsetY)
                )
            };

            // Add the label to the specified panel
            parentPanel.Controls.Add(label);
            label.BringToFront(); // Ensure the label is on top of other controls
            return label;
        }

        private void ToggleHelpLabels()
        {
            isHelpEnabled = !isHelpEnabled;
            isHelpVisible = isHelpEnabled;

            // Hide all labels first
            foreach (var subPanelLabels in subPanelHelpLabels.Values)
            {
                foreach (var label in subPanelLabels)
                {
                    label.Visible = false;
                }
            }

            // Determine the currently active panel
            Control activePanel = null;
            if (addEmployeePanel.Visible) activePanel = addEmployeePanel;
            else if (editEmployeePanel.Visible) activePanel = editEmployeePanel;

            // Show labels for the active panel
            if (activePanel != null && subPanelHelpLabels.ContainsKey(activePanel))
            {
                foreach (var label in subPanelHelpLabels[activePanel])
                {
                    label.Visible = isHelpVisible;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Show the correct panel based on the value of PanelToShow
            if (_panelToShow == "AddEmployee")
            {
                addEmployeePanel.BringToFront();
                editEmployeePanel.Visible = false;
                addEmployeePanel.Visible = true;

            }
            else if (_panelToShow == "EditEmployee")
            {
                editEmployeePanel.BringToFront();
                addEmployeePanel.Visible = false;
                editEmployeePanel.Visible = true;
                editEmployeeNameTextBox.Text = ((User)ItemToEdit).Username;
                editEmployeeMailTextBox.Text = ((User)ItemToEdit).Email;
                //editEmployeeRoleComboBox.Text = ((User)ItemToEdit).Role.RoleName;
                editEmployeeStatusComboBox.Text = ((User)ItemToEdit).EmploymentStatus;

            }
        }

        private void editEmployeeHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void addEmployeeHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void discardEditEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void discardNewEmployeeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void saveEditEmployeeButton_Click(object sender, EventArgs e)
        {
            var username = editEmployeeNameTextBox.Text;
            var email = editEmployeeMailTextBox.Text;
            var role = editEmployeeRoleComboBox.Text.ToString();
            var password = "";
            int roleNum;
            if (role == "Admin")
            {
                roleNum = 1;
            }
            else { roleNum = 2; }
            ;
            var status = editEmployeeStatusComboBox.Text.ToString();
            if(editEmployeePasswordTextBox.Text != string.Empty) { password = PasswordHasher.HashPasword(editEmployeePasswordTextBox.Text); }
            else { password = ((User)ItemToEdit).PasswordHash; }
            var editedEmployee = new DTOs.User.AddUserDto
                {

                    Username = username,
                    Email = email,
                    EmploymentStatus = status,
                    Password = password,
                    //RoleId = roleNum
                };
            var repo = new DSaA_Project_TimeTracker.Database.Repos.UserRepo();
            await repo.UpdateById(((User)ItemToEdit).Id, editedEmployee);
            this.Close();
        }

        private async void saveNewEmployeeButton_Click(object sender, EventArgs e)
        {
            
            var role = addNewEmployeeRoleComboBox.Text.ToString();
            int roleNum;
            if (role == "Admin")
            {
                roleNum = 1;
            }
            else { roleNum = 2; };

            var status = addNewEmployeeStatusComboBox.Text.ToString();
            var newEmployee = new AddUserDto
            {
                Username = addNewEmployeeNameTextBox.Text,
                Email = addNewEmployeeMailTextBox.Text,
                Password = addNewEmployeePasswordTextBox.Text,
                EmploymentStatus = status
            };
            var repo = new UserRepo();
            await repo.Add(newEmployee);
            
            this.Close();
        }
    }
}

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
    public partial class AddEditHistoryRecord : Form
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
        public AddEditHistoryRecord()
        {
            InitializeComponent();
            InitializeHelpLabels();

            addHistoryRecordPanel.Visible = false;
            editHistoryRecordPanel.Visible = false;
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

        private void InitializeHelpLabels()
        {
            // Initialize the dictionary to group help labels by sub-panel or context
            subPanelHelpLabels = new Dictionary<Control, Label[]>
            {
                {
                    editHistoryRecordPanel, new Label[]
                    {
                        CreateHelpLabel(editEventTypeTextBox, "Change type of event.", editHistoryRecordPanel),
                        CreateHelpLabel(editEventDateDatePicker, "Change the date of the event.", editHistoryRecordPanel),
                        CreateHelpLabel(editNotesTextBox, "Change the notes about the event.", editHistoryRecordPanel),
                        CreateHelpLabel(discardEditHistoryRecordButton, "Discard all changes.", editHistoryRecordPanel),
                        CreateHelpLabel(saveEditHistoryRecordButton, "Save all changes.", editHistoryRecordPanel),
                        CreateHelpLabel(editHistoryRecordHelpButton, "Show help.", editHistoryRecordPanel),
                    }
                },
                {
                    addHistoryRecordPanel, new Label[]
                    {
                        CreateHelpLabel(addEventTypeTextBox, "Add type of event.", addHistoryRecordPanel),
                        CreateHelpLabel(addEventDateDatePicker, "Set the date of the event.", addHistoryRecordPanel),
                        CreateHelpLabel(addNotesTextBox, "Add the notes about the event.", addHistoryRecordPanel),
                        CreateHelpLabel(discardNewHistoryRecordButton, "Discard all changes.", addHistoryRecordPanel),
                        CreateHelpLabel(saveNewHistoryRecordButton, "Save all changes.", addHistoryRecordPanel),
                        CreateHelpLabel(addHistoryRecordHelpButton, "Show help.", addHistoryRecordPanel),

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
            if (addHistoryRecordPanel.Visible) activePanel = addHistoryRecordPanel;
            else if (editHistoryRecordPanel.Visible) activePanel = editHistoryRecordPanel;

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
            if (_panelToShow == "AddHistoryRecord")
            {
                addHistoryRecordPanel.BringToFront();
                editHistoryRecordPanel.Visible = false;
                addHistoryRecordPanel.Visible = true;

            }
            else if (_panelToShow == "EditHistoryRecord")
            {
                editHistoryRecordPanel.BringToFront();
                addHistoryRecordPanel.Visible = false;
                editHistoryRecordPanel.Visible = true;
            }
        }

        private void editHistoryRecordHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void addHistoryRecordHelpButton_Click(object sender, EventArgs e)
        {
            ToggleHelpLabels();
        }

        private void discardEditHistoryRecordButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void discardNewHistoryRecordButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveEditHistoryRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void saveNewHistoryRecordButton_Click(object sender, EventArgs e)
        {

        }
    }
}

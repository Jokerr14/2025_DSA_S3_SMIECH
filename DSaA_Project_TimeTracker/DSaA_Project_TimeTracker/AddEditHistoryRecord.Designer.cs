namespace DSaA_Project_TimeTracker
{
    partial class AddEditHistoryRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addHistoryRecordPanel = new Panel();
            addHistoryRecordHelpButton = new Button();
            AddTaskNameLabel = new Label();
            addNotesTextBox = new TextBox();
            discardNewHistoryRecordButton = new Button();
            saveNewHistoryRecordButton = new Button();
            addEventTypeTextBox = new TextBox();
            label2 = new Label();
            addEventDateDatePicker = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            editHistoryRecordPanel = new Panel();
            editNotesTextBox = new TextBox();
            editEventTypeTextBox = new TextBox();
            editHistoryRecordHelpButton = new Button();
            label5 = new Label();
            label1 = new Label();
            editEventDateDatePicker = new DateTimePicker();
            discardEditHistoryRecordButton = new Button();
            label6 = new Label();
            saveEditHistoryRecordButton = new Button();
            label7 = new Label();
            addHistoryRecordPanel.SuspendLayout();
            editHistoryRecordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addHistoryRecordPanel
            // 
            addHistoryRecordPanel.Controls.Add(addHistoryRecordHelpButton);
            addHistoryRecordPanel.Controls.Add(AddTaskNameLabel);
            addHistoryRecordPanel.Controls.Add(addNotesTextBox);
            addHistoryRecordPanel.Controls.Add(discardNewHistoryRecordButton);
            addHistoryRecordPanel.Controls.Add(saveNewHistoryRecordButton);
            addHistoryRecordPanel.Controls.Add(addEventTypeTextBox);
            addHistoryRecordPanel.Controls.Add(label2);
            addHistoryRecordPanel.Controls.Add(addEventDateDatePicker);
            addHistoryRecordPanel.Controls.Add(label4);
            addHistoryRecordPanel.Controls.Add(label3);
            addHistoryRecordPanel.Location = new Point(12, 12);
            addHistoryRecordPanel.Name = "addHistoryRecordPanel";
            addHistoryRecordPanel.Size = new Size(773, 574);
            addHistoryRecordPanel.TabIndex = 0;
            // 
            // addHistoryRecordHelpButton
            // 
            addHistoryRecordHelpButton.Location = new Point(698, 40);
            addHistoryRecordHelpButton.Name = "addHistoryRecordHelpButton";
            addHistoryRecordHelpButton.Size = new Size(48, 23);
            addHistoryRecordHelpButton.TabIndex = 42;
            addHistoryRecordHelpButton.Text = "Help";
            addHistoryRecordHelpButton.UseVisualStyleBackColor = true;
            addHistoryRecordHelpButton.Click += addHistoryRecordHelpButton_Click;
            // 
            // AddTaskNameLabel
            // 
            AddTaskNameLabel.AutoSize = true;
            AddTaskNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddTaskNameLabel.Location = new Point(273, 32);
            AddTaskNameLabel.Name = "AddTaskNameLabel";
            AddTaskNameLabel.Size = new Size(252, 30);
            AddTaskNameLabel.TabIndex = 41;
            AddTaskNameLabel.Text = "Add New History Record";
            // 
            // addNotesTextBox
            // 
            addNotesTextBox.Location = new Point(140, 200);
            addNotesTextBox.Margin = new Padding(3, 2, 3, 2);
            addNotesTextBox.Multiline = true;
            addNotesTextBox.Name = "addNotesTextBox";
            addNotesTextBox.ScrollBars = ScrollBars.Vertical;
            addNotesTextBox.Size = new Size(606, 267);
            addNotesTextBox.TabIndex = 40;
            // 
            // discardNewHistoryRecordButton
            // 
            discardNewHistoryRecordButton.Location = new Point(308, 511);
            discardNewHistoryRecordButton.Name = "discardNewHistoryRecordButton";
            discardNewHistoryRecordButton.Size = new Size(207, 38);
            discardNewHistoryRecordButton.TabIndex = 39;
            discardNewHistoryRecordButton.Text = "Discard";
            discardNewHistoryRecordButton.UseVisualStyleBackColor = true;
            discardNewHistoryRecordButton.Click += discardNewHistoryRecordButton_Click;
            // 
            // saveNewHistoryRecordButton
            // 
            saveNewHistoryRecordButton.Location = new Point(539, 511);
            saveNewHistoryRecordButton.Name = "saveNewHistoryRecordButton";
            saveNewHistoryRecordButton.Size = new Size(207, 38);
            saveNewHistoryRecordButton.TabIndex = 38;
            saveNewHistoryRecordButton.Text = "Save";
            saveNewHistoryRecordButton.UseVisualStyleBackColor = true;
            saveNewHistoryRecordButton.Click += saveNewHistoryRecordButton_Click;
            // 
            // addEventTypeTextBox
            // 
            addEventTypeTextBox.Location = new Point(140, 94);
            addEventTypeTextBox.Name = "addEventTypeTextBox";
            addEventTypeTextBox.Size = new Size(606, 23);
            addEventTypeTextBox.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 97);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 32;
            label2.Text = "Event Type";
            // 
            // addEventDateDatePicker
            // 
            addEventDateDatePicker.Location = new Point(140, 147);
            addEventDateDatePicker.Name = "addEventDateDatePicker";
            addEventDateDatePicker.Size = new Size(235, 23);
            addEventDateDatePicker.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 153);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 35;
            label4.Text = "Event Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 203);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 33;
            label3.Text = "Notes";
            // 
            // editHistoryRecordPanel
            // 
            editHistoryRecordPanel.Controls.Add(editNotesTextBox);
            editHistoryRecordPanel.Controls.Add(editEventTypeTextBox);
            editHistoryRecordPanel.Controls.Add(editHistoryRecordHelpButton);
            editHistoryRecordPanel.Controls.Add(label5);
            editHistoryRecordPanel.Controls.Add(label1);
            editHistoryRecordPanel.Controls.Add(editEventDateDatePicker);
            editHistoryRecordPanel.Controls.Add(discardEditHistoryRecordButton);
            editHistoryRecordPanel.Controls.Add(label6);
            editHistoryRecordPanel.Controls.Add(saveEditHistoryRecordButton);
            editHistoryRecordPanel.Controls.Add(label7);
            editHistoryRecordPanel.Location = new Point(15, 12);
            editHistoryRecordPanel.Name = "editHistoryRecordPanel";
            editHistoryRecordPanel.Size = new Size(773, 574);
            editHistoryRecordPanel.TabIndex = 1;
            // 
            // editNotesTextBox
            // 
            editNotesTextBox.Location = new Point(137, 200);
            editNotesTextBox.Margin = new Padding(3, 2, 3, 2);
            editNotesTextBox.Multiline = true;
            editNotesTextBox.Name = "editNotesTextBox";
            editNotesTextBox.ScrollBars = ScrollBars.Vertical;
            editNotesTextBox.Size = new Size(606, 267);
            editNotesTextBox.TabIndex = 46;
            // 
            // editEventTypeTextBox
            // 
            editEventTypeTextBox.Location = new Point(137, 94);
            editEventTypeTextBox.Name = "editEventTypeTextBox";
            editEventTypeTextBox.Size = new Size(606, 23);
            editEventTypeTextBox.TabIndex = 44;
            // 
            // editHistoryRecordHelpButton
            // 
            editHistoryRecordHelpButton.Location = new Point(698, 39);
            editHistoryRecordHelpButton.Name = "editHistoryRecordHelpButton";
            editHistoryRecordHelpButton.Size = new Size(48, 23);
            editHistoryRecordHelpButton.TabIndex = 43;
            editHistoryRecordHelpButton.Text = "Help";
            editHistoryRecordHelpButton.UseVisualStyleBackColor = true;
            editHistoryRecordHelpButton.Click += editHistoryRecordHelpButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 97);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 41;
            label5.Text = "Event Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(302, 29);
            label1.Name = "label1";
            label1.Size = new Size(198, 30);
            label1.TabIndex = 42;
            label1.Text = "Edit History Record";
            // 
            // editEventDateDatePicker
            // 
            editEventDateDatePicker.Location = new Point(137, 147);
            editEventDateDatePicker.Name = "editEventDateDatePicker";
            editEventDateDatePicker.Size = new Size(235, 23);
            editEventDateDatePicker.TabIndex = 45;
            // 
            // discardEditHistoryRecordButton
            // 
            discardEditHistoryRecordButton.Location = new Point(302, 508);
            discardEditHistoryRecordButton.Name = "discardEditHistoryRecordButton";
            discardEditHistoryRecordButton.Size = new Size(207, 38);
            discardEditHistoryRecordButton.TabIndex = 40;
            discardEditHistoryRecordButton.Text = "Discard";
            discardEditHistoryRecordButton.UseVisualStyleBackColor = true;
            discardEditHistoryRecordButton.Click += discardEditHistoryRecordButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 153);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 43;
            label6.Text = "Event Date";
            // 
            // saveEditHistoryRecordButton
            // 
            saveEditHistoryRecordButton.Location = new Point(536, 508);
            saveEditHistoryRecordButton.Name = "saveEditHistoryRecordButton";
            saveEditHistoryRecordButton.Size = new Size(207, 38);
            saveEditHistoryRecordButton.TabIndex = 39;
            saveEditHistoryRecordButton.Text = "Save";
            saveEditHistoryRecordButton.UseVisualStyleBackColor = true;
            saveEditHistoryRecordButton.Click += saveEditHistoryRecordButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 203);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 42;
            label7.Text = "Notes";
            // 
            // AddEditHistoryRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(addHistoryRecordPanel);
            Controls.Add(editHistoryRecordPanel);
            Name = "AddEditHistoryRecord";
            Text = "AddEditHistoryRecord";
            addHistoryRecordPanel.ResumeLayout(false);
            addHistoryRecordPanel.PerformLayout();
            editHistoryRecordPanel.ResumeLayout(false);
            editHistoryRecordPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addHistoryRecordPanel;
        private Panel editHistoryRecordPanel;
        private Button addHistoryRecordHelpButton;
        private Label AddTaskNameLabel;
        private TextBox addNotesTextBox;
        private Button discardNewHistoryRecordButton;
        private Button saveNewHistoryRecordButton;
        private TextBox addEventTypeTextBox;
        private Label label2;
        private DateTimePicker addEventDateDatePicker;
        private Label label4;
        private Label label3;
        private Button editHistoryRecordHelpButton;
        private Label label1;
        private Button discardEditHistoryRecordButton;
        private Button saveEditHistoryRecordButton;
        private TextBox editNotesTextBox;
        private TextBox editEventTypeTextBox;
        private Label label5;
        private DateTimePicker editEventDateDatePicker;
        private Label label6;
        private Label label7;
    }
}
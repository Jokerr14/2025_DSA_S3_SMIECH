namespace DSaA_Project_TimeTracker
{
    partial class AddEditTeam
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
            addTeamPanel = new Panel();
            addTeamHelpButton = new Button();
            AddTaskNameLabel = new Label();
            addNewTeamDescTextBox = new TextBox();
            discardNewTeamButton = new Button();
            saveNewTeamButton = new Button();
            addNewTeamNameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            editTeamPanel = new Panel();
            editTeamHelpButton = new Button();
            label5 = new Label();
            editTeamDescTextBox = new TextBox();
            discardEditTeamButton = new Button();
            saveEditTeamButton = new Button();
            editTeamNameTextBox = new TextBox();
            label6 = new Label();
            label8 = new Label();
            addTeamPanel.SuspendLayout();
            editTeamPanel.SuspendLayout();
            SuspendLayout();
            // 
            // addTeamPanel
            // 
            addTeamPanel.Controls.Add(addTeamHelpButton);
            addTeamPanel.Controls.Add(AddTaskNameLabel);
            addTeamPanel.Controls.Add(addNewTeamDescTextBox);
            addTeamPanel.Controls.Add(discardNewTeamButton);
            addTeamPanel.Controls.Add(saveNewTeamButton);
            addTeamPanel.Controls.Add(addNewTeamNameTextBox);
            addTeamPanel.Controls.Add(label1);
            addTeamPanel.Controls.Add(label2);
            addTeamPanel.Location = new Point(12, 12);
            addTeamPanel.Name = "addTeamPanel";
            addTeamPanel.Size = new Size(762, 527);
            addTeamPanel.TabIndex = 0;
            // 
            // addTeamHelpButton
            // 
            addTeamHelpButton.Location = new Point(688, 35);
            addTeamHelpButton.Name = "addTeamHelpButton";
            addTeamHelpButton.Size = new Size(48, 23);
            addTeamHelpButton.TabIndex = 42;
            addTeamHelpButton.Text = "Help";
            addTeamHelpButton.UseVisualStyleBackColor = true;
            addTeamHelpButton.Click += addTeamHelpButton_Click;
            // 
            // AddTaskNameLabel
            // 
            AddTaskNameLabel.AutoSize = true;
            AddTaskNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddTaskNameLabel.Location = new Point(327, 28);
            AddTaskNameLabel.Name = "AddTaskNameLabel";
            AddTaskNameLabel.Size = new Size(161, 30);
            AddTaskNameLabel.TabIndex = 41;
            AddTaskNameLabel.Text = "Add New Team";
            // 
            // addNewTeamDescTextBox
            // 
            addNewTeamDescTextBox.Location = new Point(130, 151);
            addNewTeamDescTextBox.Margin = new Padding(3, 2, 3, 2);
            addNewTeamDescTextBox.Multiline = true;
            addNewTeamDescTextBox.Name = "addNewTeamDescTextBox";
            addNewTeamDescTextBox.ScrollBars = ScrollBars.Vertical;
            addNewTeamDescTextBox.Size = new Size(606, 267);
            addNewTeamDescTextBox.TabIndex = 40;
            // 
            // discardNewTeamButton
            // 
            discardNewTeamButton.Location = new Point(295, 456);
            discardNewTeamButton.Name = "discardNewTeamButton";
            discardNewTeamButton.Size = new Size(207, 38);
            discardNewTeamButton.TabIndex = 39;
            discardNewTeamButton.Text = "Discard";
            discardNewTeamButton.UseVisualStyleBackColor = true;
            discardNewTeamButton.Click += discardNewTeamButton_Click;
            // 
            // saveNewTeamButton
            // 
            saveNewTeamButton.Location = new Point(529, 456);
            saveNewTeamButton.Name = "saveNewTeamButton";
            saveNewTeamButton.Size = new Size(207, 38);
            saveNewTeamButton.TabIndex = 38;
            saveNewTeamButton.Text = "Save";
            saveNewTeamButton.UseVisualStyleBackColor = true;
            saveNewTeamButton.Click += saveNewTeamButton_Click;
            // 
            // addNewTeamNameTextBox
            // 
            addNewTeamNameTextBox.Location = new Point(130, 89);
            addNewTeamNameTextBox.Name = "addNewTeamNameTextBox";
            addNewTeamNameTextBox.Size = new Size(606, 23);
            addNewTeamNameTextBox.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 92);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 32;
            label1.Text = "Team Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 154);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 33;
            label2.Text = "Description";
            // 
            // editTeamPanel
            // 
            editTeamPanel.Controls.Add(editTeamHelpButton);
            editTeamPanel.Controls.Add(label5);
            editTeamPanel.Controls.Add(editTeamDescTextBox);
            editTeamPanel.Controls.Add(discardEditTeamButton);
            editTeamPanel.Controls.Add(saveEditTeamButton);
            editTeamPanel.Controls.Add(editTeamNameTextBox);
            editTeamPanel.Controls.Add(label6);
            editTeamPanel.Controls.Add(label8);
            editTeamPanel.Location = new Point(12, 12);
            editTeamPanel.Name = "editTeamPanel";
            editTeamPanel.Size = new Size(762, 527);
            editTeamPanel.TabIndex = 1;
            // 
            // editTeamHelpButton
            // 
            editTeamHelpButton.Location = new Point(688, 35);
            editTeamHelpButton.Name = "editTeamHelpButton";
            editTeamHelpButton.Size = new Size(48, 23);
            editTeamHelpButton.TabIndex = 43;
            editTeamHelpButton.Text = "Help";
            editTeamHelpButton.UseVisualStyleBackColor = true;
            editTeamHelpButton.Click += editTeamHelpButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(327, 28);
            label5.Name = "label5";
            label5.Size = new Size(107, 30);
            label5.TabIndex = 42;
            label5.Text = "Edit Team";
            // 
            // editTeamDescTextBox
            // 
            editTeamDescTextBox.Location = new Point(130, 151);
            editTeamDescTextBox.Margin = new Padding(3, 2, 3, 2);
            editTeamDescTextBox.Multiline = true;
            editTeamDescTextBox.Name = "editTeamDescTextBox";
            editTeamDescTextBox.ScrollBars = ScrollBars.Vertical;
            editTeamDescTextBox.Size = new Size(606, 267);
            editTeamDescTextBox.TabIndex = 41;
            // 
            // discardEditTeamButton
            // 
            discardEditTeamButton.Location = new Point(295, 456);
            discardEditTeamButton.Name = "discardEditTeamButton";
            discardEditTeamButton.Size = new Size(207, 38);
            discardEditTeamButton.TabIndex = 40;
            discardEditTeamButton.Text = "Discard";
            discardEditTeamButton.UseVisualStyleBackColor = true;
            discardEditTeamButton.Click += discardEditTeamButton_Click;
            // 
            // saveEditTeamButton
            // 
            saveEditTeamButton.Location = new Point(529, 456);
            saveEditTeamButton.Name = "saveEditTeamButton";
            saveEditTeamButton.Size = new Size(207, 38);
            saveEditTeamButton.TabIndex = 39;
            saveEditTeamButton.Text = "Save";
            saveEditTeamButton.UseVisualStyleBackColor = true;
            saveEditTeamButton.Click += saveEditTeamButton_Click;
            // 
            // editTeamNameTextBox
            // 
            editTeamNameTextBox.Location = new Point(130, 89);
            editTeamNameTextBox.Name = "editTeamNameTextBox";
            editTeamNameTextBox.Size = new Size(606, 23);
            editTeamNameTextBox.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 92);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 33;
            label6.Text = "Team Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 154);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 34;
            label8.Text = "Description";
            // 
            // AddEditTeam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 557);
            Controls.Add(addTeamPanel);
            Controls.Add(editTeamPanel);
            Name = "AddEditTeam";
            Text = "AddEditTeam";
            addTeamPanel.ResumeLayout(false);
            addTeamPanel.PerformLayout();
            editTeamPanel.ResumeLayout(false);
            editTeamPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel addTeamPanel;
        private Panel editTeamPanel;
        private Button addTeamHelpButton;
        private Label AddTaskNameLabel;
        private TextBox addNewTeamDescTextBox;
        private Button discardNewTeamButton;
        private Button saveNewTeamButton;
        private TextBox addNewTeamNameTextBox;
        private Label label1;
        private Label label2;
        private Button editTeamHelpButton;
        private Label label5;
        private TextBox editTeamDescTextBox;
        private Button discardEditTeamButton;
        private Button saveEditTeamButton;
        private TextBox editTeamNameTextBox;
        private Label label6;
        private Label label8;
    }
}
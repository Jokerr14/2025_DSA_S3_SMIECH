namespace DSaA_Project_TimeTracker
{
    partial class GenerateReport
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
            generateSummaryReportButton = new Button();
            generateDetailedReportButton = new Button();
            helpButton = new Button();
            checkedListBox = new CheckedListBox();
            label1 = new Label();
            discardButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // generateSummaryReportButton
            // 
            generateSummaryReportButton.Location = new Point(12, 552);
            generateSummaryReportButton.Name = "generateSummaryReportButton";
            generateSummaryReportButton.Size = new Size(213, 36);
            generateSummaryReportButton.TabIndex = 0;
            generateSummaryReportButton.Text = "Generate Summary Report";
            generateSummaryReportButton.UseVisualStyleBackColor = true;
            generateSummaryReportButton.Click += generateSummaryReportButton_Click;
            // 
            // generateDetailedReportButton
            // 
            generateDetailedReportButton.Location = new Point(258, 552);
            generateDetailedReportButton.Name = "generateDetailedReportButton";
            generateDetailedReportButton.Size = new Size(213, 36);
            generateDetailedReportButton.TabIndex = 1;
            generateDetailedReportButton.Text = "Generate Detailed Report";
            generateDetailedReportButton.UseVisualStyleBackColor = true;
            generateDetailedReportButton.Click += generateDetailedReportButton_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(665, 21);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(51, 36);
            helpButton.TabIndex = 2;
            helpButton.Text = "help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(184, 144);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(350, 364);
            checkedListBox.TabIndex = 3;
            checkedListBox.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 126);
            label1.Name = "label1";
            label1.Size = new Size(214, 15);
            label1.TabIndex = 4;
            label1.Text = "Choose employees to generate a report";
            // 
            // discardButton
            // 
            discardButton.Location = new Point(503, 552);
            discardButton.Name = "discardButton";
            discardButton.Size = new Size(213, 36);
            discardButton.TabIndex = 5;
            discardButton.Text = "Cancel";
            discardButton.UseVisualStyleBackColor = true;
            discardButton.Click += discardButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(279, 20);
            label2.Name = "label2";
            label2.Size = new Size(173, 30);
            label2.TabIndex = 6;
            label2.Text = "Generate Report";
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 620);
            Controls.Add(label2);
            Controls.Add(discardButton);
            Controls.Add(label1);
            Controls.Add(checkedListBox);
            Controls.Add(helpButton);
            Controls.Add(generateDetailedReportButton);
            Controls.Add(generateSummaryReportButton);
            Name = "GenerateReport";
            Text = "GenerateReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateSummaryReportButton;
        private Button generateDetailedReportButton;
        private Button helpButton;
        private CheckedListBox checkedListBox;
        private Label label1;
        private Button discardButton;
        private Label label2;
    }
}
namespace DSaA_Project_TimeTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            userViewPanel = new Panel();
            button5 = new Button();
            label3 = new Label();
            adminViewPanel = new Panel();
            button4 = new Button();
            label4 = new Label();
            loginPanel.SuspendLayout();
            userViewPanel.SuspendLayout();
            adminViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(label2);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(button3);
            loginPanel.Controls.Add(button2);
            loginPanel.Controls.Add(button1);
            loginPanel.Controls.Add(textBox2);
            loginPanel.Controls.Add(textBox1);
            loginPanel.Location = new Point(3, 2);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(1258, 668);
            loginPanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(461, 327);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(452, 363);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // button3
            // 
            button3.Location = new Point(471, 493);
            button3.Name = "button3";
            button3.Size = new Size(320, 29);
            button3.TabIndex = 4;
            button3.Text = "Show Admin View - Testing Purposes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(471, 449);
            button2.Name = "button2";
            button2.Size = new Size(320, 29);
            button2.TabIndex = 3;
            button2.Text = "Show User View - Testing Purposes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(575, 393);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(528, 360);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(320, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(528, 327);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 0;
            // 
            // userViewPanel
            // 
            userViewPanel.Controls.Add(button5);
            userViewPanel.Controls.Add(label3);
            userViewPanel.Location = new Point(3, 2);
            userViewPanel.Name = "userViewPanel";
            userViewPanel.Size = new Size(1258, 668);
            userViewPanel.TabIndex = 7;
            userViewPanel.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(575, 99);
            button5.Name = "button5";
            button5.Size = new Size(94, 59);
            button5.TabIndex = 1;
            button5.Text = "Return to Log In";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 66);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 0;
            label3.Text = "Welcome back, ___!";
            // 
            // adminViewPanel
            // 
            adminViewPanel.Controls.Add(button4);
            adminViewPanel.Controls.Add(label4);
            adminViewPanel.Location = new Point(0, 2);
            adminViewPanel.Name = "adminViewPanel";
            adminViewPanel.Size = new Size(1258, 668);
            adminViewPanel.TabIndex = 1;
            adminViewPanel.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(587, 99);
            button4.Name = "button4";
            button4.Size = new Size(94, 59);
            button4.TabIndex = 1;
            button4.Text = "Back to Log in";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 66);
            label4.Name = "label4";
            label4.Size = new Size(208, 20);
            label4.TabIndex = 0;
            label4.Text = "Welcome back, Administrator!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(userViewPanel);
            Controls.Add(loginPanel);
            Controls.Add(adminViewPanel);
            Name = "Form1";
            Text = "Time Tracker - DSaA Project";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            userViewPanel.ResumeLayout(false);
            userViewPanel.PerformLayout();
            adminViewPanel.ResumeLayout(false);
            adminViewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Label label2;
        private Panel userViewPanel;
        private Panel adminViewPanel;
        private Button button4;
        private Label label4;
        private Label label3;
        private Button button5;
    }
}

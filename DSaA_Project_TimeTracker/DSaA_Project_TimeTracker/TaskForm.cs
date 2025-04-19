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
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        // Implementing ShowDialog method
        public new DialogResult ShowDialog()
        {
            // Call the base class's ShowDialog method
            return base.ShowDialog();
        }
    }
}

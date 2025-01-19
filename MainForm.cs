using System;
using System.Windows.Forms;

namespace SchoolAdmin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // You can add any initialization code here if needed
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Students functionality will be implemented here.", "Manage Students", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Reports functionality will be implemented here.", "View Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings functionality will be implemented here.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog before logging out
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide the main form
                LoginForm loginForm = new LoginForm(); // Show the login form
                loginForm.Show();
            }
        }
    }
}

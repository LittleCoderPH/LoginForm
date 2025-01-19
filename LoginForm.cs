using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolAdmin
{
    public partial class LoginForm : Form
    {
        private const string AdminUsername = "admin"; // Admin username
        private const string AdminPassword = "password"; // Admin password

        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form
            panelAnimation.Width = 0; // Start with the panel width at 0 for animation
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Animate the panel width
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10; // Set the interval for the animation
            timer.Tick += new EventHandler((s, args) =>
            {
                if (panelAnimation.Width < this.Width)
                {
                    panelAnimation.Width += 5; // Increase the width of the panel
                }
                else
                {
                    timer.Stop(); // Stop the timer when the panel reaches full width
                }
            });
            timer.Tick += (s, args) =>
            {
                if (panelAnimation.Width < this.Width)
                {
                    panelAnimation.Width += 5; // Increase the width of the panel
                }
                else
                {
                    timer.Stop(); // Stop the timer when the panel reaches full width
                }
            };
            timer.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == AdminUsername && password == AdminPassword)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed to the main application form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System.Windows.Forms;

namespace SchoolAdmin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "School Administration System";
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form
        }
    }
}
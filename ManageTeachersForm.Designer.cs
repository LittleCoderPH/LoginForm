namespace SchoolAdmin
{
    partial class ManageTeachersForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Text = "Manage Teachers";
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; // Center relative to parent
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; // Fixed dialog style
            this.MaximizeBox = false; // Disable maximize button

            // Add controls here (e.g., DataGridView, Buttons, etc.)
            var dataGridView = new System.Windows.Forms.DataGridView
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            };
            this.Controls.Add(dataGridView);
        }
    }
}
namespace POS_project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MessageBox.Show("MainForm Loaded");

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            POS_project.AddProducts myControl = new POS_project.AddProducts();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            POS_project.Reports myControl = new POS_project.Reports();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);
        }

        private void addProducts2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            POS_project.AdminAddCategories myControl = new POS_project.AdminAddCategories();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);
        }

        private void addProducts5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Add your logic for button2 click event here.
            MessageBox.Show("Add Users button clicked!");

            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            POS_project.AddminAddEmp myControl = new POS_project.AddminAddEmp();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add your logic for button1 click event here.
            MessageBox.Show("Dashboard button clicked!");
            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            POS_project.CA_Dashboard myControl = new POS_project.CA_Dashboard();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            // Add your logic for the Dashboard load event here.
            //MessageBox.Show("Dashboard loaded!");
        }
    }
}

namespace POS_project
{
    public partial class MainForm : Form
    {
        // 1. Add a class-level variable to store the previously clicked button
        private Button previouslyClickedButton = null;

        // 2. Define your default and highlight colors as class-level variables
        // The default background of your buttons is likely the white background of panel1.
        private Color defaultButtonBackColor = Color.White;
        // The highlight color from your screenshot (image_4a2842.png)
        // appears to be a light blue/teal shade.
        private Color highlightedButtonBackColor = System.Drawing.Color.FromArgb(173, 216, 230); // A light blue color

        public MainForm()
        {
            InitializeComponent();

            // Set initial content for panel3
            panel3.Controls.Clear();
            POS_project.CA_Dashboard myControl = new POS_project.CA_Dashboard();
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);

            // 3. Highlight the initial active button when the form loads
            // Assuming button1 (Dashboard) is the default view.
            HighlightButton(btnDashboard); // Highlight button1 on form startup
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Any other load-specific logic can go here.
        }

        private void HighlightButton(Button activeButton)
        {
            // 4. Reset the background color of the previously clicked button
            // Only reset if there was a previous button and it's not the current active button
            if (previouslyClickedButton != null && previouslyClickedButton != activeButton)
            {
                previouslyClickedButton.BackColor = defaultButtonBackColor;
                // If you also change the ForeColor (text color) on highlight, reset it here too.
                // Based on CashierForm.Designer.cs, the button ForeColor is Teal.
                // previouslyClickedButton.ForeColor = Color.Teal;
            }

            // 5. Highlight the active button
            if (activeButton != null)
            {
                activeButton.BackColor = highlightedButtonBackColor;
                // If you want to change the ForeColor for contrast, do it here.
                // activeButton.ForeColor = Color.White; // Example: white text on highlighted button

                // 6. Update the tracking variable to the current active button
                previouslyClickedButton = activeButton;
            }
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
            HighlightButton(btnProduct); // Apply highlight
            panel3.Controls.Clear();
            POS_project.AddProducts myControl = new POS_project.AddProducts();
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HighlightButton(btnReports); // Apply highlight
            panel3.Controls.Clear();
            POS_project.Reports myControl = new POS_project.Reports();
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        private void addProducts2_Load(object sender, EventArgs e)
        {
            // Existing logic if any
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HighlightButton(btnCategory); // Apply highlight
            panel3.Controls.Clear();
            POS_project.AdminAddCategories myControl = new POS_project.AdminAddCategories();
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        private void addProducts5_Load(object sender, EventArgs e)
        {
            // Existing logic if any
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HighlightButton(btnUsers); // Apply highlight
            panel3.Controls.Clear();
            POS_project.AddminAddEmp myControl = new POS_project.AddminAddEmp();
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HighlightButton(btnDashboard); // Apply highlight
            panel3.Controls.Clear();
            POS_project.CA_Dashboard myControl = new POS_project.CA_Dashboard();
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {
            // Add your logic for the Dashboard load event here.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Existing logic if any
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Existing logic if any
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            // Existing logic if any
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Existing logic if any
        }

        private void label1_Click_2(object sender, EventArgs e)
        {


            if (this.WindowState == FormWindowState.Normal)
            {
                // If the form is currently normal, maximize it
                this.WindowState = FormWindowState.Maximized;
                // Optional: Change button text/image to indicate "Restore Down"
                // btnMaximizeRestore.Text = "🗗"; // Restore Down character
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                // If the form is currently maximized, restore it to normal
                this.WindowState = FormWindowState.Normal;
                // Optional: Change button text/image back to "Maximize"
                // btnMaximizeRestore.Text = "🗖"; // Maximize character
            }
            // If you also have a minimize button, you might want to handle FormWindowState.Minimized
            // if (this.WindowState == FormWindowState.Minimized) { /* Do something if minimized */ }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Set the form's WindowState to Minimized
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
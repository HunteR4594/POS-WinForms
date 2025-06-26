namespace POS_project
{
    public partial class CashierForm : Form
    {
        private int _currentCashierId;
        private string _currentCashierUsername;

        // 1. Add a class-level variable to store the previously clicked button
        private Button previouslyClickedButton = null;

        // 2. Define your default and highlight colors as class-level variables
        // The default background of your buttons is likely the white background of panel1.
        private Color defaultButtonBackColor = Color.White;
        // The highlight color from your screenshot (image_4a2842.png)
        // appears to be a light blue/teal shade.
        private Color highlightedButtonBackColor = System.Drawing.Color.FromArgb(173, 216, 230); // A light blue color

        public CashierForm(int cashierId, string cashierUsername)
        {
            InitializeComponent();
            _currentCashierId = cashierId;
            _currentCashierUsername = cashierUsername;

            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel

            // Pass the required 'cashierId' parameter to the constructor
            POS_project.CashierOrder myControl = new POS_project.CashierOrder(_currentCashierId);
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);

            // 3. Highlight the initial active button when the form loads
            // For example, if 'Order' (button3) is the default view on load:
            HighlightButton(button3);
        }

        private void HighlightButton(Button activeButton)
        {
            // 4. Reset the background color of the previously clicked button
            // Only reset if there was a previous button and it's not the current active button
            if (previouslyClickedButton != null && previouslyClickedButton != activeButton)
            {
                previouslyClickedButton.BackColor = defaultButtonBackColor;
                // If you also change the ForeColor (text color) on highlight, reset it here too.
                // previouslyClickedButton.ForeColor = Color.Teal; // Based on your designer file
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
                Form1 loginForm1 = new Form1();
                this.Close();
                loginForm1.Show();
            }
        }

        // Order Button
        private void button3_Click(object sender, EventArgs e)
        {
            HighlightButton(button3);
            panel3.Controls.Clear();
            POS_project.CashierOrder myControl = new POS_project.CashierOrder(_currentCashierId);
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HighlightButton(button5);
            panel3.Controls.Clear();
            POS_project.CA_Inventory myControl = new POS_project.CA_Inventory();
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HighlightButton(button4);
            panel3.Controls.Clear();
            Customer_Transaction myControl = new Customer_Transaction(_currentCashierId);
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }

        // Add a click handler for button1 (Dashboard) if it's part of the navigation
        // and you want it to participate in the highlighting scheme.


        private void label3_Click(object sender, EventArgs e)
        {
            // Existing logic if any
        }

        private void label1_Click(object sender, EventArgs e)
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
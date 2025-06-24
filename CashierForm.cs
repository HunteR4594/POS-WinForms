namespace POS_project
{
    public partial class CashierForm : Form
    {
        private int _currentCashierId;
        private string _currentCashierUsername;

        public CashierForm(int cashierId, string cashierUsername)
        {
            InitializeComponent();
            _currentCashierId = cashierId;
            _currentCashierUsername = cashierUsername;
            MessageBox.Show("CashierForm Loaded");

            // Optionally, display the cashier's username on the form, e.g., in a label
            // cashierNameLabel.Text = _currentCashierUsername;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void cashierOrder1_Load(object sender, EventArgs e)
        {

        }

        //Order Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Add your logic for button2 click event here.
            MessageBox.Show("Add Users button clicked!");

            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel

            // Pass the required 'cashierId' parameter to the constructor
            POS_project.CashierOrder myControl = new POS_project.CashierOrder(_currentCashierId);
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel
            POS_project.CA_Inventory myControl = new POS_project.CA_Inventory();
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);
        }
    }
}

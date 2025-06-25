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

            // IMPORTANT: Replace 'pnlContentArea' with the actual name of your main content panel
            panel3.Controls.Clear(); // Clear any existing control in the main content panel

            // Pass the required 'cashierId' parameter to the constructor
            POS_project.CashierOrder myControl = new POS_project.CashierOrder(_currentCashierId);
            myControl.Dock = DockStyle.Fill; // Optional: Fill the panel
            panel3.Controls.Add(myControl);
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

        //Order Button
        private void button3_Click(object sender, EventArgs e)
        {


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

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Customer_Transaction myControl = new Customer_Transaction(_currentCashierId);
            myControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(myControl);
        }
    }
}

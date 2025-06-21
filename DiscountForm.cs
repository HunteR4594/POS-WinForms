namespace POS_project
{
    public partial class DiscountForm : Form
    {
        // Public properties to get the selected discount type and value after the form closes
        public string SelectedDiscountType { get; set; } // Will be "Cash" or "Percent"
        public double DiscountValue { get; set; }

        // Add the following property to resolve the error
        public double AmountPaid { get; set; } // Represents the amount paid by the customer
        public double Change { get; set; }


        public DiscountForm()
        {
            InitializeComponent();
            // Set a default selection and prompt text when the form loads
            rbCashDiscount.Checked = true; // Default to Cash Discount
            lblDiscountValuePrompt.Text = "Cash Value (per unit):"; // Default prompt
            this.Text = "Apply Discount"; // Set form title
        }

        // Event handler for the Apply button
        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            // Validate the entered discount value
            if (!double.TryParse(txtDiscountValue.Text, out double value) || value < 0)
            {
                MessageBox.Show("Please enter a valid positive numeric discount value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine which discount type was selected and set the public properties
            if (rbCashDiscount.Checked)
            {
                SelectedDiscountType = "Cash";
                DiscountValue = value;
            }
            else if (rbPercentDiscount.Checked)
            {
                // For percentage, ensure the value is not over 100%
                if (value > 100)
                {
                    MessageBox.Show("Percentage discount cannot exceed 100%.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SelectedDiscountType = "Percent";
                DiscountValue = value;
            }
            else
            {
                // If neither radio button is checked (shouldn't happen with a default)
                MessageBox.Show("Please select a discount type (Cash or Percent).", "Select Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Set DialogResult to OK and close the form if validation passes
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Event handler for the Cancel button
        private void btnCancelDiscount_Click(object sender, EventArgs e)
        {
            // Set DialogResult to Cancel and close the form
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Event handlers to update the prompt text based on radio button selection
        private void rbCashDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCashDiscount.Checked)
            {
                lblDiscountValuePrompt.Text = "Cash Value (per unit):";
            }
        }

        private void rbPercentDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPercentDiscount.Checked)
            {
                lblDiscountValuePrompt.Text = "Percent Value (%):";
            }
        }
    }
}

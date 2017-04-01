using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Invoice
{
    public partial class NewWorkOrderForm : Form
    {
        public NewWorkOrderForm()
        {
            InitializeComponent();
        }
        
        // Save values into the project DB
        private void saveInvoiceButton_Click(object sender, EventArgs e)
        {
            DisplayTooltips();
        }

        // Set the invoice fields to be empty
        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            newInvoiceFirstNameTextBox.Text = null;
            newInvoiceLastNameTextBox.Text = null;
            newInvoiceStreetAddressTextBox.Text = null;
            newInvoicePrimaryPhoneNumberTextBox.Text = null;
            newInvoicePrimaryPhoneExtensionTextBox.Text = null;
            newInvoiceAlternatePhoneNumberTextBox.Text = null;
            newInvoiceAlternatePhoneExtensionTextBox.Text = null;
            newInvoiceEmailTextBox.Text = null;

            newInvoiceDescriptionOfRequestRichTextBox.Text = null;

            newInvoiceCommunityComboBox.DisplayMember = null;
            newInvoiceRequestTimeOfServiceComboBox.DisplayMember = null;
            newInvoicePrimaryPhoneTypeComboBox.DisplayMember = null;
            newInvoiceAlternatePhoneTypeComboBox.DisplayMember = null;
            newInvoiceWorkOrderTypeComboBox.DisplayMember = null;
            newInvoicePermissionToEnterComboBox.DisplayMember = null;
            newInvoiceAnimalsInHomeComboBox.DisplayMember = null;
        }

        // Close the NewWorkOrder form, and move back to the WorkOrderForm
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            WorkOrderForm workOrder = new WorkOrderForm();
            workOrder.Show();
        }

        // Save WorkOrderInfo Method saves the values entered into the ProjectDB
        private void SaveWorkOrderInfo()
        {
            // Primary phone number variables
            short primaryPhoneNumber;
            string primaryPhoneNum = newInvoicePrimaryPhoneNumberTextBox.Text.Trim();
            // Alternate phone number variables
            short alternatePhoneNumber;
            string alternatePhoneNum = newInvoiceAlternatePhoneNumberTextBox.Text.Trim();
            // Incrementory value 
            int i = 0;

            // Save String Values into the Customer table
            MySqlCommand saveOccupant = new MySqlCommand("INSERT INTO customer (first, last, address, community_name, "
                + "email, primary_phone_type) VALUES (" +
                newInvoiceFirstNameTextBox.Text.ToLower() + "," + newInvoiceLastNameTextBox.Text.ToLower() +
                "," + newInvoiceStreetAddressTextBox.Text.ToLower() +
                "," + newInvoiceCommunityComboBox.SelectedItem.ToString().ToLower() +
                "," + newInvoiceEmailTextBox.Text.ToLower() +
                "," + newInvoicePrimaryPhoneTypeComboBox.SelectedItem.ToString().ToLower() + ");");

            // Save the String Values into the InvoiceStatus table
            MySqlCommand saveInvoiceStatus = new MySqlCommand("INSERT INTO invoiceStatus (invoice_type, description, " +
                "complete, timeOfService) VALUES (" +
                newInvoiceWorkOrderTypeComboBox.SelectedItem.ToString().ToLower() +
                "," + newInvoiceDescriptionOfRequestRichTextBox.Text.ToString().ToLower() +
                ",false," + newInvoiceRequestTimeOfServiceComboBox.SelectedItem.ToString().ToLower() + ");");

            // Check if the primary phone number is valid and add to database or display tooltip message and focus the textbox
            if (IsValidPrimaryPhoneNumber(primaryPhoneNum))
            {
                Int16.TryParse(primaryPhoneNum, out primaryPhoneNumber);
                MySqlCommand saveOccupantPrimaryPhone = new MySqlCommand("INSERT INTO customer (primary#) VALUES (" +
                    primaryPhoneNumber + ");");

                // increment i to show something happened.
                i += saveOccupantPrimaryPhone.ExecuteNonQuery();

                // Check if the Alternate Phone Number textbox is not empty
                if (!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
                {
                    // Check if Alternate phone number is valid
                    if (IsValidPrimaryPhoneNumber(alternatePhoneNum))
                    {
                        Int16.TryParse(alternatePhoneNum, out alternatePhoneNumber);
                        MySqlCommand saveOccupantAlternatePhone = new MySqlCommand("INSERT INTO customer (alternate_phone#) VALUES (" +
                            alternatePhoneNumber + ");");

                        // increment i to show something happened
                        i += saveOccupantAlternatePhone.ExecuteNonQuery();
                    }
                    else
                    {
                        newInvoiceAlternatePhoneNumberTextBox.Focus();
                        ToolTip wrongFormat = new ToolTip();
                        wrongFormat.Show("Please use the correct format 9999999999", newInvoiceAlternatePhoneNumberTextBox, 10000);
                    }
                }
            }
            else
            {
                newInvoicePrimaryPhoneNumberTextBox.Focus();
                ToolTip wrongFormat = new ToolTip();
                wrongFormat.Show("Please use the correct format 9999999999", newInvoicePrimaryPhoneNumberTextBox, 10000);
            }

            // Check if user selected yes or no for the permission to enter combobox
            if (newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                MySqlCommand pte = new MySqlCommand("INSERT INTO customer (permission_to_enter) VALUES (true);");
                i += pte.ExecuteNonQuery();
            }
            else
            {
                MySqlCommand pteNeg = new MySqlCommand("INSERT INTO customer (permission_to_enter) VALUES (false);");
                i += pteNeg.ExecuteNonQuery();
            }
            
            // Check if the user selected yes or no for the AnimalsInHome combobox
            if (newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                MySqlCommand pets = new MySqlCommand("INSERT INTO customer (pets) VALUES (true);");
                i += pets.ExecuteNonQuery();
            }
            else
            {
                MySqlCommand petsNeg = new MySqlCommand("INSERT INTO customer (pets) VALUES (false);");
                i += petsNeg.ExecuteNonQuery();
            }

            i += saveOccupant.ExecuteNonQuery();
            i += saveInvoiceStatus.ExecuteNonQuery();
        }

        // Check if the phone number is valid
        private bool IsValidPrimaryPhoneNumber(string num)
        {
            // To hold the valid length
            const int VALID_LENGTH = 10;
            // To hold true/false
            bool valid = true;

            // Check if num = valid length, and if right format
            if (num.Length == VALID_LENGTH)
            {
                foreach (char ch in num)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }
        
        // Display Tooltips Method creates a tooltip over the items that are required
        private void DisplayTooltips()
        {
            // Display Tooltips if user hasn't entered in information 
            if (string.IsNullOrEmpty(newInvoiceFirstNameTextBox.Text))
            {
                ToolTip req = new ToolTip();
                req.Show("Please enter First Name", newInvoiceFirstNameTextBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoiceLastNameTextBox.Text))
            {
                ToolTip req1 = new ToolTip();
                req1.Show("Please enter Last Name", newInvoiceLastNameTextBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoiceStreetAddressTextBox.Text))
            {
                ToolTip req2 = new ToolTip();
                req2.Show("Please enter Street Address", newInvoiceStreetAddressTextBox, 10000);
            }
            if (newInvoiceCommunityComboBox.SelectedItem == null)
            {
                ToolTip req3 = new ToolTip();
                req3.Show("Please select a Community", newInvoiceCommunityComboBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
            {
                ToolTip req4 = new ToolTip();
                req4.Show("Please enter Phone Number (ex: ##########)", newInvoicePrimaryPhoneNumberTextBox, 10000);
            }
            if (newInvoicePrimaryPhoneTypeComboBox.SelectedItem == null)
            {
                ToolTip req5 = new ToolTip();
                req5.Show("Please select Phone Type", newInvoicePrimaryPhoneTypeComboBox, 10000);
            }
            if (!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
            {
                if (newInvoiceAlternatePhoneTypeComboBox.SelectedItem == null)
                {
                    ToolTip altReq = new ToolTip();
                    altReq.Show("Please select Alternate Phone Type", newInvoiceAlternatePhoneTypeComboBox, 10000);
                }
            }
            if (string.IsNullOrEmpty(newInvoiceEmailTextBox.Text))
            {
                ToolTip req6 = new ToolTip();
                req6.Show("Please enter an email address", newInvoiceEmailTextBox, 10000);
            }
            if (newInvoiceWorkOrderTypeComboBox.SelectedItem == null)
            {
                ToolTip req7 = new ToolTip();
                req7.Show("Please select Work Order Type", newInvoiceWorkOrderTypeComboBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
            {
                ToolTip req8 = new ToolTip();
                req8.Show("Please describe what you need, including the location", newInvoiceDescriptionOfRequestRichTextBox, 10000);
            }
            if (newInvoiceRequestTimeOfServiceComboBox.SelectedItem == null)
            {
                ToolTip req9 = new ToolTip();
                req9.Show("Please select Time of Service", newInvoiceRequestTimeOfServiceComboBox, 10000);
            }
            if (newInvoicePermissionToEnterComboBox.SelectedItem == null)
            {
                ToolTip req10 = new ToolTip();
                req10.Show("Please select Yes/No", newInvoicePermissionToEnterComboBox, 10000);
            }
            if (newInvoiceAnimalsInHomeComboBox.SelectedItem == null)
            {
                ToolTip req11 = new ToolTip();
                req11.Show("Please select Yes/No", newInvoiceAnimalsInHomeComboBox, 10000);
            }
        }
    }
}

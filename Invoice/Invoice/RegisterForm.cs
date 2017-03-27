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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        /**
         *  Connection to our MySQL Database "invoicelogin" which is located on the abcabasketball.com server (for now). 
         */
        MySqlConnection connection = new MySqlConnection("server=abcabasketball.com;database=abcaba5_invoicelogin;uid=abcaba5;password=test1");

        private void registerButton_Click(object sender, EventArgs e)
        {
            RadioButton[] rb = new RadioButton[] { occupantRadioButton, officeWorkerRadioButton, contractorRadioButton };

            var checkedButton = panel1.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            /**
             * 1) emailCheck is the regular expression for our email field. 
             * 2) passwordCheck is the regular expression for our password field. Youa are required to have a password that is at minimum 6 characters long with at least one lowercase letter, one uppercase letter, and one number.  
             */
            string emailCheck = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string passwordCheck = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z]{6,}$";

            /**
             * Checks the email & password using the RegularExpressions from above, confirms that your entered password matches what you entered when asked to confirm it, and checks that the email you entered has not been used previously. 
             * */
            if (Regex.IsMatch(emailEntryTextBox.Text, emailCheck) && Regex.IsMatch(passwordEntryTextBox.Text, passwordCheck) && passwordEntryTextBox.Text == confirmPasswordEntryTextBox.Text && emailAvailable() && rb.Any(radio => radio.Checked))
            {

                /**
                 *  MySQLCommand that will be used to insert the entered first name, last name, email, password, and usertype into the User table into the invoicelogin database. 
                 */
                MySqlCommand cmd = new MySqlCommand("insert into User values ('" + 0 + "', '" + firstNameEntryTextBox.Text + "', '" + lastNameEntryTextBox.Text + "', '" + emailEntryTextBox.Text.ToLower() + "', '" + passwordEntryTextBox.Text + "', '" + checkedButton.Text + "', '" + 0 + "')", connection);

                /**
                 * Opens a connection to the MySQL Database 
                 */
                connection.Open();

                /**
                 * Executes the above SQL Statement as well as returns an integer of rows that were affected. As long as this value is higher than 0 we know that we have inserted the information & added a new row to the User table. 
                 * */
                int i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i > 0)
                {
                    MessageBox.Show("Registration Successful");
                }
            }

            /**
             * If the email that was entered does not meet our requirements then MessageBox will inform you that your entered email is invalid
             */
            else if (!Regex.IsMatch(emailEntryTextBox.Text, emailCheck))
            {
                MessageBox.Show("Email is invalid");
            }

            /**
             * If the password that was entered does not meet our requirements then a MessageBox will inform you that you entered password does not meet the requirements
             */
            else if (!Regex.IsMatch(passwordEntryTextBox.Text, passwordCheck))
            {
                MessageBox.Show("Password does not meet all requirements \n 1) Password Must Be At Minimum 6 Characters\n 2) Password Must Contain At Least One Uppercase Letter\n 3) Password Must Contain At Least One Lowercase Letter\n 4) Password Must Contain At Least One Number");
            }
            /**
             * If the passwords that were entered in the password & confirm password texboxes don't match then a MessageBox will inform you that the passwords do not match.  
             */
            else if (passwordEntryTextBox.Text != confirmPasswordEntryTextBox.Text)
            {
                MessageBox.Show("Passwords Do Not Match");
                passwordEntryTextBox.Clear();
                confirmPasswordEntryTextBox.Clear();
                passwordEntryTextBox.Focus();
            }
            /**
             *  If the email has already been used to register then a MessageBox will inform you that it is already in use.   
             */
            else if (!emailAvailable())
            {
                MessageBox.Show("Email already in use");
            }
            /**
             * If the registering user hasn't selected a user type then they are informed via a message box that they have to select one.
             */
            else if (!rb.Any(radio => radio.Checked))
            {
                MessageBox.Show("No User Type Selected");
            }

        }

        /**
         * Method to check if the entered email is already in use. 
         */
        private bool emailAvailable()
        {
            bool available = false;
            connection.Open();

            MySqlCommand cmd = new MySqlCommand("select email from User where email='" + emailEntryTextBox.Text.ToLower() + "'", connection);
            MySqlDataAdapter data = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();

            data.Fill(table);
            if (table.Rows.Count > 0)
            {
                available = false;
            }
            else
            {
                available = true;
            }
            connection.Close();
            return available;
        }

        /**
         * Closes the application.  
         */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Returns application to the Login Form
         */
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}

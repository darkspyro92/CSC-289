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

namespace Invoice
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /**
         * Clicking the register button will open up a new registration form
         * */
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        /**
         *  Closes the application
         */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Checks Login creditials to determine if you can login
         */
        private void loginButton_Click(object sender, EventArgs e)
        {
            /**
             * If the email field is empty then a tooltip informs you that you need to enter an email address. 
             */
            if (string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                ToolTip tip = new ToolTip();
                tip.Show("Please Enter An Email Address", emailEntryTextBox, 10000);
            }
            /**
             * If the password field is empty then a tooltip informs you that you need to enter a password.
             */
            if(string.IsNullOrEmpty(passwordEntryTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter A Password", passwordEntryTextBox, 10000);
            }
            /**
             * If both fields are filled then a connection to the invoicelogin will be established.  
             */
            else if(!string.IsNullOrEmpty(passwordEntryTextBox.Text) && !string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                MySqlConnection connection = new MySqlConnection("server=abcabasketball.com;database=abcaba5_invoicelogin;uid=abcaba5;password=test1");
                connection.Open();

                /**
                 * MySQLCommand that will be used to query the database using the entered email and password
                 */
                MySqlCommand command = new MySqlCommand("Select email, password from User where email='" + emailEntryTextBox.Text.ToLower() + "'and password='" + passwordEntryTextBox.Text + "'", connection);

                /**
                 *  Fill the DataTable with results from the query. 
                 *  If the table has at least one row then that means the login information entered was that of a registered user and login was successful.
                 *  In the future logging successfully will result in you being taken to another form. For now you are only informed of your successful login. 
                 *  If the table has no rows, then either your email-password combination could not be found in our records and the login was unsuccessful. 
                 * */
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                data.Fill(table);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful!");

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

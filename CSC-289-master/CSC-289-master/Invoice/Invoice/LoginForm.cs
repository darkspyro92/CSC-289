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

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                ToolTip tip = new ToolTip();
                tip.Show("Please Enter A Email Address", emailEntryTextBox, 10000);
            }
            if(string.IsNullOrEmpty(passwordEntryTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter A Password", passwordEntryTextBox, 10000);
            }
            else if(!string.IsNullOrEmpty(passwordEntryTextBox.Text) && !string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                MySqlConnection connection = new MySqlConnection("server=abcabasketball.com;database=abcaba5_invoicelogin;uid=abcaba5;password=test1");
                connection.Open();

                MySqlCommand command = new MySqlCommand("Select email, password from User where email='" + emailEntryTextBox.Text + "'and password='" + passwordEntryTextBox.Text + "'", connection);
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
    }
}

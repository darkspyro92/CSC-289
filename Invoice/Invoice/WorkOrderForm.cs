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
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();
        }

        // Get user information to determine what to display
        private static void GetUserInfo()
        {
            MySqlConnection connection = new MySqlConnection("server=abcabasketball.com;database=abcaba5_invoicelogin;uid=abcaba5;password=test1");
            connection.Open();
        }

        private void newInvoiceButton_Click(object sender, EventArgs e)
        {
            NewWorkOrderForm newWorkOrder = new NewWorkOrderForm();
            newWorkOrder.Show();
            this.Hide();
        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void invoiceInformationCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

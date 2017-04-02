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
        Bitmap bit;

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            // Creates the bitmap that is the same size as the groupbox
            Graphics graphics = invoiceInformationGroupBox.CreateGraphics();
            Size size = invoiceInformationGroupBox.ClientSize;
            bit = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bit);

            // Copy the area of the screen that the groupbox covers
            Point grpbxLocation = PointToScreen(invoiceInformationGroupBox.Location);
            graphics.CopyFromScreen(grpbxLocation.X, grpbxLocation.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;

            // Show Print Preview 
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void invoiceInformationCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit, e.MarginBounds);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class InvoiceDatabaseForm : Form
    {
        public InvoiceDatabaseForm()
        {
            InitializeComponent();
        }

        Bitmap bit;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit, e.MarginBounds);
        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            // Adds a panel control
            Panel panel = new Panel();
            this.Controls.Add(panel);

            // Creates the bitmap that is the same size as the form
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bit = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bit);

            // Copy the area of the screen that the Panel covers
            Point panelLocation = PointToScreen(panel.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, size); printPreviewDialog1.Document = printDocument1;

            // Show Print PReview 
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void InvoiceDatabaseForm_Load(object sender, EventArgs e)
        {
        }
    }
}

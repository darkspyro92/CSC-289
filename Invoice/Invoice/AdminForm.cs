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
using System.Data.OleDb;

namespace Invoice
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        MySqlConnection connection = new MySqlConnection("server=abcabasketball.com;database=abcaba5_invoicelogin;uid=abcaba5;password=test1");
        OleDbConnection connection2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb");
        OleDbDataAdapter adapter;
        DataSet ds;
        private void confirmAccountButton_Click(object sender, EventArgs e)
        {
            string data = "";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell clmSelect = new DataGridViewCheckBoxCell();
                clmSelect = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                if (clmSelect.Value != null &&
                       Convert.ToBoolean(clmSelect.Value) == true)
                {
                    data += (dataGridView1.Rows[i].Cells[1].Value.ToString()) + ",";
                }
            }
            data = data.TrimEnd(',');
            string updatesql = "UPDATE User SET confirmed=1 WHERE id in (" + data + ")";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(updatesql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    string update = "SELECT * FROM User";

                    MySqlDataAdapter userAdapter = new MySqlDataAdapter(update, connection);
                    DataTable users = new DataTable();
                    users.Clear();
                    userAdapter.Fill(users);

                    if (users.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = users;
                    }
                }
                else
                {
                    MessageBox.Show("Please Select An Item");
                    return;
                }
            }



        }

        private void showUnconfirmedAccountsButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            dataGridView1.Show();

            connection.Open();
            string unconfirmedsql = "SELECT * FROM User WHERE confirmed=0";
            MySqlDataAdapter unconfirmedAdapter = new MySqlDataAdapter(unconfirmedsql, connection);
            DataTable users = new DataTable();
            users.Clear();
            unconfirmedAdapter.Fill(users);

            if (users.Rows.Count > 0)
            {
                dataGridView1.DataSource = users;
            }
            connection.Close();
        }

        private void showAllAccountsButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            dataGridView1.Show();

            connection.Open();
            string allsql = "SELECT * FROM User";
            MySqlDataAdapter allAdapter = new MySqlDataAdapter(allsql, connection);
            DataTable users = new DataTable();
            users.Clear();
            allAdapter.Fill(users);

            if (users.Rows.Count > 0)
            {
                dataGridView1.DataSource = users;
            }
            connection.Close();
        }

        private void showAllInvoiceButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Show();
            connection2.Open();
            string allinvoice = "SELECT * FROM Invoice";
            adapter = new OleDbDataAdapter(allinvoice, connection2);
            ds = new DataSet();
            adapter.Fill(ds, "Invoices");
            dataGridView2.DataSource = ds.Tables[0];

            connection2.Close();
        }

        private void updateInvoiceButton_Click_1(object sender, EventArgs e)
        {
            OleDbCommandBuilder cmdbl = new OleDbCommandBuilder(adapter);
            adapter.Update(ds, "Invoices");
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            dataGridView1.Show();
            connection.Open();
            string data = "";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell clmSelect = new DataGridViewCheckBoxCell();
                clmSelect = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                if (clmSelect.Value != null &&
                       Convert.ToBoolean(clmSelect.Value) == true)
                {
                    data += (dataGridView1.Rows[i].Cells[1].Value.ToString()) + ",";
                }
            }

            data = data.TrimEnd(',');

            string deletesql = "DELETE FROM User WHERE id in (" + data + ")";

            MySqlCommand cmd = new MySqlCommand(deletesql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            string update = "SELECT * FROM User";

            MySqlDataAdapter userAdapter = new MySqlDataAdapter(update, connection);
            DataTable users = new DataTable();
            users.Clear();
            userAdapter.Fill(users);

            if (users.Rows.Count > 0)
            {
                dataGridView1.DataSource = users;
            }
        }
    }
}

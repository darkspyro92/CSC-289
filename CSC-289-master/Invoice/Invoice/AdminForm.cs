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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abcaba5_invoiceloginDataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter1.Fill(this.abcaba5_invoiceloginDataSet2.User);
        }
        MySqlConnection connection = new MySqlConnection("server=abcabasketball.com;database=abcaba5_invoicelogin;uid=abcaba5;password=test1");

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
            MessageBox.Show(data);
            string updatesql = "UPDATE User SET confirmed=1 WHERE id in (" + data + ")";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(updatesql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            string update = "SELECT * FROM User";

            MySqlDataAdapter userAdapter = new MySqlDataAdapter(update, connection);
            DataTable users = new DataTable();
            users.Clear();
            userAdapter.Fill(users);

            if(users.Rows.Count > 0)
            {
                dataGridView1.DataSource = users;
            }

            
        }

        private void showUnconfirmedAccountsButton_Click(object sender, EventArgs e)
        {
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
    }
}

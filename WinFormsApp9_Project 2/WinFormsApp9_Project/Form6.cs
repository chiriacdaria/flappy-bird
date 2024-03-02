using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9_Project
{

    public partial class Form6 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VS6LDVR\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");

        public Form6()
        {
            InitializeComponent();
            DisplayTopThreeUsers();
        }

        private void DisplayTopThreeUsers()
        {
            try
            {
                conn.Open();
                string query = "SELECT username, highestScore FROM LoginGame ORDER BY highestScore DESC";
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured: " + e.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}

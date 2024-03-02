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
    public partial class Form8 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VS6LDVR\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");

        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                conn.Open();
                string username = ((Form1)Application.OpenForms["Form1"]).GetUsername();
                string password = textBox1.Text;
                string sql = "UPDATE LoginGame SET password=@password WHERE  username= '" + username + "'";

                SqlCommand command = new SqlCommand(sql, conn);

                command.Parameters.AddWithValue("@password", password);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Password updated");
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("The password does not match!", "Error");
            }
        }
    }
}

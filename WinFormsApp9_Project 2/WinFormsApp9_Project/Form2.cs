using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp9_Project
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VS6LDVR\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Unvalid data!", "ERR0R");
            }
            else
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into [LoginGame] values(@username, @password, @highestScore)";
                cmd.Connection = conn;
                if (textBox2.Text == textBox3.Text)
                {
                    cmd.Parameters.AddWithValue("username", textBox1.Text);
                    cmd.Parameters.AddWithValue("password", textBox2.Text);
                    cmd.Parameters.AddWithValue("highestScore", 0);

                    textBox1.Text = "";
                    textBox2.Text = "";
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Account added");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords does not match");
                }
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

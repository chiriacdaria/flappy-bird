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
    public partial class Form9 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VS6LDVR\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                conn.Open();
                string username = textBox4.Text;
                string password = textBox1.Text;
                string oldPassword = textBox3.Text;

                string verifySql = "SELECT COUNT(*) FROM LoginGame WHERE username = @username AND password = '" + oldPassword + "'";

                SqlCommand verifyCommand = new SqlCommand(verifySql, conn);
                verifyCommand.Parameters.AddWithValue("@username", username);
                verifyCommand.Parameters.AddWithValue("@password", oldPassword);


                int usernameCount = (int)verifyCommand.ExecuteScalar();

                if (usernameCount > 0)
                {
                    if (textBox1.Text == textBox2.Text)
                    {
                        string sql = "UPDATE LoginGame SET password=@password WHERE  username= '" + username + "'";

                        SqlCommand command = new SqlCommand(sql, conn);

                        command.Parameters.AddWithValue("@password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password reseted");
                        }

                    }
                    else
                    {
                        MessageBox.Show("The password does not match!", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect old password or username does not exist!", "Error");
                }
                conn.Close();
            }
        }
    }

}
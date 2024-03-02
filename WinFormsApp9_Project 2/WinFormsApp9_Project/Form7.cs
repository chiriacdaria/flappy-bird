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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp9_Project
{
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VS6LDVR\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");

        public Form7()
        {
            InitializeComponent();
            button3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            conn.Open();
            string username = ((Form1)Application.OpenForms["Form1"]).GetUsername();
            SqlCommand deleteCommand = new SqlCommand();
            deleteCommand.CommandText = "DELETE from LoginGame WHERE  username= '" + username + "'";
            deleteCommand.Connection = conn;
            int a = deleteCommand.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Account Deleted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 form = new Form8();
            form.Show();
            this.Hide();
        }
    }
}

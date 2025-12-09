using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text.Trim();
            string password = txtpwd.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            // Updated connection string: no password for root
            string connectionString = "server=localhost;user id=root;password=;database=login;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT * FROM loginTable WHERE username=@user AND pwd=@pass";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login Successful!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtuser_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtuser.Text == "Username")
            {
                txtuser.Clear();
            }

        }

        private void txtpwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpwd.Text == "Password")
            {
                txtpwd.Clear();
                txtpwd.PasswordChar = '*';
            }
        }

        private void insta_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.instagram.com/",
                UseShellExecute = true
            });
        }

        private void wtsp_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://web.whatsapp.com/",
                UseShellExecute = true
            });
        }

        private void fb_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://web.facebook.com/profile.php?id=100085644737224&sk=about",
                UseShellExecute = true
            });
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        // Implemented signup handler (Designer previously threw NotImplementedException)
        private void Signup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign up is not implemented in this build.");
        }
    }
}

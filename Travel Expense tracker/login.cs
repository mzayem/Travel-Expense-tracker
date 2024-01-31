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
using System.Xml.Linq;


namespace Travel_Expense_tracker
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=travelExpenses;Integrated Security=true";

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void username_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lgn_username.Text) || lgn_username.Text == "Username")
            {
                errorname.SetError(lgn_username, "Please enter your username!!");
                lgn_username.ForeColor = Color.Gray;
                lgn_username.Text = "Username"; 
            }
            else
            {
                errorname.Clear();
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (lgn_username.Text == "Username")
            {
                lgn_username.Text = "";
                lgn_username.ForeColor = Color.Black;
            }
        }

        private void userPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userPass.Text) || userPass.Text == "Password")
            {
                errorPass.SetError(userPass, "Please enter at least one uppercase, one lowercase, one number, and one special character!!");
                userPass.ForeColor = Color.Gray;
                userPass.UseSystemPasswordChar = false;
                userPass.Text = "Password";
            }
            else
            {
                errorPass.Clear();
            }
        }

        private void userPass_Enter(object sender, EventArgs e)
        {
            if (userPass.Text == "Password")
            {
                userPass.Text = "";
                userPass.ForeColor = Color.Black;
                userPass.UseSystemPasswordChar = true; 
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString)) 
            {
                string login = "SELECT * FROM userData WHERE Name = @username";
                SqlCommand cmd = new SqlCommand(login, con);
                con.Open();
                cmd.Parameters.AddWithValue("@username",lgn_username.Text);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader["Password"].ToString();
                        if (storedPassword == userPass.Text)
                        {
                            MessageBox.Show("Login successful!");
                            Properties.Settings.Default.username = lgn_username.Text;
                            Properties.Settings.Default.userId = Convert.ToInt32(reader["userId"]);
                            if (reader["Photo"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["Photo"];
                                string imageBase64 = Convert.ToBase64String(imageData);
                                Properties.Settings.Default.image = imageBase64;
                            }
                            else
                            {
                                Properties.Settings.Default.image = null; 
                            }
                            Properties.Settings.Default.phone = reader["Phone"].ToString();
                            Properties.Settings.Default.email = reader["Email"].ToString();
                            Properties.Settings.Default.password = userPass.Text;
                            Properties.Settings.Default.Save();

                            Dashboard dashboard = new Dashboard();
                            dashboard.FormClosed += (s, args) => this.Close();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }

            }
        }

        private void registertext_Click(object sender, EventArgs e)
        {
            registration registeration= new registration();
            registeration.Show();
            this.Hide();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (userPass.UseSystemPasswordChar == false) 
            {
                userPass.UseSystemPasswordChar = true;
            }
            else  {
                userPass.UseSystemPasswordChar = false;
            }

        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

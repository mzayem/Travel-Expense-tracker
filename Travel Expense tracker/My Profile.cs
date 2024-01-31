using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Travel_Expense_tracker
{
    public partial class My_Profile : Form
    {
        public My_Profile()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=travelExpenses;Integrated Security=true"; 
        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string password = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
        private void My_Profile_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.image != null)
            {
                byte[] imageData = Convert.FromBase64String(Properties.Settings.Default.image);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image image = Image.FromStream(ms);
                    userImage.Image = image;
                    Bitmap circularImage = new Bitmap(userImage.Width, userImage.Height);

                    using (Graphics g = Graphics.FromImage(circularImage))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;

                        using (var path = new GraphicsPath())
                        {
                            path.AddEllipse(0, 0, circularImage.Width - 1, circularImage.Height - 1);
                            g.Clip = new Region(path);
                            g.DrawImage(image, 0, 0, circularImage.Width, circularImage.Height);
                        }
                    }

                    
                    userImage.Image = circularImage;

                }
                username.Text = Properties.Settings.Default.username;
                phone.Text = Properties.Settings.Default.phone;
                email.Text = Properties.Settings.Default.email;
                userpass.Text = Properties.Settings.Default.password;
                userpass.UseSystemPasswordChar = true;
            }
            else
            {
                userImage.Image = null;
            }

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = null;
            Properties.Settings.Default.userId = 0; 
            Properties.Settings.Default.image = null;
            Properties.Settings.Default.phone = null;
            Properties.Settings.Default.email = null;
            Properties.Settings.Default.password = null; 

            Properties.Settings.Default.Save();
            login login = new login();
            login.Show();
            this.Hide();

        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (userpass.UseSystemPasswordChar == false)
            {
                userpass.UseSystemPasswordChar = true;
            }
            else
            {
                userpass.UseSystemPasswordChar = false;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this user account?",
                                    "Confirm Delete!",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                int userIdToDelete = Properties.Settings.Default.userId;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string deleteUserQuery = "DELETE FROM userData WHERE userId = @userId";
                        using (SqlCommand cmd = new SqlCommand(deleteUserQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@userId", userIdToDelete);
                            cmd.ExecuteNonQuery();
                            btnreset_Click(sender, e);
                            btnLogout_Click(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the user account: " + ex.Message);
                    }
                }
            }
            else { return; }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this user account and all associated entries?",
                                    "Confirm Delete!",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
               

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        
                        

                            string deleteExpensesQuery = "DELETE FROM addExpense WHERE userId = @userId";
                            using (SqlCommand cmdExpenses = new SqlCommand(deleteExpensesQuery, connection))
                            {
                                cmdExpenses.Parameters.AddWithValue("@userId", Properties.Settings.Default.userId);
                                cmdExpenses.ExecuteNonQuery();
                                MessageBox.Show("Expenses Data Deleted !!");
                            }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the user account and associated entries: " + ex.Message);
                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (userImage.Image == null)
                {
                    MessageBox.Show("Please select an image to save.");
                    return;

                }
                else if (String.IsNullOrEmpty(username.Text) == true)
                {
                    username.Focus();
                    MessageBox.Show("please enter your name!!");
                }
                else if (Regex.IsMatch(email.Text, pattern) == false)
                {
                    email.Focus();
                    MessageBox.Show("please enter Valid email");
                }
                else if (string.IsNullOrEmpty(phone.Text) == true)
                {
                    phone.Focus();
                    MessageBox.Show("Please enter the your phone number!!");
                }
                else if (Regex.IsMatch(userpass.Text, password) == false)
                {
                    userpass.Focus();
                    MessageBox.Show("please enter atleast one upper , one lower , one number , and special character as well !!");
                    
                }

                else
                {
                    string query = "UPDATE userData SET Name = @name, Phone = @phone, Email = @email, Photo = @image, Password = @password WHERE userId = @userId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        Image image = userImage.Image;
                        MemoryStream ms = new MemoryStream();
                        /*image.Save(ms, image.RawFormat);*/
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imageData = ms.ToArray();

                        conn.Open();
                        /*cmd.Parameters.AddWithValue("@name", username.Text);
                          cmd.Parameters.AddWithValue("@phone", phone.Text);
                          cmd.Parameters.AddWithValue("@email", email.Text);
                          *//*                        cmd.Parameters.AddWithValue("@image", imageData);*//*
                          cmd.Parameters.Add("@image", SqlDbType.VarBinary, imageData.Length).Value = imageData;
                          cmd.Parameters.AddWithValue("@password", Password.Text);*/
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = username.Text;
                        cmd.Parameters.Add("@phone", SqlDbType.VarChar, 50).Value = phone.Text; // Adjust the size based on your column definition
                        cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = email.Text; // Adjust the size based on your column definition
                        cmd.Parameters.Add("@image", SqlDbType.VarBinary, -1).Value = imageData; // Use -1 for VarBinary(MAX)
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = userpass.Text;
                        cmd.Parameters.Add("@userid", Properties.Settings.Default.userId);


                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Data saved successfully.");
                        /*login login = new login();
                        login.Show();
                        this.Hide();*/
                        Properties.Settings.Default.username = username.Text;
                        Properties.Settings.Default.image = Convert.ToBase64String(imageData);
                        Properties.Settings.Default.phone = phone.Text.ToString();
                        Properties.Settings.Default.email = email.ToString();
                        Properties.Settings.Default.password = userpass.Text;
                        Properties.Settings.Default.Save();
                    }
                }

            }

        }

        private void imgSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select your image";
            openFileDialog1.Filter = "Select Image (*.png,*.jpg) | *.png; *.jpg ";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image selectedImage = Image.FromFile(openFileDialog1.FileName);
                Bitmap circularImage = new Bitmap(userImage.Width, userImage.Height);

                using (Graphics g = Graphics.FromImage(circularImage))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;

                    using (var path = new GraphicsPath())
                    {
                        path.AddEllipse(0, 0, circularImage.Width - 1, circularImage.Height - 1);
                        g.Clip = new Region(path);
                        g.DrawImage(selectedImage, 0, 0, circularImage.Width, circularImage.Height);
                    }
                }
                userImage.Image = circularImage;
                selectedImage.Dispose();
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void My_Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

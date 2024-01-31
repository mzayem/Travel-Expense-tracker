using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Travel_Expense_tracker
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=travelExpenses;Integrated Security=True;";


        string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string password = @"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$";
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

        private void lgntext_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

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
            if (String.IsNullOrEmpty(username.Text) == true)
            {
                errorname.SetError(this.username, "please enter your name!!");
            }
            else
            {
                errorname.Clear();
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text, pattern) == false)
            {
                errorEmail.SetError(this.email, "please enter Valid email");
            }
            else
            {
                errorEmail.Clear();
            }
        }
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) )
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void phone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phone.Text) == true)
            {
                errorPhone.SetError(this.phone, "Please enter the your phone number!!");
            }
            else
            {
                errorPhone.Clear();
            }
        }


        private void Password_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Password.Text, password) == false)
            {
                errorPass.SetError(this.Password, "please enter atleast one upper , one lower , one number , and special character as well !!");
            }
            else
            {
                errorPass.Clear();
            }
        }

        private void confirmPass_Leave(object sender, EventArgs e)
        {
            if (Password.Text != confirmPass.Text)
            {
                errorMatchPass.SetError(this.Password, "Password not matched");
            }
            else
            {
                errorMatchPass.Clear();
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
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
                    errorname.SetError(this.username, "please enter your name!!");
                }
                else if (Regex.IsMatch(email.Text, pattern) == false)
                {
                    email.Focus();
                    errorEmail.SetError(this.email, "please enter Valid email");
                }
                else if (string.IsNullOrEmpty(phone.Text) == true)
                {
                    phone.Focus();
                    errorPhone.SetError(this.phone, "Please enter the your phone number!!");
                }
                else if (Regex.IsMatch(Password.Text, password) == false)
                {
                    Password.Focus();
                    errorPass.SetError(this.Password, "please enter atleast one upper , one lower , one number , and special character as well !!");
                }
                else if (Password.Text != confirmPass.Text)
                {
                    errorMatchPass.SetError(this.Password, "Password not matched");
                }
                else 
                {
                    string query = "INSERT INTO userData (Name, Phone, Email, Photo, Password) VALUES (@name, @phone, @email, @image, @password)";

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
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar, 50).Value = Password.Text; // Adjust the size based on your column definition


                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Data saved successfully.");
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }
                }

            }

        }

        private void registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}

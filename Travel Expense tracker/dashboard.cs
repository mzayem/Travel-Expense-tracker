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
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections;
using Travel_Expense_tracker.Properties;



namespace Travel_Expense_tracker
{
    
    public partial class Dashboard : Form
    {
       

        public Dashboard()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Dashboard_Load);
        }

        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=travelExpenses;Integrated Security=true";
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpensesDataSet3.addExpense' table. You can move, or remove it, as needed.
            this.addExpenseTableAdapter.Fill(this.travelExpensesDataSet3.addExpense);
            // TODO: This line of code loads data into the 'travelExpensesDataSet2.expenseType' table. You can move, or remove it, as needed.
            this.expenseTypeTableAdapter1.Fill(this.travelExpensesDataSet2.expenseType);
            if (Properties.Settings.Default.userId == 0)
            {
                Filter.Visible = false;
                monthFilter.Visible = false;
                typeFilter.Visible = false;
                exData.Visible = false;
                btnNew.Visible = false;
                userImage.Visible = false;
                profileName.Visible = false;

            }
            else
            {
                btnlogin.Visible = false;
                btnregister.Visible = false;



                profileName.Text = Properties.Settings.Default.username;
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

                        // Set the PictureBox's Image property to the circular image
                        userImage.Image = circularImage;

                    }
                }
                else
                {
                    userImage.Image = null;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {


                    string query = "SELECT Date, travelType, Location, expenseType, Amount, pymtMethod, Note FROM addExpense WHERE userId = @userid";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@userid", Properties.Settings.Default.userId);


                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        exData.DataSource = dataTable;
                       
                    }


                }
            }
        }

        private void profileName_Click(object sender, EventArgs e)
        {
            My_Profile my_Profile = new My_Profile();
            my_Profile.Show();
           this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            My_Profile my_Profile = new My_Profile();
            my_Profile.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
          login login = new login();
            login.Show();
            this.Hide();
        }


        private void btnregister_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Expense addExpense = new Add_Expense();
            addExpense.Show();
            this.Hide();
        }

        private void monthFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                if (typeFilter.SelectedIndex > 0) {
                    string query = "SELECT Date, travelType, Location, expenseType, Amount, pymtMethod, Note FROM addExpense WHERE MONTH(Date) = @Month And userId = @userid And expenseType = @type";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@type", typeFilter.Text);
                        command.Parameters.AddWithValue("@Month", monthFilter.SelectedIndex+1);
                        command.Parameters.AddWithValue("@userid", Properties.Settings.Default.userId);


                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        exData.DataSource = dataTable;
                    }
                }
                else
                {
                    string query = "SELECT Date, travelType, Location, expenseType, Amount, pymtMethod, Note FROM addExpense WHERE MONTH(Date) = @Month And userId = @userid";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@Month", monthFilter.SelectedIndex + 1);
                        command.Parameters.AddWithValue("@userid", Properties.Settings.Default.userId);


                        DataTable dataTable = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        exData.DataSource = dataTable;
                    }    
                }   
            }
        }

        
         private void typeFilter_SelectedIndexChanged(object sender, EventArgs e)
             {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM addExpense WHERE expenseType = @type And userId = @userid";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@type", typeFilter.Text);
                    command.Parameters.AddWithValue("@userid", Properties.Settings.Default.userId);


                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    exData.DataSource = dataTable;
                }                
            }
         }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    } 
}

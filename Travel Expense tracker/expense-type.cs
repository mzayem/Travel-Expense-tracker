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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.IO;


namespace Travel_Expense_tracker
{
    public partial class expense_type : Form
    {
        public expense_type()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.expense_type_Load);
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=travelExpenses;Integrated Security=true";

        private void expense_type_Load(object sender, EventArgs e)
        {
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
            // TODO: This line of code loads data into the 'travelExpensesDataSet2.expenseType' table. You can move, or remove it, as needed.
            this.expenseTypeTableAdapter1.Fill(this.travelExpensesDataSet2.expenseType);
            // TODO: This line of code loads data into the 'travelExpensesDataSet.expenseType' table. You can move, or remove it, as needed.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Name FROM expenseType";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    exTypeData.DataSource = dataTable;
                    exTypeData.Columns["Id"].HeaderText = "ID";
                    exTypeData.Columns["Name"].HeaderText = "Name";
                    exTypeData.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    exTypeData.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading expense types: " + ex.Message);
                }

            }
        }

        private void exName_Enter(object sender, EventArgs e)
        {
            if (exName != null)
            {
                exName.Text = "";
                exName.ForeColor = Color.Black;
            }
        }

        private void exName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(exName.Text) == true)
            {
                exName.Text = "Expense Type Name";
                exName.ForeColor = Color.Gray;
            }
        }

        private void enterType_Click(object sender, EventArgs e)
        {
            if (exName.Text == "Expense Type Name" || string.IsNullOrWhiteSpace(enterType.Text) == true)
            {
                MessageBox.Show("please eneter a name");
            }
            else
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string addEx = "INSERT INTO expenseType (Name) Values (@typeName)";
                    SqlCommand cmd = new SqlCommand(addEx, con);

                    con.Open();
                    cmd.Parameters.AddWithValue("@typeName", exName.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    successMsg.Visible = true;
                    expense_type_Load(this, EventArgs.Empty);
                    exName.Text = "";


                }
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dltType.SelectedItem != null)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete this item?",
                                                    "Confirm Delete!",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    int selectedTypeId = Convert.ToInt32(dltType.SelectedValue);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM expenseType WHERE Id = @typeId";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                            {
                                cmd.Parameters.AddWithValue("@typeId", selectedTypeId);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Expense type deleted successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("The expense type could not be found.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while deleting the expense type: " + ex.Message);
                        }
                        finally
                        {
                            expense_type_Load(this, EventArgs.Empty);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }

        }

        private void btnAddex_Click(object sender, EventArgs e)
        {
            Add_Expense add_Expense = new Add_Expense();
            add_Expense.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void userImage_Click(object sender, EventArgs e)
        {
            My_Profile my_Profile = new My_Profile();
            my_Profile.Show();
            this.Hide();
        }

        private void profileName_Click(object sender, EventArgs e)
        {
            My_Profile my_Profile = new My_Profile();
            my_Profile.Show();
            this.Hide();
        }

        private void expense_type_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Travel_Expense_tracker
{
    public partial class Add_Expense : Form
    {
        public Add_Expense()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Add_Expense_Load);
        }
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=travelExpenses;Integrated Security=true";

        private void Add_Expense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpensesDataSet2.expenseType' table. You can move, or remove it, as needed.
            this.expenseTypeTableAdapter.Fill(this.travelExpensesDataSet2.expenseType);
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
        }
        private void btnAddex_Click(object sender, EventArgs e)
        {
            expense_type expense_Type = new expense_type();
            expense_Type.Show();
            this.Hide();
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
            this.Hide();
        }

        private void txtLocation_Enter(object sender, EventArgs e)
        {
            if (txtLocation != null)
            {
                txtLocation.Text = "";
                txtLocation.ForeColor = Color.Black;
            }
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) == true)
            {
                errorLocation.SetError(this.txtLocation, "enter location!!");
                txtLocation.Text = "Location Name";
                txtLocation.ForeColor = Color.Gray;
            }
            else
            {
                errorLocation.Clear();
            }
        }

        private void sltType_Leave(object sender, EventArgs e)
        {
            if (sltType.Text == "Select" || sltType.Text == null)
            {
                errorType.SetError(this.sltType, "select Expense Type!!");
            }
            else
            {
                errorType.Clear();

            }
        }

        private void txtAmount_Enter(object sender, EventArgs e)
        {
            if (txtAmount != null)
            {
                txtAmount.Text = "";
                txtAmount.ForeColor = Color.Black;
            }
        }

        private bool IsCurrencySymbol(char c)
        {
            return Char.GetUnicodeCategory(c) == UnicodeCategory.CurrencySymbol;
        }
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || IsCurrencySymbol(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmount.Text) == true)
            {
                errorAmount.SetError(this.txtAmount, "enter amount ");
                txtAmount.Text = "eg. $100";
                txtAmount.ForeColor = Color.Gray;

            }
            else
            {
                errorAmount.Clear();
            }
        }

        private void sltMethod_Leave(object sender, EventArgs e)
        {
            if (sltMethod.Text == "Select" || sltMethod.Text == null)
            {
                errorPymt.SetError(this.sltMethod, "select Payment Method!!");
            }
            else
            {
                errorPymt.Clear();

            }
        }
        private void txtNote_Enter(object sender, EventArgs e)
        {
            if (txtNote.Text != null)
            {
                txtNote.Text = "";
                txtNote.ForeColor = Color.Black;
            }
            else { txtNote.Clear(); }
        }
        private void txtNote_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNote.Text) == true)
            {
                txtNote.Text = "eg. Buy a Coffe";
                txtNote.ForeColor = Color.Gray;
            }
        }

    
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) == true)
            {
                txtLocation.Focus();
                errorLocation.SetError(this.txtLocation, "enter location!!");
            }
            else if (sltType.Text == "Select" || sltType.Text == null)
            {
                sltType.Focus();
                errorType.SetError(this.sltType, "select Expense Type!!");
            }
            else if (string.IsNullOrWhiteSpace(txtAmount.Text) == true)
            {
                txtAmount.Focus();
                errorAmount.SetError(this.txtAmount, "enter amount ");
            }
            else if (sltMethod.Text == "Select" || sltMethod.Text == null)
            {
                errorPymt.SetError(this.sltMethod, "select Payment Method!!");
            }
            else
            {
                using(SqlConnection con= new SqlConnection(connectionString))
                {
                    string Submit = "INSERT INTO addExpense (Date, travelType, Location, expenseType, Amount, pymtMethod, Note, UserID) values (@date, @travelType, @Location, @exType, @amount, @pymtMethod, @exNote, @userid)";
                    
                    using (SqlCommand cmd = new SqlCommand(Submit, con))
                    {
                        con.Open();

                        cmd.Parameters.AddWithValue("@date", datePicker.Value);
                        cmd.Parameters.AddWithValue("@travelType", trlType.Text);
                        cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                        cmd.Parameters.AddWithValue("@exType", sltType.Text);
                        cmd.Parameters.AddWithValue("@amount", txtAmount.Text);
                        cmd.Parameters.AddWithValue("@pymtMethod", sltMethod.Text);
                        cmd.Parameters.AddWithValue("@exNote", txtNote.Text);
                        cmd.Parameters.AddWithValue("@userid", Properties.Settings.Default.userId);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        response.Visible = true;

                    }

                }

            }

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

        private void Add_Expense_FormClosed(object sender, FormClosedEventArgs e)
        {

                Application.Exit();
            
        }
    }
}

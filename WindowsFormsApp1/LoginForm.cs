using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        SQLiteConnection connection = new SQLiteConnection("Data Source=POS_DB.db;Version=3;");

        public LoginForm()
        {
            InitializeComponent();
            button_register.Visible = false;
        }
        int customerId;
        string customerName;
        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {

                System.Diagnostics.Trace.WriteLine("button_login clicked");

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                // Check if the username and password are empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Please enter username and password");
                    return;
                }

                // Connect to the SQLite database
                connection.Open();

                // Check if the user is an admin
                string query = "SELECT * FROM users WHERE username=@username AND password=@password AND is_admin=1";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Close();
                    connection.Close();
                    AdminForm adminDashboardForm = new AdminForm(username);
                    this.Close();
                    adminDashboardForm.Show();
                    //MessageBox.Show("Welcome, admin!");
                    // TODO: Do something if the user is an admin DONE 
                }
                else
                {

                    // Check if the user is a regular user DONE 
                    query = "SELECT * FROM users WHERE username=@username AND password=@password AND is_admin=0";
                    cmd = new SQLiteCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // iterate through all rows of data
                        while (reader.Read())
                        {
                            // TODO: Do something if the user is a regular user DONE

                            // get values from the current row of data Tested and works
                            customerId = reader.GetInt32(0);
                            customerName = reader.GetString(1);
                        }
                        Form1 adminDashboardForm = new Form1(new Customer() { CustomerID = customerId, CustomerName = customerName, CustomerEmail = "", Password = "" });
                        adminDashboardForm.Show();
                        this.Close();
                        reader.Close();
                        connection.Close();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Trace error message
                Trace.WriteLine("Error occurred in button_login_Click: " + ex.Message);
            }

        }

        private void linklabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("linklabel_register clicked");




                this.Hide();
                button_login.Visible = false;
                linklabel_register.Visible = false;
                button_register.Visible = true;
                linklabel_login.Visible = true;
                Task.Delay(1000);
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Trace error message
                Trace.WriteLine("Error occurred in linklabel_register_LinkClicked: " + ex.Message);
            }


        }




        private void linklabel_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {

                System.Diagnostics.Trace.WriteLine("linklabel_login clicked");



                // Hide the current form
                this.Hide();

                // Show the login button
                button_login.Visible = true;

                // Show the register link label
                linklabel_register.Visible = true;

                // Hide the register button
                button_register.Visible = false;

                // Hide the login link label
                linklabel_login.Visible = false;

                // Delay the UI thread for 1 second
                Task.Delay(1000);

                // Show the current form
                this.Show();
            }
            catch (Exception ex)
            {
                // If an exception is caught, show an error message box with the exception message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {

            try
            {

                System.Diagnostics.Trace.WriteLine("button_register clicked");


                // Create an instance of ClassBLL
                ClassBLL objbll = new ClassBLL();

                // Add a new user with the provided username and password
                objbll.AddUser(txtUsername.Text, txtPassword.Text);

                // Hide the current form
                this.Hide();

                // Show the login button
                button_login.Visible = true;

                // Show the register link label
                linklabel_register.Visible = true;

                // Hide the register button
                button_register.Visible = false;

                // Hide the login link label
                linklabel_login.Visible = false;

                // Delay the UI thread for 1 second - perfect 
                Task.Delay(1000);

                // Show the current form
                this.Show();
            }
            catch (Exception ex)
            {
                // If an exception is caught, show an error message box with the exception message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // This method is empty, which is okay
        }
    }
}

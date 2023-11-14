using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm(string username)
        {
            InitializeComponent();

            // Print trace message when AdminForm is created
            System.Diagnostics.Trace.WriteLine("AdminForm created");

            label_welcome.Text = $"Welcome! {username}";
        }

        private void button_products_Click(object sender, EventArgs e)
        {
            // Print trace message when button_products is clicked
            System.Diagnostics.Trace.WriteLine("button_products clicked");

            ManageProuctsForm obj = new ManageProuctsForm();
            obj.ShowDialog();
        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            // Print trace message when button_orders is clicked
            System.Diagnostics.Trace.WriteLine("button_orders clicked");

            ManageOrdersForm obj = new ManageOrdersForm();
            obj.ShowDialog();
        }

        private void button_sale_Click(object sender, EventArgs e)
        {
            // Print trace message when button_sale is clicked
            System.Diagnostics.Trace.WriteLine("button_sale clicked");

            SaleForm obj = new SaleForm();
            obj.ShowDialog();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            // Print trace message when button_logout is clicked
            System.Diagnostics.Trace.WriteLine("button_logout clicked");

            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void button_users_Click(object sender, EventArgs e)
        {
            // Print trace message when button_users is clicked
            System.Diagnostics.Trace.WriteLine("button_users clicked");

            UsersForm obj = new UsersForm();
            obj.ShowDialog();
        }

        private void button_orderstock_Click(object sender, EventArgs e)
        {
            // Print trace message when button_orderstock is clicked
            System.Diagnostics.Trace.WriteLine("button_orderstock clicked");

            StockOrderForm obj = new StockOrderForm();
            obj.ShowDialog();
        }

        private void label_welcome_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

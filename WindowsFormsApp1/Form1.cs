using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Create a new instance of the ShoppingCart class
        ShoppingCart cart = new ShoppingCart();
        Customer customer = new Customer();
        public Form1(Customer _customer = null)
        {
            InitializeComponent();
            panel_productDetails.Visible = false;
            customer = _customer;
            if (customer == null)
            {
                this.Text = "Home";
                button_viewcart.Visible = false;
                button_addtocart.Visible = false;
                QuantityNumericUpDown.Visible = false;
                label_quantity.Visible = false;
                button_login.Visible = true;
                button_logout.Visible = false;
                label_welcome.Visible = false;

            }
            else
            {
                this.Text = "Dashboard";
                this.ControlBox = false;
                label_welcome.Text = $"Welcome! {customer.CustomerName}";
                button_login.Visible = false;
                button_logout.Visible = true;
                label_welcome.Visible = true;
            }

            // Handle the button click event to remove items from the cart
            dataGridView1.CellContentClick += (sender, e) =>
            {
                if (e.ColumnIndex == dataGridView1.Columns["RemoveButton"].Index && e.RowIndex >= 0)
                {
                    int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                    cart.RemoveCustomItem(id);
                    //CartItem itemToRemove = (CartItem)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                    //cart.RemoveItem(itemToRemove);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                    // dataGridView1.DataSource = null;
                    //dataGridView1.DataSource = cart.GetItems();
                }
            };

        }

        #region Function To Generate Dynamic User Controls
        private void GenerateDynamicUserControl()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                ClassBLL objbll = new ClassBLL(); //business login layer(BLL) class object to access function

                DataTable dt = objbll.GetItems("products"); //keeping items coming from database in data table object.

                if (dt != null) //check if data table is not null
                {
                    if (dt.Rows.Count > 0) // also has some records in it
                    {

                        /*
                         * dt.Rows.Count = no of rows in a data table
                         * array size will be dynamic as per the no of rows being stored in data table.
                         */
                        MyUserControl[] listItems = new MyUserControl[dt.Rows.Count];

                        for (int i = 0; i < 1; i++) //this loop runs once only
                        {
                            //this loop runs untill the records ends in data table.
                            foreach (DataRow row in dt.Rows) //read rows one by one from data table.
                            {
                                listItems[i] = new MyUserControl();

                                //reconverting binary formatted image coming from database to normal image. 
                                MemoryStream ms = new MemoryStream((byte[])row["image"]);
                                listItems[i].Icon = new Bitmap(ms);

                                //get title & subtitle from current row in a data table and set to user control.
                                listItems[i].Title = row["name"].ToString();
                                listItems[i].Price = $"£{row["price"]}";
                                listItems[i].Description = row["description"].ToString();
                                listItems[i].Id = row["productId"].ToString();
                                listItems[i].Quantity = row["stock_quantity"].ToString();


                                flowLayoutPanel1.Controls.Add(listItems[i]);

                                listItems[i].Click += new System.EventHandler(this.UserControl_Click);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion


        #region User Control Click Event
        /*
         * this event will perform function when user control be clicked.
         */
        void UserControl_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Trace.WriteLine("UserControl(list of products) clicked");


            try
            {
                MyUserControl obj = (MyUserControl)sender; // user control object to access controls used in it like( icon, title and sub title)
                pb_icon.Image = obj.Icon;
                lbl_title.Text = obj.Title;
                lbl_price.Text = obj.Price;
                richTextBox1.Text = obj.Description;
                pb_icon.Tag = obj.Id;
                QuantityNumericUpDown.Maximum = Int32.Parse(obj.Quantity);
                showpanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        #endregion


        #region Hide & Show Panel
        private void showpanel()
        {
            try
            {
                if (!panel_productDetails.Visible)
                {
                    panel_productDetails.Visible = true;
                    panel_productDetails.BringToFront();
                }

                // panel_container.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void hidepanel()
        {
            panel_container.Visible = false;
        }
        #endregion


        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {


            try
            {
                GenerateDynamicUserControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion


        private void LoadCartItems()
        {




            try
            {
                dataGridView1.Rows.Clear();
                foreach (var item in cart.GetItems())
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);  // this line was missing
                    row.Cells[0].Value = item.Product.Name;
                    row.Cells[1].Value = item.Product.Price.ToString();
                    row.Cells[2].Value = item.Quantity.ToString();
                    row.Cells[4].Value = item.Product.ProductID.ToString();
                    dataGridView1.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Button Click
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("Addtocartbtn clicked");

            try
            {
                // Get the product to add to the cart (e.g. from a database)
                Product product = new Product { ProductID = Int32.Parse(pb_icon.Tag.ToString()), Name = lbl_title.Text, Price = Decimal.Parse((lbl_price.Text).Substring(1)) };
                // Add the product to the cart

                if (Int32.Parse(QuantityNumericUpDown.Value.ToString()) > 0)
                {
                    cart.AddItem(product, Int32.Parse(QuantityNumericUpDown.Value.ToString()));
                    LoadCartItems();
                    if (!panel_cart.Visible)
                    {
                        panel_cart.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please select quantity");
                }

                //hidepanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion


        //private void btn_additems_Click(object sender, EventArgs e)
        //{

        //}


        #region Button Refresh
        private void btn_refresh_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Trace.WriteLine("btn_refresh clicked");



            try
            {
                GenerateDynamicUserControl();
                if (flowLayoutPanel1.Controls.Count == 0)
                {
                    MessageBox.Show("Data not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void button_viewcart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("button_viewcart clicked");

            try
            {
                if (panel_cart.Visible)
                {
                    panel_cart.Visible = false;
                }
                else
                {
                    panel_cart.Visible = !false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Trace.WriteLine("button_login clicked");

            try
            {

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                //  this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("button_logout clicked");

            try
            {
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_placeorder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("button_placeorder clicked");

            try
            {
                if (cart.GetItems().Count > 0)
                {

                    ClassBLL objbll = new ClassBLL(); //business logic layer class object to access functions.

                    decimal totalPrice = cart.GetItems().Sum(p => p.Quantity * p.Product.Price);
                    long orderNo = OrderNumber();
                    string orderDate = DateTime.Now.ToString("dd-MMM-yyyy");

                    foreach (CartItem item in cart.GetItems())
                    {
                        if (objbll.SaveOrder(customer.CustomerID, item.Product.ProductID, item.Quantity, DateTime.Now.ToString("dd-MMM-yyyy"), orderNo, DateTime.Now.ToString("MMMM"), DateTime.Now.ToString("yyyy")))
                        {
                            // MessageBox.Show("Success!"); //function returns true : record saved sucessfully.
                        }
                        else
                        {
                            MessageBox.Show("Failed!"); //function returns false : Failed to save record.
                        }
                        //   Console.WriteLine($"{item.Product.Name} ({item.Quantity})");
                    }

                    dataGridView1.Rows.Clear();
                    cart.ClearCart();

                    OrderNumberForm orderNumberForm = new OrderNumberForm(totalPrice, orderNo.ToString(), orderDate);
                    orderNumberForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cart is empty!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private long OrderNumber()
        {
            try
            {
                SQLiteConnection connection = new SQLiteConnection("Data Source=POS_DB.db;Version=3;");
#pragma warning disable CS0168 // Variable is declared but never used
                try
                {
                    SQLiteDataAdapter da = new SQLiteDataAdapter("select orderId from Orders order by orderId desc ", connection);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        return int.Parse(ds.Tables[0].Rows[0][0].ToString()) + 1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
#pragma warning restore CS0168 // Variable is declared but never used so i did this just because idk haha love making comments 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private void panel_productDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_cart_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

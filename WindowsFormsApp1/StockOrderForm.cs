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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class StockOrderForm : Form
    {
        public StockOrderForm()
        {
            InitializeComponent();
            LoadPR();
            AddButtonsToGrid();
        }
        Stock _stock = new Stock();
        private void AddButtonsToGrid()
        {
            try
            {
                // Handle the button click event to remove items from the cart
                dataGridView1.CellContentClick += (sender, e) =>
                {
                    if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index && e.RowIndex >= 0)
                    {

                        int productId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        string productName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        int productQuantity = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

                        ProductToOrder product = new ProductToOrder { ProductID = productId, Name = productName, Quantity = productQuantity };

                        _stock.AddItem(product);

                        dataGridView2.Rows.Clear();
                        foreach (var item in _stock.GetItems())
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView2);  // this line was missing
                            row.Cells[0].Value = item.Name;
                            row.Cells[1].Value = item.Quantity;
                            row.Cells[3].Value = item.ProductID;
                            dataGridView2.Rows.Add(row);
                        }
                    }
                };

                dataGridView2.CellContentClick += (sender, e) =>
                {
                    if (e.ColumnIndex == dataGridView2.Columns["RemoveButton"].Index && e.RowIndex >= 0)
                    {
                        int productId = Int32.Parse(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
                        _stock.RemoveCustomItem(productId);
                        dataGridView2.Rows.RemoveAt(e.RowIndex);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void button_getproducts_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("button_getproducts clicked");

                ClassBLL objbll = new ClassBLL();

                DataTable productsToOredr = objbll.GetProductsToOrder("products", (int)QuantityNumericUpDown.Value);

                if (productsToOredr != null) //check if data table is not null
                {
                    if (productsToOredr.Rows.Count > 0) // also has some records in it
                    {
                        dataGridView1.Rows.Clear();
                        foreach (DataRow dr in productsToOredr.Rows)
                        {
                            //row["name"].ToString();
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);  // this line was missing
                            row.Cells[3].Value = dr["productId"].ToString();
                            row.Cells[0].Value = dr["name"].ToString();
                            row.Cells[1].Value = dr["stock_quantity"].ToString();
                            dataGridView1.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private long OrderNumber()
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=POS_DB.db;Version=3;");
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("select orderId from OrderStock order by orderId desc ", connection);
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        DataTable OrderStockDT;
        private void LoadPR()
        {
            try
            {
                dataGridView3.Rows.Clear();

                ClassBLL objbll = new ClassBLL(); //business login layer(BLL) class object to access function

                OrderStockDT = objbll.GetItems("OrderStock", "orderStatus", "in process"); //keeping items coming from database in data table object.

                if (OrderStockDT != null) //check if data table is not null
                {
                    if (OrderStockDT.Rows.Count > 0) // also has some records in it
                    {
                        foreach (DataRow dr in OrderStockDT.Rows)
                        {
                            //row["name"].ToString();
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView3);  // this line was missing
                            row.Cells[0].Value = dr["orderQuantity"].ToString();
                            row.Cells[1].Value = dr["productName"].ToString();
                            row.Cells[2].Value = dr["orderDate"].ToString();
                            row.Cells[3].Value = dr["orderStatus"].ToString();
                            row.Cells[4].Value = dr["orderNumber"].ToString();
                            dataGridView3.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void button_orderstock_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("button_orderstock clicked");


                if (dataGridView2.Rows.Count > 0)
                {
                    ClassBLL objbll = new ClassBLL();
                    long orderNo = OrderNumber();
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        // Get the value of the first cell in the row
                        int productId = Convert.ToInt32(row.Cells[3].Value.ToString());

                        // Get the value of the second cell in the row
                        string productName = row.Cells[0].Value.ToString();

                        // Get the value of the third cell in the row
                        int quantity = Convert.ToInt32(row.Cells[1].Value);

                        // Do something with the values...
                        objbll.AddToOrderStock(productId, DateTime.Now.ToString("dd-MMMM-yyyy"), quantity, "in process", orderNo, productName);
                    }
                    LoadPR();
                    dataGridView2.Rows.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Check if a row was double-clicked, not a column header
                {
                    ClassBLL objbll = new ClassBLL();
                    DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
                    // Retrieve the data from the row
                    int orderno = int.Parse(row.Cells[4].Value.ToString());
                    // int age = Convert.ToInt32(row.Cells["Age"].Value);
                    // Do something with the data, e.g. display it in a message box
                    // MessageBox.Show($"Selected row: {name}, {age} years old");


                    DialogResult result = MessageBox.Show($"Do you want to update stock from order # {orderno}?", "Stock Recieved Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var matchingRows = from DataRow dr in OrderStockDT.Rows
                                           where dr["orderNumber"] != DBNull.Value && int.TryParse(dr["orderNumber"].ToString(), out int id) && id == orderno //(int)dr["orderNumber"] == int.Parse(orderno)
                                           select dr;
                        foreach (DataRow dr1 in matchingRows)
                        {
                            // Do something with the matching rows, e.g. retrieve data from other columns

                            int productId = int.Parse(dr1["productId"].ToString());
                            int stock_quantity = int.Parse(dr1["orderQuantity"].ToString());
                            // ...
                            objbll.UpdateStock(productId, stock_quantity);
                            objbll.UpdateOrderStockStatus(productId, orderno);
                            LoadPR();
                        }


                        // User clicked Yes
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addproducts_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap; 
        private void print_btn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);   

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}

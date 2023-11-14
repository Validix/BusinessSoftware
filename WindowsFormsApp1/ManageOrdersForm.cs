using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1
{
    public partial class ManageOrdersForm : Form
    {
        DataTable _customers;
        DataTable _products;
        public ManageOrdersForm()
        {
            InitializeComponent();
            Load();
        }
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private void Load()
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        {
            try
            {
                ClassBLL objbll = new ClassBLL();
                _customers = objbll.GetItems("users", "is_admin", "0");
                comboBox1.DataSource = _customers;
                comboBox1.DisplayMember = "username";
                comboBox1.ValueMember = "userId";
                _products = objbll.GetItems("products");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string GetValueFromDT(DataTable dt, string parametername, string parametervalue, string parametertoget)
        {
            try
            {
                DataRow[] foundRows = dt.Select($"{parametername} = " + parametervalue);

                if (foundRows.Length > 0)
                {
                    return foundRows[0][parametertoget].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }
        DataTable orders;
        private void button_filterorders_Click(object sender, EventArgs e)
        {
            try
            {


                System.Diagnostics.Trace.WriteLine("button_FilterOrders clicked");


                ClassBLL objbll = new ClassBLL();
                // get the selected item from the ComboBox
                object selectedItem = comboBox1.SelectedItem;

                // check if the selected item is not null and is of the expected type
                if (selectedItem != null && selectedItem is DataRowView)
                {

                    // get the DataRowView associated with the selected item
                    DataRowView selectedRow = (DataRowView)selectedItem;

                    // get the value of the "CustomerId" column of the selected row
                    int customerId = Convert.ToInt32(selectedRow["userId"]);
                    orders = objbll.GetOrders("Orders", customerId, datetimepicker_fromdate.Value.ToString("dd-MMM-yyyy"), datetimepicker_todate.Value.ToString("dd-MMM-yyyy"));

                }
                else
                {
                    orders = objbll.GetOrders("Orders", 0, datetimepicker_fromdate.Value.ToString("dd-MMM-yyyy"), datetimepicker_todate.Value.ToString("dd-MMM-yyyy"));

                }
                dataGridView1.Rows.Clear();
                if (orders != null) //check if data table is not null
                {
                    if (orders.Rows.Count > 0) // also has some records in it
                    {
                        foreach (DataRow dr in orders.Rows)
                        {
                            //row["name"].ToString();
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);  // this line was missing
                            row.Cells[0].Value = dr["orderNumber"].ToString();
                            row.Cells[1].Value = GetValueFromDT(_customers, "userId", dr["userId"].ToString(), "username");
                            row.Cells[2].Value = GetValueFromDT(_products, "productId", dr["productId"].ToString(), "name");
                            row.Cells[3].Value = dr["quantity"].ToString();
                            row.Cells[4].Value = Encoding.UTF8.GetString((byte[])dr["orderDate"]);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManageOrdersForm_Load_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

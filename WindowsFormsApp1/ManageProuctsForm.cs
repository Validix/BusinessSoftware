using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class ManageProuctsForm : Form
    {
        ClassBLL objbll = new ClassBLL();
        public ManageProuctsForm()
        {
            InitializeComponent();
            LoadProducts();
            AddButtonsToGrid();
        }

        private void AddButtonsToGrid()
        {
            try
            {
                // Handle the button click event to remove items from the cart
                dataGridView1.CellContentClick += (sender, e) =>
                {
                    if (e.ColumnIndex == dataGridView1.Columns["RemoveButton"].Index && e.RowIndex >= 0)
                    {
                        int productId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                        ClassBLL objbll = new ClassBLL();
                        objbll.DeleteItem("products", "productId", productId);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index && e.RowIndex >= 0)
                    {

                        int productId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                        txt_title.Tag = productId;
                        txt_title.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txt_description.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txt_price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        QuantityNumericUpDown.Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        pb_image.Image = (Image)dataGridView1.Rows[e.RowIndex].Cells[7].Value;
                        if (!panel_editproduct.Visible)
                        {
                            panel_editproduct.Visible = true;
                        }
                        //cart.RemoveCustomItem(id);
                        //dataGridView1.Rows.RemoveAt(e.RowIndex);

                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void LoadProducts()
        {
            try
            {
                dataGridView1.Rows.Clear();

                ClassBLL objbll = new ClassBLL(); //business login layer(BLL) class object to access function

                DataTable dt = objbll.GetItems("products"); //keeping items coming from database in data table object.

                if (dt != null) //check if data table is not null
                {
                    if (dt.Rows.Count > 0) // also has some records in it
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            //row["name"].ToString();
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);  // this line was missing
                            row.Cells[6].Value = dr["productId"].ToString();
                            row.Cells[0].Value = dr["name"].ToString();
                            row.Cells[1].Value = dr["description"].ToString();
                            row.Cells[2].Value = dr["price"].ToString();
                            row.Cells[3].Value = dr["stock_quantity"].ToString();
                            //reconverting binary formatted image coming from database to normal image. 
                            MemoryStream ms = new MemoryStream((byte[])dr["image"]);
                            row.Cells[7].Value = new Bitmap(ms);
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

        private void btn_addproducts_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("btn_addproducts clicked");

                using (Form2 obj = new Form2())
                {

                    obj.ShowDialog();
                    if (obj.DialogResult == DialogResult.OK)
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
                
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Trace.WriteLine("btn_upload clicked");

                OpenFileDialog opendlg = new OpenFileDialog();
                if (opendlg.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile(opendlg.FileName);
                    pb_image.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public static bool IsNullOrEmpty(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }
        private void button_save_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Trace.WriteLine("button_save clicked");

            try
            {
                if (!IsNullOrEmpty(pb_image) && !string.IsNullOrEmpty(txt_title.Text) && !string.IsNullOrEmpty(txt_description.Text) && !string.IsNullOrEmpty(txt_price.Text) && !string.IsNullOrEmpty(QuantityNumericUpDown.Value.ToString()))
                {
                    int productId = (int)txt_title.Tag;
                   
                    if (objbll.UpdateProduct(productId, pb_image.Image, txt_title.Text, txt_description.Text, Decimal.Parse(txt_price.Text), Int32.Parse(QuantityNumericUpDown.Value.ToString())))
                    {
                        panel_editproduct.Visible = false;
                        LoadProducts();
                    }
                }
                else
                {
                    MessageBox.Show("please fill all fields.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '.' && txt_price.Text.Contains("."))
                {
                    // Stop more than one dot Char
                    e.Handled = true;
                }
                else if (e.KeyChar == '.' && txt_price.Text.Length == 0)
                {
                    // Stop first char as a dot input
                    e.Handled = true;
                }
                else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    // Stop allow other than digit and control
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void panel_editproduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

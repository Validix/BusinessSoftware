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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            LoadUsers();
            AddButtonsToGrid();
        }

        private void AddButtonsToGrid()
        {
            try
            {
                dataGridView1.CellContentClick += (sender, e) =>
                {
                    if (e.ColumnIndex == dataGridView1.Columns["RemoveButton"].Index && e.RowIndex >= 0)
                    {
                        int userId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        ClassBLL objbll = new ClassBLL();
                        objbll.DeleteItem("users", "userId", userId);
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                    if (e.ColumnIndex == dataGridView1.Columns["EditButton"].Index && e.RowIndex >= 0)
                    {
                        int productId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                        txt_username.Tag = productId;
                        txt_username.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                        if (!panel_edituser.Visible)
                        {
                            panel_edituser.Visible = true;
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Handle the button click event to remove items from the cart
           
        }

        private void LoadUsers()
        {
            try
            {
                dataGridView1.Rows.Clear();

                ClassBLL objbll = new ClassBLL(); //business login layer(BLL) class object to access function

                //DataTable dt = objbll.GetItems("users"); //keeping items coming from database in data table object.
                DataTable dt = objbll.GetItems("users", "is_admin", "0"); //keeping items coming from database in data table object.

                if (dt != null) //check if data table is not null
                {
                    if (dt.Rows.Count > 0) // also has some records in it
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            //row["name"].ToString();
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(dataGridView1);  // this line was missing
                            row.Cells[3].Value = dr["userId"].ToString();
                            row.Cells[0].Value = dr["username"].ToString();

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

        private void button_save_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Trace.WriteLine("button_save clicked");

            try
            {
                int userId = (int)txt_username.Tag;
                ClassBLL objbll = new ClassBLL();
                objbll.DeleteItem("users", "userId", userId);

                objbll.AddUser(txt_username.Text, txt_password.Text);
                panel_edituser.Visible = false;
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void panel_edituser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

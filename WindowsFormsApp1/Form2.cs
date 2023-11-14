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

    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        public static bool IsNullOrEmpty(PictureBox pb)
        {
            return pb == null || pb.Image == null;
        }

        #region Button Upload
        private void btn_upload_Click(object sender, EventArgs e)
        {


            try
            {
                System.Diagnostics.Trace.WriteLine("btn_upload clicked"); // trace comment added
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
        #endregion



        #region Button Save
        private void btn_save_Click(object sender, EventArgs e)
        {

            try
            {
                System.Diagnostics.Trace.WriteLine("btn_save clicked"); // trace comment added
                if (!IsNullOrEmpty(pb_image) && !string.IsNullOrEmpty(txt_title.Text) && !string.IsNullOrEmpty(txt_description.Text) && !string.IsNullOrEmpty(txt_price.Text) && !string.IsNullOrEmpty(QuantityNumericUpDown.Value.ToString()))
                {

                    ClassBLL objbll = new ClassBLL(); //business logic layer class object to access functions.

                    /*
                     * sending image, title & subtitles to function
                     * objbll.SaveItems(image,title,subtitle)
                     * function returns true if record save succesfully 
                     */
                    if (objbll.SaveItems(pb_image.Image, txt_title.Text, txt_description.Text, Decimal.Parse(txt_price.Text), Int32.Parse(QuantityNumericUpDown.Value.ToString())))
                    {
                        MessageBox.Show("Success!"); //function returns true : record saved sucessfully.
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Failed!"); //function returns false : Failed to save record.
                    }
                }
                else
                {
                    MessageBox.Show("please fill all fields.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void button_cancel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("button_cancel clicked");

            this.DialogResult = DialogResult.Cancel;
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                System.Diagnostics.Trace.WriteLine("txt_price clicked");

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

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

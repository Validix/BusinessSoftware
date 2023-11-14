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
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
            LoadSale();
        }

        private void LoadSale()
        {
            try
            {
                ClassBLL objbll = new ClassBLL();
                string month = datetimepicker_month.Value.ToString("MMMM");
                string year = datetimepicker_month.Value.ToString("yyyy");
                label_orderpermonth.Text = objbll.OrdersPerMonthOrYear("Orders", "orderNumber", "orderMonth", month).ToString();
                label_orderperyear.Text = objbll.OrdersPerMonthOrYear("Orders", "orderNumber", "orderYear", year).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button_viewsale_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("button_viewsale clicked");


            LoadSale();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {

        }
    }
}

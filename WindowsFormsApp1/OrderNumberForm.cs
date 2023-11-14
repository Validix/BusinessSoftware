using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OrderNumberForm : Form
    {
        public OrderNumberForm(decimal totalPrice, string orderNo, string orderDate)
        {
            InitializeComponent();
            label_totalprice.Text = "\u00A3" + totalPrice.ToString();
            label_orderno.Text = orderNo.ToString();
            label_orderdate.Text = orderDate.ToString();
        }

        private void OrderNumberForm_Load(object sender, EventArgs e)
        {

        }
    }
}

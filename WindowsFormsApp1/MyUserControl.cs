using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }






        #region Getter & Setter For Labels & Picture Box 

        private Image _icon;
        private string _id;
        private string _title;
        private string _description;
        private string _price;
        private string _quantity;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pb_icon.Image = value; }
        }

        [Category("Custom Props")]
        public string Id
        {
            get { return _id; }
            set { _id = value; this.Tag = value; }
        }

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_title.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }


        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = value; }
        }

        [Category("Custom Props")]
        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; lbl_quantity.Text = value; }
        }


        #endregion






        #region Hover Effect
        private void ucRequest_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 229, 242); //change user control back color when mouse enters.
        }

        private void ucRequest_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255); //reset user control back color when mouse leaves.
        }
        #endregion
    }
}

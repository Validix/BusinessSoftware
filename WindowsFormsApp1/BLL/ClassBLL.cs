using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.BLL
{
    class ClassBLL
    {
        private ClassDAL objdal = new ClassDAL();

        #region Add User to Table
        public bool AddUser(string username, string password)
        {

            try
            {
               // ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.AddUser(username, password); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        #endregion


        #region Add Stock to Order
        public bool AddToOrderStock(int productId, string orderDate, int orderQuantity, string orderStatus, long orderNumber, string productName)
        {

            try
            {
               // ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.AddToOrderStock(productId,orderDate,orderQuantity,orderStatus,orderNumber, productName); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        #endregion


        #region Read Items Table
        public DataTable GetProductsToOrder(string tablename, int OrderThreshold)
        {
            try
            {
              //  ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.GetProductsToOrder(tablename, OrderThreshold);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion

        #region Update Product
        public bool UpdateProduct(int productId, Image img, string title, string description, decimal price, int quantity)
        {
            try
            {
                //  ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.UpdateProduct(productId, img,title, description, price,quantity); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
        #endregion


        #region Save Items
        public bool SaveItems(Image img, string title, string subtitle, decimal price, int quantity)
        {
            try
            {
              //  ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.AddItemsToTable(img, title, subtitle, price, quantity); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
            
        }
        #endregion

        #region Save Order
        public bool SaveOrder(int customerId, int productId, int quantity, string orderDate, long orderNumber, string month, string year)
        {
            try
            {
              //  ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.AddOrder(customerId, productId,quantity,orderDate, orderNumber, month, year); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
        #endregion

        #region Get Items
        public DataTable GetItems(string tablename)
        {
            try
            {
               // ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.ReadItemsTable(tablename);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion

        #region Update Stock
        public bool UpdateStock(int productId, int quantity)
        {
            try
            {
               // ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.UpdateStock(productId,quantity);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
        #endregion

        #region Update Stock status
        public bool UpdateOrderStockStatus(int productId, int ordernumber)
        {
            try
            {
                //data access layer class object to access functions
                return objdal.UpdateOrderStockStatus(productId, ordernumber);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
        #endregion


        #region Get Items
        public DataTable GetItems(string tablename, string parametername, string parametervalue)
        {
            try
            {
               // ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.ReadItemsTable(tablename, parametername, parametervalue);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        public DataTable GetOrders(string tablename, int customerid, string fromdate, string todate)
        {
            try
            {
               // ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.ReadOrdersTable( tablename,  customerid,  fromdate,  todate);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion

        #region Delete Items
        public bool DeleteItem(string tablename, string parameter, int id)
        {
            try
            {
              //  ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.DeleteProduct(tablename,parameter,id); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }

        }
        #endregion

        #region Order per month sale
        public long OrdersPerMonthOrYear(string tablename, string distinctparameter, string parametername, string parametervalue)
        {
            try
            {
               // ClassDAL objdal = new ClassDAL(); //data access layer class object to access functions
                return objdal.OrdersPerMonthOrYear(tablename, distinctparameter, parametername, parametervalue); // pass values to data access layer function
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return 0;
            }
        }
        #endregion
    }
}

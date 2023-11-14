using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class ClassDAL
    {
        #region Add Items to Table
        public bool AddItemsToTable(Image img, string title, string description, decimal price, int quantity)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "INSERT INTO products (name, description, price,stock_Quantity,image) VALUES (@name, @description, @price,@stock_Quantity, @image)"; 

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@name", title.Trim()); // set title to parameter.
                    cmd.Parameters.AddWithValue("@description", description.Trim()); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@price", price); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@stock_Quantity", quantity); // set sub-title to parameter.

                    //converting image to binary format to store in sql database.
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    cmd.Parameters.AddWithValue("@image", ms.ToArray()); //set binary formatted image to parameter.

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Add Items to Table
        public bool AddOrder(int customerId, int productId, int quantity, string orderDate, long orderNumber, string month, string year)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "INSERT INTO Orders (userId, productId, quantity,orderDate,orderNumber,orderMonth,orderYear) VALUES (@userId, @productId, @quantity,@orderDate,@orderNumber,@orderMonth,@orderYear)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@userId", customerId); // set title to parameter.
                    cmd.Parameters.AddWithValue("@productId", productId); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@quantity", quantity); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@orderDate", orderDate); // set sub-title to parameter..
                    cmd.Parameters.AddWithValue("@orderMonth", month); // set sub-title to parameter..
                    cmd.Parameters.AddWithValue("@orderYear", year); // set sub-title to parameter..
                    cmd.Parameters.AddWithValue("@orderNumber", orderNumber); // set sub-title to parameter..

                    cmd.ExecuteNonQuery(); //save to table

                    query = $"update products set stock_quantity=stock_quantity-{quantity} where productId={productId}";
                    cmd.CommandText = query;
                    cmd.ExecuteScalar();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Update Stock
        public bool UpdateStock(int productId, int quantity)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = $"update products set stock_quantity=stock_quantity+{quantity} where productId={productId}";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
                {
                    cmd.CommandText = query;
                    cmd.ExecuteScalar();

                    //query = $"update OrderStock set orderStatus= 'completed' where productId={productId} AND orderNumber={ordernumber}";
                    //cmd.CommandText = query;
                    //cmd.ExecuteScalar();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Update Product
        public bool UpdateProduct(int productId,Image img, string title, string description, decimal price, int quantity)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }


           // string query = "INSERT INTO products (name, description, price,stock_Quantity,image) VALUES (@name, @description, @price,@stock_Quantity, @image)";
            string query = $"update products set stock_quantity=+@stock_quantity, image=@image, name=@name, description=@description, price=@price where productId=@productId";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@name", title.Trim()); // set title to parameter.
                    cmd.Parameters.AddWithValue("@description", description.Trim()); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@price", price); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@stock_Quantity", quantity); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@productId", productId); // set sub-title to parameter.

                    //converting image to binary format to store in sql database.
                    MemoryStream ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                    cmd.Parameters.AddWithValue("@image", ms.ToArray()); //set binary formatted image to parameter.

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }



            ////converting image to binary format to store in sql database.
            //MemoryStream ms = new MemoryStream();
            //img.Save(ms, img.RawFormat);

            ////parametrized query to insert title, subtitle and image in table -> (Table_Items)
            //string query = $"update products set stock_quantity=+{quantity}, image={ms.ToArray()}, name={title}, description={description}, price={price} where productId={productId}";

            //try
            //{
            //    using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
            //    {
            //        cmd.CommandText = query;
            //        cmd.ExecuteScalar();

            //        //query = $"update OrderStock set orderStatus= 'completed' where productId={productId} AND orderNumber={ordernumber}";
            //        //cmd.CommandText = query;
            //        //cmd.ExecuteScalar();
            //    }
            //    return true;
            //}
            //catch
            //{
            //    throw;
            //}
        }
        #endregion

        #region Update Stock
        public bool UpdateOrderStockStatus(int productId, int ordernumber)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = $"update OrderStock set orderStatus= 'completed' where productId={productId} AND orderNumber={ordernumber}";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
                {
                    cmd.CommandText = query;
                    cmd.ExecuteScalar();
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion


        #region Add Stock to Order
        public bool AddToOrderStock(int productId, string orderDate, int orderQuantity, string orderStatus, long orderNumber, string productName)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "INSERT INTO OrderStock (productId,orderDate,orderQuantity,orderStatus,orderNumber,productName) VALUES (@productId,@orderDate,@orderQuantity,@orderStatus,@orderNumber,@productName)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@productId", productId); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@orderDate", orderDate);
                    cmd.Parameters.AddWithValue("@orderQuantity", orderQuantity); // set sub-title to parameter.
                    cmd.Parameters.AddWithValue("@orderStatus", orderStatus); // set sub-title to parameter..
                    cmd.Parameters.AddWithValue("@orderNumber", orderNumber); // set sub-title to parameter..
                    cmd.Parameters.AddWithValue("@productName", productName); // set sub-title to parameter..

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion


        #region Add User to Table
        public bool AddUser(string username, string password)
        {

            Connection con = new Connection(); // connection class created in Data Access Layer (DAL)
            if (ConnectionState.Closed == con.connect.State) //check if connection state is closed.
            {
                con.connect.Open(); //open connection.
            }

            //parametrized query to insert title, subtitle and image in table -> (Table_Items)
            string query = "INSERT INTO users (username, password) VALUES (@username, @password)";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, con.connect))
                {
                    cmd.Parameters.AddWithValue("@username", username); // set title to parameter.
                    cmd.Parameters.AddWithValue("@password", password); // set sub-title to parameter. 

                    cmd.ExecuteNonQuery(); //save to table
                }
                return true;
            }
            catch
            {
                throw;
            }
        }
        #endregion


        #region Read Items Table
        public DataTable ReadItemsTable(string tablename)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            //query to select all records from table -> (Table_Items)
            string query = $"SELECT * FROM {tablename}";
            SQLiteCommand cmd = new SQLiteCommand(query, con.connect);
            try
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable(); 
                    sda.Fill(dt); //save all records coming from database in data table. 
                    return dt; // return data table.
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Read Items Table
        public DataTable GetProductsToOrder(string tablename, int OrderThreshold)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            //query to select all records from table -> (Table_Items)
            string query = $"SELECT * FROM {tablename} where stock_quantity <= {OrderThreshold}";
            SQLiteCommand cmd = new SQLiteCommand(query, con.connect);
            try
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); //save all records coming from database in data table. 
                    return dt; // return data table.
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Read Items Table
        public DataTable ReadItemsTable(string tablename, string parametername, string parametervalue)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            //query to select all records from table -> (Table_Items)
            string query = $"SELECT * FROM {tablename} where {parametername}='{parametervalue}'";
            SQLiteCommand cmd = new SQLiteCommand(query, con.connect);
            try
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); //save all records coming from database in data table. 
                    return dt; // return data table.
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Read Items Table
        public DataTable ReadOrdersTable(string tablename, int customerid, string fromdate, string todate)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }
            string query;
            //query to select all records from table -> (Table_Items)
            if (customerid == 0)
            {
                 query = $"SELECT * FROM {tablename} WHERE orderDate BETWEEN '{fromdate}' AND '{todate}'";
            }
            else
            {
                query = $"SELECT * FROM {tablename} WHERE userId = {customerid} AND orderDate BETWEEN '{fromdate}' AND '{todate}'";
            }
            //string query = $"SELECT * FROM {tablename} WHERE userId = {customerid} AND orderDate BETWEEN '{fromdate}' AND '{todate}'";
            SQLiteCommand cmd = new SQLiteCommand(query, con.connect);
            try
            {
                using (SQLiteDataAdapter sda = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt); //save all records coming from database in data table. 
                    return dt; // return data table.
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region Delete Produt
        public bool DeleteProduct(string tablename, string parameter, int id)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

                using (SQLiteCommand command = new SQLiteCommand(con.connect))
                {
                    command.CommandText = $"DELETE FROM {tablename} WHERE {parameter} = {id}";

                    // execute the query
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


        }
        #endregion

        #region Order per month sale
        public long OrdersPerMonthOrYear(string tablename,string distinctparameter, string parametername, string parametervalue)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            using (SQLiteCommand command = new SQLiteCommand(con.connect))
            {
                command.CommandText = $"SELECT COUNT(DISTINCT {distinctparameter}) AS orders_per_month FROM {tablename}  WHERE {parametername} = '{parametervalue}'";
                return (long)command.ExecuteScalar();  
            }
        }
        #endregion
    }
}

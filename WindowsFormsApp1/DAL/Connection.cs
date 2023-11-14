using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    class Connection
    {
        #region DB CONNECTION

        //database connection string
        //database name : DB_Items
        //Data Source   : Sql server name or use (.)

        //public SqlConnection connect = new SqlConnection("Data Source =.; Initial Catalog = DB_Items; Integrated Security = True");
        public SQLiteConnection connect = new SQLiteConnection("Data Source=POS_DB.db;Version=3;");

        #endregion
    }
}

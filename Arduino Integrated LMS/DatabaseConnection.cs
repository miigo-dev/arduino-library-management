using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino_Integrated_LMS
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        public SqlConnection Connection { get; }

        private DatabaseConnection()
        {
            Connection = new SqlConnection(@"Data Source=LEGION\SQLEXPRESS;Initial Catalog=Arduino-ILMS;Integrated Security=True");
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }
    }
}

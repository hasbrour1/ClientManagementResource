using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

/*
 * CRM Model Class
 * Created By Robert Hasbrouck
 * 
 * This will be the model class in the MVC structure.  This will 
 * hold the MySql database information.
 */

namespace ClientManagementResource
{

    public class CMRModel
    {
        private static String MyConnectionString = "Server=localhost;Database=accounts;Uid=root;Pwd=Password1";
        private MySqlConnection connection;
        private MySqlCommand cmd;

        public CMRModel()
        {
            connection = new MySqlConnection(MyConnectionString);
            cmd = connection.CreateCommand();

        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}

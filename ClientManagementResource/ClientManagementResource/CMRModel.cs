using System;
using System.Collections.Generic;
using System.Data;
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

        public void addClient(String name, int id, String address, double phone)
        {
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO clients VALUES (@id, @name, @address, @number)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@number", phone);

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

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

        public void addClient(String name, String address, double phone)
        {
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO clients(ClientName, ClientAddress, ClientNumber) VALUES (@name, @address, @number)";
                cmd.Prepare();
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

        public void addJob(String details, String date, int bill, String clientName)
        {
            connection.Open();

            try
            {
                int clientId = 0;
                cmd = connection.CreateCommand();

                
                cmd.CommandText = "SELECT ClientId FROM clients WHERE clientName = '" + clientName +
                    "';";
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                clientId = reader.GetInt32(0);

                connection.Close();
                connection.Open();

                cmd = connection.CreateCommand();
                cmd.CommandText = "INSERT INTO jobs(ClientId, JobDetail, JobDate, JobCost, job_Complete)"
                    + " VALUES (@client, @detail, @date, @cost, false);";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@client", clientId);
                cmd.Parameters.AddWithValue("@detail", details);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@cost", bill);

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

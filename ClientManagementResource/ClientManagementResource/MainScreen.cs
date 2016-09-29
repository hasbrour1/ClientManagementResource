using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientManagementResource
{
    public partial class MainScreen : Form
    {

        public static String MyConnectionString = "Server=localhost;Database=accounts;Uid=root;Pwd=Password1";


        public MainScreen()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT jobs.JobId, clients.ClientName, clients.ClientPhone," +
                    "jobs.JobDetail, jobs.JobDate, jobs.jobcost FROM clients inner" +
                    " join jobs ON clients.ClientId = jobs.ClientId" +
                    " WHERE jobs.job_complete = false;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                jobsGridView.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception)
            {
                throw;
            }finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

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
    public partial class FindJobScreen : Form
    {

        CMRModel model;
        CMRController controller;

        public FindJobScreen(CMRModel _model)
        {
            InitializeComponent();
            model = _model;
        }

        public void setController(CMRController _controller)
        {
            controller = _controller;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Will search for job id first, if it is blank it will then search client box
            if(jobIdBox.Text != "") { 
                String cmd = "SELECT jobs.JobId, clients.ClientName, clients.ClientNumber," +
                        "jobs.JobDetail, jobs.JobDate, jobs.jobcost FROM clients inner" +
                        " join jobs ON clients.ClientId = jobs.ClientId" +
                        " WHERE jobs.JobId = " + jobIdBox.Text + ";";

                jobSearchQuery(cmd);
                  
            }
            else if(clientNameBox.Text != "")
            {
              
                String cmd = "SELECT jobs.JobId, clients.ClientName, clients.ClientNumber," +
                        "jobs.JobDetail, jobs.JobDate, jobs.jobcost FROM clients inner" +
                        " join jobs ON clients.ClientId = jobs.ClientId" +
                        " WHERE clients.ClientName = '" + clientNameBox.Text + "';";

                jobSearchQuery(cmd);
            }
            else
            {
                errorLabel.Text = "*Please fill out one box";
            }
        }

        //This method makes the query
        private void jobSearchQuery(String command)
        {
            MySqlConnection connection = model.getConnection();
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = command;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adap.Fill(ds);
                jobGridView.DataSource = ds.Tables[0].DefaultView;
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

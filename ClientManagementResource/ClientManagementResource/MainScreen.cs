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
        public CMRModel model;
        public CMRController controller;

        public MainScreen(CMRModel _model)
        {
            InitializeComponent();
            model = _model;
            LoadData();
        }

        public void setController(CMRController _controller)
        {
            controller = _controller;
        }

        public void LoadData()
        {
            MySqlConnection connection = model.getConnection();
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT jobs.JobId, clients.ClientName, clients.ClientNumber," +
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

        private void newClientButton_Click(object sender, EventArgs e)
        {
            controller.showNewClientScreen();
        }

        private void newJobButton_Click(object sender, EventArgs e)
        {
            controller.showNewJobScreen();
        }

        private void searchJobsButton_Click(object sender, EventArgs e)
        {
            controller.showJobSearchScreen();
        }
    }
}

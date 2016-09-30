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
    public partial class AddJobScreen : Form
    {
        private CMRController controller;
        private CMRModel model;

        public AddJobScreen(CMRModel _model)
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
            //Get List of Clients for Drop Down
            MySqlConnection connection = model.getConnection();
            connection.Open();

            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT ClientName, ClientId FROM clients;";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetString(0));
                }
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (billBox.Text != "" && comboBox1.Text != "")
            {
                try
                {
                    Console.WriteLine("Line: " + jobDetailBox.Text + dateTimePicker1.Text + Int32.Parse(billBox.Text) + comboBox1.Text);
                    controller.addJob(jobDetailBox.Text, dateTimePicker1.Text, Int32.Parse(billBox.Text), comboBox1.Text);
                    this.Close();
                }
                catch(Exception)
                {
                    errorLabel.Text = "* Database Error";
                }           
            }
            else
            {
                errorLabel.Text = "* Please fill out required fields";
            }
        }
    }
}

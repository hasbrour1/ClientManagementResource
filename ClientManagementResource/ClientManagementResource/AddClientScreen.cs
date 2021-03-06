﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementResource
{
    public partial class AddClientScreen : Form
    {
        CMRController controller;

        public AddClientScreen()
        {
            InitializeComponent();
        }

        public void setController(CMRController _controller)
        {
            controller = _controller;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (custNameBox.Text != "" && custPhone.Text != ""
                && custAddrBox.Text != "")
            {
                errorLabel.Text = "";

                try
                {
                    double phone;

                    String address = custAddrBox.Text;
                    String name = custNameBox.Text;
                    phone = Double.Parse(custPhone.Text);

                    //chekc if phone number is 10 digits
                    if(phone > 9999999999 || phone < 1000000000)
                    {
                        errorLabel.Text = "* Please fill Phone Number correctly";
                    }
                    else
                    {
                        controller.addClient(name, address, phone);
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    errorLabel.Text = "*Error with form data";
                }          
            }else
            {
                errorLabel.Text = "* Please fill all fields";
            }
        }
    }
}

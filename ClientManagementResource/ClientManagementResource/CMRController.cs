using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * CRM Controller Class
 * Created By Robert Hasbrouck
 * 
 * This will be the Controller class in the MVC structure.  This will 
 * tell the model when and what to update to the model, and when to refresh
 * the form views. 
 */

namespace ClientManagementResource
{
    public class CMRController
    {
        private CMRModel model;
        private MainScreen mainScreen;
        private AddClientScreen addClientScreen;
        private AddJobScreen addJobScreen;
        private FindJobScreen findJobScreen;

        public CMRController(CMRModel _model, MainScreen _main)
        {
            model = _model;
            mainScreen = _main;

            addClientScreen = new AddClientScreen();
            addClientScreen.setController(this);
            addJobScreen = new AddJobScreen(model);
            addJobScreen.setController(this);
            findJobScreen = new FindJobScreen(model);
            findJobScreen.setController(this);
        }

        public void showNewClientScreen()
        {
            addClientScreen.Show();
        } 

        public void showNewJobScreen()
        {
            addJobScreen.Show();
        }

        public void showJobSearchScreen()
        {
            findJobScreen.Show();
        }

        public void addClient(String name, String address, double phone)
        {
            model.addClient(name, address, phone);
        }

        public void addJob(String details, String date, int bill, String clientName)
        {
            model.addJob(details, date, bill, clientName);
            mainScreen.LoadData();
        }
    }
}

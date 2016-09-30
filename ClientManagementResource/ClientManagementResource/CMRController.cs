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

        public CMRController(CMRModel _model, MainScreen _main)
        {
            model = _model;
            mainScreen = _main;
            addClientScreen = new AddClientScreen();
        }

        public void showNewClientScreen()
        {
            addClientScreen.Show();
        } 

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForwardFrancesca
{
    class Controller
    {
        Model W = new Model();
        public delegate void viewEventHandler(object sender, string textToWrite); // questo gestisce l'evento
        public event viewEventHandler FlushText;
        public Controller()
        {
            W.FlushText += controllerViewEventHandler;
        }

        private void controllerViewEventHandler(object sender, string textToWrite)
        {
            FlushText(this, textToWrite);
        }

        public void doSomething()
        {
            W.doSomathing();
        }

        public void readView(bool isSQLite, string idCli)
        {
            string connString;
            if (isSQLite)
                connString = ConfigurationManager.ConnectionStrings["SQLiteConn"].ConnectionString;
            else
                connString = ConfigurationManager.ConnectionStrings["localDBConn"].ConnectionString;

            W.readView(connString, isSQLite, idCli);
        }
    }
}

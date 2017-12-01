using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjectForwardFrancesca
{
    public partial class View : Form
    {

        Controller C = new Controller();
        public View()
        {
            InitializeComponent();
            C.FlushText += viewEventHandler;
            string sdb = ConfigurationManager.AppSettings["isSQLite"];
            if (sdb == "1")
            {
                rbSQLite.Checked = true;
            }
            else
            {
                rbSQLite.Checked = true;
            }
        }
        private void viewEventHandler(object sender, string textToWrite)
        { txtConsole.AppendText(textToWrite + Environment.NewLine); }

        private void btnRW_Click(object sender, EventArgs e)
        {
          // if(readView.Checked)
            C.readView(rbSQLite.Checked,txtIdCliente.Text);
        }

        /*private void btnReadFactory_Click(object sender, EventArgs e)
        {
            C.readViaFactory(rbSQLite.Checked, txtIdCliente.Text);
        }*/



        private void btnForcast_Click(object sender, EventArgs e)
        {

        }

    }
}

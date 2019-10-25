using BeerProductionSystem.PersistenceLayer.ConnectionModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerProductionSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            OPCConnectionManager connectionManager = new OPCConnectionManager();
            connectionManager.CheckConnection();
            connectionManager.ConnectToServer();
            connectionManager.CheckConnection();
            var temperature = connectionManager.AccessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[3].Value");
            string hej = temperature.ToString();
            MessageBox.Show("Temperature: " + hej);
            connectionManager.DisconnectFromServer();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerProductionSystem.PersistenceLayer.ConnectionModule
{
    class OPCConnectionManager
    {
        public OpcClient AccessPoint { get; set; }
        // private readonly string URL = "opc.tcp://192.168.0.122:4840"; //server
        private readonly string URL = "opc.tcp://127.0.0.1:4840"; // simulation



        public OPCConnectionManager()
        {
            AccessPoint = new OpcClient(URL);
        }
        // server state was either connected or created, but "created" didn't sound like it wasn't connected
        public void CheckConnection()
        {
            var state = AccessPoint.State;
            string stat = state.ToString();
            if (stat == "Connected")
            {
                MessageBox.Show("Connection is Active"); //husk at fjerne
            }
            else
            {
                MessageBox.Show("Not Connected"); // husk at fjerne
            }
        }
        //trying to connect up to 3 times.
        public void ConnectToServer()
        {
            try
            {
                AccessPoint.Connect();
                MessageBox.Show("CONNECTED"); // husk at fjern
            }
            catch (OpcException ex)
            {
                MessageBox.Show("Handled connect exeption. Reason: " + ex.Message); // husk at fjerne
            }

        }
        //disconnect and clean up
        public void DisconnectFromServer()
        {
            AccessPoint.Disconnect();
            AccessPoint.Dispose();
            MessageBox.Show("Disconnected"); // husk at fjerne
        }

    }
}

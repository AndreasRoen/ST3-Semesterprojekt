using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerProductionSystem.PersistenceLayer.ConnectionModule {
    class OPCConnectionManager {
        public OpcClient AccessPoint { get; set; }
        //string URL = "opc.tcp://192.168.0.122:4840";
        private readonly string URL = "opc.tcp://127.0.0.1:4840";
        private bool connectionFailed=false;
        private int count = 0;

        public OPCConnectionManager() {
            AccessPoint = new OpcClient(URL);
        }
        // server state was either connected or created, but "created" didn't sound like it wasn't connected
        public void CheckConnection() {
            var state = AccessPoint.State;
            string stat = state.ToString();
            if (stat == "Connected") {
                MessageBox.Show("Connection is Active");
            } else {
                MessageBox.Show("Not Connected");
            }
        }
        //trying to connect up to 3 times.
        public void ConnectToServer() {
            try {
                AccessPoint.Connect();
            } catch (Exception ex) {
                MessageBox.Show("Handled connect exeption. Reason: " + ex.Message);
                connectionFailed = true;
            }
            if (connectionFailed == true && ++count < 3) {
                MessageBox.Show("Connection Failed, trying again");
                ConnectToServer();
                System.Threading.Thread.Sleep(5000);
            }
            else {MessageBox.Show("Unable to connect, please try again later");
                }
            }
        //disconnect and clean up
        public void DisconnectFromServer() {
            AccessPoint.Disconnect();
            AccessPoint.Dispose();
        }

    }
}

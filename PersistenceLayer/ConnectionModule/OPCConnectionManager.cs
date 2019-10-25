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
        string URL = "opc.tcp://127.0.0.1:4840";
        public OPCConnectionManager() {
            AccessPoint = new OpcClient(URL);
        }

        public void CheckConnection() {
            var state = AccessPoint.State;
            string stat = state.ToString();
            if (stat == "Connected") {
                MessageBox.Show("Connection is Active");
            } else {
                MessageBox.Show("Not Connected");
            }
        }

        public void ConnectToServer() {
            AccessPoint.Connect();
        }

        public void DisconnectFromServer() {
            AccessPoint.Disconnect();
            AccessPoint.Dispose();
        }

    }
}

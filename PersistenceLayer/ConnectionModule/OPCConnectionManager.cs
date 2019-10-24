using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.ConnectionModule {
    class OPCConnectionManager {
        public OpcClient AccessPoint { get; }

        string machineURL = "opc.tcp://192.168.0.122:4840";
        string simulationURL = "opc.tcp://127.0.0.1:4840";

        public void CheckConnection() {

        }

        public void ConnectToServer() {
            AccessPoint.Connect();
        }

        public void DisconnectFromServer() {
            AccessPoint.Disconnect();
        }

    }
}

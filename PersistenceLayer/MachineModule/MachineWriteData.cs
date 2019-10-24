using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;

namespace BeerProductionSystem.PersistenceLayer.MachineModule
{
    class MachineWriteData : IMachineWriteData
    {
        private Dictionary<string, string> nodePathDictionary;  //TODO move to Database package

        public MachineWriteData()
        {
            nodePathDictionary = new Dictionary<string, string>()
            {
                { "ControlCommand", "ns=6;s=::Program:Cube.Command.CntrlCmd" },
                { "CommandChangeRequest", "ns=6;s=::Program:Cube.Command.CmdChangeRequest" },
                { "MachSpeed", "ns=6;s=::Program:Cube.Command.MachSpeed" },
                { "NextBatchID", "ns=6;s=::Program:Cube.Command.Parameter[0].Value" },
                { "NextBatchProductType", "ns=6;s=::Program:Cube.Command.Parameter[1].Value" },
                { "NextBatchSize", "ns=6;s=::Program:Cube.Command.Parameter[2].Value" },

            };
        }

        public void WriteControlCommand(OpcClient accessPoint, int commandValue)
        {
            accessPoint.WriteNode(nodePathDictionary["ControlCommand"], commandValue);
            WriteCommandChangeRequest(accessPoint);
        }

        public void WriteCommandChangeRequest(OpcClient accessPoint)
        {
            accessPoint.WriteNode(nodePathDictionary["CommandChangeRequest"], true);
        }

        public void WriteDesiredMachineSpeed(OpcClient accessPoint, float speed)
        {
            accessPoint.WriteNode(nodePathDictionary["MachSpeed"], speed);
        }

        public void WriteNextBatchID(OpcClient accessPoint, float batchID)
        {
            accessPoint.WriteNode(nodePathDictionary["NextBatchID"], batchID);
        }

        public void WriteNextBatchProductType(OpcClient accessPoint, float productTypeValue)
        {
            accessPoint.WriteNode(nodePathDictionary["NextBatchProductType"], productTypeValue);
        }

        public void WriteNextBatchSize(OpcClient accessPoint, float batchSize)
        {
            accessPoint.WriteNode(nodePathDictionary["NextBatchSize"], batchSize);
        }
    }
}

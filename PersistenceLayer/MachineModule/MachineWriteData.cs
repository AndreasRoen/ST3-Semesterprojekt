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
        private Dictionary<NodeID, string> nodePathDictionary;  //TODO move to Database package

        private enum NodeID { ControlCommand, CommandChangeRequest, MachSpeed, NextBatchID, NextBatchProductType, NextBatchSize };

        public MachineWriteData()
        {

            nodePathDictionary = new Dictionary<NodeID, string>()
            {
                { NodeID.ControlCommand, "ns=6;s=::Program:Cube.Command.CntrlCmd" },
                { NodeID.CommandChangeRequest, "ns=6;s=::Program:Cube.Command.CmdChangeRequest" },
                { NodeID.MachSpeed, "ns=6;s=::Program:Cube.Command.MachSpeed" },
                { NodeID.NextBatchID, "ns=6;s=::Program:Cube.Command.Parameter[0].Value" },
                { NodeID.NextBatchProductType, "ns=6;s=::Program:Cube.Command.Parameter[1].Value" },
                { NodeID.NextBatchSize, "ns=6;s=::Program:Cube.Command.Parameter[2].Value" },

            };
        }

        public void WriteControlCommand(OpcClient accessPoint, int commandValue)
        {
            accessPoint.WriteNode(nodePathDictionary[NodeID.ControlCommand], commandValue);
            WriteCommandChangeRequest(accessPoint);
        }

        public void WriteCommandChangeRequest(OpcClient accessPoint)
        {
            accessPoint.WriteNode(nodePathDictionary[NodeID.CommandChangeRequest], true);
        }

        public void WriteDesiredMachineSpeed(OpcClient accessPoint, float speed)
        {
            accessPoint.WriteNode(nodePathDictionary[NodeID.MachSpeed], speed);
        }

        public void WriteNextBatchID(OpcClient accessPoint, float batchID)
        {
            accessPoint.WriteNode(nodePathDictionary[NodeID.NextBatchID], batchID);
        }

        public void WriteNextBatchProductType(OpcClient accessPoint, float productTypeValue)
        {
            accessPoint.WriteNode(nodePathDictionary[NodeID.NextBatchProductType], productTypeValue);
        }

        public void WriteNextBatchSize(OpcClient accessPoint, float batchSize)
        {
            accessPoint.WriteNode(nodePathDictionary[NodeID.NextBatchSize], batchSize);
        }
    }
}

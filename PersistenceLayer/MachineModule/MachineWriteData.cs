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
        private Dictionary<string, string> nodeDictionary;

        public MachineWriteData()
        {
        }

        public void WriteControlCommand(OpcClient accessPoint, int commandValue)
        {
            accessPoint.WriteNode("ns=6;s=::Program:Cube.Command.CntrlCmd", commandValue);
            WriteCommandChangeRequest(accessPoint);
        }

        public void WriteCommandChangeRequest(OpcClient accessPoint)
        {
            accessPoint.WriteNode("ns=6;s=::Program:Cube.Command.CmdChangeRequest", true);
        }

        public void WriteDesiredMachineSpeed(OpcClient accessPoint, float speed)
        {
            accessPoint.WriteNode("ns=6;s=::Program:Cube.Command.MachSpeed", speed);
        }

        public void WriteNextBatchID(OpcClient accessPoint, float batchID)
        {
            accessPoint.WriteNode("ns=6;s=::Program:Cube.Command.Parameter[0].Value", batchID);
        }

        public void WriteNextBatchProductType(OpcClient accessPoint, float productTypeValue)
        {
            accessPoint.WriteNode("ns=6;s=::Program:Cube.Command.Parameter[1].Value", productTypeValue);
        }

        public void WriteNextBatchSize(OpcClient accessPoint, float batchSize)
        {
            accessPoint.WriteNode("ns=6;s=::Program:Cube.Command.Parameter[2].Value", batchSize);
        }
    }
}

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

        public void WriteNextBatchID(OpcClient accessPoint, ushort batchID)
        {
            throw new NotImplementedException();
        }

        public void WriteNextBatchProductType(OpcClient accessPoint, ushort productTypeValue)
        {
            throw new NotImplementedException();
        }

        public void WriteNextBatchSize(OpcClient accessPoint, ushort batchSize)
        {
            throw new NotImplementedException();
        }
    }
}

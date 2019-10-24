using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opc.UaFx.Client;

namespace BeerProductionSystem.PersistenceLayer.MachineModule
{
    class MachineReadData : IMachineReadData
    {
        public Opc.UaFx.OpcValue ReadBatchID(OpcClient accessPoint)
        {
            const string NodeId = "ns=6;s=::Program:Cube.Status.Parameter[0].Value";
            return accessPoint.ReadNode(NodeId);
        }

        public ushort ReadBatchSize(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[1].Value");
        }

        public bool ReadCommandChangeRequest(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.CmdChangeRequest");
        }

        public int ReadControlCommand(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.CntrlCmd");
        }

        public int ReadCurrentState(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.StateCurrent");
        }

        public ushort ReadDefectProducts(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:product.bad");
        }

        public float ReadDesiredMachineSpeed(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public float ReadHumidity(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[2].Value");
        }

        public float ReadMachineSpeed(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public ushort ReadNextBatchID(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.Parameter[0].Value");
        }

        public ushort ReadNextBatchProductType(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.Parameter[1].Value");
        }

        public ushort ReadNextBatchSize(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.Parameter[2].Value");
        }

        public float ReadNormalizedMachineSpeed(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.CurMachSpeed");
        }

        public ushort ReadProducedProducts(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:product.produced");
        }

        public ushort ReadProductID(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public int ReadStopReasonID(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Admin.StopReason.ID");
        }

        public int ReadStopReasonValue(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public float ReadTemperature(OpcClient accessPoint)
        {
             return accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[3].Value");
        }

        public float ReadVibration(OpcClient accessPoint)
        {
            return accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[4].Value");
        }
    }
}

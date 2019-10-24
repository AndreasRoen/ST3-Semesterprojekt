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
        public float ReadBatchID(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[0].Value").Value;
        }

        public ushort ReadBatchSize(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[1].Value").Value;
        }

        public bool ReadCommandChangeRequest(OpcClient accessPoint)
        {
            return (bool)accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.CmdChangeRequest").Value;
        }

        public int ReadControlCommand(OpcClient accessPoint)
        {
            return (int)accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.CntrlCmd").Value;
        }

        public int ReadCurrentState(OpcClient accessPoint)
        {
            return (int)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.StateCurrent").Value;
        }

        public ushort ReadDefectProducts(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:product.bad").Value;
        }

        public float ReadDesiredMachineSpeed(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public float ReadHumidity(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[2].Value").Value;
        }

        public float ReadMachineSpeed(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public ushort ReadNextBatchID(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.Parameter[0].Value").Value;
        }

        public ushort ReadNextBatchProductType(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.Parameter[1].Value").Value;
        }

        public ushort ReadNextBatchSize(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.Parameter[2].Value").Value;
        }

        public float ReadNormalizedMachineSpeed(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.CurMachSpeed").Value;
        }

        public ushort ReadProducedProducts(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:product.produced").Value;
        }

        public ushort ReadProductID(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public int ReadStopReasonID(OpcClient accessPoint)
        {
            return (int)accessPoint.ReadNode("ns=6;s=::Program:Cube.Admin.StopReason.ID").Value;
        }

        public int ReadStopReasonValue(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }

        public float ReadTemperature(OpcClient accessPoint)
        {
             return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[3].Value").Value;
        }

        public float ReadVibration(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[4].Value").Value;
        }

        ushort IMachineReadData.ReadBatchID(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }
    }
}

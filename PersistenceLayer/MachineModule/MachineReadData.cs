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
        public float ReadBarleyAmount(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Inventory.Barley").Value;
        }

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
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Command.MachSpeed").Value;
        }

        public bool ReadFlillingInventory(OpcClient accessPoint)
        {
            return (bool)accessPoint.ReadNode("ns=6;s=::Program:FillingInventory").Value;
        }

        public float ReadHopsAmount(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Inventory.Hops").Value;
        }

        public float ReadHumidity(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[2].Value").Value;
        }

        public float ReadActualMachineSpeed(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.MachSpeed").Value;
        }

        public ushort ReadMaintanceCounter(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:Maintenance.Counter").Value;
        }

        public ushort ReadMaintanceTrigger(OpcClient accessPoint)
        {
            return (ushort)accessPoint.ReadNode("ns=6;s=::Program:Maintanence.Trigger").Value;
        }

        public float ReadMaltAmount(OpcClient accesspoint)
        {
            return (float)accesspoint.ReadNode("ns=6;s=::Program:Inventory.Malt").Value;
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

        public int ReadStopReasonID(OpcClient accessPoint)
        {
            return (int)accessPoint.ReadNode("ns=6;s=::Program:Cube.Admin.StopReason.ID").Value;
        }

        public int ReadStopReasonValue(OpcClient accessPoint)
        {
            return (int)accessPoint.ReadNode("ns=6;s=::Program:Cube.Admin.StopReason.Value").Value;
        }

        public float ReadTemperature(OpcClient accessPoint)
        {
             return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[3].Value").Value;
        }

        public float ReadVibration(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Cube.Status.Parameter[4].Value").Value;
        }

        public float ReadWheatAmount(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Inventory.Wheat").Value;
        }

        public float ReadYeastAmount(OpcClient accessPoint)
        {
            return (float)accessPoint.ReadNode("ns=6;s=::Program:Inventory.Yeast").Value;
        }

        ushort IMachineReadData.ReadBatchID(OpcClient accessPoint)
        {
            throw new NotImplementedException();
        }
    }
}

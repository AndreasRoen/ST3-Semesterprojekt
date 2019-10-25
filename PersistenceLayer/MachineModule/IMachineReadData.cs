﻿using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.MachineModule
{
    interface IMachineReadData
    {
        ushort ReadProducedProducts(OpcClient accessPoint);

        ushort ReadDefectProducts(OpcClient accessPoint);

        int ReadStopReasonID(OpcClient accessPoint);

        int ReadStopReasonValue(OpcClient accessPoint);

        int ReadCurrentState(OpcClient accessPoint);

        float ReadBatchID(OpcClient accessPoint);

        ushort ReadBatchSize(OpcClient accessPoint);

        float ReadHumidity(OpcClient accessPoint);

        float ReadTemperature(OpcClient accessPoint);

        float ReadVibration(OpcClient accessPoint);

        float ReadActualMachineSpeed(OpcClient accessPoint);

        float ReadNormalizedMachineSpeed(OpcClient accessPoint);

        float ReadDesiredMachineSpeed(OpcClient accessPoint);

        int ReadControlCommand(OpcClient accessPoint);

        bool ReadCommandChangeRequest(OpcClient accessPoint);

        ushort ReadNextBatchID(OpcClient accessPoint);

        ushort ReadNextBatchProductType(OpcClient accessPoint);

        ushort ReadNextBatchSize(OpcClient accessPoint);

        float ReadBarleyAmount(OpcClient accessPoint);

        float ReadHopsAmount(OpcClient accessPoint);

        float ReadMaltAmount(OpcClient accesspoint);

        float ReadWheatAmount(OpcClient accessPoint);

        float ReadYeastAmount(OpcClient accessPoint);

        bool ReadFlillingInventory(OpcClient accessPoint);

        ushort ReadMaintanceCounter(OpcClient accessPoint);

        ushort ReadMaintanceTrigger(OpcClient accessPoint);
    }
}

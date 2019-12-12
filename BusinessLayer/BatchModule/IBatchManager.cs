using System;
using BeerProductionSystem.DOClasses;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    interface IBatchManager
    {
        BatchDO CurrentBatch { get; set; }
        StateLogDO StateLog { get; set; }

        void CreateBatch(ushort productType, ushort productionSpeed, ushort batchSize);

        bool CheckBatchParameter();

        void SaveTimeInState(MachineState currentState, TimeSpan timeSpan);
    }
}

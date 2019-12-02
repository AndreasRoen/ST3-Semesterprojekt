using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DOClasses;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    interface IBatchManager
    {

        Batch CurrentBatch { get; set; }
        BatchReport BatchReport { get; set; }
        StateLog StateLog { get; set; }
        void CreateBatch(ushort productType, ushort productionSpeed, ushort batchSize);

        void CreateBatchReport(ushort batchId, ushort productType,ushort productionSpeed, ushort amountOfProductsTotal);

        bool CheckBatchParameter();

        void SaveTimeInState(int currentState, TimeSpan timeSpan);

    }
}

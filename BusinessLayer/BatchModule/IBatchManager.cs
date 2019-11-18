using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    interface IBatchManager
    {

        Batch CurrentBatch { get; set; }

        void CreateBatch(ushort productType, ushort productionSpeed, ushort batchSize);

        void CreateBatchReport(ushort batchId, ushort productType, ushort amountOfProductsTotal);

        bool CheckBatchParameter();

        void SaveTimeInState(int currentState, TimeSpan timeSpan);


        BatchReportDO GetBatchReportDO();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DOClasses;


namespace BeerProductionSystem.PersistenceLayer.DatabaseModule
{
    interface IDatabaseManager
    {
        bool SaveBatchReport(BatchReport batchReport);

        bool UpdateBatchReport(LiveRelevantDataDO liveRelevantData);

        BatchReport LoadBatchReport(int BatchID);

        List<BatchReport> GetBatchReports();
    }
}

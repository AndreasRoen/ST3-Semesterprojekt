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
        int GetLastBatchReportID();
        bool SaveBatchReport(BatchDO batchReport);

        bool UpdateBatchReport(LiveRelevantDataDO liveRelevantData);

        BatchDO LoadBatchReport(int BatchID);

        List<BatchDO> GetBatchReports();
    }
}

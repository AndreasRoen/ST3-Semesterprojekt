using BeerProductionSystem.DOClasses;
using System.Collections.Generic;


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

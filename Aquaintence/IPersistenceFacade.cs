﻿using BeerProductionSystem.DOClasses;
using System.Collections.Generic;

namespace BeerProductionSystem.Aquaintence
{
    /// <summary>
    /// Interface describing a class that can be used for accessing the persistence layer
    /// </summary>
    public interface IPersistenceFacade
    {
        bool ConnectToMachine(string machineName);

        bool CheckMachineConnection();
        int GetLastBatchReportID();

        LiveRelevantDataDO GetUpdateData();

        void SendCommand(int command);

        void SetBatchParameters(float productType, int productionSpeed, int batchSize, int batchID);

        bool SaveBatchReport(BatchDO batchReport);
        bool UpdateBatchReport(LiveRelevantDataDO liveRelevantData);
        List<BatchDO> GetBatchReports();

        BatchDO GetSpecificReport(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DOClasses;

namespace BeerProductionSystem.Aquaintence
{
    /// <summary>
    /// Interface describing a class that can be used for accessing the persistence layer
    /// </summary>
    public interface IPersistenceFacade
    {
        bool ConnectToMachine(string machineName);

        bool CheckMachineConnection();

        LiveRelevantDataDO GetUpdateData();

        void SendCommand(int command);

        void SetBatchParameters(float productType, ushort productionSpeed, ushort batchSize, ushort batchID);

        bool SaveBatchReport(BatchReport batchReport);
        bool UpdateBatchReport(LiveRelevantDataDO liveRelevantData);
        List<BatchReport> GetBatchReports();

    }
}

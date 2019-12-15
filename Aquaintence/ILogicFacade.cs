using BeerProductionSystem.DOClasses;
using System.Collections.Generic;

namespace BeerProductionSystem.Aquaintence
{
    public interface ILogicFacade
    {
        bool ConnectToMachine(string machineName);

        bool CheckMachineConnection();

        LiveRelevantDataDO UpdateData();

        void SendResetCommand();

        void SendStartCommand(ushort productType, ushort productionSpeed, ushort batchSize);

        void SendStopCommand();

        void SendAbortCommand();

        void SendClearCommand();

        bool checkBatchParameter();

        bool SaveBatchReport();

        int GetProductMaxSpeed(string productName);

        List<BatchDO> GetAllBatchReports();

        BatchDO GetSpecificReport(int id);

        int GetEstimatedError(ushort productType, ushort productionSpeed);

        int GetTotalOptimalEquipmentEffectiveness(List<BatchDO> batchList, int productType);

        int GetOptimalProductionSpeed(ushort productType);

        int GetProductTypeNumber(string productType);

    }
}

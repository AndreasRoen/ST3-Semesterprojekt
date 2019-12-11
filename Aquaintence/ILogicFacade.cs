using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DOClasses;

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
        
        List<BatchReport> GetAllBatchReports();

        BatchReport GetSpecificReport(int id);

        int GetEstimatedError(ushort productType, ushort productionSpeed);

        int GetOptimalEquipmentEfficiency();

        int GetOptimalProductionSpeed(ushort productType);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.Aquaintence
{
    public interface ILogicFacade
    {
        LiveRelevantDataDO UpdateData();

        void SendResetCommand();

        void SendStartCommand(ushort productType, ushort productionSpeed, ushort batchSize);

        void SendStopCommand();

        void SendAbortCommand();

        void SendClearCommand();

        //void SetProductType(float type);

        //void SetProductionSpeed(ushort speed);

        //void SetBatchSize(ushort size);

        bool checkBatchParameter();

        bool SaveBatchReport();

        int GetProductMaxSpeed(string productName);
    }
}

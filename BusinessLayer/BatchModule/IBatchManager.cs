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

        void CreateBatch(float productType, ushort productionSpeed, ushort batchSize);

        void CreateBatchReport();

        bool CheckBatchParameter();

        BatchReportDTO GetBatchReportDTO();
    }
}

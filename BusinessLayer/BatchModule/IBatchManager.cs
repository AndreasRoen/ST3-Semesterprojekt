using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    interface IBatchManager
    {

        void CreateBatch();

        void CreateBatchReport();

        bool ChechBatchParameter();

        BatchDTO GetBatchDTO();

        BatchReportDTO GetBatchReportDTO();
        
    }
}

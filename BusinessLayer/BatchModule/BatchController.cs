using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchController : IBatchController
    {
        private BatchReportModel batchReport;
        private BatchModel batchModel;

        public bool CheckBatchParameter ()
        {
            throw new NotImplementedException();
        }

        public bool CreateBatch ()
        {
            throw new NotImplementedException();
        }

        public BatchReportDTO GetBatchReportDTO()
        {
            return batchReport.GetBatchReport();
        }
    }
}

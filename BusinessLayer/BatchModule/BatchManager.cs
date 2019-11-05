using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchManager : IBatchManager
    {
        private Type batchReport;
        private Type batchModel;
        private BatchDTO batchDTO;
        private BatchReportDTO batchReportDTO;

        public BatchManager()
        {
            CreateBatch();
            CreateBatchReport();
        }

        public bool ChechBatchParameter ()
        {
            throw new NotImplementedException();
        }

        public void CreateBatch ()
        {
            BatchDTO batch = new BatchDTO();
            this.batchDTO = batch;
        }

        public void CreateBatch (ushort a, ushort b, ushort c, float f)
        {
            BatchDTO batch = new BatchDTO(a,b,c,f);
            this.batchDTO = batch;
        }

        public void CreateBatchReport ()
        {
            BatchReportDTO batchReport = new BatchReportDTO();
            this.batchReportDTO = batchReport;
        }

        public BatchDTO GetBatchDTO()
        {
            return this.batchDTO;
        }

        public BatchReportDTO GetBatchReportDTO()
        {
            return this.batchReportDTO;
        }
    }
}

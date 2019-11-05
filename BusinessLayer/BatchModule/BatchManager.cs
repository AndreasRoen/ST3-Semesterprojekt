using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchManager : IBatchManager
    {
        private BatchDTO batchDTO;
        private BatchReportDTO batchReportDTO;

        public BatchManager()
        {
            CreateBatch();
            CreateBatchReport();
        }

        public bool CheckBatchParameter()
        {
            bool check = true;
            int[] maxSpeeds = new int[]{600, 300, 150, 200, 100, 125};

            if(batchDTO.BatchSize < 0 || batchDTO.BatchSize > 65535)
            {
                check = false;
            }
            else if(batchDTO.ProductType < 0 || batchDTO.ProductType > 5)
            {
                check = false;
            } 
            else if(batchDTO.ProductionSpeed < 0 || batchDTO.ProductionSpeed > maxSpeeds[(int)batchDTO.ProductType])
            {
                check = false;
            }
            
            return check;
        }


        public void CreateBatch ()
        {
            BatchDTO batch = new BatchDTO();
            this.batchDTO = batch;
        }

        public void CreateBatch (ushort type, ushort id, ushort size, float speed)
        {
            BatchDTO batch = new BatchDTO(type, id, size, speed);
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

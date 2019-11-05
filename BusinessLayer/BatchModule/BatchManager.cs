using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchManager : IBatchManager
    {
        private Batch batch;
        private BatchReport batchReport;

        public BatchManager()
        {
            CreateBatch();
            CreateBatchReport();
        }

        public bool CheckBatchParameter()
        {
            bool check = true;
            int[] maxSpeeds = new int[]{600, 300, 150, 200, 100, 125};

            if(batch.BatchSize < 0 || batch.BatchSize > 65535)
            {
                check = false;
            }
            else if(batch.ProductType < 0 || batch.ProductType > 5)
            {
                check = false;
            } 
            else if(batch.ProductionSpeed < 0 || batch.ProductionSpeed > maxSpeeds[(int)batch.ProductType])
            {
                check = false;
            }
            
            return check;
        }


        public void CreateBatch ()
        {
            Batch batch = new Batch();
            this.batch = batch;
        }

        public void CreateBatch (ushort type, ushort id, ushort size, float speed)
        {
            Batch batch = new Batch(type, id, size, speed);
            this.batch = batch;
        }

        public void CreateBatchReport ()
        {
            BatchReport batchReport = new BatchReport();
            this.batchReport = batchReport;
        }

        public Batch GetBatch()
        {
            throw new NotImplementedException();
        }

        public Batch GetBatchDTO()
        {
            return this.batch;
        }

        public BatchReportDTO GetBatchReportDTO()
        {
            return this.batchReport.GetBatchReportDTO();
        }
    }
}

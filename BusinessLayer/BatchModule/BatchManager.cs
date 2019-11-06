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
        public Batch CurrentBatch { get; set; }
        private BatchReport batchReport;
        private ushort batchID;

        public BatchManager()
        {
            this.batchID = 0;
        }

        public bool CheckBatchParameter()
        {
            bool check = true;
            int[] maxSpeeds = new int[] { 600, 300, 150, 200, 100, 125 };

            if (CurrentBatch.BatchSize < 0 || CurrentBatch.BatchSize > 65535)
            {
                check = false;
            }
            else if (CurrentBatch.ProductType < 0 || CurrentBatch.ProductType > 5)
            {
                check = false;
            }
            else if (CurrentBatch.ProductionSpeed < 0 || CurrentBatch.ProductionSpeed > maxSpeeds[(int)CurrentBatch.ProductType])
            {
                check = false;
            }

            return check;
        }


        public void CreateBatch(float productType, ushort productionSpeed, ushort batchSize)
        {
            Batch batch = new Batch(productType, batchID, batchSize, productionSpeed);
            this.CurrentBatch = batch;
            batchID++;
        }

        public void CreateBatch(ushort type, ushort id, ushort size, float speed)
        {
            Batch batch = new Batch(type, id, size, speed);
            this.CurrentBatch = batch;
        }

        public void CreateBatchReport()
        {
            BatchReport batchReport = new BatchReport();
            this.batchReport = batchReport;
        }

        public Batch GetBatchDTO()
        {
            return this.CurrentBatch;
        }

        public BatchReportDTO GetBatchReportDTO()
        {
            return this.batchReport.GetBatchReportDTO();
        }
    }
}

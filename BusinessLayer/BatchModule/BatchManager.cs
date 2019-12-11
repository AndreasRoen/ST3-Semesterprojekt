using BeerProductionSystem.DOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchManager : IBatchManager
    {
        public Batch CurrentBatch { get; set; }
        public BatchReport BatchReport { get; set; }
        public StateLog StateLog { get; set; }

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


        public void CreateBatch(ushort productType, ushort productionSpeed, ushort batchSize)
        {
            Batch batch = new Batch(productType, batchID, batchSize, productionSpeed);
            CreateBatchReport(batchID, productType, productionSpeed, batchSize);
            this.CurrentBatch = batch;
            batchID++;
        }

        public void CreateBatchReport(ushort batchId, ushort productType, ushort productionSpeed, ushort amountOfProductsTotal)
        {
            this.BatchReport = new BatchReport
            {
                BatchReportID = batchID,
                MachineSpeed = productionSpeed,
                ProductType = productType,
                TotalAmount = amountOfProductsTotal,
                ProductionStartTime = System.DateTime.Now
             };

        }

        
        public void SaveTimeInState(MachineState currentState, TimeSpan timeSpan)
        {
            Dictionary<int, TimeSpan> dict = new Dictionary<int, TimeSpan>();
            dict.Add((int)currentState, timeSpan);
            
            //StateLog.setTimeInStates(dict);
        }

        
    }
}

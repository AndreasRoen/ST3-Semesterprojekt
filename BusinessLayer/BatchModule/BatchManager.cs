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
        public BatchDO CurrentBatch { get; set; }

        public StateLogDO StateLog { get; set; }


        private int batchID;

        public BatchManager(int LatestBatchReportID)
        {
            this.batchID = LatestBatchReportID;
            StateLog = new StateLogDO();

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
            this.CurrentBatch = new BatchDO
            {
                BatchReportID = batchID,
                ProductType = productType,
                BatchSize = batchSize,
                ProductionSpeed = productionSpeed,
                ProductionStartTime = System.DateTime.Now

            };
            batchID++;
        }

        public void SaveTimeInState(MachineState currentState, TimeSpan timeSpan)
        {
            Dictionary<int, TimeSpan> dict = new Dictionary<int, TimeSpan>();
            dict.Add((int)currentState, timeSpan);
            StateLog.SetTimeInStates(dict);
        }
    }
}

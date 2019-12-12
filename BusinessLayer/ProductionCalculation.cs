using BeerProductionSystem.DOClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BeerProductionSystem.BusinessLayer
{
    class ProductionCalculation
    {
        public int CalculateError(ProductType productType, ushort machineSpeed)
        {
            int error = 0;
            switch (productType)
            {
                case ProductType.Pilsner:
                    error = (int)(0.113 * Math.Pow(Math.E, 0.0103 * machineSpeed));
                    break;
                case ProductType.Wheat:
                    error = (int)(0.336 * machineSpeed - 1.01);
                    break;
                case ProductType.IPA:
                    error = (int)(35.1 - 1.35 * machineSpeed + 0.0122 * Math.Pow(machineSpeed, 2));
                    break;
                case ProductType.Stout:
                    error = (int)(43 + 0.124 * machineSpeed - 0.0014 * Math.Pow(machineSpeed, 2));
                    break;
                case ProductType.Ale:
                    error = (int)(1.29 - 0.0706 * machineSpeed + 0.00419 * Math.Pow(machineSpeed, 2));
                    break;
                case ProductType.Alcohol_Free:
                    error = (int)(0.402 * machineSpeed + 9.07);
                    break;
            }
            if (error < 0)
            {
                return 0;
            }
            else if (error > 100)
            {
                return 100;
            }
            else
            {
                return error;
            }
        }

        public double CalculateTotalOptimalEquipmentEffectiveness(List<BatchDO> batchDOList, int productType)
        {
            List<BatchDO> sortedList = batchDOList.FindAll(b => b.ProductType == productType);
            List<double> OEEList = new List<double>();
            
            foreach(BatchDO b in sortedList)
            {
                double downTime = getStateDownTime(b.StateDictionary);
                
                int acceptableProducts = (int)(b.ProducedProducts - b.DefectProducts);
                OEEList.Add(CalculateOptimalEquipmentEffectiveness(acceptableProducts, b.ProductionSpeed, b.BatchSize, downTime));
            }
            try
            {
               return OEEList.Average();
            }
            catch (InvalidOperationException)
            {

            }
            return 0;

        }

        private double CalculateOptimalEquipmentEffectiveness(double acceptableProducts, double productionSpeed, double batchSize, double downTime)
        {
            double OEE = (acceptableProducts * (productionSpeed*60)) / ((batchSize / (productionSpeed*60)) - downTime);
            Debug.WriteLine(downTime);
            return OEE;
        }

        private double getStateDownTime(Dictionary<int, TimeSpan> stateDictionary)
        {
            double downTime = 0;
            downTime += stateDictionary[(int)MachineState.Aborted].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Aborting].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Activating].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Clearing].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Complete].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Completing].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Deactivated].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Deactivating].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Held].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Holding].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Idle].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Resetting].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Starting].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Stopped].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Stopping].TotalSeconds;
            downTime += stateDictionary[(int)MachineState.Suspended].TotalSeconds;
            return downTime;
        }

    }
}

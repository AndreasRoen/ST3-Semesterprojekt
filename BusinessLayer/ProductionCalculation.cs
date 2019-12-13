using BeerProductionSystem.DOClasses;
using System;
using System.Collections.Generic;
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
            List<double> oeeList = new List<double>();

            foreach (BatchDO b in sortedList)
            {
                double OEE;
                if (b.ProducedProducts == 0)
                {
                    OEE = 0;
                }
                else
                {
                    //Calculate Availability
                    double availability = CalculateAvailability(b);
                    //Calculate Performance
                    double performance = CalculatePerformance(b);
                    //Calcualate Quality
                    double quality = CalculateQuality(b);

                    //Finally Calculate OEE
                    OEE = CalculateOptimalEquipmentEffectiveness(availability, performance, quality);
                }
                oeeList.Add(OEE);
            }
            try
            {
                return oeeList.Average();
            }
            catch (InvalidOperationException)
            {
            }
            return 0;
        }

        private double CalculateQuality(BatchDO batchDO)
        {
            double quality;
            double AcceptableProducts = (double)(batchDO.ProducedProducts - batchDO.DefectProducts);
            quality = AcceptableProducts / (double)batchDO.ProducedProducts;
            return quality;

        }
        private double CalculateAvailability(BatchDO batchDO)
        {
            double availability;
            double runTime = batchDO.ProductionEndTime.Subtract(batchDO.ProductionStartTime).TotalMinutes;
            double downTime = GetStateDownTime(batchDO.StateDictionary);
            availability = (runTime - downTime) / runTime;
            return availability;
        }
        private double CalculatePerformance(BatchDO batchDO)
        {
            double performance;
            //Gather necessary data and calculate Performance
            double runTime = batchDO.ProductionEndTime.Subtract(batchDO.ProductionStartTime).TotalMinutes;
            ProductType productType = (ProductType)batchDO.ProductType;
            ProductMaxSpeed productMaxSpeed = (ProductMaxSpeed)Enum.Parse(typeof(ProductMaxSpeed), productType.ToString());
            double idealCycleTime = 60 / (double)((int)productMaxSpeed);
            performance = (idealCycleTime * (double)batchDO.ProducedProducts) / runTime;
            return performance;
        }
        private double CalculateOptimalEquipmentEffectiveness(double availability, double performance, double quality)
        {
            double OEE = availability * performance * quality;
            return OEE;
        }

        private double GetStateDownTime(Dictionary<int, TimeSpan> stateDictionary)
        {
            double downTime = 0;
            //All states count as downtime except the "Execute State"
            downTime += stateDictionary[(int)MachineState.Aborted].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Aborting].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Activating].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Clearing].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Complete].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Completing].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Deactivated].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Deactivating].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Held].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Holding].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Idle].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Resetting].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Starting].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Stopped].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Stopping].TotalMinutes;
            downTime += stateDictionary[(int)MachineState.Suspended].TotalMinutes;
            return downTime;
        }
    }
}

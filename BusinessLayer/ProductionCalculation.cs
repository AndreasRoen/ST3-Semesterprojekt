using System;

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

        public int CalculateOptimalEquipmentEffectivness()
        {
            return 100;
        }
    }
}

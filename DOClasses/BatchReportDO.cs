﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.DTOClasses
{
    /// <summary>
    /// Data object created in the business layer
    /// </summary>
    public class BatchReportDO
    {

        public ushort BatchID { get; }
        public ushort ProductType { get; }
        public ushort MachineSpeed { get; }
        public ushort AmountOfProductsTotal { get; }
        public ushort AmountOfProductsAcceptable { get; }
        public ushort AmountOfProductsDefect { get; }
        public Dictionary<int, TimeSpan> AmountOfTimeInStates { get; }
        public List<float> LoggingOfTemperature { get; }
        public List<float> LoggingOfHumidity { get; }


        public BatchReportDO(ushort BatchID, ushort ProductType, ushort AmountOfProductsTotal, ushort AmountOfProductsAcceptable
            , ushort AmountOfProductsDefect, Dictionary<int, TimeSpan> AmountOfTimeInStates, List<float> LoggingOfTemperature, List<float> LogginOfHumidity)

        {
            this.BatchID = BatchID;
            this.ProductType = ProductType;
            this.AmountOfProductsTotal = AmountOfProductsTotal;
            this.AmountOfProductsAcceptable = AmountOfProductsAcceptable;
            this.AmountOfProductsDefect = AmountOfProductsDefect;
            this.AmountOfTimeInStates = AmountOfTimeInStates;
            this.LoggingOfTemperature = LoggingOfTemperature;
            this.LoggingOfHumidity = LogginOfHumidity;
        }

        public BatchReportDO(ushort ProductType, ushort AmountOfProductsTotal, ushort MachineSpeed)
        {
            this.ProductType = ProductType;
            this.AmountOfProductsTotal = AmountOfProductsTotal;
            this.MachineSpeed = MachineSpeed;

        }
    }
}

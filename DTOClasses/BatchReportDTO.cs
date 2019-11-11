using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.DTOClasses
{
    public class BatchReportDTO
    {

        public ushort BatchID { get; }
        public ushort ProductType { get; }
        public ushort AmountOfProductsTotal { get; }
        public ushort AmountOfProductsAcceptable { get; }
        public ushort AmountOfProductsDefect { get; }
        public Dictionary<int, TimeSpan> AmountOfTimeInStates { get; }
        public List<float> LoggingOfTemperature { get; }
        public List<float> LoggingOfHumidity { get; }

        public BatchReportDTO(ushort BatchID, ushort ProductType, ushort AmountOfProductsTotal, ushort AmountOfProductsAcceptable
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


    }
}

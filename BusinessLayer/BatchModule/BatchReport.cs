using BeerProductionSystem.DTOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchReport
    {
        public ushort BatchID { get; set; }
        public ushort ProductType { get; set; }
        public ushort AmountOfProductsTotal { get; set; }
        public ushort AmountOfProductsAcceptable { get; set; }
        public ushort AmountOfProductsDefect { get; set; }
        public Dictionary<int, int> AmountOfTimeInStates { get; set; }
        public List<float> LoggingOfTemperature { get; set; }
        public List<float> LoggingOfHumidity { get; set; }

        public BatchReport(ushort batchID, ushort productType, ushort amountOfProductsTotal, ushort amountOfProductsAcceptable, ushort amountOfProductsDefect, Dictionary<int, int> amountOfTimeInStates, List<float> loggingOfTemperature, List<float> loggingOfHumidity)
        {
            BatchID = batchID;
            ProductType = productType;
            AmountOfProductsTotal = amountOfProductsTotal;
            AmountOfProductsAcceptable = amountOfProductsAcceptable;
            AmountOfProductsDefect = amountOfProductsDefect;
            AmountOfTimeInStates = amountOfTimeInStates;
            LoggingOfTemperature = loggingOfTemperature;
            LoggingOfHumidity = loggingOfHumidity;
        }
        
        public BatchReport() : this(0,0,0,0,0,new Dictionary<int,int>(), new List<float>(), new List<float>()) {}

        public BatchReportDTO GetBatchReportDTO()
        {
            return new BatchReportDTO(BatchID, ProductType, AmountOfProductsTotal, AmountOfProductsAcceptable, AmountOfProductsDefect,
                AmountOfTimeInStates, LoggingOfTemperature, LoggingOfHumidity);
        }
    }

}

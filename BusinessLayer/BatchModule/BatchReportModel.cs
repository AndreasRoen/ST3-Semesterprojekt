using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchReportModel
    {
        public ushort BatchID { get; set; }
        public ushort ProductType { get; set; }
        public ushort AmountOfProductsTotal { get; set; }
        public ushort AmountOfProductsAcceptable { get; set; }
        public ushort AmountOfProductsDefect { get; set; }
        public Dictionary<int, int> AmountOfTimeInStates { get; set; }
        public List<float> LoggingOfTemperature { get; set; }
        public List<float> LoggingOfHumidity { get; set; }

        public BatchReportDTO GetBatchReport()
        {
            return new BatchReportDTO(BatchID, ProductType, AmountOfProductsTotal, AmountOfProductsAcceptable, AmountOfProductsDefect,
                AmountOfTimeInStates, LoggingOfTemperature, LoggingOfHumidity);
        }
    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    class BatchReportModel
    {
        private ushort batchID { get; set; }
        private ushort productType { get; set; }
        private ushort amountOfProductsTotal { get; set; }
        private ushort amountOfProductsAcceptable { get; set; }
        private ushort amountOfProductsDefect { get; set; }
        private Dictionary<String, int> amountOfTimeInStates { get; set; }
        private List<float> loggingOfTemperature { get; set; }
        private List<float> loggingOfHumidity { get; set; }
    }
}

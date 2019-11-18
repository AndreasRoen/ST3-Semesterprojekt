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
        public Dictionary<int, TimeSpan> AmountOfTimeInStates { get; set; }
        public List<float> LoggingOfTemperature { get; set; }
        public List<float> LoggingOfHumidity { get; set; }

        public BatchReport(ushort batchID, ushort productType, ushort amountOfProductsTotal)
        {
            BatchID = batchID;
            ProductType = productType;
            AmountOfProductsTotal = amountOfProductsTotal;
            AmountOfProductsAcceptable = 0;
            AmountOfProductsDefect = 0;
            AmountOfTimeInStates = new Dictionary<int, TimeSpan>();
            LoggingOfTemperature = new List<float>();
            LoggingOfHumidity = new List<float>();
        }

        public BatchReportDO GetBatchReportDTO()
        {
            return new BatchReportDO(BatchID, ProductType, AmountOfProductsTotal, AmountOfProductsAcceptable, AmountOfProductsDefect,
                AmountOfTimeInStates, LoggingOfTemperature, LoggingOfHumidity);
        }

        public void AddToTemperatureList(float temperatureData)
        {
            LoggingOfTemperature.Add(temperatureData);
        }

        public void AddToHumidityList(float humidityData)
        {
            LoggingOfHumidity.Add(humidityData);
        }

        public void AddToDictionary(int state, TimeSpan timeSpan)
        {
            AmountOfTimeInStates.Add(state, timeSpan);

        }


    }

}

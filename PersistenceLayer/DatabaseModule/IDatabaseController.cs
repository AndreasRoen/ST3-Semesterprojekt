using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule
{
    interface IDatabaseController
    {
        bool SaveBatchReport(BatchReportDO batchReport);

        bool UpdateBatchReport(LiveRelevantDataDO liveRelevantData);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.Aquaintence
{
    /// <summary>
    /// Interface describing a class that can be used for accessing the persistence layer
    /// </summary>
    public interface IPersistenceFacade
    {
        LiveRelevantDataDTO GetUpdateData();

        void SendCommand(int command);

        bool CreateBatchReport(BatchReportDTO batchReport);

    }
}

using BeerProductionSystem.DTOClasses;
﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule {
    class DatabaseController : IDatabaseController {
        public DatabaseController() {

        }

        bool IDatabaseController.SaveBatchReport(BatchReportDTO batchReport)
        {
            throw new NotImplementedException();
        }
    }

}

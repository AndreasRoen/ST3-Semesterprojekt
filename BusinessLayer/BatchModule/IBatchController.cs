using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeerProductionSystem.DTOClasses;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    interface IBatchController
    {

        bool CreateBatch();

        BatchReportDTO GetBatchReportDTO();

        bool CheckBatchParameter();
    }
}

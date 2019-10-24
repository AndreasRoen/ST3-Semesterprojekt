using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.BusinessLayer.BatchModule
{
    interface IBatchController
    {

        bool CreateBatch();

        bool CreateBatchReport();

        bool ChechBatchParameter();
    }
}

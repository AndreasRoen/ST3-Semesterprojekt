using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule
{
    interface IDatabaseController
    {
        public bool saveBatchReport();
    }
}

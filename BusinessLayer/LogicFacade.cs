using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.PersistenceLayer;
using System.Collections.Generic;
using BeerProductionSystem.BusinessLayer.BatchModule;

namespace BeerProductionSystem.BusinessLayer
{
    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;
        private IBatchController batchController;

        public LogicFacade()
        {
            persistenceFacade = new PersistenceFacade();
            batchController = new BatchController();

        }

        public List<float> UpdateData()
        {
            List<float> values =  persistenceFacade.GetUpdateData();
            values[3] = 0;
            values[4] = 0;
            //values 3 og 4 skal hentes fra batch da de ikke ændres
            values[7] = values[5] - values[6];
            return values;
        }
    }
}

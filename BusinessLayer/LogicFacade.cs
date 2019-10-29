using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.PersistenceLayer;

namespace BeerProductionSystem.BusinessLayer
{
    class LogicFacade : ILogicFacade
    {
        private IPersistenceFacade persistenceFacade;

        public LogicFacade()
        {
            persistenceFacade = new PersistenceFacade();
        }

        public string UpdateData()
        {
            return persistenceFacade.GetUpdateData();
        }
    }
}

using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer;
using BeerProductionSystem.DTOClasses;
using BeerProductionSystem.PersistenceLayer.DatabaseModule;
using BeerProductionSystem.PersistenceLayer.DatabaseModule.DTOClasses;
using BeerProductionSystem.PersistenceLayer.MachineModule;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeerProductionSystem.PresentationLayer
{
    static class Program
    {
        static void Main()
        {
            //TestSaveBatchReport();
            //TestUpdateBatchReport();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ILogicFacade logicFacade = new LogicFacade();
            UI s1 = new UI(logicFacade);
            s1.Show();
            Application.Run(s1);


        }

        public static void TestSaveBatchReport()
        {
            BatchReportDO testDO = new BatchReportDO(1, 1000, 600);

            DatabaseController testData = new DatabaseController();
            testData.SaveBatchReport(testDO);
            
        }

        public static void TestUpdateBatchReport()
        {
            LiveRelevantDataDO liveRelevantData = new LiveRelevantDataDO((float)20.2, (float)3.5, (float)0.8, 100, 30, 5, 0, 0, 0, 0, 0, 0, 0);
            DatabaseController testData = new DatabaseController();
            testData.UpdateBatchReport(liveRelevantData);
        }
    }
}

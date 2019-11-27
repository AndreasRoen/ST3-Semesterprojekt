using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer;
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
            Test();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //ILogicFacade logicFacade = new LogicFacade();
            //UI s1 = new UI(logicFacade);
            //s1.Show();
            //Application.Run(s1);


        }

        public static void Test()
        {
            using (DataContext context = new DataContext())
            {
                BatchReportDTO report = new BatchReportDTO
                {
                    BatchReportID = 1,
                    ProductType = 0,
                    TotalAmount = 100,
                    AcceptableAmount = 0,
                    DefectAmount = 10,
                    MachineSpeed = 200,
                    ProductionEndTime = System.DateTime.Now,
                    ProductionStartTime = System.DateTime.Now,
                    
                };

                context.BatchReports.Add(report);
                context.SaveChanges();
            }
        }
    }
}

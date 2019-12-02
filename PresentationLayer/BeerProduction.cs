using BeerProductionSystem.Aquaintence;
using BeerProductionSystem.BusinessLayer;
using BeerProductionSystem.DOClasses;
using BeerProductionSystem.PersistenceLayer.DatabaseModule;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            StartupConnection sc = new StartupConnection();
            Application.Run(sc);
        }
    }
}

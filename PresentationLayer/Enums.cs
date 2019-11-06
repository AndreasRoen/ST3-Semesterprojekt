using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PresentationLayer
{
    enum MachineState
    {
        Deactivated,
        Clearing,
        Stopped,
        Starting,
        Idle,
        Suspended,
        Execute,
        Stopping,
        Aborting,
        Aborted,
        Holding,
        Held,
        Resetting = 15,
        Completing,
        Complete,
        Deactivating,
        Activating
    }

    enum ProductType
    {
        Pilsner,
        Wheat,
        IPA,
        Stout,
        Ale,
        Alcohol_Free
    }
}

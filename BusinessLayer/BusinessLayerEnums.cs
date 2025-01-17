﻿
namespace BeerProductionSystem.BusinessLayer
{
    enum Commands
    {
        RESET = 1,
        START,
        STOP,
        ABORT,
        CLEAR
    }

    enum ProductMaxSpeed
    {
        Pilsner = 600,
        Wheat = 300,
        IPA = 150,
        Stout = 200,
        Ale = 100,
        Alcohol_Free = 125
    }

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

    enum OptimalProductionSpeed
    {
        Pilsner = 460,
        Wheat = 150,
        IPA = 105,
        Stout = 200,
        Ale = 90,
        Alcohol_Free = 112
    }
}

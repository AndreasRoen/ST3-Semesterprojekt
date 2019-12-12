using BeerProductionSystem.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.DOClasses
{
    /// <summary>
    /// Data object created in the persistence layer
    /// </summary>
    public class LiveRelevantDataDO
    {
        public float Temperature { get; }
        public float Humidity { get; }
        public float Vibration { get; }
        public int BatchID { get; set; }
        public int BatchSize { get; set; }
        public float ActualMachineSpeed { get; }
        public ushort ProducedProducts { get; }
        public ushort AcceptableProducts { get; set; }
        public ushort DefectProducts { get; }
        public float Barley { get; }
        public float Hops { get; }
        public float Malt { get; }
        public float Wheat { get; }
        public float Yeast { get; }
        public ushort MaintainenceMeter { get; }
        public int CurrentState { get; }
        public Dictionary<int, TimeSpan> StateDictionary { get; set; }

        public LiveRelevantDataDO(float temperature, float humidity, float vibration, float actualMachineSpeed, ushort producedProducts, ushort defectProducts, float barley, float hops, float malt, float wheat, float yeast, ushort maintainenceMeter, int currentState)
        {
            Temperature = temperature;
            Humidity = humidity;
            Vibration = vibration;
            ActualMachineSpeed = actualMachineSpeed;
            ProducedProducts = producedProducts;
            DefectProducts = defectProducts;
            Barley = barley;
            Hops = hops;
            Malt = malt;
            Wheat = wheat;
            Yeast = yeast;
            MaintainenceMeter = maintainenceMeter;
            CurrentState = currentState;
            StateDictionaryInit();
        }

        private void StateDictionaryInit()
        {
            this.StateDictionary = new Dictionary<int, TimeSpan>();
            this.StateDictionary.Add((int)MachineState.Deactivated, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Clearing, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Stopped, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Starting, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Idle, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Suspended, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Execute, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Stopping, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Aborting, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Aborted, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Holding, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Held, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Resetting, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Completing, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Complete, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Deactivating, TimeSpan.Zero);
            this.StateDictionary.Add((int)MachineState.Activating, TimeSpan.Zero);

        }



        //values.Add(machineReadData.ReadTemperature(accessPoint));
        //values.Add(machineReadData.ReadHumidity(accessPoint));
        //values.Add(machineReadData.ReadVibration(accessPoint));
        //values.Add(0); //batch id 
        //values.Add(0); // batch size
        //values.Add(machineReadData.ReadActualMachineSpeed(accessPoint));
        //values.Add(machineReadData.ReadProducedProducts(accessPoint));
        //values.Add(0); //acceptable products
        //values.Add(machineReadData.ReadDefectProducts(accessPoint));
        //values.Add(machineReadData.ReadBarleyAmount(accessPoint));
        //values.Add(machineReadData.ReadHopsAmount(accessPoint));
        //values.Add(machineReadData.ReadMaltAmount(accessPoint));
        //values.Add(machineReadData.ReadWheatAmount(accessPoint));
        //values.Add(machineReadData.ReadYeastAmount(accessPoint));
        //values.Add(machineReadData.ReadMaintenanceCounter(accessPoint));
        //values.Add(machineReadData.ReadCurrentState(accessPoint));

    }
}
